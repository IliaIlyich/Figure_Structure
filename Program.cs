using System;

namespace FIgure_Structure
{
    class Program
    {
        static void Main(string[] args)
        {  
             Console.WriteLine("Введите размерномть массива структур");
             int a=int.Parse(Console.ReadLine());
             object [] Figure = new object [a];

            for (int i=0; i <Figure.Length; i++)
            {
              
              if (i%2==0) 
              {
              Console.WriteLine("Введите координату x, y и 2 стороны прямоугольника");
              Figure [i] = new Rectangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
              }

              else
              {
              Console.WriteLine("Введите координату x, y и радиус круга");
              Figure [i] = new Circle (double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
              }
            }

            foreach (object figure in Figure)
            {
              Console.WriteLine(figure);
            }
        }
    }
}
