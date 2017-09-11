using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace TestApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Random random = new Random();
            //random.NextDouble(-10, 11);
            //Console.WriteLine(random.NextDouble(-10, 11));
            //Vector v = new Vector();
            //v.Generate(-10, 10);
            //Console.WriteLine(v.Generate(-10, 10).Generate(-10, 10).X);
            //Console.WriteLine(v);
            //Console.WriteLine(v.Scale(2, 3));

            Console.WriteLine();

            for (int count = 1; count <= 10; count++)
            {
                Console.WriteLine(Vector.Generate(-100, 100));
            }
        }
    }
}