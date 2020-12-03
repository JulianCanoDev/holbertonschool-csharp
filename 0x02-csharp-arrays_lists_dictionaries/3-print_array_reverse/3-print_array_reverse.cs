using System;

class Array
{
    public static void Reverse(int[] array)
    {
        int i;
        if (array != null)
        {
            for (i = array.Length - 1 ; i >= 0 ; i--)
            {
                if (array > 0)
                    Console.Write($"{array[i]} ");
                else
                    Console.WriteLine(array[i]);
            }
        }
    }
}
