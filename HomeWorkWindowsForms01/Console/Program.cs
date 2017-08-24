using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHomeWork01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入Pokemon編號：");
            string Id = Console.ReadLine();
            Console.Write("請輸入Pokemon名稱：");
            string name = Console.ReadLine();
            Console.Write("請輸入Pokemon身高：");
            string Height = Console.ReadLine();
            Console.Write("請輸入Pokemon體重：");
            string Weight = Console.ReadLine();
            Console.WriteLine("您的神奇寶貝編號：{0}，名字是：{1}、身高：{2} cm、體重：{3} kg", Id, name, Height, Weight);
        }
    }
}