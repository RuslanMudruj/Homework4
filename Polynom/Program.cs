using System;
using System.Collections.Generic;

// Це майже готовий варінт завдання
namespace Polynom
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод первого многочлена
            int step;
            int[] koef;

            Console.WriteLine("Enter matrix 1 polynom");
            step = Convert.ToInt32(Console.ReadLine());

            int Val = 0;
           


            koef = new int[step + 1];

            Console.WriteLine("Enter matrix 1 polynom");
            for (int i = 0; i < koef.Length; i++)
            {
                koef[i] = int.Parse(Console.ReadLine());
            }
            Polynomial A = new Polynomial(koef, step);

            
            int step2;
            int[] koef2;

            Console.WriteLine("Enter step 2 polynom");
             step2 = Convert.ToInt32(Console.ReadLine());




             koef2 = new int [step2+1];

             Console.WriteLine("Enter matrix 2 polynom");
             for (int i = 0; i < koef2.Length; i++)
             {
                 koef2[i] = int.Parse(Console.ReadLine());
             }
             Polynomial B = new Polynomial(koef2, step2);

             //вывод многочленов
             Console.Write("A= ");
             A.show();
             Console.WriteLine("\n");
             Console.Write("B= ");
             B.show();

             //вывод операций

             Polynomial C = A + B;
             Polynomial D = A - B;
             Polynomial E = A * B;
             Console.Write("\nA+B= ");
             C.show();
            Console.Write("\nA-B= ");
            D.show();
            Console.Write("\nA*B= ");
            E.show();

            Console.ReadLine();
        }
    }
}

            


