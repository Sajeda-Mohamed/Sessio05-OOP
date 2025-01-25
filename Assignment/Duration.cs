using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Duration
    {
        #region Auto Prop
        public double Hours { get; set; }
        public double Minutes { get; set; }
        public double Seconds { get; set; }
        #endregion

        #region Constractor
        public Duration(double H, double M, double S)
        {
            Hours = H;
            Minutes = M;
            Seconds = S;
        } 

        public Duration(double S)
        {
            Hours = S / 3600;
            S %= 3600;
            Minutes = S / 60;
            Seconds = S % 60;
        }


        #endregion

        #region Methods
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }
        #region OPerator OverLoading
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
        }
        public static Duration operator +(Duration d1, double seconds)
        {
            return new Duration(d1.Hours, d1.Minutes, d1.Seconds + seconds);
        }
        public static Duration operator ++(Duration d)
        {
            return new Duration(d.Hours, d.Minutes + 1, d.Seconds);
        }
        public static Duration operator --(Duration d)
        {
            return new Duration(d.Hours, d.Minutes - 1, d.Seconds);
        }
        public static Duration operator -(Duration d1, Duration d2)
        {
            double totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            double totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
             return new Duration(Math.Max(0,totalSeconds1 - totalSeconds2));
        }
        public static bool operator >(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) > (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        } 
        public static bool operator <(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) < (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return (d1 <= d2);
        } 
        public static bool operator >=(Duration d1, Duration d2)
        {
            return (d1 >= d2);
        }
        public static bool operator true(Duration d)
        {
            return (d.Hours != 0 || d.Minutes != 0 || d.Seconds != 0);
        }public static bool operator false(Duration d)
        {
            return (d.Hours == 0 && d.Minutes == 0 && d.Seconds == 0);
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(2025, 25, 01, (int)d.Hours, (int)d.Minutes,(int)d.Seconds);
        }
        #endregion
        #endregion
    }
}
