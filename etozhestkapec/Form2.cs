using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using etozhestkapec.Properties;

namespace etozhestkapec
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            if (Settings.Default.endlessplus == 1)
            {
                endlessplus.Visible = true;
            }
        }

        private void myHero_Click(object sender, EventArgs e)
        {
            Form form4 = new Form4();
            form4.ShowDialog();
        }

        private void playbutton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void upravlenie_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.Show();
        }

        private void endlessmode_Click(object sender, EventArgs e)
        {
            Form form6 = new Form6();
            form6.Show();
        }

        private void endlessplus_Click(object sender, EventArgs e)
        {
            Form form8 = new Form8();
            form8.Show();
        }
    }
}
