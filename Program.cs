namespace lab4CH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "-";
            int im;
            while (s != "0")
            {
                Console.WriteLine("Type what do you want to do this time!\n" +
                "1 - Create lottery guess!\n" +
                "2 - Create lottery ticket\n" +
                "3 - Choose toy as a present\n" +
                "4 - Get \n" +
                "5 - Get price difference\n" +
                "6 - Sing a song!\n" +
                "0 - Exit");
                s = Console.ReadLine();
                if (s == "1")
                {
                    Console.WriteLine("Type amount of numbers!");
                    try
                    {
                        im = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Something went wrong!\n" +
                            "Number will be set to 36");
                        im = 36;
                    }
                    FileMassBin data0 = new FileMassBin(im);
                    Task1 data1 = new Task1();
                    Console.WriteLine("Done");
                }
                else if (s == "2") {
                    Console.WriteLine("Type amount of numbers!");
                    try
                    {
                        im = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Something went wrong!\n" +
                            "Number will be set to 36");
                        im = 36;
                    }
                    FileMassBin data0 = new FileMassBin(im);
                    Task2 data2 = new Task2(6);
                    Console.WriteLine(data2);
                    Console.WriteLine("Done");
                }
                else if (s == "3")
                {
                    Task3 data3 = new Task3();
                    Console.WriteLine("Done");
                }
                else if (s == "4")
                {
                    Task4 data4 = new Task4();
                    Console.WriteLine("Done");
                }
                else if (s == "5")
                {
                    Task5 data5 = new Task5();
                    Console.WriteLine("Done");
                }
                else if (s == "6") 
                {
                    Task6 data6 = new Task6();
                    Console.WriteLine("Done");
                }
                else if (s == "0")
                {
                    Console.WriteLine("Time to end it!");
                    break;
                }
                else
                {
                    Console.WriteLine("You wrote smth wrong");
                }
            }
        }
    }
}