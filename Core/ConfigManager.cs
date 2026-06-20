using System;
using System.IO;
using Newtonsoft.Json;
using AOI_Platform.Models;

namespace AOI_Platform.Core
{
    // ConfigManager 負責管理系統設定檔
    // 主要功能：
    // 1. 程式啟動時讀取 Config.json
    // 2. 如果 Config.json 不存在，就建立預設設定
    // 3. 使用者修改設定後，將 ConfigParameter 儲存成 JSON 檔案
    public static class ConfigManager
    {
        // Config 資料夾路徑
        private static readonly string _configDirectory =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config");

        // Config.json 完整路徑
        private static readonly string _configPath =
            Path.Combine(_configDirectory, "Config.json");

        // 讀取設定檔
        public static ConfigParameter Load()
        {
            try
            {
                // 如果 Config 資料夾不存在，就建立
                if (!Directory.Exists(_configDirectory))
                {
                    Directory.CreateDirectory(_configDirectory);
                }

                // 如果 Config.json 不存在，就建立一份預設設定
                if (!File.Exists(_configPath))
                {
                    ConfigParameter defaultConfig = new ConfigParameter();
                    Save(defaultConfig);
                    return defaultConfig;
                }

                // 讀取 Config.json 文字內容
                string json = File.ReadAllText(_configPath);

                // 將 JSON 字串轉回 ConfigParameter 物件
                ConfigParameter config =
                    JsonConvert.DeserializeObject<ConfigParameter>(json);

                // 如果轉換失敗，就使用預設設定
                if (config == null)
                {
                    config = new ConfigParameter();
                }

                return config;
            }
            catch (Exception ex)
            {
                // 如果讀取過程發生錯誤，寫入 Log，並回傳預設設定
                LogManager.WriteException(ex);
                return new ConfigParameter();
            }
        }

        // 儲存設定檔
        public static void Save(ConfigParameter config)
        {
            try
            {
                // 如果 Config 資料夾不存在，就建立
                if (!Directory.Exists(_configDirectory))
                {
                    Directory.CreateDirectory(_configDirectory);
                }

                // 將 ConfigParameter 物件轉成 JSON 字串
                string json =
                    JsonConvert.SerializeObject(config, Formatting.Indented);

                // 將 JSON 寫入 Config.json
                File.WriteAllText(_configPath, json);
            }
            catch (Exception ex)
            {
                // 如果儲存失敗，寫入 Log
                LogManager.WriteException(ex);
            }
        }
    }
}