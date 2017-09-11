using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMathLibrary
{
    public class Vector
    {
        private static Random random;
        public static int TotalVectors;

        #region 欄位與屬性

        public double X { get; set; }
        public double Y { get; set; }
        public double Max { get; set; }
        public double Min { get; set; }

        public double Length
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }

        #endregion 欄位與屬性

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
            TotalVectors++;
        }

        public Vector()
        {
            TotalVectors++;
        }

        public static Vector Generate(double min, double max)
        {
            if (Vector.random == null)
                Vector.random = new Random();

            Random random = new Random();
            double x = random.NextDouble(min, max);
            double y = random.NextDouble(min, max);
            Vector v = new Vector(x, y);
            return v;
        }

        public Vector ScaleX(double factor)

        {
            X *= factor;
            return this;
        }

        public Vector ScaleY(double factor)

        {
            Y *= factor;
            return this;
        }

        public Vector Scale(double factorx, double factory)
        {
            return this.ScaleX(factorx).ScaleY(factory);
        }

        public override string ToString()
        {
            return string.Format("(x,y) ={0},{1}", X, Y);
        }
    }
}