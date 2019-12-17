using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06
{
   
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Divide seven");
               Console.Write("Enter number Begin: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter number last: ");
            int l = int.Parse(Console.ReadLine());

            finddiv7(b, l);
            Console.ReadKey();
        }
        static void finddiv7(int b, int l)
        {
            for (int i = b; i <= l; i++)
            {
                if (i % 7 == 0)
                    Console.Write($"{i} ");
            }
        }



    }
}
