using System;
using System.Reflection;
namespace FIgure_Structure
{
    class Program
    {
        static void Main(string[] args)
        {  
             
             /*Console.WriteLine("Первый круг");
             IFigure Circle1 = new Circle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
             Console.WriteLine(Circle1);
             Console.WriteLine("Второй круг");
             IFigure Circle2 = new Circle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
             Console.WriteLine(Circle2);
             Console.WriteLine(Circle1.Equals(Circle2));
             Console.WriteLine(Circle1.GetHashCode()); 

             Console.WriteLine("Введите размерномть массива структур");
             int a=int.Parse(Console.ReadLine());
             IFigure [] Figure = new IFigure [a];

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

            foreach (IFigure figure in Figure)
            {
              Console.WriteLine(figure);
            }
*/
            IFigure C1 = new Circle(1, 2, 3);
            IFigure R1= new Rectangle(1, 2, 3, 4);
            ShowProperties(C1);
            ShowProperties(R1);
            Console.ReadLine();
        }
static void ShowProperties(IFigure figure)
{
  Type type = figure.GetType();
  if (type.Name == "Circle") Console.WriteLine("Круг");
  else if ((type.Name == "Rectangle")) Console.WriteLine("Прямоугольник");

  foreach (PropertyInfo p in type.GetProperties())
{
  Console.WriteLine($"Свойство {p.Name} имеет значение { p.GetValue(figure)}");
}
Console.WriteLine();

}




    }
}

