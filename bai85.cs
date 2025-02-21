using System;

class Program
{
    static void Main()
    {
        int thang_136;
        Console.Write("\nNhap thang: ");
        thang_136 = int.Parse(Console.ReadLine());

        switch (thang_136)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine("\nQui mot");
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine("\nQui hai");
                break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine("\nQui ba");
                break;
            case 10:
            case 11:
            case 12:
                Console.WriteLine("\nQui bon");
                break;
            default:
                Console.WriteLine("\nThang khong hop le");
                break;
        }

        Console.ReadKey();
    }
}
