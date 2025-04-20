using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите радиус круга (R > 0): ");
        double R = double.Parse(Console.ReadLine());

        if (R <= 0)
        {
            Console.WriteLine("Радиус должен быть больше нуля.");
            return;
        }

        int count = 0;
        int radiusInt = (int)Math.Floor(R);

        for (int x = -radiusInt; x <= radiusInt; x++)
        {
            for (int y = -radiusInt; y <= radiusInt; y++)
            {
                if (x * x + y * y <= R * R)
                {
                    count++;
                }
            }
        }

        Console.WriteLine($"Количество точек с целочисленными координатами: {count}");
    }
}