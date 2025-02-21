using System;

class bai37
{
    static void Main()
    {
        int i_136, n_136;
        double S_136;

        do
        {
            Console.Write("\nNhap n (n >= 2): ");
            n_136 = int.Parse(Console.ReadLine());

            if (n_136 < 2)
            {
                Console.WriteLine("\nn phai >= 2. Xin nhap lai!");
            }
        } while (n_136 < 2);

        i_136 = 3;
        S_136 = Math.Pow(2.0, 1.0 / 2);

        while (i_136 <= n_136)
        {
            S_136 = Math.Pow((i_136 + S_136) * 1.0, 1.0 / i_136);
            i_136++;
        }

        Console.WriteLine("\nTong la " + S_136);
    }
}
