using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4CH
{
    class Task6
    {
        //Читаем текст из файла (доп метод для проверок)
        private void ReadText(string name)
        {
            string line;
            using (var stream = File.Open(name, FileMode.Open))
            {
                using (var reader = new StreamReader(stream))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
        //Конструктор, который генерирует и читает текстовый файл, заменяя , на пробелы в каждой строке
        //Так же он записывает результат в новый файл
        public Task6()
        {
            TextGen.FileCreator();
            string line;
            using (var stream = File.Open("Text.txt", FileMode.Open))
            {
                using (var reader = new StreamReader(stream))
                {
                    using (var stream2 = File.Open("Text2.txt", FileMode.OpenOrCreate))
                    {
                        using (var writer = new StreamWriter(stream2))
                        {
                            while ((line = reader.ReadLine()) != null)
                            {
                                line = line.Replace(',', ' ');
                                line = line.Replace('.', ' ');
                                line = line.Replace('!', ' ');
                                line = line.Replace('?', ' ');
                                line = line.Replace(';', ' ');
                                line = line.Replace(':', ' ');
                                //Console.WriteLine(line);
                                writer.WriteLine(line);
                            }
                        }
                    }
                }
            }
            //ReadText("Text2.txt");
            Process.Start(new ProcessStartInfo("https://www.youtube.com/watch?v=dQw4w9WgXcQ") { UseShellExecute = true });
        }
    }
}
