﻿using System;

namespace _14._Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int symbolsBreak = 97 + l;

            for (int symbol1 = 1; symbol1 < n; symbol1++)
            {
                for (int symbol2 = 1; symbol2 < n; symbol2++)
                {
                    for (char symbol3 = 'a'; symbol3 < symbolsBreak; symbol3++)
                    {
                        for (char symbol4 = 'a'; symbol4 < symbolsBreak; symbol4++)
                        {
                            for (int symbol5 = 1; symbol5 <= n; symbol5++)
                            {
                                if (symbol5 > symbol1 && symbol5 > symbol2)
                                {
                                    Console.Write($"{symbol1}{symbol2}{symbol3}{symbol4}{symbol5} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
