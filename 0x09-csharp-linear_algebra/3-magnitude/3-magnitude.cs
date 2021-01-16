using System;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length != 2 || vector.Length != 3)
            return(-1);

        double magnitude = 0;

        if (vector.Length == 2)
            magnitude = vector[0] * vector[1];
        if (vector.Length == 3)
            magnitude = vector[0] * vector[1] * vector[2];

        magnitude = Math.Round(Math.Sqrt(magnitude), 2);
        return(magnitude);
    }
}
