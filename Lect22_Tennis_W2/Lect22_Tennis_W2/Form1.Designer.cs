namespace Lect22_Tennis_W2
{
    partial class PlayArea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rightWall = new System.Windows.Forms.Panel();
            this.leftWall = new System.Windows.Forms.Panel();
            this.topWall = new System.Windows.Forms.Panel();
            this.bottomWall = new System.Windows.Forms.Panel();
            this.lb_Collisons = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rightWall
            // 
            this.rightWall.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightWall.Location = new System.Drawing.Point(2303, 0);
            this.rightWall.Name = "rightWall";
            this.rightWall.Size = new System.Drawing.Size(10, 1022);
            this.rightWall.TabIndex = 0;
            // 
            // leftWall
            // 
            this.leftWall.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftWall.Location = new System.Drawing.Point(0, 0);
            this.leftWall.Name = "leftWall";
            this.leftWall.Size = new System.Drawing.Size(10, 1022);
            this.leftWall.TabIndex = 1;
            // 
            // topWall
            // 
            this.topWall.Dock = System.Windows.Forms.DockStyle.Top;
            this.topWall.Location = new System.Drawing.Point(10, 0);
            this.topWall.Name = "topWall";
            this.topWall.Size = new System.Drawing.Size(2293, 10);
            this.topWall.TabIndex = 2;
            // 
            // bottomWall
            // 
            this.bottomWall.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomWall.Location = new System.Drawing.Point(10, 980);
            this.bottomWall.Name = "bottomWall";
            this.bottomWall.Size = new System.Drawing.Size(2293, 42);
            this.bottomWall.TabIndex = 3;
            // 
            // lb_Collisons
            // 
            this.lb_Collisons.AutoSize = true;
            this.lb_Collisons.Location = new System.Drawing.Point(17, 19);
            this.lb_Collisons.Name = "lb_Collisons";
            this.lb_Collisons.Size = new System.Drawing.Size(0, 32);
            this.lb_Collisons.TabIndex = 4;
            // 
            // PlayArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2313, 1022);
            this.Controls.Add(this.lb_Collisons);
            this.Controls.Add(this.bottomWall);
            this.Controls.Add(this.topWall);
            this.Controls.Add(this.leftWall);
            this.Controls.Add(this.rightWall);
            this.Name = "PlayArea";
            this.Text = "Playground";
            this.Load += new System.EventHandler(this.PlayArea_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PlayArea_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayArea_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel rightWall;
        private System.Windows.Forms.Panel leftWall;
        private System.Windows.Forms.Panel topWall;
        private System.Windows.Forms.Panel bottomWall;
        private System.Windows.Forms.Label lb_Collisons;
    }
}

