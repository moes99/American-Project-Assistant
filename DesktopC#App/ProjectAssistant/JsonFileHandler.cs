using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProjectAssistant
{
    internal class JsonFileHandler
    {
        public static JsonElement readJson (string path)
        {
            if (File.Exists(path))
            {
                string jsonString = File.ReadAllText(path);
                using var document = JsonDocument.Parse(jsonString);
                return document.RootElement.Clone();
            }
            else
            {
                MessageBox.Show("The JSON file at path: " + path + " does not exist!", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new JsonElement();
            }
        }

        public static bool writeJson (string path, string fileName, object Object)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(Object, options);
                File.WriteAllText($"{path}/{fileName}", jsonString, Encoding.UTF8);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static T? jsonToObject<T>(string path, string fileName)
        {
            try
            {
                string jsonString = File.ReadAllText($"{path}/{fileName}");
                T? obj = JsonSerializer.Deserialize<T>(jsonString);
                return obj;
            }
            catch (Exception ex)
            {
                return default(T);
            }
        }
    }
}
