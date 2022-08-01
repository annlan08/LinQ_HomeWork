using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQ_HomeWork
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Frm_HW1 F1 = new Frm_HW1();
            F1.MdiParent = this;
            F1.Show();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Frm_HW2 F2 = new Frm_HW2();
            F2.MdiParent = this;
            F2.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Frm_HW3 F3 = new Frm_HW3();
            F3.MdiParent = this;
            F3.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Frm_HW4 F4 = new Frm_HW4();
            F4.MdiParent = this;
            F4.Show();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
