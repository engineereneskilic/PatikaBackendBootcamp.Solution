using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_11_interface
{
    public interface IShape
    {
        void Draw();

        double Area();

    }

    /*
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }


        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public void Draw()
        {
            Console.WriteLine("Circle Drawing...");
        }

        
    }

    public class Rectangle : IShape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double height,double width)
        {
            Height = height;
            Width = width;
        }


        public double Area()
        {
            return Width * Height;
        }

        public void Draw()
        {
            Console.WriteLine("Rectangle Drawing...");
        }


    }
    */
}
