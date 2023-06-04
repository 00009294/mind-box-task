using System;
namespace MindBoxTask.Services
{
	public class Circle:IShape
	{
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}

