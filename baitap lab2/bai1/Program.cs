using System;

class Bai1
{
    static void Main()
    {
        int n;
        Console.Write("Nhap n: ");
        n = int.Parse(Console.ReadLine());

        int s = 0;
        for (int i = 2; i <= n; i += 2)
        {
            s += i;
        }

        Console.WriteLine("Tong S = " + s);
        Console.ReadLine();
    }
}