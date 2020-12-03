using System;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        if (aQueue == null)
            aQueue = new Queue<string>();

        Console.WriteLine($"Number of items: {aQueue.Count}");
        if (aQueue.Count == 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine($"Top item: {aQueue.Peek()}");
        Console.WriteLine($"Stack contains \"{search}\": {aQueue.Contains(search)}");

        while (aQueue.Contains(search))
            aQueue.Pop();

        if (newItem != null)
            aQueue.Push(newItem);

        return(aQueue);
    }
}
