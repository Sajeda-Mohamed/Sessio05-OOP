using Demo.Abstract;
using Demo.Operator_OverLoading;
using System.Drawing;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstract
            //Rectanglee rectangle = new Rectanglee();

            //double rectArea = rectangle.CalcArea();

            //double rectParimeter = rectangle.Parimeter;

            //Square square = new Square(10);

            //double sqParimeter = square.Parimeter;

            //double sqArea = square.CalcArea();

            //Circle circle = new Circle(10);

            //double circleParimeter = circle.Parimeter;

            //double circleArea = circle.CalcArea();
            #endregion

            #region Operator OverLoading
            //int x = 5;
            //int y = 6;
            //int sum = x + y;

            Complex C1 = new Complex() { Reel = 3 , Imagine = 2};
            Complex C2 = new Complex() { Reel = 1 , Imagine = 4};

            Complex C3 = default; //
            Console.WriteLine(C1);
            Console.WriteLine(C2);

            //C3 = C1 + C2;// Invalid
            //Console.WriteLine(C3);

            //C3 = C1 - C2;
            //Console.WriteLine(C3);

            //if(C1 > C2)
            //    Console.WriteLine("C1 greater than C2");
            //else
            //    Console.WriteLine("C2 greater than C1");

            int X = (int)C1;
            //int X = C1; // notRecomended
            #endregion
        }
    }
}
