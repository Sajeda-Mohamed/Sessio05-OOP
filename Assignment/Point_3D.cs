using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Point_3D : ICloneable,IComparable
    {
        #region Auto Prop
        public double X { get; set; }
        public double Y { get; set; }
        public double Z{ get; set; }
        #endregion

        #region Constractors
        public Point_3D(double x, double y, double z)
        {
            X = x;
            Y = y; 
            Z = z;
        }
        public Point_3D()
        {
            
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Point Coordinates:({X},{Y},{Z})";
        }

        public int CompareTo(object? obj)
        {
            Point_3D passedPoint = obj as Point_3D;
            if (this.X > passedPoint.X && this.Y > passedPoint.Y)
                return 1;
            else if (this.X < passedPoint.X && this.Y < passedPoint.Y)
                return -1;
            else
                return 0;
        }

        public object Clone()
        {
            return new Point_3D()
            {
                X = this.X,
                Y = this.Y,
                Z = this.Z,
            };
        }

        public static bool operator ==(Point_3D left, Point_3D right)
        {
            if (left.X == right.X && left.Y == right.Y && left.Z == right.Z)
                return true;
            else
                return false;
        } 
        public static bool operator !=(Point_3D left, Point_3D right)
        {
            if (left.X != right.X || left.Y != right.Y || left.Z != right.Z)
                return true;
            else
                return false;
        }
        #endregion
    }
}
