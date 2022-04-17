
using System;

namespace salameleykim
{
    class Program
    {
        static void Main(string[] args)
        {
            //        3 dene 5 reqemli eded var.
            //Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet. Alinan neticeleri topla
            //Yekunda alian cavabin 50 % -ni hemin ededin uzerine gel
            Random generator = new Random();
            String a = generator.Next(10000, 100000).ToString("D5");
            string b = generator.Next(10000, 100000).ToString("D5");
            string c = generator.Next(10000, 100000).ToString("D5");
            Console.WriteLine($"reqemler:" + a +" ve"+ b+" ve" + c);
            a = a.Remove(1, 3);
            b = b.Remove(1, 3);
            c = c.Remove(1, 3);
            Console.WriteLine("eded duzeldilenden sonra ");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine("onlarin cemi");
            int x = int.Parse(a) + int.Parse(b) + int.Parse(c);
            Console.WriteLine(x);
            double y = Convert.ToDouble(x);

            Console.WriteLine($"50 faizi ve cemi {y*1.5}");




        }
       
        
    }
}
