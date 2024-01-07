using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Drawing;
using System.Windows.Forms;

namespace etozhestkapec
{
    internal class whip
    {
        public string direction;
        public int whipLeft;
        public int whipTop;


        private int speed = 1;
        private PictureBox Whip = new PictureBox();
        private Timer whipTimer = new Timer();
        int seccount = 0;

        



            public void Makewhip(Form form)
        {
            Whip.SizeMode = PictureBoxSizeMode.StretchImage;
            Whip.Width = 100;
            Whip.Height = 100;
            Whip.BackColor = Color.Transparent;
            Whip.Tag = "melee";
            Whip.Left = whipLeft;
            Whip.Top = whipTop;
            Whip.BringToFront();

            form.Controls.Add(Whip);


            whipTimer.Interval = 5000000;
            whipTimer.Tick += new EventHandler(WhipTimerEvent);
            if (direction == "left")
            {
                Whip.Image = Properties.Resources.whipl;
            }
            if (direction == "right")
            {
                Whip.Image = Properties.Resources.whipr;
            }
            if (direction == "up")
            {
                Whip.Image = Properties.Resources.whipu;
            }
            if (direction == "down")
            {
                Whip.Image = Properties.Resources.whipd;
            }
        }


        

        private void WhipTimerEvent(object sender, EventArgs e)
        {
            if (direction == "left")
            {
                Whip.Left -= speed;

            }
            if (direction == "right")
            {
                Whip.Left += speed;
            }
            if (direction == "up")
            {
                Whip.Top -= speed;
            }
            if (direction == "down")
            {
                Whip.Top += speed;
            }
            if (Whip.Left < 10 || Whip.Left > 1900 || Whip.Top < 10 || Whip.Top > 1000 && seccount == 1)
            {
                whipTimer.Stop();
                whipTimer.Dispose();
                Whip.Dispose();
                whipTimer = null;
                Whip = null;
            }
        }

    }
}
