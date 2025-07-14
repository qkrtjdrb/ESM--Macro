using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ESM광고Macro.Chrome;
namespace ESM광고Macro.Resources
{
    internal class Config
    {
        public static IWebDriver driver;

        public static int listsearchtimer { get; set; }
        public static int timer { get; set; } 
        private static int scheduledONtime { get; set; }
        private static int scheduledOFFtime { get; set; }

        static Config()
        {
            driver = BrowserActions.ChromeESMStart();
            listsearchtimer = 5000;
            timer = 30;
        }
    }
    internal class SaveConfig
    {
        public static void SC(string filepath)
        {
            var lines = new List<string>();

            lines.Add("Key,Value");
            var props = typeof(Config).GetProperties
                (
                    System.Reflection.BindingFlags.Static |
                    System.Reflection.BindingFlags.Public |
                    System.Reflection.BindingFlags.NonPublic
                );
            foreach (var prop in props)
            {
                var key = prop.Name;
                var value = prop.GetValue(null)?.ToString();
                lines.Add($"{key} {value}");
            }

            File.WriteAllLines(filepath, lines);
            MessageBox.Show("설정 저장 완료");
        }
    }

    internal class LoadConfig
    {
        public static Config LC(string filePath)
        {
            var config = new Config();

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines.Skip(1)) // 첫 줄은 헤더
            {
                var parts = line.Split(' ');
                if (parts.Length != 2) continue;

                string key = parts[0];
                string value = parts[1];

                var prop = typeof(Config).GetProperty(key);
                if (prop != null && prop.CanWrite)
                {
                    try
                    {
                        object convertedValue = Convert.ChangeType(value, prop.PropertyType);
                        prop.SetValue(config, convertedValue);
                    }
                    catch
                    {
                        // 변환 실패 시 무시하거나 로깅
                    }
                }
            }

            return config;
        }

        public static void LoadConfigToTextBoxes(TextBox textboxlistTimer, TextBox textboxTimer)
        {
            textboxlistTimer.Text = (Config.listsearchtimer / 1000).ToString();
            textboxTimer.Text = Config.timer.ToString();
        }
    }
}
