using System;
class A
{
    static void Main()
    {
        Console.WriteLine("Введите количество денег: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите цену одной шоколадки: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество оберток для обмена на новую шоколадку: ");
        int c = Convert.ToInt32(Console.ReadLine());
        int d = m(a, b, c);
        Console.WriteLine($"Максимально возможное количество шоколадок: {d}");
    }
    static int m(int a, int b, int c)
    {
        int e = a / b; int f = e;
        while (f >= c)
        {
            int g = f / c; e += g; f = g + (f % c);
        }
        return e;
    }
}