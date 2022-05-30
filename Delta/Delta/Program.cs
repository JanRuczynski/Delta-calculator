using System;

namespace Delta
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int x1;
            int x2;
            int delta;

            Console.Write("Podaj wartość parametru a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj wartość parametru a: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj wartość parametru a: ");
            int c = Convert.ToInt32(Console.ReadLine());

            delta = b ^ 2 - 4 * a * c; 

            if(delta > 0)
            {
                x1 = (int)(-b - Math.Sqrt(delta)) / (2 * a);

                x2 = (int)(-b + Math.Sqrt(delta)) / (2 * a);
            }
            else if(delta == 0)
            {
                x1 = (int)(-b / 2 * a);
            }
            else
            {
                Console.WriteLine("równanie nie ma pierwiastków rzeczywistych");
                Console.ReadLine();
            }
        }
    }
}
