using System;
using MindBoxTask.Services;
namespace ShapeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание круга
            double circleRadius = 5;
            Circle circle = new Circle(circleRadius);
            double circleArea = circle.CalculateArea();
            Console.WriteLine($"Площадь круга радиусом {circleRadius} равна {circleArea}");

            // Создание треугольника
            double triangleSide1 = 3;
            double triangleSide2 = 4;
            double triangleSide3 = 5;
            Triangle triangle = new Triangle(triangleSide1, triangleSide2, triangleSide3);
            double triangleArea = triangle.CalculateArea();
            bool isRightAngled = triangle.IsRightAngled();
            Console.WriteLine($"Площадь треугольника со сторонами {triangleSide1}, {triangleSide2} и {triangleSide3} равна {triangleArea}");
            Console.WriteLine($"Треугольник прямоугольный: {isRightAngled}");
        }
    }
}
