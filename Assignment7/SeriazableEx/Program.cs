using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializableEx
{
    class serialization
    {
        public static void SerializationData()
        {
            string str = "Welcome to serialization";
            FileStream filestream = new FileStream(@"D:\serialization\serial.cs", FileMode.Create);
            BinaryFormatter binaryobject = new BinaryFormatter();
            binaryobject.Serialize(filestream, str);
            filestream.Close();

        }
        public static void Main(string[] args)
        {
            SerializationData();
            Console.ReadLine();
            Console.WriteLine("serialization successful");
        }
    }
}
