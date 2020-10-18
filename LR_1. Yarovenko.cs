using System;
using System.Linq.Expressions;

namespace LR_1._Yarovenko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Яровенко Максим, ИУ5Ц-52Б");

            begin: try
            {
                Console.Write("Данная прогрfмма решает уравнения биквадратные уравнения вида Ax^4 + Bx^2 + C = 0." +
                    "\nВведите коэффициенты А, B и C. \nA = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("B = ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("C = ");
                double c = double.Parse(Console.ReadLine());

                double d = b*b - 4*a*c;

                if (d < 0) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корней нет");
                    Console.ResetColor();
                }

                if (d == 0)
                {
                    double x1 = Math.Sqrt(-b / (2 * a));
                    double x2 = - Math.Sqrt(-b / (2 * a));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
                    Console.ResetColor();
                }
                if (d > 0)
                {
                    double x1 = Math.Sqrt((-b + Math.Sqrt(d)) / (2 * a));
                    double x2 = -Math.Sqrt((-b + Math.Sqrt(d)) / (2 * a));
                    double x3 = Math.Sqrt((-b - Math.Sqrt(d)) / (2 * a));
                    double x4 = -Math.Sqrt((-b - Math.Sqrt(d)) / (2 * a));
                    if (double.IsNaN(x3) && !double.IsNaN(x4)) { Console.ForegroundColor = ConsoleColor.Green; 
                        Console.WriteLine("x1 = {0}; x2 = {1}; x3 = {2}; ", x1, x2, x4); Console.ResetColor();}
                    if (double.IsNaN(x4) && !double.IsNaN(x3)) { Console.ForegroundColor = ConsoleColor.Green; 
                        Console.WriteLine("x1 = {0}; x2 = {1}; x3 = {2}; ", x1, x2, x3); Console.ResetColor(); }
                    if (double.IsNaN(x3) && double.IsNaN(x4)) { Console.ForegroundColor = ConsoleColor.Green; 
                        Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2); Console.ResetColor(); }
                    if (!double.IsNaN(x3) && !double.IsNaN(x4)){Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("x1 = {0}; x2 = {1}; x3 = {2}; x4 = {3}", x1, x2, x3, x4); Console.ResetColor();
                    }

                }


            }
            catch (System.FormatException) {
                Console.WriteLine("Некорректный ввод числа. Введите повторно");
                goto begin;

            }



            
            
           
            

        }
    }
}
