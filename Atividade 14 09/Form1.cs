using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_14_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            if(rb1.Checked == true)
            {
                pc1.Image = Properties.Resources.indo_ali_1 ;
            }
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2.Checked == true)
            {
                pc1.Image = Properties.Resources.indo_ali_2;
            }
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            if (rb3.Checked == true)
            {
                pc1.Image = null;
            }
        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            if (rb4.Checked == true)
            {
                pc1.BorderStyle = BorderStyle.None;
            }
        }

        private void rb5_CheckedChanged(object sender, EventArgs e)
        {
            if (rb5.Checked == true)
            {
                pc1.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void rb6_CheckedChanged(object sender, EventArgs e)
        {
            if (rb6.Checked == true)
            {
                pc1.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb1.Checked == true)
            {
                pc1.Visible = true;
            }
            else
            {
                pc1.Visible = false;
            }
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
