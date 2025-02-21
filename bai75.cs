using System;

class Program
{
    static bool KiemTra_136(int n_136)
    {
        if (n_136 < 2)
            return true;

        while (n_136 > 1)
        {
            if (n_136 % 2 != 0)
                return false;
            n_136 /= 2;
        }
        return true;
    }

    static void Main()
    {
        int max_136 = 10000;
        Console.WriteLine("Cac so co dang 2^k trong khoang [0, {0}]:", max_136);

        for (int i_136 = 0; i_136 < max_136; i_136++)
        {
            if (KiemTra_136(i_136))
                Console.Write("{0,5}", i_136);
        }

        Console.ReadKey();
    }
}
