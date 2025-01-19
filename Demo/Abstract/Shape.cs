using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstract
{
    internal abstract class Shape
    {
        public double Hight { get; set; }
        public double Width { get; set; }
        public abstract double Parimeter { get; }
        public abstract double CalcArea();
    }
    internal class Rectanglee : RectBase 
    {
        public override double Parimeter { get { return (Hight + Width) * 2; } }
    }
    internal class Square : RectBase
    {
        public Square(double Dim)
        {
            Hight = Width = Dim;
        }
        public override double Parimeter { get { return Width * 4; } }
    }
    abstract class RectBase : Shape
    {
        public override double CalcArea()
        {
            return Hight * Width;
        }
    }
    class Circle : Shape
    {
        public Circle(double radius)
        {
            radius = Width = Hight;
        }
        public override double Parimeter { get { return 2 * 3.14 * Width; } }
        public override double CalcArea()
        {
            return 3.14 * Math.Pow(Width,2);
        }
    }
}
