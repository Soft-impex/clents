using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Clients
{
    public static class GlobalParam
    {
        public static SettingsManager<Setting> SettingsManager;
        public static Setting Setting { get; set; }
        static GlobalParam()
        {
            SettingsManager = new SettingsManager<Setting>("settings.json");
            Setting = SettingsManager.LoadSettings();
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if(!File.Exists(Path.Combine(appData, "Clients", "settings.json")))
                SettingsManager.SaveSettings(Setting);
        }
    }
}
