using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code.Orz;

namespace Example02
{
    public partial class MainWindow : Form
    {
        private Person elsa;   //宣告一個變數叫做Elsa
        private double distance = 0;

        public MainWindow()
        {
            InitializeComponent();
            elsa = new Person()
            {
                Name = "Elsa",
                Pos = new Position()
                {
                    x = this.pictureBox1.Location.X,
                    y = this.pictureBox1.Location.Y,
                },
                Theta = 0
            };
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            elsa.MoveForward(5);
            int x = (int)elsa.Pos.x;
            int y = (int)elsa.Pos.y;

            this.pictureBox1.Location = new System.Drawing.Point(x, y);
            distance += 5;

            if (distance > 0 && distance % 300 == 0)
            {
                elsa.TurnRight(90);
            }
        }
    }
}