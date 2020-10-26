using System;
using System.Dynamic;

namespace LR_2._Yarovenko
{

    abstract class Geometrical_figure
    {

        string _Figure;
        public string Figure { get; protected set; }

        public abstract double Area();


    }

    interface IPrint
    {
        void Print();
    }

    class Rectangle : Geometrical_figure, IPrint
    {
        double _Height;
        public double Height { get; protected set; }

        double _Width;
        public double Width { get; protected set; }

        public Rectangle(double h, double w)
        {
            Height = h;
            Width = w;
            Figure = "Прямоугольник";
        }

        public override double Area()
        {
            double result = Height * Width;
            return result;
        }

        public override string ToString()
        {
            return Figure + "(высота: " + Height + ", ширина: " + Width + ") площадью " + Area().ToString();
        }

        public void Print() { Console.WriteLine(ToString()); }
    }
    class Square : Rectangle, IPrint
    {
        public Square(double a) : base(a, a) { Figure = "Квадрат"; }

        public override string ToString()
        {
            return Figure + "(сторона: " + Height + ") площадью " + Area().ToString();
        }

    }

    class Circle : Geometrical_figure, IPrint
    {
        double _Radius;
        public double Radius { get; protected set; }

        public Circle(double r) { Radius = r; Figure = "Круг"; }

        public override double Area()
        {
            double result = Math.PI * Radius * Radius;
            return result;
        }

        public override string ToString()
        {
            return Figure + "(радиус: " + Radius + ") площадью " + Area().ToString();
        }

        public void Print() { Console.WriteLine(ToString()); }

    }

    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Яровенко Максим, ИУ5Ц-52Б");

            Console.WriteLine("Демонстрация лаборатоной работы, реализующей работу с классами\n");

            Rectangle rect = new Rectangle(5, 8);
            Square sq = new Square(5);
            Circle circ = new Circle(4);

            rect.Print();
            sq.Print();
            circ.Print();

            Console.ReadLine();

        }
    }
}
