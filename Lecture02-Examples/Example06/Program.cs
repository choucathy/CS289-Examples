using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[4];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;

            string name1 = "a";
            string name2 = "b";
            string phone1 = "0912345678";
            string phone2 = "0987654321";

            string[] names = new string[] { "a", "b" };
            string[] phone = new string[] { "0912345678", "0987654321" };

            Student student = new Student() { name = "a", Phone = "0912345678" };  //物件

            Console.WriteLine(student.name);
        }
    }
}