using System;
using System.Collections.Immutable;
using System.ComponentModel;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project
            //Point_3D P = new Point_3D(10, 10, 10);
            //Console.WriteLine(P.ToString());
            #region point_1
            //Console.WriteLine("Enter x1 : ");
            //bool flag1 = double.TryParse(Console.ReadLine(), out double x1);
            //Console.WriteLine("Enter y1 : ");
            //bool flag2 = double.TryParse(Console.ReadLine(), out double y1);
            //Console.WriteLine("Enter z1 : ");
            //bool flag3 = double.TryParse(Console.ReadLine(), out double z1);
            #endregion

            #region Point_2
            //Console.WriteLine("Enter x2 : ");
            //bool flag4 = double.TryParse(Console.ReadLine(), out double x2);
            //Console.WriteLine("Enter y2 : ");
            //bool flag5 = double.TryParse(Console.ReadLine(), out double y2);
            //Console.WriteLine("Enter z2 : ");
            //bool flag6 = double.TryParse(Console.ReadLine(), out double z2);
            #endregion

            //Point_3D P1 = new Point_3D(x1, y1, z1);
            //Point_3D P2 = new Point_3D(x2, y2, z2);

            //if(P1 == P2)
            //    Console.WriteLine("P1 equal P2");
            //else
            //    Console.WriteLine("P1 not equal P2");

            //P2 =(Point_3D) P1.Clone();
            //Console.WriteLine(P2);

            #region Array of Points
            Point_3D[] Points =
            {
                new Point_3D() {X = 1, Y = 2, Z = 3},
                new Point_3D() {X = 4, Y = 5, Z = 6},
                new Point_3D() {X = 7, Y = 8, Z = 9}
            };

            Array.Sort(Points);
            //foreach (var item in Points)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion

            #region Second Project
            //Console.WriteLine(Maths.Add(4,4));
            //Console.WriteLine(Maths.Subtract(4,4));
            //Console.WriteLine(Maths.Multiply(4,4));
            //Console.WriteLine(Maths.Divide(4,4));
            #endregion

            #region Third Project
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString());

            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());

            D3 = D1 + D2;
            D3 = D1 + 7800;
            D3 = D3 + 666;
            D3 = ++D1;
            D3 = --D2;
            D1 = D1 - D2;
            if (D1 > D2)
                Console.WriteLine("D1 Greater than D2");
            else
                Console.WriteLine("D1 less than D2");

            if (D1 <= D2)
                Console.WriteLine("D1 <= D2");
            else
                Console.WriteLine("D1 >= D2");
            if (D1)
                Console.WriteLine(D1);
            else
                Console.WriteLine("Null");
               
            DateTime Obj = (DateTime)D1;
            Console.WriteLine(Obj);
            #endregion
        }
    }
}
