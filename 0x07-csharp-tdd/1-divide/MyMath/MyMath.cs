using System;

namespace MyMath
{
    /// <summary>
    /// This is our class Matrix.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// This is our public static int[,] Divide.
        /// </summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            int matrix_winght = matrix.getLenght(1);
            int matrix_lenght = matrix.getLenght(0);
            if (matrix == NULL)
                return(NULL);
            else if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return(NULL);
            }
            else
        }
    }
}
