﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegateConvert;
using System.Diagnostics;

namespace DelegateConvert.Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ActionTest();
            FunctionTest();
            Debugger.Break();
        }

        private static void ActionTest()
        {
            Action<string, string, int> dst = (x, y, z) => Console.WriteLine($"STR1: {x} STR2: {y} INT: {z}");
            var myDele = ActionConvert.ConvertToObjectParams(dst);
            myDele(new object[] { "Hey", "Yo", 123 });
        }

        private static void FunctionTest()
        {
            Func<int, int, int, bool> checksum = (x, y, z) => x + y == z;
            var myDele = FuncConvert.ConvertToObjectParams<bool>(checksum);
            if (myDele(new object[] { 1, 2, 3 }))
            {
                Console.WriteLine("Yay");
            }
            else
            {
                Console.WriteLine("Nay");
            }
        }
    }
}