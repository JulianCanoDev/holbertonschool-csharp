using System;

namespace _11_print_diagonal
{
    class Line
    {
        public static void PrintDiagonal(int length)
        {
            int repetitions, spaces;
            if (length <= 0)
                Console.Write("\n");
            else
            {
                for (repetitions = 0 ; repetitions < length ; repetitions++)
                {
                    for (spaces = 0 ; spaces < repetitions ; spaces++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("/");
                }
                Console.Write("\n");
            }
        }
    }
}
