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
            int a = 1;
            int b = 2;
            int c;
            c = add(a, b);
            Console.WriteLine("c = {0}", c);
            Console.WriteLine("3 + 5 = {0}", add(3, 5));
            Console.WriteLine("4 + 7 =  " + add(4, 7));
            Console.ReadLine();
        }

        static int add(int a, int b)
        {
            return a + b;
        }

    }
}
