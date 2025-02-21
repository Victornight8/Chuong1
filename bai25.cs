using System;

class bai25
{
    static void Main()
    {
        int i_136, n_136;
        long S_136;

        do
        {
            Console.Write("\nNhap n (n > 0): ");
            n_136 = int.Parse(Console.ReadLine());

            if (n_136 <= 0)
            {
                Console.WriteLine("\nN phai > 0. Xin nhap lai!");
            }

        } while (n_136 <= 0);

        i_136 = 1;
        S_136 = 0;

        Console.WriteLine($"\nCac uoc so chan cua so {n_136} la: ");

        while (i_136 <= n_136)
        {
            if (n_136 % i_136 == 0)
            {
                if (i_136 % 2 == 0)
                {
                    Console.Write($"{i_136,4}");
                    S_136 += i_136;
                }
            }
            i_136++;
        }

        Console.WriteLine($"\nTong cac uoc so chan cua {n_136} la: {S_136}");
    }
}
