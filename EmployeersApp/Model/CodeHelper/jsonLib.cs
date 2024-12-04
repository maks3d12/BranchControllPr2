using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeersApp.Model.CodeHelper
{
    public class FileManager
    {
        public static void Serialize<T>(ObservableCollection<T> list, string fileName)
        {
            string json = JsonConvert.SerializeObject(list);
            File.WriteAllText($"{fileName}.json", $"\r\n{json}");
        }


        public static ObservableCollection<T> Deserialization<T>(string fileName)
        {
            string info = File.ReadAllText($"{fileName}.json");
            ObservableCollection<T> collection = JsonConvert.DeserializeObject<ObservableCollection<T>>(info);
            return collection;
        }
    }
}
