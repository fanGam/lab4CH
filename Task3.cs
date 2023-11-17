using System.Text;
using System;

namespace lab4CH
{
    class Task3
    {
        //Описывается структура для хранения игрушек
        private struct Toy
        {
            public Toy(string a, int b, int c, int d)
            {
                Name = a;
                Price = b;
                AgeFrom = c;
                AgeTo = d;
            }
            public string Name { get; set; }
            public int Price { get; set; }
            public int AgeFrom { get; set; }
            public int AgeTo { get; set; }
            public override string ToString()
            {
                return $"{Name} toy with price of {Price}$ for children from {AgeFrom} to {AgeTo}";
            }
        }
        List<Toy> ToyStore;
        Toy OneToy;
        public void Gen()
        {
            //Записываем игрушки в файл
            using (var stream = File.Open("FileToys.dat", FileMode.OpenOrCreate))
            {
                using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                {
                    writer.Write("Train"); writer.Write(125); writer.Write(6); writer.Write(15);
                    writer.Write("Doll"); writer.Write(100); writer.Write(0); writer.Write(12);
                    writer.Write("Tablet"); writer.Write(1249); writer.Write(12); writer.Write(85);
                    writer.Write("Car"); writer.Write(150); writer.Write(2); writer.Write(12);
                    writer.Write("Puzzle"); writer.Write(80); writer.Write(12); writer.Write(18);
                    writer.Write("Monopoly"); writer.Write(120); writer.Write(8); writer.Write(85);
                    writer.Write("Chess"); writer.Write(140); writer.Write(14); writer.Write(85);
                    writer.Write("Slime"); writer.Write(50); writer.Write(6); writer.Write(16);
                    writer.Write("Djenga"); writer.Write(130); writer.Write(4); writer.Write(85);
                    writer.Write("Paint"); writer.Write(90); writer.Write(3); writer.Write(12);
                }
            }
        }
        public Task3()
        {
            ToyStore = new List<Toy>();
            Gen();
            //Последовательно читаем по одной игрушке и записываем в список
            if (File.Exists("FileToys.dat"))
            {
                using (var stream = File.Open("FileToys.dat", FileMode.OpenOrCreate))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        string Name;
                        int Price;
                        int AgeFrom;
                        int AgeTo;
                        try
                        {
                            while ((Name = reader.ReadString()) != null &&
                            (Price = reader.ReadInt32()) != -1 &&
                            (AgeFrom = reader.ReadInt32()) != -1 &&
                            (AgeTo = reader.ReadInt32()) != -1)
                            {
                                OneToy = new Toy(Name, Price, AgeFrom, AgeTo);
                                Console.WriteLine(OneToy);
                                ToyStore.Add(OneToy);
                            }
                        }
                        catch (EndOfStreamException)
                        {

                        }
                    }
                }
            }
            //Проходим по списку и находим самую дорогую игрушку
            if (ToyStore.Count() > 0)
            {
                Toy MostExp = ToyStore[0];
                for (int i = 0; i < ToyStore.Count(); i++)
                {
                    if (ToyStore[i].Price > MostExp.Price)
                    {
                        MostExp = ToyStore[i];
                    }
                }
                Console.WriteLine(MostExp);
            }
            else
            {
                Console.WriteLine("No toys in shop");
            }
        }
        
    }
}
