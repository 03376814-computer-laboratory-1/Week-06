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
            int val ; // uninitialized variable

            refMethod(out val);
            Console.WriteLine(val);
            Console.ReadLine();
        }

        static void refMethod(out int i)
        {
            i = i + 1;
        }

    }
}
