using System;

class Program
{
    static void Main()
    {
        double d;
        Console.Write("Введіть діаметр d: ");
        string input = Console.ReadLine();
        if (!double.TryParse(input, out d))
        {
            Console.WriteLine("Помилка: потрібно ввести число");
            return;
        }
        if (d <= 0)
        {
            Console.WriteLine("Діаметр повинен бути додатним");
            return;
        }
        double r = d / 2;
        double s = Math.PI * r * r;
        Console.WriteLine("Площа круга = " + s);
        Console.ReadKey();
    }
}
