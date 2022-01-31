using System;

namespace FIgure_Structure
{
    public struct Rectangle: IFigure
    {
      public double X { get; set;}
      public double Y { get; set;}
     
      private double s1;
      private double s2;

      public double Side1
      {
       get { return s1;}
       set {
             if (value<=0) throw new ArgumentException("Сторона не может быть меньеш или равна 0");
              s1 = value;
           }
           }
           public double Side2
      {
       get { return s2;}
       set {
             if (value<=0) throw new ArgumentException("Сторона не может быть меньеш или равна 0");
              s2 = value;
           }
      }

      public Rectangle (double X, double Y, double s1, double s2)
      {
       this.X=X;
       this.Y=Y;
       if (s1<=0) throw new ArgumentException("Сторона не может быть 0 или иметь отрицательное значение");
       this.s1=s1;
       if (s2<=0) throw new ArgumentException("Сторона не может быть 0 или иметь отрицательное значение");
       this.s2=s2;
      }
      
      public override string ToString()
      {
          return String.Format("Прямоугольник имеет координаты [{0}, {1}], стороны {2} и {3}, площадь: {4}", X, Y, s1, s2, Square());
      }
      public double Square()
      {
          return s1*s2;
      }
    }
}
