using System;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length != 2 || vector.Length != 3)
            return(-1);

        if (vector.Length == 2)
            return(Math.Sqrt(Math.Pow(vector[0] + vector[1], 2)));
        if (vector.Length == 3)
            return(Math.Sqrt(Math.Pow(vector[0] + vector[1] + vector[2], 2)));
    }
}
