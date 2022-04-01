



using System;



namespace ConsoleApp1

{

    internal class Program

    {

        static void Main(string[] args)

        {

            //) 8 reqemli ededin reqemlerini iki -iki qruplashdir.

            //Qruplarin cemini tap.Alinan cavabin axirina 99 artir.

            //Sonra cavabin ozunden onun 18 % ni cix;

            int a = Convert.ToInt32(Console.ReadLine());

            if (a >= 10000000 && a < 100000000)

            {

                ///12345678

                /// 1234 5678

                ///  

                int b = a % 10000;

                int c = a / 10000;

                int d = b + c;

                // 18 faizin cixilmasi yeni  

                double d2 = Convert.ToDouble(d);

                double d3 = d2 * 0.82;



                Console.WriteLine($"1 ci qrup {b}, 2 ci qrup {c} yekun cavab {d3}");



            }

            else

            {

                Console.WriteLine("xeta");

            }

        }

    }

}













