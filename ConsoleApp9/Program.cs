



using System;



namespace ConsoleApp1

{

    internal class Program

    {

        static void Main(string[] args)

        {

            //9 reqemli ededdin

            //tek yerde dayananlardan

            //bir eded duzlet: 132346389 = 12439

            long a = Convert.ToInt64(Console.ReadLine());

            if (a >= 100000000 && a < 1000000000)

            {

                //1 2 3  4 5 6 7 8 9  

                //1   3    5   7   9

                long b = a % 10;

                long c = ((a % 1000) - (a % 100)) / 100;

                long d = ((a % 100000) - (a % 10000)) / 10000;

                long e = ((a % 10000000) - (a % 1000000)) / 1000000;

                long f = a / 100000000;

                string y = (f.ToString() + e.ToString() +

                    d.ToString() + c.ToString() + b.ToString());

                Console.WriteLine(y);

            }

            else

            {

                Console.WriteLine("xeta");

            }







        }

    }

}













