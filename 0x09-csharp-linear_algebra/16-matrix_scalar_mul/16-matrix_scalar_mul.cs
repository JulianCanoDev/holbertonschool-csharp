﻿using System;

/// <summary>This is the class object.</summary>
class MatrixMath
{
    /// <summary>This is the class object.</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix is double[,] && (2 == matrix.GetLength(0) && 2 == matrix.GetLength(1)) ||
        (3 == matrix.GetLength(0) && 3 == matrix.GetLength(1)) )
        {
            int i, j;
            int matrix_len = matrix.GetLength(0);

            for (i = 0 ; i < matrix_len ; i++)
            {
                for (j = 0 ; j < matrix_len ; j++)
                {
                    matrix[i, j] += (matrix[i, j] * scalar);
                }
            }

            return(matrix);
        }

        else return new double[,]{{-1}};
    }
}
