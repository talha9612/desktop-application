using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lect22_Tennis_W2
{
    class Ball:PictureBox
    {
        int _speed;
        BallDirection direction;
        public Ball(int startX, int startY)
        {
            Point p = new Point(startX, startY);
            this.Location = p;
            this.Height = this.Width = 30;
            this.BackColor = Color.Blue;
            this._speed = 2;
            direction = BallDirection.UP_RIGHT;
            
        }
        public void MoveBall()
        {
            if(direction == BallDirection.UP_RIGHT)
            {
                Point p = this.Location;
                p.X += Speed;
                p.Y -= Speed;
                this.Location = p;


            }
            else if(direction == BallDirection.UP_LEFT)
            {
                Point p = this.Location;
                p.X -= Speed;
                p.Y -= Speed;
                this.Location = p;


            }
            else if (direction == BallDirection.DOWN_RIGHT)
            {
                Point p = this.Location;
                p.X += Speed;
                p.Y += Speed;
                this.Location = p;


            }
            else if (direction == BallDirection.DOWN_LEFT)
            {
                Point p = this.Location;
                p.X -= Speed;
                p.Y += Speed;
                this.Location = p;

            }
        }
        public void Display(Graphics g)
        {
            g.FillEllipse(new SolidBrush(this.BackColor), new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height));
        }
        public int Speed { get => _speed; set => _speed = value; }
        internal BallDirection Direction { get => direction; set => direction = value; }

//        public enum BallDirection {DOWN_LEFT, DOWN_RIGHT,UP_LEFT, UP_RIGHT }


    }
    public enum BallDirection { DOWN_LEFT, DOWN_RIGHT, UP_LEFT, UP_RIGHT }

}
