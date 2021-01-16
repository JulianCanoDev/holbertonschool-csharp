using System;

/// <summary>This is the class object.</summary>
class VectorMath
{
    /// <sumary>This method gets either a 2D or 3D vector and returns its magnitude,
    ///if the vector is not 2D or 3D it returns -1.</summary>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length != 2 || vector.Length != 3)
            return -1;

        double magnitude = 0;

        foreach (double element in vector)
        {
            magnitude += (element * element);
        }
        magnitude = Math.Round(Math.Sqrt(magnitude), 2);
        return magnitude;
    }
}
