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

      public Rectangle (double X=0, double Y=0, double s1=1, double s2=1)
      {
       this.X=X;
       this.Y=Y;
       this.s1=s1;
       this.s2=s2;
      }
      
      public override string ToString()
      {
          return String.Format("Прямоугольник со сторонами [0] и [1], площадью: [2]", s1, s2, Square());
      }
      public double Square()
      {
          return s1*s2;
      }
    }
}
