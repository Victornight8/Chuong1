using System;

class Bai45
{
    static void Main()
    {
        int themang_136, n_136, P_136;

        do
        {
            Console.Write("\nNhap n: ");
            if (!int.TryParse(Console.ReadLine(), out n_136) || n_136 < 0)
            {
                Console.WriteLine("\nLoi: n >= 0 !");
            }
        } while (n_136 < 0);

        P_136 = 1;
        themang_136 = n_136;

        while (themang_136 != 0)
        {
            P_136 *= themang_136 % 10;
            themang_136 /= 10;
        }

        Console.WriteLine("\nTich la " + P_136);
        Console.ReadKey();
    }
}
