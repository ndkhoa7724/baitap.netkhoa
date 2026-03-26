using System;

class Bai5
{
    static void Main()
    {
        int n;
        Console.Write("Nhap n: ");
        n = int.Parse(Console.ReadLine());

        int a = 0, b = 1;

        Console.Write(a + " " + b + " ");

        for (int i = 3; i <= n; i++)
        {
            int c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }

        Console.ReadLine();
    }
}