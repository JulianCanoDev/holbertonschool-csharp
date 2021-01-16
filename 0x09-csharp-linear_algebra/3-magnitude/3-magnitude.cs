using System;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length != 2 || vector.Length != 3)
            return(-1);

        double magnitude = 0;

        foreach (double element in vector)
        {
            magnitude += (element * element);
        }
        magnitude = Math.Round(Math.Sqrt(magnitude), 2);
        return magnitude;
    }
}
