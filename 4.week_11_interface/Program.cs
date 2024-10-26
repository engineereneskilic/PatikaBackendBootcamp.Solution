using System;

namespace _4.week_11_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(7);
            circle.Draw();
            circle.Area();

            Rectangle rectangle = new Rectangle(100,200);
            rectangle.Draw();
            rectangle.Area();


            MsSQLDatabase db = new MsSQLDatabase();
            db.Connect();
            db.ExecuteQuery("select * from user");
            db.Store ("user",new { Name = "Murat" });
            db.Retrieve("user");
            db.Disconnect();
        }

        public class Circle : Shape
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public override void Draw()
            {
                Console.WriteLine("Circle Drawing");
            }

            public override double Area()
            {
                return Math.PI * Radius * Radius;

            }
        }
        public class Rectangle : Shape
        {
            public int Height { get; set; }
            public int Width { get; set; }

            public Rectangle(int height,int width)
            {
                Height = height;
                Width = width;
            }
            public override void Draw()
            {
                Console.WriteLine("Rectangle Drawing");
            }
            public override double Area()
            {
                return Height * Width;
            }
        }
    }
}
