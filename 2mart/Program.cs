using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //verilmish 4 reqemli ededin reqemlerinin cemini tap

            int a = Convert.ToInt32(Console.ReadLine());

            int b = Math.Abs(a);

            int cem = 0;
            if (b < 10000 && b >= 1000)
            {
                while (a != 0)

                {
                    cem += a % 10;
                    a /= 10;
                }
                Console.WriteLine(cem);
            }
            else

            {
                Console.WriteLine("4 reqemli deyil");
            }
        }

    }

}

