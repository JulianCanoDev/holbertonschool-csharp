using System;

/// <summary>This is the class object.</summary>
class VectorMath
{
    /// <summary>This is the class object.</summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double sum = 0;
        int i;

        if (vector1.Length != vector2.Length || vector1.Length < 2 || vector1.Length > 3
            || vector2.Length < 2 || vector2.Length > 3)
        {
            return(-1);
        }

        int vector1_lenght = vector1.Length;

        for (i = 0 ; i < vector1_lenght ; i++)
            sum += (vector1[i] * vector2[i]);

        return sum;
    }
}
