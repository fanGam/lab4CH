using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4CH
{
    class Task1
    {
        //Поля для внутренних обработок
        private List<int> MyList;
        private int num;
        //Конструктор, который проходит по файлу FileBin.dat и читает числа оттуда
        public Task1()
        {
            //Читаем файл и заполняем список
            if (File.Exists("FileBin.dat"))
            {
                MyList = new List<int>();
                using (var stream = File.Open("FileBin.dat", FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        while ((num = reader.Read()) != -1)
                        {
                            if (!MyList.Contains(num))
                            {
                                MyList.Add(num);
                            }
                        }
                    }
                }

            }
            //Открываем новый файл и записываем из списка
            using (var stream = File.Open("FileBin2.dat", FileMode.OpenOrCreate))
            {
                using (var reader = new BinaryWriter(stream, Encoding.UTF8, false))
                {
                    //MyList.Sort();
                    foreach (int n in  MyList)
                    {
                        reader.Write(n);
                        Console.WriteLine(n);
                    }
                }
            }
        }
    }
}
