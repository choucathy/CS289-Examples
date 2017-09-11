using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Status response = Status.ConnectionSuccess;
            Console.WriteLine(response);
            Console.WriteLine((int)response);
            Console.WriteLine((int)Status.ConnectionError);
            Console.WriteLine((int)Status.ReadSuccess);
            Console.WriteLine((int)Status.ReadError);

            Console.ReadLine();
            Console.WriteLine((Status)1);    //會顯示 ConnectionSuccess
        }
    }
}