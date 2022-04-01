using System;



namespace ConsoleApp1

{

    internal class Program

    {

        static void Main(string[] args)

        {

            //verilmihs 8 reqemli ededin ilk I

            //ve axirinci reqemlerini legv et

            int x = Convert.ToInt32(Console.ReadLine());

            x = Math.Abs(x);



            // 12345678

            //234567





            if (x >= 10000000 && x < 100000000)

            {



                int reqem1 = x / 10000000;

                int sonReqem = x % 10;

                int son = (x - reqem1 * 10000000 - sonReqem) / 10;

                Console.WriteLine(son);

            }

            else

            {

                Console.WriteLine("xeta");

            }





        }

    }

}

