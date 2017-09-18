using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryConsoleApplication
{
    public abstract class Shape
    {
       
        public abstract double GetArea();
    }

    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double GetArea()
        {
            return Height * Width;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double GetArea() { return Math.PI * Radius * Radius; }
    }

    public class Triangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double GetArea()
        {
            return Width * Height / 2;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("There is no args");
                Console.ReadKey();
            }

            if (args.Length == 3)
            {
                if (!string.IsNullOrEmpty(args[0]))
                {
                    Console.WriteLine("Display the area of ");
                    Console.WriteLine(args[0]);
                    Rectangle r = new Rectangle();
                    r.Width = 10.2;
                    r.Height = 20.3;
                    Console.WriteLine(r.GetArea());
                    Console.ReadKey();
                }

                if (!string.IsNullOrEmpty(args[1]))
                {
                    Console.WriteLine("\n Display the area of ");
                    Console.WriteLine(args[1]);
                    Circle c = new Circle();
                    c.Radius = 5.6;
                    Console.WriteLine(c.GetArea());
                    Console.ReadKey();
                }
                if (!string.IsNullOrEmpty(args[2]))
                {
                    Console.WriteLine("\n Display the area of ");
                    Console.WriteLine(args[2]);
                    Triangle t = new Triangle();
                    t.Height = 4.3;
                    t.Width = 5.9;
                    Console.WriteLine(t.GetArea());
                    Console.ReadKey();
                }
               
            }
        }
    }
}
