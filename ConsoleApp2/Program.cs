using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6 reqemlinin ilk3 reqeqmi

            int x = Convert.ToInt32(Console.ReadLine());
            x = Math.Abs(x);
            int a = x / 1000;
            int sum = 0;
            Console.WriteLine(a);
            if (a >= 100 && a < 1000)
            {
                while (a == 0 == false)

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

