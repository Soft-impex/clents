using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Clients
{
    public class SettingsManager<T> where T : class, new()
    {
        private readonly string _filePath;

        public SettingsManager(string fileName)
        {
            _filePath = GetLocalFilePath(fileName);
        }

        private string GetLocalFilePath(string fileName)
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(Path.Combine(appData, "Clients")))
                Directory.CreateDirectory(Path.Combine(appData, "Clients"));
            return Path.Combine(appData, "Clients", fileName);
        }

        public T LoadSettings() =>
            File.Exists(_filePath) ?
            JsonSerializer.Deserialize<T>(File.ReadAllText(_filePath)) :
            new T();

        public void SaveSettings(T settings)
        {
            string json = JsonSerializer.Serialize(settings);
            File.WriteAllText(_filePath, json);
        }
    }
}
