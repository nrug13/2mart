using System;
namespace ConsoleApp2
{
    internal class Program

    {
        static void Main(string[] args)
        {

            //        3 dene 5 reqemli eded var.
            //Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet. Alinan neticeleri topla
            //Yekunda alian cavabin 50 % -ni hemin ededin uzerine gel.
            Console.WriteLine("reqemleri daxil et");
          
            int a = Convert.ToInt32(Console.ReadLine());
            yoxla(a);
            
            int b = Convert.ToInt32(Console.ReadLine());
            yoxla(b);
            
            int c = Convert.ToInt32(Console.ReadLine());
            yoxla(c);
            
            int a2 = a % 10;
            int a1 = a / 10000;
            int a3 = int.Parse(a1.ToString() + a2.ToString());
            int b2 = b % 10;
            int b1 = b / 10000;
            int b3 = int.Parse(b1.ToString() + b2.ToString());
            int c2 = c % 10;
            int c1 = c / 10000;
            int c3 = int.Parse(c1.ToString() + c2.ToString());
            Console.WriteLine($" 1 Alinan eded{a3}");
            Console.WriteLine($" 1 Alinan eded{a3}");
            Console.WriteLine($" 1 Alinan eded{a3}");
            double cem = (a3 + b3 + c3)*1.0*1.5;
            Console.WriteLine($"cavab {cem}");


        }

        static void yoxla(int o)
        {
            l1:
            o= Convert.ToInt32(Console.ReadLine());
            if (o >= 10000 && o < 100000)
            {
                Console.WriteLine("reqem daxil edildi");  
            }
            else
            {
                Console.WriteLine("xeta");
                goto l1;
                
                
            }
        }
       
    }















}























