using System;
using System.Reflection;
namespace FIgure_Structure
{
    class Program
    {
        static void Main(string[] args)
        {  
           Circle C1 = new Circle (1, 2, 3);
           Circle C2 = new Circle (1, 2, 3);
           IFigure C3 = new Circle (1, 2, 3);//что делать, если нужно сравнивать два объекта типа интерфейс?
           IFigure C4 = new Circle (1, 2, 4);

           Console.WriteLine(C1==C2);
           Console.WriteLine(C1!=C2);
           Console.WriteLine(C3==C4);
           Console.WriteLine(C3!=C4);
           Console.ReadLine();  
            
        }
    }
}

