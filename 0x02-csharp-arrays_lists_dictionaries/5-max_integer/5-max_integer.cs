using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        int i;
        int max_value;
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return(-1);
        }
        for (i = 0 ; i <= myList.Count ; i++)
        {
            if (myList[i] > myList[i + 1])
                max_value = myList[i];
        }
        return(max_value);
    }
}
