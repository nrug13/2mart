



using System;



namespace ConsoleApp1

{

    internal class Program

    {

        static void Main(string[] args)

        {

            //9 reqemli ededdi

            //tek yerde dayananlardan bir eded duzlet,

            //sonra cut yerde dayanlarinda bir eded duzlet,

            // sonra onlari topla
            l1:
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

                long tek = long.Parse(f.ToString() + e.ToString() +

                    d.ToString() + c.ToString() + b.ToString());

                Console.WriteLine("tek yerde" + tek);

                // 2 4 6 8  

                long g = (a % 100000000 - a % 10000000) / 10000000;

                long h = (a % 1000000 - a % 100000) / 100000;

                long i = (a % 10000 - a % 1000) / 1000;

                long j = (a % 100 - a % 10) / 10;

                long cut = long.Parse(g.ToString() + h.ToString() +



                     i.ToString() + j.ToString());

                Console.WriteLine("tek yerde" + tek);

                Console.WriteLine("cut yerde" + cut);

                Console.WriteLine($"ikisi birlikde {tek + cut}");

            }

            else

            {

                Console.WriteLine("BIR DAHA CEHD EDIN");
                goto l1;

            }







        }

    }

}













