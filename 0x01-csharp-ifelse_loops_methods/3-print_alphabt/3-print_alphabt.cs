﻿using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            char alphabet = 'a';
            for (alphabet = 'a'; alphabet <= 'z'; alphabet++)
            {
                if (alphabet == 'q' || alphabet == 'e')
                    continue;
                else
                    Console.Write(alphabet);
            }
        }
    }
}
