using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Operator_OverLoading
{
    internal class Complex
    {
        #region Auto Prop
        public int Reel { get; set; }
        public int Imagine { get; set; }
        #endregion

        #region Methods
        //public override string ToString()
        //{
        //    return $"{Reel} + {Imagine}i";
        //}

        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex
            {
                Reel = (Left?.Reel ?? 0) + (Right?.Reel ?? 0),
                Imagine = (Left?.Imagine ?? 0) + (Right?.Imagine ?? 0)
            };
        }
        public static Complex operator -(Complex Left, Complex Right)
        {
            return new Complex
            {
                Reel = (Left?.Reel ?? 0) - (Right?.Reel ?? 0),
                Imagine = (Left?.Imagine ?? 0) - (Right?.Imagine ?? 0)
            };
        }
        public static bool operator >(Complex Left, Complex Right)
        {
            if (Left?.Reel == Right?.Reel)
                return (Left?.Imagine > Right?.Imagine);
            else
                return (Left?.Reel > Right?.Reel);
        }
        public static bool operator <(Complex Left, Complex Right)
        {
            if (Left?.Reel == Right?.Reel)
                return (Left?.Imagine < Right?.Imagine);
            else
                return (Left?.Reel < Right?.Reel);
        }
        public static Complex operator ++(Complex C)
        {
            return new Complex
            {
                Reel = (C?.Reel ?? 0) + 1,
                Imagine = (C?.Imagine ?? 0) 
            };
        }

        public static explicit operator int (Complex C)
        {
            return C?.Reel ?? 0;
        }

        //public static implicit operator int (Complex C) => NotRecomended
        //{
        //    return C?.Reel ?? 0;
        //}

        #endregion
    }
}
