using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Orz
{
    public class Person
    {
        public string Name;
        public Position Pos;
        public double Theta;  //使用角度

        public void MoveForward(double d)  //d*Cos(Theta);
        {
            Pos.x += d * Math.Cos(Theta * Math.PI / 180.0);
            Pos.y += d * Math.Sin(Theta * Math.PI / 180.0);
        }

        public void TurnRight(double theta)
        {
            this.Theta += theta;
        }
    }
}