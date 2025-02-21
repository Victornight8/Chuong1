using System;

class bai6
{
    static void Main()
    {
        int i_136, n_136;
        float S_136 = 0;
        i_136 = 1;

        do
        {
            Console.Write("\nNhap n: ");
            n_136 = int.Parse(Console.ReadLine());

            if (n_136 < 1)
            {
                Console.WriteLine("\nN phai lon hon hoac bang 1. Xin nhap lai!");
            }

        } while (n_136 < 1);

        while (i_136 <= n_136)
        {
            S_136 += 1.0f / (i_136 * (i_136 + 1));
            i_136++;
        }

        Console.WriteLine("\nTong la: " + S_136);
    }
}
