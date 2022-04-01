using System;



namespace ConsoleApp1

{

    internal class Program

    {

        static void Main(string[] args)

        {

            //2 dene 5 reqemli eded daxil et.

            //I ededin reqemleri ceminin usutne

            // II ededin reqemleri hasilini gel.

            // Neticenin axirina I ededin en axiinci reqemini artir.
            l1:
            int a = Convert.ToInt32(Console.ReadLine());



            int sum = 0;

            //127
            
            if (a >= 10000 && a < 100000)

            {

                while (a != 0)

                {
                    sum += a % 10;

                    a /= 10;

                    continue;

                }



                Console.WriteLine("birinci reqem daxil edildi");





            }

            else

            {

                Console.WriteLine("yeniden cehd edin");
                goto l1;


            }


            l3:
            int b = Convert.ToInt32(Console.ReadLine());

            int sum2 = 1;



            if (b >= 10000 && b < 100000)

            {

                while (b != 0)

                {

                    sum2 *= b % 10;

                    b /= 10;

                    continue;

                }



                Console.WriteLine("ikinci reqem daxil edildi");





            }

            else

            {

                Console.WriteLine("yeniden cehd edin");
                goto l3;
            }

            Console.WriteLine($"{sum + sum2}");







        }

    }

}

