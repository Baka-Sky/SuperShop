using System;
using System.IO;

namespace SuperShop_V2_Demo
{
    public class ConfigManager
    {
        public string ConfigFilePath { get; } = "shop.config";

        public (int R, int G, int B) LoadConfig()
        {
            if (File.Exists(ConfigFilePath))
            {
                var configContent = File.ReadAllText(ConfigFilePath).Trim();
                // 假设配置文件内容格式为 "RGB=255,128,128"
                var prefix = "RGB=";
                var startIndex = configContent.IndexOf(prefix) + prefix.Length;
                var parts = configContent.Substring(startIndex).Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length == 3 &&
                    int.TryParse(parts[0].Trim(), out int r) &&
                    int.TryParse(parts[1].Trim(), out int g) &&
                    int.TryParse(parts[2].Trim(), out int b))
                {
                    return (r, g, b);
                }
            }
            // 如果文件不存在或内容格式不正确，则返回默认值
            return (255, 255, 255); // Default values
        }

        public void SaveConfig(int r, int g, int b)
        {
            var configContent = $"RGB={r},{g},{b}";
            File.WriteAllText(ConfigFilePath, configContent);
        }



        public string ConfigFilePath1 { get; } = "shopBtn.config";


        }
    }
