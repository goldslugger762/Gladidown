using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using etozhestkapec.Properties;

namespace etozhestkapec
{
    public partial class Form4 : Form
    {
        Font newfont = new Font("Serif", 16);
        Font defaultfont = new Font("Sans Serif", 10);


        public Form4()
        {
            InitializeComponent();
            yourscore.Text = Convert.ToString(Settings.Default.ochki);
            if (yourspeedtxt.Text == "0")
            {
                costskorost.Text = "Стоимость: 500 очков\r\nПовышает твою скорость на 5 единиц за уровень!\r\n";
            }
            if (Settings.Default.speedprokachka == 5)
            {
                yourspeedtxt.Text = "1";
                costskorost.Text = "Следующий уровень уже будет стоить 700!";
            }
            if (Settings.Default.speedprokachka == 10)
            {
                yourspeedtxt.Text = "2";
                costskorost.Text = "Уже подороже! 900!";
            }
            if (Settings.Default.speedprokachka == 15)
            {
                yourspeedtxt.Text = "3";
                costskorost.Text = "Не слишком быстро? 1200";
            }
            if (Settings.Default.speedprokachka == 20)
            {
                yourspeedtxt.Text = "4";
                costskorost.Text = "Ты почти у цели. 1800";
            }
            if (Settings.Default.speedprokachka == 25)
            {
                yourspeedtxt.Text = "5";
                costskorost.Text = "MAX";
                costskorost.Font = newfont;
                costskorost.BackColor = Color.Black;
                costskorost.ForeColor = Color.Gold;
                speedprokachkabutton.Visible = false;
            }
            if (yourstonestxt.Text == "0")
            {
                costkamni.Text = "Стоимость: 250 очков\r\nПовышает твоё стартовое количество камней на 5 единиц за уровень!\r\n";
            }
            if (Settings.Default.kamniprokachka == 5)
            {
                yourstonestxt.Text = "1";
                costkamni.Text = "$450";
            }
            if (Settings.Default.kamniprokachka == 10)
            {
                yourstonestxt.Text = "2";
                costkamni.Text = "Закидай их всех! 650";
            }
            if (Settings.Default.kamniprokachka == 15)
            {
                yourstonestxt.Text = "3";
                costkamni.Text = "Не тяжко носить? 850";
            }
            if (Settings.Default.kamniprokachka == 20)
            {
                yourstonestxt.Text = "4";
                costkamni.Text = "Ты все ещё можешь бегать? 1050";
            }
            if (Settings.Default.kamniprokachka == 25)
            {
                yourstonestxt.Text = "5";
                costkamni.Text = "MAX";
                costkamni.Font = newfont;
                costkamni.BackColor = Color.Black;
                costkamni.ForeColor = Color.Gold;
                stonesprokachkabutton.Visible = false; ;
            }
            if (yourheatlhtxt.Text == "0")
            {
                costhealth.Text = "Стоимость: 700 очков\r\nПовышает твоё максимальное количество жизней на 20 единиц за уровень! Живи дольше!";
            }
            if (Settings.Default.helthprokachka == 20)
            {
                yourheatlhtxt.Text = "1";
                costhealth.Text = "Ещё жизней! 950";
            }
            if (Settings.Default.helthprokachka == 40)
            {
                yourheatlhtxt.Text = "2";
                costhealth.Text = "Дополнительно! 1250";
            }
            if (Settings.Default.helthprokachka == 60)
            {
                yourheatlhtxt.Text = "3";
                costhealth.Text = "Ещё больше хп 1600";
            }
            if (Settings.Default.helthprokachka == 80)
            {
                yourheatlhtxt.Text = "4";
                costhealth.Text = "Вторая броня! 2000";
            }
            if (Settings.Default.helthprokachka == 100)
            {
                yourheatlhtxt.Text = "5";
                costhealth.Text = "MAX";
                costhealth.Font = newfont;
                costhealth.BackColor = Color.Black;
                costhealth.ForeColor = Color.Gold;
                heatlhprokachkabutton.Visible = false; 
            }
        }
        
        

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void speedprokachkabutton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(yourscore.Text) >= 500 && yourspeedtxt.Text == "0")
            {
                int a;
                Settings.Default.ochki -= 500;
                yourspeedtxt.Text = "1";
                Settings.Default.speedprokachka += 5;
                Settings.Default.Save();
                a = Convert.ToInt32(yourscore.Text);
                a -= 500;
                yourscore.Text = Convert.ToString(a);
                costskorost.Text = "Следующий уровень уже будет стоить 700!";
                return;
            }
            if (Convert.ToInt32(yourscore.Text) >= 700 && yourspeedtxt.Text == "1")
            {
                int a;
                Settings.Default.ochki -= 700;
                yourspeedtxt.Text = "2";
                Settings.Default.speedprokachka += 5;
                Settings.Default.Save();
                a = Convert.ToInt32(yourscore.Text);
                a -= 700;
                yourscore.Text = Convert.ToString(a);
                costskorost.Text = "Уже подороже! 900!";
                return;
            }
            if (Convert.ToInt32(yourscore.Text) >= 900 && yourspeedtxt.Text == "2")
            {
                int a;
                Settings.Default.ochki -= 900;
                yourspeedtxt.Text = "3";
                Settings.Default.speedprokachka += 5;
                Settings.Default.Save();
                a = Convert.ToInt32(yourscore.Text);
                a -= 900;
                yourscore.Text = Convert.ToString(a);
                costskorost.Text = "Не слишком быстро? 1200";
                return;
            }
            if (Convert.ToInt32(yourscore.Text) >= 1200 && yourspeedtxt.Text == "3")
            {
                int a;
                Settings.Default.ochki -= 1200;
                yourspeedtxt.Text = "4";
                Settings.Default.speedprokachka += 5;
                Settings.Default.Save();
                a = Convert.ToInt32(yourscore.Text);
                a -= 1200;
                yourscore.Text = Convert.ToString(a);
                costskorost.Text = "Ты почти у цели. 1800";
                return;
            }
            if (Convert.ToInt32(yourscore.Text) >= 1800 && yourspeedtxt.Text == "4")
            {
                int a;
                Settings.Default.ochki -= 1800;
                yourspeedtxt.Text = "5";
                Settings.Default.speedprokachka += 5;
                Settings.Default.Save();
                a = Convert.ToInt32(yourscore.Text);
                a -= 1800;
                yourscore.Text = Convert.ToString(a);
                costskorost.Text = "MAX";
                costskorost.Font = newfont;
                costskorost.BackColor = Color.Black;
                costskorost.ForeColor = Color.Gold;
                speedprokachkabutton.Visible = false;
                return;
            }
        }

        private void stonesprokachkabutton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(yourscore.Text) >= 250 && yourstonestxt.Text == "0")
            {
                int a;
                Settings.Default.ochki -= 250;
                yourstonestxt.Text = "1";
                Settings.Default.kamniprokachka += 5;
                Settings.Default.Save();
                a = Convert.ToInt32(yourscore.Text);
                a -= 250;
                yourscore.Text = Convert.ToString(a);
                costkamni.Text = "$450";
                return;
            }
            if (Convert.ToInt32(yourscore.Text) >= 450 && yourstonestxt.Text == "1")
            {
                int a;
                Settings.Default.ochki -= 450;
                yourstonestxt.Text = "2";
                Settings.Default.kamniprokachka += 5;
                Settings.Default.Save();
                a = Convert.ToInt32(yourscore.Text);
                a -= 450;
                yourscore.Text = Convert.ToString(a);
                costkamni.Text = "Закидай их всех! 650";
                return;
            }
            if (Convert.ToInt32(yourscore.Text) >= 650 && yourstonestxt.Text == "2")
            {
                int a;
                Settings.Default.ochki -= 650;
                yourstonestxt.Text = "3";
                Settings.Default.kamniprokachka += 5;
                Settings.Default.Save();
                a = Convert.ToInt32(yourscore.Text);
                a -= 650;
                yourscore.Text = Convert.ToString(a);
                costkamni.Text = "Не тяжко носить? 850";
                return;
            }
            if (Convert.ToInt32(yourscore.Text) >= 850 && yourstonestxt.Text == "3")
            {
                int a;
                Settings.Default.ochki -= 850;
                yourstonestxt.Text = "4";
                Settings.Default.kamniprokachka += 5;
                Settings.Default.Save();
                a = Convert.ToInt32(yourscore.Text);
                a -= 850;
                yourscore.Text = Convert.ToString(a);
                costkamni.Text = "Ты все ещё можешь бегать? 1050";
                return;
            }
            if (Convert.ToInt32(yourscore.Text) >= 1050 && yourstonestxt.Text == "4")
            {
                int a;
                Settings.Default.ochki -= 1050;
                yourstonestxt.Text = "5";
                Settings.Default.kamniprokachka += 5;
                Settings.Default.Save();
                a = Convert.ToInt32(yourscore.Text);
                a -= 1050;
                yourscore.Text = Convert.ToString(a);
                costkamni.Text = "MAX";
                costkamni.Font = newfont;
                costkamni.BackColor = Color.Black;
                costkamni.ForeColor = Color.Gold;
                stonesprokachkabutton.Visible = false;
                return;
            }
        }

        private void heatlhprokachkabutton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(yourscore.Text) >= 700 && yourheatlhtxt.Text == "0")
            {
                int a;
                Settings.Default.ochki -= 700;
                yourheatlhtxt.Text = "1";
                Settings.Default.helthprokachka += 20;
                Settings.Default.Save();
                a = Convert.ToInt32(yourscore.Text);
                a -= 700;
                yourscore.Text = Convert.ToString(a);
                costhealth.Text = "Ещё жизней! 950";
                return;
            }
            if (Convert.ToInt32(yourscore.Text) >= 950 && yourheatlhtxt.Text == "1")
            {
                int a;
                Settings.Default.ochki -= 950;
                yourheatlhtxt.Text = "2";
                Settings.Default.helthprokachka += 20;
                Settings.Default.Save();
                a = Convert.ToInt32(yourscore.Text);
                a -= 950;
                yourscore.Text = Convert.ToString(a);
                costhealth.Text = "Дополнительно! 1250";
                return;
            }
            if (Convert.ToInt32(yourscore.Text) >= 1250 && yourheatlhtxt.Text == "2")
            {
                int a;
                Settings.Default.ochki -= 1250;
                yourheatlhtxt.Text = "3";
                Settings.Default.helthprokachka += 20;
                Settings.Default.Save();
                a = Convert.ToInt32(yourscore.Text);
                a -= 1250;
                yourscore.Text = Convert.ToString(a);
                costhealth.Text = "Ещё больше хп 1600";
                return;
            }
            if (Convert.ToInt32(yourscore.Text) >= 1600 && yourheatlhtxt.Text == "3")
            {
                int a;
                Settings.Default.ochki -= 1600;
                yourheatlhtxt.Text = "4";
                Settings.Default.helthprokachka += 20;
                Settings.Default.Save();
                a = Convert.ToInt32(yourscore.Text);
                a -= 1600;
                yourscore.Text = Convert.ToString(a);
                costhealth.Text = "Вторая броня! 2000";
                return;
            }
            if (Convert.ToInt32(yourscore.Text) >= 2000 && yourheatlhtxt.Text == "4")
            {
                int a;
                Settings.Default.ochki -= 2000;
                yourheatlhtxt.Text = "5";
                Settings.Default.helthprokachka += 20;
                Settings.Default.Save();
                a = Convert.ToInt32(yourscore.Text);
                a -= 2000;
                yourscore.Text = Convert.ToString(a);
                yourscore.Text = Convert.ToString(a);
                costhealth.Text = "MAX";
                costhealth.Font = newfont;
                costhealth.BackColor = Color.Black;
                costhealth.ForeColor = Color.Gold;
                heatlhprokachkabutton.Visible = false;
                return;
            }
        }


        private void sbrosbutton_MouseEnter(object sender, EventArgs e)
        {
            sbrosbutton.BackColor = Color.Red;
            
        }

        private void sbrosbutton_MouseLeave_1(object sender, EventArgs e)
        {
            sbrosbutton.BackColor= Color.White;
        }

        private void yourscore_Click(object sender, EventArgs e)
        {
            int a;
            Settings.Default.ochki += 500;
            Settings.Default.Save();
            a = Convert.ToInt32(yourscore.Text);
            a += 500;
            yourscore.Text = Convert.ToString(a);
        }

        private void sbrosbutton_Click(object sender, EventArgs e)
        {
            Settings.Default.ochki = 0;
            Settings.Default.helthprokachka = 0;
            Settings.Default.kamniprokachka = 0;
            Settings.Default.speedprokachka = 0;
            yourheatlhtxt.Text = "0";
            yourscore.Text = "0";
            yourspeedtxt.Text = "0";
            yourstonestxt.Text = "0";
            costkamni.Text = "Стоимость: 250 очков\r\nПовышает твоё стартовое количество камней на 5 единиц за уровень!";
            costkamni.BackColor = Color.White;
            costkamni.Font = defaultfont;
            costkamni.ForeColor = Color.Black; 
            costhealth.Text = "Стоимость: 700 очков\r\nПовышает твоё максимальное количество жизней на 20 единиц за уровень! Живи дольше!";
            costhealth.BackColor = Color.White;
            costhealth.Font = defaultfont;
            costhealth.ForeColor = Color.Black;
            costskorost.Text = "Стоимость: 500 очков\r\nПовышает твою скорость на 5 единиц за уровень!";
            costskorost.BackColor = Color.White;
            costskorost.Font = defaultfont;
            costskorost.ForeColor = Color.Black;
            heatlhprokachkabutton.Visible = true;
            speedprokachkabutton.Visible = true;
            stonesprokachkabutton.Visible = true;


            Settings.Default.Save();
        }

        private void sbrosendless_MouseEnter(object sender, EventArgs e)
        {
            sbrosendless.BackColor = Color.Red;
        }

        private void sbrosendless_MouseLeave(object sender, EventArgs e)
        {
            sbrosendless.BackColor = Color.White;
        }

        private void sbrosendless_Click(object sender, EventArgs e)
        {
            Settings.Default.staroeznachenie = 0;
            Settings.Default.Save();
        }
    }
}
