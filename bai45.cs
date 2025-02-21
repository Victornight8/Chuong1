using System;

class Program
{
    static void Main()
    {
        int so_136;

        Console.Write("Nhap vao so = ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input) || !int.TryParse(input, out so_136) || so_136 < 10 || so_136 > 99)
        {
            Console.WriteLine("\nKhong hop le !");
            return;
        }

        int donvi_136 = so_136 % 10;
        int chuc_136 = so_136 / 10;

        string[] chuSo = { "", "Mot", "Hai", "Ba", "Bon", "Nam", "Sau", "Bay", "Tam", "Chin" };
        
        if (chuc_136 > 1)
        {
            Console.Write(chuSo[chuc_136] + " Muoi ");
        }
        else
        {
            Console.Write("Muoi ");
        }

        if (donvi_136 != 0)
        {
            Console.Write(chuSo[donvi_136]);
        }

        Console.ReadKey();
    }
}
