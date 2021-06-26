namespace LMS_TUBES.Config
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;

    class ParsingConfig<T>
    {
        List<T> ConfigList { get; set; }
        string filePath;

        public ParsingConfig() { }

        public ParsingConfig(List<T> configList)
        {
            ConfigList = new List<T>();
            ConfigList = configList;
        }

        public void SaveToJson(string fileName)
        {
            try
            {
                HandlingConfig.SanitizeInputNotNull(fileName);

                filePath = @"" + $"{fileName}.json";
                string jsonData = JsonConvert.SerializeObject(ConfigList, Formatting.Indented);

                File.WriteAllText(filePath, jsonData);
            }
            catch(ArgumentNullException e)
            {
                Console.Error.WriteLine(e.ParamName);
            }
            
            
        }

        public List<T> ReadJson(string fileName)
        {
            try
            {
                HandlingConfig.SanitizeInputNotNull(fileName);

                filePath = $"{fileName}.json";

                HandlingConfig.SanitizeFileIsExist(filePath);
                
                String configJsonData = File.ReadAllText(filePath);
                ConfigList = JsonConvert.DeserializeObject<List<T>>(configJsonData);

                return ConfigList;

            }
            catch (Exception e)
            {
                if(e is ArgumentNullException | e is FileNotFoundException)
                {
                    Console.Error.WriteLine(e.Message);
                    return null;
                }
                
            }
            return null;
        }
    }
}
