﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180305ps5_op2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nFirst = 3;
            int nSecond = 3;

            Console.WriteLine("후증가, 후감소 연산자");
            Console.WriteLine("nFirst = {0}, nSecond = {1}",nFirst, nSecond);
            Console.WriteLine("nFrist++ = {0}, nSecond-- = {1}",nFirst++,nSecond--);
            Console.WriteLine("nFirst = {0},nSecond = {1}\n",nFirst,nSecond);

            nFirst = 3;
            nSecond = 3;

            Console.WriteLine("선증가, 선감소 연산자");
            Console.WriteLine("nFirst = {0}, nSecond = {1}",nFirst, nSecond);
            Console.WriteLine("++nFirst = {0}, --nSecond = {1}",++nFirst,--nSecond);
            Console.WriteLine("nFirst = {0}, nSecond = {1}",nFirst,nSecond);
        }
    }
}
