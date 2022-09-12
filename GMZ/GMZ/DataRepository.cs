using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace GMZ
{
    public class DataRepository
    {
        
        private static string m_path;
        private static string fileName = System.IO.Path.Combine(Path, "GMZdata.xml");
        private static DataRepository instance;
        public static string Path
        {
            get
            {
                if (m_path != null) return m_path;
                m_path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GMZ", "Data");
                if (!Directory.Exists(m_path)) Directory.CreateDirectory(m_path);
                return m_path;
            }
        }
        public List<DataComponent> Components { get; } = new List<DataComponent>();
        public List<Product> Products { get; } = new List<Product>();
        private static XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataRepository));
        //Создать метод, который будет возвращать DataRepository, прочитанный из файла.
        public static DataRepository GetRepository()
        {
            if (instance != null) return instance;
            if (!File.Exists(fileName)) return instance = new DataRepository();
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
            {
                return instance = (DataRepository)xmlSerializer.Deserialize(fileStream);
            }

        }
        public static void SaveData(DataRepository dataRepository)
        {
            if (File.Exists(fileName)) File.Delete(fileName);
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            {
                xmlSerializer.Serialize(fileStream, dataRepository);
                instance = dataRepository;
            }
        }
    }
}
