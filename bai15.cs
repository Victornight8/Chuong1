using System;

class Program
{
    static void Main()
    {
        int i_136, n_136;
        float S_136, T_136;
        i_136 = 1;
        S_136 = 0;
        T_136 = 0;

        do
        {
            Console.Write("\nNhập n: ");
            n_136 = int.Parse(Console.ReadLine());

            if (n_136 < 1)
            {
                Console.WriteLine("\nN phải >= 1. Xin nhập lại!");
            }

        } while (n_136 < 1);

        while (i_136 <= n_136) 
        {
            T_136 = T_136 + i_136;
            S_136 = S_136 + 1.0f / T_136;
            i_136++;
        }

        Console.WriteLine("\nTổng là: " + S_136);
    }
}
