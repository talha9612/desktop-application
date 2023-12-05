using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lect22_Tennis_W2
{
    public partial class PlayArea : Form
    {
        Ball myball;
        Paddle player1;
        Paddle player2;
        Graphics g;
        int points = 0;
        bool UptoDown = false;
        public PlayArea()
        {
            InitializeComponent();
            myball = new Ball(this.Width/2, this.Height/2);
            player1 = new Paddle(this.Width / 2, 50, Color.DarkGreen);
            player2 = new Paddle(this.Width / 2, this.Height - 100, Color.DarkOrange);

        }

        private void PlayArea_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            lb_Collisons.Text = "Collisions: 0";

        }

        private void PlayArea_Paint(object sender, PaintEventArgs e)
        {
            myball.Display(g);
            player1.Display(g);
            player2.Display(g);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            myball.MoveBall();
            // Collison Detection ( Wall Collision , Paddle Collision)
            CheckWallCollison();
            CheckPaddleCollision1(player1);
            CheckPaddleCollision2(player2);

            this.Invalidate();

        }

        private void CheckPaddleCollision1(Paddle player)
        {
            if (myball.Bounds.IntersectsWith(player.Bounds) && UptoDown == false )
            {
                if (myball.Direction == BallDirection.DOWN_RIGHT)
                    myball.Direction = BallDirection.UP_RIGHT;
                else if (myball.Direction == BallDirection.DOWN_LEFT)
                    myball.Direction = BallDirection.UP_LEFT;
                else if (myball.Direction == BallDirection.UP_RIGHT)
                    myball.Direction = BallDirection.DOWN_RIGHT;
                else if (myball.Direction == BallDirection.UP_LEFT)
                    myball.Direction = BallDirection.DOWN_LEFT;
                points++;
                lb_Collisons.Text = "Collisions: " + points.ToString();
                UptoDown = true;
                
            }
        }

        private void CheckPaddleCollision2(Paddle player)
        {
            if (myball.Bounds.IntersectsWith(player.Bounds)&&UptoDown == true)
            {
                if (myball.Direction == BallDirection.DOWN_RIGHT)
                    myball.Direction = BallDirection.UP_RIGHT;
                else if (myball.Direction == BallDirection.DOWN_LEFT)
                    myball.Direction = BallDirection.UP_LEFT;
                else if (myball.Direction == BallDirection.UP_RIGHT)
                    myball.Direction = BallDirection.DOWN_RIGHT;
                else if (myball.Direction == BallDirection.UP_LEFT)
                    myball.Direction = BallDirection.DOWN_LEFT;
                points++;
                lb_Collisons.Text = "Collisions: " + points.ToString();
                UptoDown = false;
            }
        }

        private void CheckWallCollison()
        {
            if (myball.Bounds.IntersectsWith(rightWall.Bounds))
            {
                if (myball.Direction  == BallDirection.DOWN_RIGHT)
                    myball.Direction = BallDirection.DOWN_LEFT;
                else if (myball.Direction == BallDirection.UP_RIGHT)
                    myball.Direction = BallDirection.UP_LEFT;

            }

            else if (myball.Bounds.IntersectsWith(leftWall.Bounds))
            {
                if (myball.Direction == BallDirection.UP_LEFT)
                    myball.Direction = BallDirection.UP_RIGHT;
                else if (myball.Direction == BallDirection.DOWN_LEFT)
                    myball.Direction = BallDirection.DOWN_RIGHT;

            }
            else if (myball.Bounds.IntersectsWith(topWall.Bounds))
            {
                timer1.Stop();
                MessageBox.Show(player2.BackColor.ToString() + " player wins");

            }
            else if (myball.Bounds.IntersectsWith(bottomWall.Bounds))
            {
                timer1.Stop();
                MessageBox.Show(player1.BackColor.ToString() + " player wins");

            }

        }

        private void PlayArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                if(!player1.Bounds.IntersectsWith(rightWall.Bounds))
                {
                    Point p = player1.Location;
                    p.X +=player1.Jump;
                    player1.Location = p;

                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (!player1.Bounds.IntersectsWith(leftWall.Bounds))
                {
                    Point p = player1.Location;
                    p.X -= player1.Jump;
                    player1.Location = p;

                }
            }
            else if (e.KeyCode == Keys.A)
            {
                if (!player2.Bounds.IntersectsWith(leftWall.Bounds))
                {
                    Point p = player2.Location;
                    p.X -= player2.Jump;
                    player2.Location = p;

                }
            }
            else if (e.KeyCode == Keys.S)
            {
                if (!player2.Bounds.IntersectsWith(rightWall.Bounds))
                {
                    Point p = player2.Location;
                    p.X += player2.Jump;
                    player2.Location = p;

                }
            }
        }
    }
}
