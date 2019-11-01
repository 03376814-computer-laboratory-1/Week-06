﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] myObjArray = { 2, 'b', 1000.05d, "Hello World" };
            useParams(myObjArray);
            useParams("IE.Tech.", "KMITL", 2017);
            Console.ReadLine();
        }

        static void useParams(params object[] list)
        {
            foreach (object o in list)
                Console.Write(o + " ");
            Console.WriteLine();

        }
    }
}
