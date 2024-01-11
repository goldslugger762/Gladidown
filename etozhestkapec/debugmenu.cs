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
    public partial class debugmenu : Form
    {
        public debugmenu()
        {
            InitializeComponent();
        }

        private void lvl1_Click(object sender, EventArgs e)
        {
            Form lvl1 = new Form1();
            lvl1.Show();
        }

        private void lvl2_Click(object sender, EventArgs e)
        {
            Form lvl2 = new Form5();
            lvl2.Show();
        }

        private void lvl3_Click(object sender, EventArgs e)
        {
            Form lvl3 = new Form7();
            lvl3.Show();
        }

        private void winscren_Click(object sender, EventArgs e)
        {
            Form winscren = new youwinscreen();
            winscren.Show();
        }

        private void unlockendl_Click(object sender, EventArgs e)
        {
            Settings.Default.endlessplus = 1;
            Settings.Default.Save();
        }

        private void endpllock_Click(object sender, EventArgs e)
        {
            Settings.Default.endlessplus = 0;
            Settings.Default.Save();
        }

        private void exitbt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
