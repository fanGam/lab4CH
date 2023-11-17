using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab4CH
{
    class Task5
    {
        private FileMass Mass1;
        public Task5()
        {
            using (FileStream f = new FileStream("file.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(FileMass));
                Mass1 = xmlSerializer.Deserialize(f) as FileMass;
                Console.WriteLine($" {Mass1.Arr[0]} and {Mass1.Arr.Min()}");
                Console.WriteLine($" {Mass1.Arr[0] - Mass1.Arr.Min()}");
            }
        }
    }
}
