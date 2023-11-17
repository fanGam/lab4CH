using System.Text;

namespace lab4CH
{
    class Task2
    {
        private int num;
        private Stack<int> MyStack;
        private int[,] MySpace;
        private int SizeList;
        //Базовый конструктор который принимает на вход число n - размер квадратной матрицы
        public Task2(int n)
        {
            SizeList = n;
            MyStack = new Stack<int>();
            //Читаем из файла и записываем в стек
            if (File.Exists("FileBin.dat"))
            {
                using (var stream = File.Open("FileBin.dat", FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        while ((num = reader.Read()) != -1)
                        {
                            if (num != 0)
                            {
                                MyStack.Push(num);
                            }
                        }
                    }
                }
            }
            //заполняем матрицу
            MySpace = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((num = MyStack.Pop()) != -1)
                    {
                        if ((i + j) % 2 == 0)
                        {
                            while (num > 10) num /= 10;
                        }
                        MySpace[i, j] = num;
                    }
                    else
                    {
                        MySpace[i, j] = 0;
                    }
                }
            }
        }
        public override string ToString()
        {
            for (int i = 0; i < SizeList; i++)
            {
                for (int j = 0; j < SizeList; j++)
                {
                    Console.Write("{0,5}", this.MySpace[i, j]);
                }
                Console.WriteLine();
            }
            return "------------------------------------";
        }
    }
}
