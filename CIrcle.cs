using System;
namespace FIgure_Structure
{
    public struct Circle : IFigure
    {
        public double X { get; set; }
        public double Y { get; set; }
        private double r;
        public double Radius
        {
            get { return r; }
            set
            {
                if (value <= 0) throw new ArgumentException("Круг не может быть нулевого или отрицательного размера");
                r = value;
            }
        }

        public Circle(double X=0, double Y=0, double r=1)
        {   
         this.X=X;
         this.Y=Y;
         this.r=r;
        }

       public double Square() 
        {
            return Math.PI * Math.Pow(Radius, 2); 
        }

        public override string ToString()
        {
            return String.Format("Круг имеет координаты [{0}, {1}], радиус {2}, площадь {3}", X, Y, Radius, Square());
        }

       
    }
}
