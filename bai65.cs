using System;

class Program
{
    const int VoNghiem_136 = 0, VoSoNghiem_136 = -1;

    static int PhuongTrinhBac1_136(double a_136, double b_136, out double x_136)
    {
        int soNghiem_136;
        if (a_136 != 0)
        {
            x_136 = -b_136 / a_136;
            soNghiem_136 = 1;
        }
        else
        {
            x_136 = 0;
            soNghiem_136 = (b_136 == 0) ? VoSoNghiem_136 : VoNghiem_136;
        }
        return soNghiem_136;
    }

    static int PhuongTrinhBac2_136(double a_136, double b_136, double c_136, out double x1_136, out double x2_136)
    {
        x1_136 = x2_136 = 0;
        if (a_136 == 0)
            return PhuongTrinhBac1_136(b_136, c_136, out x1_136);

        double delta_136 = b_136 * b_136 - 4 * a_136 * c_136;
        double haiA_136 = 2 * a_136;
        if (delta_136 < 0)
            return VoNghiem_136;
        else if (delta_136 == 0)
        {
            x1_136 = x2_136 = -b_136 / haiA_136;
            return 1;
        }
        else
        {
            double canDelta_136 = Math.Sqrt(delta_136);
            x1_136 = (-b_136 - canDelta_136) / haiA_136;
            x2_136 = (-b_136 + canDelta_136) / haiA_136;
            return 2;
        }
    }

    static int PhuongTrinhTrungPhuong_136(double a_136, double b_136, double c_136, out double x1_136, out double x2_136, out double x3_136, out double x4_136)
    {
        x1_136 = x2_136 = x3_136 = x4_136 = 0;
        int soNghiem1_136, soNghiem2_136;
        double y1_136, y2_136;
        soNghiem1_136 = PhuongTrinhBac2_136(a_136, b_136, c_136, out y1_136, out y2_136);

        switch (soNghiem1_136)
        {
            case VoNghiem_136:
            case VoSoNghiem_136:
                return soNghiem1_136;
            case 1:
                return PhuongTrinhBac2_136(1, 0, -y1_136, out x1_136, out x2_136);
            case 2:
                soNghiem2_136 = PhuongTrinhBac2_136(1, 0, -y1_136, out x1_136, out x2_136);
                switch (soNghiem2_136)
                {
                    case VoNghiem_136:
                        return PhuongTrinhBac2_136(1, 0, -y2_136, out x1_136, out x2_136);
                    case 1:
                        return 1 + PhuongTrinhBac2_136(1, 0, -y2_136, out x2_136, out x3_136);
                    case 2:
                        return 2 + PhuongTrinhBac2_136(1, 0, -y2_136, out x3_136, out x4_136);
                }
                break;
        }
        return 0;
    }

    static void Main()
    {
        double a_136, b_136, c_136, x1_136, x2_136;
        Console.Write("Nhập a = ");
        a_136 = double.Parse(Console.ReadLine());
        Console.Write("Nhập b = ");
        b_136 = double.Parse(Console.ReadLine());
        Console.Write("Nhập c = ");
        c_136 = double.Parse(Console.ReadLine());

        double delta_136 = b_136 * b_136 - 4 * a_136 * c_136;
        int soNghiem_136 = PhuongTrinhBac2_136(a_136, b_136, c_136, out x1_136, out x2_136);

        Console.WriteLine($"Số nghiệm của phương trình là: {soNghiem_136}");
        if (a_136 == 0)
        {
            if (b_136 != 0)
                Console.WriteLine($"Nghiệm của phương trình {b_136}x + {c_136} = 0 là: {x1_136}");
            else
                Console.WriteLine($"Phương trình {b_136}x + {c_136} = 0 {(c_136 == 0 ? "có vô số nghiệm" : "vô nghiệm")}");
        }
        else
        {
            if (delta_136 < 0)
                Console.WriteLine($"Phương trình {a_136}x^2 + {b_136}x + {c_136} = 0 vô nghiệm");
            else if (delta_136 == 0)
                Console.WriteLine($"Phương trình {a_136}x^2 + {b_136}x + {c_136} = 0 có nghiệm kép: x1 = x2 = {x1_136}");
            else
                Console.WriteLine($"Phương trình {a_136}x^2 + {b_136}x + {c_136} = 0 có 2 nghiệm phân biệt: {x1_136} và {x2_136}");
        }

        Console.ReadKey();
    }
}
