using System;

namespace FIgure_Structure
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Введите значение двух прямоугольников");
            Circle c1 = new Circle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine(c1);
            Circle c2 = new Circle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine(c2);
            
        }
    }
}
