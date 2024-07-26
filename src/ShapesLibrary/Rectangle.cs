using System;
namespace ShapesLibrary
{
    public class Rectangle : IShape
    {
        public double widht;
        public double height;

        public Rectangle() { }

        public Rectangle(double widht, double height) {
            this.widht = widht;
            this.height = height;   
        }
        
        public double Area()
        {
            return this.widht *  this.height;
        }

        public double Circumference()
        {
            return (this.height*2) + (this.widht*2);
        }
        public override string ToString()
        {
            double area = this.Area();
            double circum = this.Circumference();
            string s = String.Format("Rectangle with width {0:0.00} and height {1:0.00} has area {2:0.00} and circumference {3:0.00}",
                this.widht, this.height, area, circum);
            return s;
        }
    }
}
