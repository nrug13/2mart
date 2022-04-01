using System;



namespace ConsoleApp1

{

    internal class Program

    {

        static void Main(string[] args)

        {

            //verilmihs 5 reqemli ilk ve son reqemlerinin

            //ceminin kvadrati

            //1 234 5    

            // 1 2345

            int x = Convert.ToInt32(Console.ReadLine());

            x = Math.Abs(x);









            if (x >= 10000 && x < 100000)

            {

                int y = x % 10;

                int b = x / 10000;

                int c = (y + b) * (y + b);

                Console.WriteLine(c);

            }

            else

            {

                Console.WriteLine("xeta");

            }





        }

    }

}

