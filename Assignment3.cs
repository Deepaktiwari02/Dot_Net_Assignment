using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Point3D : IFormattable
    {

        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }

        public Point3D(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"Point3D(x: {x}, y: {y}, z: {z})";
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format)) format = "G";
            switch (format)
            {
                case "G":
                case "C":
                    return $"({x}, {y}, {z})";
                case "X":
                    return x.ToString();
                case "Y":
                    return y.ToString();
                case "Z":
                    return z.ToString();
                default:
                    throw new FormatException($"The {format} format string is not supported.");
            }
        }

        public string ToString(string format)
        {
            return ToString(format, null);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point3D point = new Point3D(3.5f, 7.2f, 1.4f);

            Console.WriteLine(point.ToString("X")); 
            Console.WriteLine(point.ToString("Y")); 
            Console.WriteLine(point.ToString("Z")); 
            Console.WriteLine(point.ToString("C")); 
            Console.WriteLine(point.ToString("G")); 

            Console.WriteLine($"X: {point.ToString("X")}");
            Console.WriteLine($"Y: {point.ToString("Y")}");
            Console.WriteLine($"Z: {point.ToString("Z")}");
            Console.WriteLine($"Combined (C): {point.ToString("C")}");
            Console.WriteLine($"General (G): {point.ToString("G")}");

            Console.ReadKey();
        }
    }

}
