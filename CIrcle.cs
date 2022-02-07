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

        public Circle(double X, double Y, double r)
        {   
         this.X=X;
         this.Y=Y;
         if (r<=0) throw new ArgumentException("Круг не может иметь нулевой или отрицательный радиус");
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
        public static bool operator == (Circle C1, Circle C2)
        {
         return C1.Equals(C2);
        }
        public static bool operator != (Circle C1, Circle C2)
        {
           return !C1.Equals(C2);
        }
        
        public override bool Equals(object obj)
        {
           if (obj == null || this.GetType() != obj.GetType() ) 
            {
                return false;
            } 
            Circle circle = (Circle)obj;
            return this.X==circle.X && this.Y==circle.Y && this.r == circle.r;
        }
        
        public override int GetHashCode()
        {
            return this.X.GetHashCode()^this.Y.GetHashCode()^this.r.GetHashCode();
        }
        
    }
}
