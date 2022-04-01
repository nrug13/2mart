using System;



namespace ConsoleApp1

{

    internal class Program

    {

        static void Main(string[] args)

        {

            // verilmihs 6 reqemli ededin

            // 1 ci reqemini hemin ededin axirina at.

            int x = Convert.ToInt32(Console.ReadLine());

            x = Math.Abs(x);



            // 1 23456





            if (x >= 100000 && x < 1000000)

            {



                int b = x / 100000;

                int c = int.Parse(x.ToString() + b.ToString());

                Console.WriteLine(c);

            }

            else

            {

                Console.WriteLine("xeta");

            }





        }

    }

}

