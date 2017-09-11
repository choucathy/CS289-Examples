using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Data.SqlClient;//不確定要不要using這個空間
using System.Data;
using System.Data.SQLite;

namespace SQLiteApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (!File.Exists(@"C:\users\鄒舒帆\Desktop\test.db"))
            {
                SQLiteConnection.CreateFile(@"C:\users\鄒舒帆\Desktop\test.db");
            }

            SQLiteConnection conn = new SQLiteConnection(@"Data source = C:\users\鄒舒帆\Desktop\test.db");

            conn.Open();

            Console.WriteLine("連線成功");
        }
    }
}