using System;

class bai5
{
    static void Main()
    {
        int i_136, n_136;
        float S_136 = 0;
        do
        {
            Console.Write("\nNhap n: ");
            n_136 = int.Parse(Console.ReadLine());

            if (n_136 < 1)
            {
                Console.WriteLine("\nn>=1, nhap lai: ");
            }

        } while (n_136 < 1);

        for (i_136 = 0; i_136 < n_136; i_136++)
        {
            S_136 += 1.0f / ((2 * i_136) + 1);
        }

        Console.WriteLine("\nTong: " + S_136);
    }
}
