using System;

/// <summary>This is the class object.</summary>
class VectorMath
{
    /// <summary>This is the class object.</summary>

    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] sum = new double[2];

        if (vector1.Length < 2 || vector1.Length > 3 || vector2.Length < 2 ||
            vector2.Length > 3 || vector1.Length != vector1.Length)
        {
        for (int i = 0; i < 2; i++)
            sum[i] = -1;
        return sum;
        }

        int len;
        if  (vector1.Length == 2)
            len = 2;
        else
            len = 3;

        double[] sum2 = new double[len];
        for (int i = 0; i < vector1.Length; i++)
            sum2[i] = (vector1[i] + vector2[i]);

        return sum2;
    }
}
