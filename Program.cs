using System;

class PTBac1
{
    protected double a;
    protected double b;

    public PTBac1(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public virtual void Giai()
    {
        if (a == 0)
        {
            if (b == 0)
                Console.WriteLine("Phương trình vô số nghiệm.");
            else
                Console.WriteLine("Phương trình vô nghiệm.");
        }
        else
        {
            double x = -b / a;
            Console.WriteLine("Nghiệm của phương trình là x = " + x);
        }
    }
}

class PTBac2 : PTBac1
{
    private double c;

    public PTBac2(double a, double b, double c) : base(a, b)
    {
        this.c = c;
    }

    public override void Giai()
    {
        if (a == 0)
        {
            Console.WriteLine("Vì a = 0 nên phương trình trở thành bậc 1:");
            base.Giai();
            return;
        }

        double delta = b * b - 4 * a * c;

        if (delta < 0)
        {
            Console.WriteLine("Phương trình vô nghiệm.");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Phương trình có nghiệm kép x = " + x);
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Phương trình có 2 nghiệm:");
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string tieptuc;

        do
        {
            Console.Write("Nhập a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhập c: ");
            double c = double.Parse(Console.ReadLine());

            PTBac2 pt = new PTBac2(a, b, c);
            pt.Giai();

            Console.Write("\nBạn có muốn tiếp tục không? (y/n): ");
            tieptuc = Console.ReadLine().ToLower();

            Console.WriteLine(); // xuống dòng cho đẹp
        }
        while (tieptuc == "y");

        Console.WriteLine("Chương trình kết thúc. Nhấn Enter để thoát.");
        Console.ReadLine();
    }
}
