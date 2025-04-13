using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AntdUI;

namespace SuperShop_V2_Demo
{
    public partial class App : UserControl
    {
        // 数据库配置
        public static string mysqlcon = "server=hostsql.btust.xiaokecloud.cn;database=gwlned;user=gwlned;password=eCpNZRq89mBW";

        // 状态标志
        private bool comboBox1Loaded = false;
        private bool sqlViwiLoaded = false;
        private bool isFiltered = false;

        // 下载相关变量
        private string _fileUrl;
        private string _savePath;
        private int _totalThreads = 4; // 默认线程数
        private long _fileSize;
        private CancellationTokenSource _cancellationTokenSource;
        private ConcurrentDictionary<int, long> _downloadedBytesPerThread = new ConcurrentDictionary<int, long>();
        private DateTime _lastUpdateTime;
        private long _lastDownloaded;
        private string _downloadStatus;

        // UI组件
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();

        public App()
        {
            InitializeComponent();
            InitializeDataGridView();
            InitializeEventHandlers();
        }

        private void InitializeDataGridView()
        {
            SqlViwi.CellMouseClick += SqlViwi_CellMouseClick;
            SqlViwi.CellClick += SqlViwi_CellClick;
            SqlViwi.CellDoubleClick += SqlViwi_CellDoubleClick;
            SqlViwi.RowHeadersVisible = false;

            // 添加下载按钮列
            DataGridViewButtonColumn downloadColumn = new DataGridViewButtonColumn
            {
                Name = "DownloadColumn",
                HeaderText = "操作",
                Text = "下载",
                UseColumnTextForButtonValue = true
            };
            SqlViwi.Columns.Add(downloadColumn);
        }

        private void InitializeEventHandlers()
        {
            this.Load += App_Load;
            textBox1.TextChanged += textBox1_TextChanged;
            AddBtn.Click += AddBtn_Click;
            ResBtn.Click += ResBtn_Click;
        }

        private async void App_Load(object sender, EventArgs e)
        {
            AddBtn.Enabled = false;
            ResBtn.Enabled = false;
            textBox1.Enabled = false;
            comboBox1.Enabled = false;

            await InitializeDataAsync();
        }

        private async Task InitializeDataAsync()
        {
            try
            {
                await Task.WhenAll(
                    FillComboBoxAsync(),
                    LoadDataAsync()
                );
            }
            catch (Exception ex)
            {
                Modal.open(form2, "初始化错误", ex.Message, TType.Error);
            }
            finally
            {
                UpdateUIState();
            }
        }

        private async Task FillComboBoxAsync()
        {
            using (var con = new MySqlConnection(mysqlcon))
            {
                await con.OpenAsync();
                string sql = "SELECT DISTINCT 软件名 FROM app";
                using (var cmd = new MySqlCommand(sql, con))
                {
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        comboBox1.BeginUpdate();
                        comboBox1.Items.Clear();
                        while (await reader.ReadAsync())
                        {
                            comboBox1.Items.Add(reader.GetString(0));
                        }
                        comboBox1.EndUpdate();
                    }
                }
                comboBox1Loaded = true;
            }
        }

        private async Task LoadDataAsync(string filter = "")
        {
            label4.Hide();

            Waitbar.Visible = true;
            Waitbar.Value = 0;

            using (var con = new MySqlConnection(mysqlcon))
            {
                await con.OpenAsync();
                string sql = string.IsNullOrEmpty(filter)
                    ? "SELECT * FROM app"
                    : $"SELECT * FROM app WHERE 软件名 LIKE '%{filter}%'";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        var ds = new DataSet();
                        await Task.Run(() => adapter.Fill(ds));
                        SqlViwi.DataSource = ds.Tables[0];
                    }
                }
                sqlViwiLoaded = true;

