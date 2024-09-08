using System;
using CalculatingArea;

class Program
{
    static void Main(string[] args)
    {
        // Ввод радиуса круга с клавиатуры
        Console.Write("Введите радиус круга: ");
        double radius = GetValidDoubleInput();
        IShape circle = new Circle(radius);
        Console.WriteLine($"Площадь круга: {ShapeAreaCalculator.CalculateShapeArea(circle)}");

        // Ввод сторон треугольника с клавиатуры
        Console.Write("Введите первую сторону треугольника: ");
        double sideA = GetValidDoubleInput();

        Console.Write("Введите вторую сторону треугольника: ");
        double sideB = GetValidDoubleInput();

        Console.Write("Введите третью сторону треугольника: ");
        double sideC = GetValidDoubleInput();

        try
        {
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Console.WriteLine($"Площадь треугольника: {ShapeAreaCalculator.CalculateShapeArea(triangle)}");
            Console.WriteLine($"Треугольник прямоугольный: {triangle.IsRightAngled()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    // Метод для получения корректного ввода числа с клавиатуры
    private static double GetValidDoubleInput()
    {
        double value;
        while (!double.TryParse(Console.ReadLine(), out value) || value <= 0)
        {
            Console.WriteLine("Пожалуйста, введите положительное число.");
        }
        return value;
    }
}
