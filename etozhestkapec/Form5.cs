using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using etozhestkapec.Properties;



namespace etozhestkapec
{
    public partial class Form5 : Form
    {


        bool goLeft, goRight, goUp, goDown, gameOver, nazhata, nenazhata;
        string facing = "up";
        int playerHealth = 100 + Settings.Default.helthprokachka;
        int speed = 3 + Settings.Default.speedprokachka;
        int ammo = 5 + Settings.Default.kamniprokachka;
        int zedSpeed = 7;
        int startspeed = 3 + Settings.Default.speedprokachka;
        Random randNum = new Random();
        int score;
        List<PictureBox> zedsList = new List<PictureBox>();
        List<PictureBox> spikeList = new List<PictureBox>();



        public Form5()
        {
            InitializeComponent();
            RestartGame();
        }





        private void txtammo_Click(object sender, EventArgs e)
        {
            ammo += 5;
        }

        private void healthbar_Click(object sender, EventArgs e)
        {
            playerHealth = 100 + Settings.Default.helthprokachka;
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                healthbar.Maximum = 100 + Settings.Default.helthprokachka;
                healthbar.Value = playerHealth;
            }
            else
            {
                umerlabel.Visible = true;
                umerlabel.BringToFront();
                gameOver = true;
                gametimer.Stop();
            }
            txtammo.Text = "Stones:" + ammo;
            txtscore.Text = "Corpses:" + score;

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }

            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }

            if (goUp == true && player.Top > 43)
            {
                player.Top -= speed;
            }

            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }



            if (nazhata == false)
            {
                speed = startspeed;
                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "melee")
                    {
                        this.Controls.Remove(j);
                        ((PictureBox)j).Dispose();
                    }
                }

            }


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "zed")
                {

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                    }


                    if (x.Left > player.Left)
                    {
                        x.Left -= zedSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zedl;
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += zedSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zedr;
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= zedSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zedu;
                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += zedSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zedd;
                    }
                }

                foreach (Control y in this.Controls)
                {
                    if (y is PictureBox && (string)y.Tag == "spike")
                    {
                        if (player.Bounds.IntersectsWith(y.Bounds))
                        {
                            playerHealth -= 1;
                        }
                    }
                }



                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zed")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;
                            Properties.Settings.Default.ochki += 2;
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            zedsList.Remove(((PictureBox)x));
                            MakeZeds();
                        }
                    }
                }
                foreach (Control k in this.Controls)
                {
                    if (k is PictureBox && (string)k.Tag == "melee" && x is PictureBox && (string)x.Tag == "zed")
                    {
                        if (x.Bounds.IntersectsWith(k.Bounds))
                        {
                            score++;
                            Properties.Settings.Default.ochki += 2;
                            this.Controls.Remove(k);
                            ((PictureBox)k).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            zedsList.Remove(((PictureBox)x));
                            MakeZeds();
                        }
                    }
                }
                foreach (Control z in this.Controls)
                {
                    if ((z is PictureBox && (string)z.Tag == "ammo"))
                    {
                        if (player.Bounds.IntersectsWith(z.Bounds))
                        {
                            this.Controls.Remove(z);
                            ((PictureBox)z).Dispose();
                            this.Controls.Remove(z);
                            ammo += 3;
                        }
                    }
                }
                if (player.Left < 350)
                {
                    goLeft = false;
                }
                if (player.Left > 1500)
                {
                    goRight = false;
                }
                if (player.Top < 50)
                {
                    goUp = false;
                }
                Settings.Default.Save();
            }
        }

        private void KeyDownIs(object sender, KeyEventArgs e)
        {

            if (gameOver == true)
            {
                return;
            }



            if (e.KeyCode == Keys.Left && player.Left > 350)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right && player.Left < 1500)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }

            if (e.KeyCode == Keys.Up && player.Top > 50)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.up;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.down;
            }
            if (e.KeyCode == Keys.X)
            {
                nazhata = true;
                speed = 1;

            }
            if (nazhata == true)
            {
                nenazhata = false;
                AttackWhip(facing);
            }
        }




        private void player_Click(object sender, EventArgs e)
        {

        }

        private void txthealth_Click(object sender, EventArgs e)
        {

        }

        private void KeyUpIs(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                ShootBullet(facing);

                if (ammo < 1)
                {
                    DropRocks();
                }
            }
            if (e.KeyCode == Keys.X)
            {
                nazhata = false;
            }


            if (e.KeyCode == Keys.Enter)
            {
                Settings.Default.Save();
                RestartGame();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Settings.Default.Save();
                this.Close();
            }
        }







        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);
        }

        private void AttackWhip(string direction)
        {
            whip attackWhip = new whip();
            attackWhip.direction = direction;
            attackWhip.whipLeft = player.Left + (player.Width / 3) - 45;
            attackWhip.whipTop = player.Top + (player.Height / 3) - 45;
            attackWhip.Makewhip(this);
        }


        private void MakeZeds()
        {
            PictureBox zed = new PictureBox();
            zed.Tag = "zed";
            zed.BackColor = Color.Transparent;
            zed.Image = Properties.Resources.zedd;
            zed.Left = randNum.Next(300, 1700);
            zed.Top = randNum.Next(200, 750);
            zed.SizeMode = PictureBoxSizeMode.StretchImage;
            zed.Height = 50;
            zed.Width = 45;
            zedsList.Add(zed);
            this.Controls.Add(zed);
            player.BringToFront();
            zed.BringToFront();
        }

        private void DropRocks()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.rocks;
            ammo.SizeMode = PictureBoxSizeMode.StretchImage;
            ammo.Height = 40;
            ammo.Width = 40;
            ammo.Left = randNum.Next(500, 1500);
            ammo.Top = randNum.Next(300, 700);
            ammo.Tag = "ammo";
            ammo.BackColor = Color.Transparent;
            this.Controls.Add(ammo);

            ammo.BringToFront();
            player.BringToFront();
        }


        private void spikes()
        {
            PictureBox spike = new PictureBox();
            spike.Tag = "spike";
            spike.BackColor = Color.Transparent;
            spike.Image = Properties.Resources.spike;
            spike.Left = randNum.Next(500, 1500);
            spike.Top = randNum.Next(300, 700);
            spike.SizeMode = PictureBoxSizeMode.StretchImage;
            spike.Height = 50;
            spike.Width = 45;
            spikeList.Add(spike);
            this.Controls.Add(spike);
            player.BringToFront();
            spike.BringToFront();
        }



        private void RestartGame()
        {
            player.Image = Properties.Resources.up;

            foreach (PictureBox i in zedsList)
            {
                this.Controls.Remove(i);
            }

            foreach (PictureBox i in spikeList)
            {
                this.Controls.Remove(i);
            }

            zedsList.Clear();
            spikeList.Clear();

            for (int i = 0; i < 4; i++)
            {
                MakeZeds();
            }
            for (int i = 0; i < 2; i++)
            {
                spikes();
            }

            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;
            umerlabel.Visible = false;



            playerHealth = 100 + Settings.Default.helthprokachka;
            score = 0;
            ammo = 5 + Settings.Default.kamniprokachka;

            gametimer.Start();
        }






    }
}
