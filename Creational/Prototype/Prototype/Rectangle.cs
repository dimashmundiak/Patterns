using System;

namespace Prototype
{
    public class Rectangle : IFigure
    {
        public int Width { get; }
        public int Height { get; }

        public Rectangle(int w, int h)
        {
            Width = w;
            Height = h;
        }

        public IFigure Clone()
        {
            return new Rectangle(Width, Height);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Прямоугольник длиной {Height} и шириной {Width}");
        }
    }
}
