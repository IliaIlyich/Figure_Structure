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

           Rectangle R1 = new Rectangle(1, 2, 3, 4);
           Rectangle R2 = new Rectangle(1, 2, 3, 5);

           Console.WriteLine(C1 + "\n" + C2);
           Console.WriteLine("Работа переопределенного оператора == ");
           Console.WriteLine(C1==C2);
           Console.WriteLine("Работа переопределенного метода object.Equals(object obj) ");
           Console.WriteLine(C1.Equals(C2));
           Console.WriteLine("Работа переопределенного метода object.GetHashCode(). Считает по площади");
           Console.WriteLine(C1.GetHashCode());

           Console.WriteLine(R1 + "\n" + R2);
           Console.WriteLine("Работа переопределенного оператора == ");
           Console.WriteLine(R1==R2);
           Console.WriteLine("Работа переопределенного оператора != ");
           Console.WriteLine(R1!=R2);

           Console.ReadLine();  
            
        }
    }
}

