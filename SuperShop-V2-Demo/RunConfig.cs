using System;
using System.IO;
using SuperShop_V2_Demo;


namespace SuperShop_V2_Demo
{
    public class RunConfigManager
    {
    
        private string configFilePath = "run.txt";

        // 确保配置文件存在，如果不存在则创建并设置默认值
        public void EnsureConfigFile()
        {
            if (!File.Exists(configFilePath))
            {
                File.WriteAllText(configFilePath, "Force-waiting");
            }
        }

        // 读取配置文件中的值
        public string ReadConfigValue()
        {
            if (File.Exists(configFilePath))
            {
                return File.ReadAllText(configFilePath).Trim();
            }
            return "Force-waiting"; // 如果文件不存在，返回默认值
        }

        // 更新配置文件中的值
        public void UpdateConfigValue(string value)
        {
            File.WriteAllText(configFilePath, value);
        }

        // 保存RGB值到配置文件


        // 加载RGB配置

    }
}