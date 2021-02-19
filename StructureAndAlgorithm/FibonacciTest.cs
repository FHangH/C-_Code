﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StructureAndAlgorithm
{
    class FibonacciTest
    {
        static void Main(string[] args)
        {
            int num;
            string str;

            WriteLine("使用递归计算斐波拉契数列");
            Write("请输入一个整数：");

            str = ReadLine();
            num = int.Parse(str);
            if (num < 0)
            {
                WriteLine("输入的数字必须大于等于0\n");
            }
            else
            {
                Write("Fibonacci(" + num + ")=" + Fibonacci(num) + "\n");
            }
        }

        static int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return (Fibonacci(n - 1) + Fibonacci(n - 2));
            }
        }
    }
}
