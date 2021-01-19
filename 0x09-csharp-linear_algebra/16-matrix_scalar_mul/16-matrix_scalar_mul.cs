using System;

/// <summary>This is the class object.</summary>
class MatrixMath
{
    /// <summary>This is the class object.</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (
            (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3) ||
            (matrix.GetLength(1) < 2 || matrix.GetLength(1) > 3)
        )
        {
            return new double[,]{{-1}};
        }

        int i, j;
        int matrix_len_0 = matrix.GetLength(0);
        int matrix_len_1 = matrix.GetLength(1);

        for (i = 0 ; i < matrix_len_0 ; i++)
        {
            for (j = 0 ; j < matrix_len_1 ; j++)
            {
                matrix[i, j] += (matrix[i, j] * scalar);
            }
        }

        return(matrix);
    }
}
