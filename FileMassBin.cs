using System.Text;

namespace lab4CH
{
    class FileMassBin
    {
        private Random rnd = new Random();
        public FileMassBin()
        {
            using (var stream = File.Open("FileBin.dat", FileMode.Open))
            {
                using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                {
                    for (int i = 0; i < 100; i++)
                    {
                        writer.Write(rnd.Next(0, 100));
                    }
                }
            }
        }
        public FileMassBin(int a)
        {
            using (var stream = File.Open("FileBin.dat", FileMode.Open))
            {
                using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                {
                    for (int i = 0; i < a; i++)
                    {
                        writer.Write(rnd.Next(0, 100));
                    }
                }
            }
        }
    }
}
