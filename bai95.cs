using System;

class Program
{
    static void Main()
    {
        float a_136, b_136, c_136;

        Console.Write("\nNhap a: ");
        a_136 = float.Parse(Console.ReadLine());

        Console.Write("\nNhap b: ");
        b_136 = float.Parse(Console.ReadLine());

        Console.Write("\nNhap c: ");
        c_136 = float.Parse(Console.ReadLine());

        if (a_136 < 0)
            a_136 = -a_136;
        if (b_136 < 0)
            b_136 = -b_136;
        if (c_136 < 0)
            c_136 = -c_136;

        Console.WriteLine($"\na = {a_136}");
        Console.WriteLine($"\nb = {b_136}");
        Console.WriteLine($"\nc = {c_136}");

        Console.ReadKey();
    }
}
