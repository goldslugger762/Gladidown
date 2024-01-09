﻿using System;
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


        private PictureBox Whip = new PictureBox();

        



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


        


    }
}
