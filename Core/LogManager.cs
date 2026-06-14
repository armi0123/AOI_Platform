using System;
using System.IO;

namespace AOI_Platform.Core
{
    public static class LogManager
    {
        private static string _logDirectory;

        // 初始化LogManager，確保Log目錄存在
        public static void Initialize()
        {
            // 建立Log目錄
            _logDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
            // 如果Log目錄不存在，則建立它
            if (!Directory.Exists(_logDirectory))
            {
                Directory.CreateDirectory(_logDirectory);
            }
            // 寫入程式啟動的Log
            Info("Program Start");
        }
        // 寫入Log的方法，會自動將Log寫入以日期命名的檔案中
        public static void Write(string message)
        {
            try
            {
                // 確保Log目錄存在，如果Initialize沒有被呼叫，則在這裡建立Log目錄
                if (string.IsNullOrEmpty(_logDirectory))
                {
                    _logDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
                }

                if (!Directory.Exists(_logDirectory))
                {
                    Directory.CreateDirectory(_logDirectory);
                }
                // 以日期為檔名，確保每天的Log寫入不同的檔案
                string fileName = DateTime.Now.ToString("yyyyMMdd") + ".txt";
                string filePath = Path.Combine(_logDirectory, fileName);

                string logText =
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") +
                    "  " +
                    message +
                    Environment.NewLine;

                // 將Log寫入檔案，使用AppendAllText確保不會覆蓋原有的Log
                File.AppendAllText(filePath, logText);
            }
            catch
            {
                // Log本身失敗時，先不要讓主程式崩潰
            }
        }
        
        public static void Info(string message)
        {
            Write("[INFO] " + message);
        }

        public static void Error(string message)
        {
            Write("[ERROR] " + message);
        }

        public static void WriteException(Exception ex)
        {
            Write("[EXCEPTION] " + ex.ToString());
        }
    }
}