                pictureBox1.Hide();
                PS.Hide();
                label3.Hide();
                pictureBox3.Hide();
            }

            Waitbar.Value = 100;
        }

        private void UpdateUIState()
        {
            AddBtn.Enabled = comboBox1Loaded && sqlViwiLoaded;
            ResBtn.Enabled = comboBox1Loaded && sqlViwiLoaded;
            textBox1.Enabled = true;
            comboBox1.Enabled = true;
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            await LoadDataAsync(textBox1.Text);
        }

        private async void SqlViwi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (isFiltered && e.ColumnIndex != SqlViwi.Columns["DownloadColumn"].Index)
            {
                await LoadDataAsync();
                isFiltered = false;
            }
            else if (e.ColumnIndex == SqlViwi.Columns["DownloadColumn"].Index)
            {
                string softwareName = SqlViwi.Rows[e.RowIndex].Cells["软件名"].Value.ToString();
                string downloadUrl = await GetDownloadUrlAsync(softwareName);

                if (!string.IsNullOrEmpty(downloadUrl))
                {
                    await StartDownloadAsync(downloadUrl);
                }
            }
        }

        private async Task<string> GetDownloadUrlAsync(string softwareName)
        {
            using (var con = new MySqlConnection(mysqlcon))
            {
                await con.OpenAsync();
                string sql = "SELECT 链接 FROM app WHERE 软件名 = @name";
                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@name", softwareName);
                    return (await cmd.ExecuteScalarAsync())?.ToString();
                }
            }
        }

        private async Task StartDownloadAsync(string url)
        {
            try
            {
                // 初始化下载参数
                _fileUrl = url;
                _savePath = GetDownloadPath(url);

                // 检查下载支持
                if (!await CheckDownloadSupportAsync())
                {
                    // 如果不支持多线程下载，使用浏览器下载
                    DialogResult result = MessageBox.Show(
                        "该文件不支持多线程下载，是否使用浏览器下载？",
                        "下载方式选择",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = url,
                            UseShellExecute = true
                        });
                    }
                    return;
                }

                // 初始化取消令牌
                _cancellationTokenSource = new CancellationTokenSource();

                // 开始下载
                await DownloadWithProgressAsync();

                Modal.open(form2, "下载完成", $"文件已保存到: {_savePath}", TType.Success);
            }
            catch (OperationCanceledException)
            {
                Modal.open(form2, "下载取消", "下载已被用户取消", TType.Info);
            }
            catch (Exception ex)
            {
                Modal.open(form2, "下载错误", ex.Message, TType.Error);
            }
            finally
            {
                CleanTempFiles();
            }
        }

        private string GetDownloadPath(string url)
        {
            // 获取配置的下载目录
            string downloadDir = GetConfiguredDownloadDirectory();

            // 获取安全的文件名
            string fileName = GetSafeFileName(url);

            // 组合完整路径
            return Path.Combine(downloadDir, fileName);
        }

        private string GetConfiguredDownloadDirectory()
        {
            string configFile = Path.Combine(Application.StartupPath, "directory.txt");

            try
            {
                // 如果配置文件不存在，创建默认配置
                if (!File.Exists(configFile))
                {
                    string defaultDir = Path.Combine(Application.StartupPath, "Downloads");
                    Directory.CreateDirectory(defaultDir);
                    File.WriteAllText(configFile, defaultDir);
                    return defaultDir;
                }

                // 读取配置
                string dirPath = File.ReadAllText(configFile).Trim();

                // 如果配置为空，使用默认路径
                if (string.IsNullOrEmpty(dirPath))
                {
                    dirPath = Path.Combine(Application.StartupPath, "Downloads");
                    File.WriteAllText(configFile, dirPath);
                }

                // 确保目录存在
                Directory.CreateDirectory(dirPath);
                return dirPath;
            }
            catch
            {
                // 如果出现错误，使用程序目录作为后备
                return Application.StartupPath;
            }
        }

        private string GetSafeFileName(string url)
        {
            try
            {
                string fileName = Path.GetFileName(Uri.UnescapeDataString(new Uri(url).AbsolutePath));
                if (string.IsNullOrEmpty(fileName))
                {
                    fileName = $"download_{DateTime.Now:yyyyMMddHHmmss}";
                }

                // 过滤非法字符
                foreach (char c in Path.GetInvalidFileNameChars())
                {
                    fileName = fileName.Replace(c.ToString(), "_");
                }

                return fileName;
            }
            catch
            {
                return $"download_{DateTime.Now:yyyyMMddHHmmss}";
            }
        }

        private async Task<bool> CheckDownloadSupportAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    // 设置超时时间
                    client.Timeout = TimeSpan.FromSeconds(10);

                    var headResponse = await client.SendAsync(
                        new HttpRequestMessage(HttpMethod.Head, _fileUrl),
                        HttpCompletionOption.ResponseHeadersRead,
                        _cancellationTokenSource?.Token ?? default);

                    // 检查是否支持断点续传
                    bool supportsRange = headResponse.Headers.AcceptRanges.Contains("bytes");

                    // 获取文件大小
                    _fileSize = headResponse.Content.Headers.ContentLength ?? 0;

                    // 小文件直接使用单线程
                    if (_fileSize < 1024 * 1024) // 小于1MB
                    {
                        return false;
                    }

                    return supportsRange && _fileSize > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        private async Task DownloadWithProgressAsync()
        {
            _lastUpdateTime = DateTime.Now;
            _lastDownloaded = 0;
            _downloadStatus = "准备下载...";
            UpdateStatusLabel();
            label4.Show();

            // 根据文件大小优化线程数
            OptimizeThreadCount();

            var downloadTasks = new Task[_totalThreads];
            long[] blockSizes = CalculateBlockSizes();

            for (int i = 0; i < _totalThreads; i++)
            {
                long start = i == 0 ? 0 : blockSizes.Take(i).Sum();
                long end = start + blockSizes[i] - 1;
                downloadTasks[i] = DownloadChunkAsync(i, start, end);
            }

            var progressTask = Task.Run(async () =>
            {
                while (!_cancellationTokenSource.Token.IsCancellationRequested)
                {
                    long downloaded = _downloadedBytesPerThread.Values.Sum();
                    UpdateDownloadStatus(downloaded);
                    await Task.Delay(1000);
                }
            });

            await Task.WhenAll(downloadTasks);
            await MergeDownloadedChunksAsync();

            _downloadStatus = "下载完成！";
            await Task.Delay(1000);
            label4.Hide();
            UpdateStatusLabel();
        }

        private void OptimizeThreadCount()
        {
            // 小文件(小于10MB)使用较少线程
            if (_fileSize < 10 * 1024 * 1024)
            {
                _totalThreads = Math.Min(2, Environment.ProcessorCount);
            }
            // 中等文件(10MB-100MB)使用中等线程数
            else if (_fileSize < 100 * 1024 * 1024)
            {
                _totalThreads = Math.Min(4, Environment.ProcessorCount);
            }
            // 大文件使用较多线程(最多8个)
            else
            {
                _totalThreads = Math.Min(8, Environment.ProcessorCount);
            }
        }

        private long[] CalculateBlockSizes()
        {
            long[] sizes = new long[_totalThreads];
            long baseSize = _fileSize / _totalThreads;
            long remainder = _fileSize % _totalThreads;

            for (int i = 0; i < _totalThreads; i++)
            {
                sizes[i] = baseSize + (i < remainder ? 1 : 0);
            }

            return sizes;
        }

        private void UpdateDownloadStatus(long downloaded)
        {
            DateTime now = DateTime.Now;
            double elapsedSeconds = (now - _lastUpdateTime).TotalSeconds;

            if (elapsedSeconds > 0)
            {
                double speed = (downloaded - _lastDownloaded) / elapsedSeconds;
                double progress = (double)downloaded / _fileSize * 100;

                _downloadStatus = $"线程: {_totalThreads} | 进度: {progress:F2}% | 速度: {FormatSpeed(speed)}";

                _lastUpdateTime = now;
                _lastDownloaded = downloaded;
                UpdateStatusLabel();
            }
        }

        private string FormatSpeed(double bytesPerSecond)
        {
            if (bytesPerSecond < 1024)
                return $"{bytesPerSecond:F0}B/s";

            if (bytesPerSecond < 1024 * 1024)
                return $"{bytesPerSecond / 1024:F0}KB/s";

            return $"{bytesPerSecond / (1024 * 1024):F1}MB/s";
        }

        private void UpdateStatusLabel()
        {
            if (label4.InvokeRequired)
            {
                label4.Invoke(new Action(UpdateStatusLabel));
                return;
            }
            label4.Text = _downloadStatus;
        }

        private async Task DownloadChunkAsync(int threadId, long start, long end)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Range = new RangeHeaderValue(start, end);
                var response = await client.GetAsync(
                    _fileUrl,
                    HttpCompletionOption.ResponseHeadersRead,
                    _cancellationTokenSource.Token
                );

                string tempFile = GetChunkFileName(threadId);
                using (var fs = new FileStream(tempFile, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true))
                {
                    await response.Content.CopyToAsync(fs);
                    _downloadedBytesPerThread[threadId] = new FileInfo(tempFile).Length;
                }
            }
        }

        private async Task MergeDownloadedChunksAsync()
        {
            using (var output = new FileStream(_savePath, FileMode.Create))
            {
                for (int i = 0; i < _totalThreads; i++)
                {
                    string chunkFile = GetChunkFileName(i);
                    if (File.Exists(chunkFile))
                    {
                        using (var input = File.OpenRead(chunkFile))
                        {
                            await input.CopyToAsync(output);
                        }
                    }
                }
            }
        }

        private string GetChunkFileName(int threadId)
        {
            return Path.Combine(
                Path.GetTempPath(),
                $"{Path.GetFileNameWithoutExtension(_savePath)}_part{threadId}"
            );
        }

        private void CleanTempFiles()
        {
            for (int i = 0; i < _totalThreads; i++)
            {
                string file = GetChunkFileName(i);
                if (File.Exists(file))
                    File.Delete(file);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            form3.Show();
        }

        private void ResBtn_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource?.Cancel();
        }

        private void SqlViwi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && SqlViwi.Columns[e.ColumnIndex].Name == "上传者")
            {
                string uploader = SqlViwi.Rows[e.RowIndex].Cells["上传者"].Value?.ToString();
                if (!string.IsNullOrEmpty(uploader))
                {
                    FilterByUploader(uploader);
                    isFiltered = true;
                }
            }
        }

        private async void FilterByUploader(string uploader)
        {
            using (var con = new MySqlConnection(mysqlcon))
            {
                await con.OpenAsync();
                string sql = "SELECT * FROM app WHERE 上传者 = @uploader";
                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@uploader", uploader);
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        var ds = new DataSet();
                        adapter.Fill(ds);
                        SqlViwi.DataSource = ds.Tables[0];
                    }
                }
            }
        }

        private void SqlViwi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string softwareName = SqlViwi.Rows[e.RowIndex].Cells["软件名"].Value.ToString();
                if (!comboBox1.Items.Contains(softwareName))
                    comboBox1.Items.Add(softwareName);
                comboBox1.SelectedItem = softwareName;
            }
        }

        private void ResBtn_Click_1(object sender, EventArgs e)
        {
            // 保留空实现
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                if (this.IsHandleCreated)
                    this.Invoke(new Action(() =>
                    {
                        this.Time.Text = DateTime.Now.ToString();
                    }));
            });
        }
    }
}