



using System;



namespace ConsoleApp1

{

    internal class Program

    {

        static void Main(string[] args)

        {

            //4 reqemli

            //tersine duz//

            //8 artir

            int x = Convert.ToInt32(Console.ReadLine());



            x = Math.Abs(x);

            if (x >= 1000 && x < 10000)



            {

                int reverse = 0;

                int qaliq = 0;





                while (x != 0)

                {

                    qaliq = x % 10;

                    reverse = reverse * 10 + qaliq;

                    x /= 10;



                }

                int z = int.Parse("8" + reverse);

                Console.WriteLine(z);

            }

            else

            {

                Console.WriteLine("xeta");

            }





        }

    }

}













