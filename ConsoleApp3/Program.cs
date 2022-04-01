using System;



namespace ConsoleApp1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //verilmihs 9 reqemli ededin duz ortaya dushen

            //3 reqeminin reqemleri cemi

            //123 456 789

            //123 456  123456- 123000

            int x = Convert.ToInt32(Console.ReadLine());
            x = Math.Abs(x);
            int y = x / 1000;
            int a = y - (y / 1000) * 1000;
            int sum = 0;
            if (a >= 100 && a < 1000)
            {
                while (a != 0)
                {
                    sum += a % 10;
                    a /= 10;
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("xeta");
            }
        }

    }

}

