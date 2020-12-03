using System;

class List
{
    public static List<int> CreatePrint(int size)
    {
        int i;
        List<int> new_list = new List<int>();
        int counter = 0;
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }
        for (i = 0 ; i <= size ; i++)
        {
            new_list[i] = counter;
            if (i < new_list.Length - 1)
                Console.Write(new_list[i] + " ");
            else
                Console.WriteLine(new_list[i]);
        }
        return(new_list);
    }
}
