using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size == 0)
        {
            Console.Write('\n');
        }
        else if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }
    }
}
