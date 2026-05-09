using System;

class Program

{
    static void Main()
    {
        int L = int.Parse(Console.ReadLine()!);
        int C = int.Parse(Console.ReadLine()!);

        if ((L+C) % 2 ==0)
        Console.WriteLine(1);
        else
        Console.WriteLine(0);
    }
}