﻿using System;
using System.Reflection;

/// <summary>
/// This is our class Zombie.
/// </summary>
class Obj
{
    /// <summary>
    /// This is our class Zombie.
    /// </summary>
    public static void Print(object myObj)
    {
        Type t = myObj.GetType();
        TypeInfo myType = t.GetTypeInfo();
        PropertyInfo[] props = t.GetProperties();
        MethodInfo[] methods = t.GetMethods();

        Console.WriteLine(myType.Name + " Properties:");
        foreach (var element in props)
            Console.WriteLine(element.Name);

        Console.WriteLine(myType.Name + " Methods:");
        foreach (var element in methods)
            Console.WriteLine(element.Name);
    }
}
