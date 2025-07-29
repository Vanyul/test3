using System;

class BaseConverter
{
    private double celsius;

    public BaseConverter(double celsius)
    {
        this.celsius = celsius;
    }

    public double Convert(string toUnit)
    {
        return toUnit.ToLower() switch
        {
            "k" => celsius + 273.15,             
            "f" => celsius * 9 / 5 + 32,     
            _ => throw new ArgumentException("Неизвестная единица")
        };
    }
}

class Task3
{
    public static void Main()
    {
        Console.Write("Введите температуру в Цельсиях: ");
        double temp = double.Parse(Console.ReadLine());

        Console.Write("Введите 'k' для Кельвинов или 'f' для Фаренгейтов: ");
        string unit = Console.ReadLine();

        BaseConverter converter = new BaseConverter(temp);
        double result = converter.Convert(unit);
        Console.WriteLine($"Результат: {result:F2}");
    }
}
