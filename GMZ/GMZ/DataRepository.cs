using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace GMZ
{
    class DataRepository
    {
        private string m_path;
        public string Path
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
        private static XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataRepository));
        //Создать метод, который будет возвращать DataRepository, прочитанный из файла.
    }
}
