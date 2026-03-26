using System;

class Bai2
{
    static void Main()
    {
        int n;
        Console.Write("Nhap n: ");
        n = int.Parse(Console.ReadLine());

        double s = 0;
        for (int i = 1; i <= n; i++)
        {
            s += 1.0 / i;
        }

        Console.WriteLine("Tong S = " + s);
        Console.ReadLine();
    }
}