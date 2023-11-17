using System;
using System.Text;
using System.Xml.Serialization;

namespace lab4CH
{
    class Task4
    {
        private FileMass Mass1;
        //Создаём файл типа xml и записываем туда класс FileMass который содержит список
        private void FileCreate()
        {
            using (FileStream f = new FileStream("file.xml", FileMode.OpenOrCreate))
            {
                Mass1 = new FileMass();
                XmlSerializer xml = new XmlSerializer(Mass1.GetType());
                xml.Serialize(f, Mass1);
            }
        }
        //Конструктор, который проходит по списку считанному из файла и ищем числа заканчивающиеся на нужное число
        public Task4()
        {
            FileCreate();
            using (FileStream f = new FileStream("file.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer xml = new XmlSerializer(Mass1.GetType());
                Mass1 = xml.Deserialize(f) as FileMass;
                Console.WriteLine("Type last digit");
                int end = 0;
                try
                {
                    end = int.Parse(Console.ReadLine()) % 10;
                }
                catch (FormatException)
                {
                    end = 0;
                    Console.WriteLine("Looks like you wrote it wrong! It will be set to 0");
                }
                int Sum = 0;
                for (int i = 0; i < Mass1.Len; i++)
                {
                    if (Mass1.Arr[i] % 10 == end)
                    {
                        Console.WriteLine(Mass1.Arr[i]);
                        Sum += Mass1.Arr[i];
                    }
                }
                Console.WriteLine($"Summ of that elements is {Sum}");
            }
        }
    }
}
