using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGeomFigure
{
    // абстрактный класс фигуры
    abstract class Figure
    {
        // абстрактный метод для получения периметра
        public abstract double Perimeter();
        // абстрактный метод для получения площади
        public abstract double Area();
    }
    // производный класс треугольника
    class Triangle : Figure
    { 
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        // переопределение получения площади
        public override double Area()
        {//Формула Герона (Heron's formula)
            double s = Perimeter() / 2; // полупериметр (semi-perimeter)
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }
        // переопределение получения периметра
        public override double Perimeter()
        {
            return A + B + C;
        }

        public override string ToString()
        {
            return "Triangle";
        }

        public void Display()
        {
            Console.WriteLine($" Периметр треугольника равен {Perimeter()}/n Площадь треугольник равен {Area()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
