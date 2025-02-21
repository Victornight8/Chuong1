using System;

class Program
{
    static void Main()
    {
        int i_136, n_136;
        float S_136 = 0;
        do
        {
            Console.Write("\nNhập n: ");
            n_136 = int.Parse(Console.ReadLine());

            if (n_136 < 1)
            {
                Console.WriteLine("\nN phải lớn hơn hoặc bằng 1. Xin nhập lại!");
            }

        } while (n_136 < 1);

        for (i_136 = 0; i_136 < n_136; i_136++)
        {
            S_136 += 1.0f / ((2 * i_136) + 1);
        }

        Console.WriteLine("\nTổng là: " + S_136);
    }
}
