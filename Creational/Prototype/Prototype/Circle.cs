using System;

namespace Prototype
{
    public class Circle : IFigure
    {
        public int Radius { get; }

        public Circle(int r)
        {
            Radius = r;
        }

        public IFigure Clone()
        {
            return new Circle(Radius);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Круг радиусом {Radius}");
        }
    }
}
