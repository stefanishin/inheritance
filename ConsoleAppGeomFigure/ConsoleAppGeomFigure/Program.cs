using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGeomFigure
{/*
  * Задание 1.Разработать абстрактный класс «Геометрическая Фигура» с методами «Площадь Фигуры» и «Периметр Фигуры». 
  * Разработать классы-наследники: Треугольник, Квадрат, Прямоугольник, Круг. 
  * Реализовать конструкторы, которые однозначно определяют объекты данных классов.
  */
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
        protected double A { get; set; }
        protected double B { get; set; }
        protected double C { get; set; }
        //Параметризированный конструктор. 
        public Triangle(double a, double b, double c) : this(0)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        
        public Triangle(double a)
        {
            A = a;
        }
        // переопределение получения периметра
        public override double Perimeter()
        {
            return A + B + C;
        }
        // переопределение получения площади
        public override double Area()
        {//Формула Герона (Heron's formula)
            double s = Perimeter() / 2; // полупериметр (semi-perimeter)
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }
        //вывод на экран
        public void Display()
        {         
            Console.WriteLine($"\nСтороны треугольника равны A={A}, B={B}, C= {C}\n Периметр треугольника равен {Perimeter()}\n Площадь треугольникa равен {Area()}");
        }
    }
  
    class Square : Triangle
    {
    //    public Square() : this(0) { }
        public Square(double a) : base(a)
        {
            A = a;
        }

        public override double Perimeter()
        {
            return 4 * A;
        }
        public override double Area()
        {
            return A * A;
        }
        //вывод на экран
        public new void Display()
        {
            Console.WriteLine($" \nСторона квадрата равна А = {A}\n Периметр квадрата равен {Perimeter()}\n Площадь квадрата равен {Area()}");
        }        
    }
    class Rectangle : Square
    {
        public Rectangle(double a, double b) : base(a)
        {
            A = a;
            B = b;
        }

        public Rectangle(double a) : this(0, 0)
        {
            A = a;
        }

        public override double Perimeter()
        {
            return (2 * A) + (2 * B);
        }

        public override double Area()
        {
            return A * B;
        }

        //вывод на экран
        public new void Display()
        {
            Console.WriteLine($"\nСтороны прямоугольника равна А = {A} B = {B}\n Периметр прямоугольника равен {Perimeter()}\n Площадь прямоугольника равен {Area()}");
        }
    }
    class Cricle : Rectangle
    {
        protected double R { get; set; }
        public Cricle(double r) : base(r)
        {
            this.R = r;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * R;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(R, 2);
        }
        //вывод на экран
        public new void Display()
        {
            Console.WriteLine($"\nСторона круга равна R = {R}\n Периметр круга равнa {Perimeter()}\n Площадь круга равна {Area()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(5, 6, 7);            
            triangle.Display();

            Rectangle rectangle = new Rectangle(3, 5);
            rectangle.Display();

            Square square = new Square(5);
            square.Display();

            Cricle cricle = new Cricle(28);
            cricle.Display();

            Console.ReadKey();
        }
    }
}
