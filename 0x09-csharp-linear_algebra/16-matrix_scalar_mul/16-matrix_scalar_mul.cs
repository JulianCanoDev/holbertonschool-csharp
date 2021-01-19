using System;

/// <summary>This is the class object.</summary>
class MatrixMath
{
    /// <summary>This is the class object.</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (
            (matrix.GetLength(0) != matrix.GetLength(1)) ||
            (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3) ||
            (matrix.GetLength(1) < 2 || matrix.GetLength(1) > 3)
        )
        {
            return new double[,]{{-1}};
        }

        int dimMat = matrix.GetLength(0);
        double[,] kMatrix = new double[dimMat, dimMat];

        for (int vec = 0; vec < dimMat; vec++)
        {
            for (int row = 0; row < dimMat; row++)
            {
                kMatrix[vec, row] = scalar * matrix[vec, row] ;
            }
        }
        return kMatrix;
    }
}
