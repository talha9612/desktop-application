using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lect22_Tennis_W2
{
    class Paddle:PictureBox
    {
       
        public Paddle(int x, int y, Color c)
        {
            // TODO: Complete member initialization
            Point temp = new Point(x, y);
            Location = temp;
            this.BackColor = c;
            this.Height = 20;
            this.Width = 100;
            
        }
        private int _jump = 5;


        public int Jump
        {
            get
            {
                return _jump;
            }

            set
            {
                _jump = value;
            }
        }

        public void Display(Graphics g)
        {
            g.FillRectangle(new SolidBrush(this.BackColor), new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height));
        }



    }
}
