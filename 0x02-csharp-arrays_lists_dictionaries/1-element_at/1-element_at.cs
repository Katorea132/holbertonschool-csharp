﻿using System;

class Array
{
    public static int elementAt(int[] array, int index)
    {
        if ((index < array.Length) && (index >= 0))
            return array[index];
        Console.WriteLine("Index out of range");
        return -1;
    }
}
