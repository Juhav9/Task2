using System;
namespace ShapesLibrary
{
    public class Circle : IShape
    {
        double radius;

        public Circle() { }
        public Circle(double radius)
        {
            this.radius = radius;   
        }

        public double Area()
        {
            return this.radius *  this.radius *  System.Math.PI;
        }

        public double Circumference()
        {
            return 2*System.Math.PI*this.radius;
        }

        public override string ToString()
        {
            double area = this.Area();
            double circum = this.Circumference();
            string s = String.Format("Circle with radius {0:0.00} has area {1:0.00} and circumference {2:0.00}",
                this.radius, area, circum);
            return s;
        }

    }
}
