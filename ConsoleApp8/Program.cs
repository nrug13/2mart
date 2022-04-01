



using System;



namespace ConsoleApp1

{

    internal class Program

    {

        static void Main(string[] args)

        {//erilmis ededdin axirdan 3-cu reqemi ile

            //sonuncu reqeminin cemini tap  

            int x = Convert.ToInt32(Console.ReadLine());

            if (x >= 100)

            {///13333533

                int son = x % 10;



                int son3 = x / 100;

                int son4 = son3 % 10;

                int ss = son + son4;

                Console.WriteLine(ss);



            }

            else

            {

                Console.WriteLine("minimum shert odenmir");

            }









        }

    }

}













