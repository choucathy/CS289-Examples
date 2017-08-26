using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example04
{
    internal class Program
    {
        private static void Main(string[] args) //  \倒斜線是跳脫字元,要忽略的話在前面加上@
        {
            string path = @"C:\CSE289-Examples\Lecture02-Examples\Example04";
            string sql = @"
            select * from table
            where id=1
            order by id";
            Console.WriteLine(sql);
        }
    }
}