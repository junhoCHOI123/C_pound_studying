﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace iteration_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myAI = new ArrayList();
            myAI.Add("Hello");
            myAI.Add("World");
            myAI.Add("!");
            Console.Write("Values:");

            PrintValues(myAI);
        }
        public static void PrintValues(ArrayList myList)
        {
            foreach(string text in myList)
            {
                Console.Write("\t{0}",text);
            }
            Console.WriteLine();
        }
    }
}
