using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sanxiang
{
    public partial class Formbjls : Form
    {
        public Formbjls()
        {
            InitializeComponent();
        }

        private void buttonItem21_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRadar fmrd = new FormRadar();
            fmrd.Show();
        }

        private void buttonItem19_Click(object sender, EventArgs e)
        {
            

        }

        private void buttonItem20_Click(object sender, EventArgs e)
        {
            
        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        private void Formbjls_Load(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem19_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Formbjls fmbs = new Formbjls();
            fmbs.Show();

        }

        private void buttonItem20_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Formbjcssz fmbz = new Formbjcssz();
            fmbz.Show();

        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.Show();

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fm3 = new Form3();
            fm3.Show();

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fm2 = new Form2();
            fm2.Show();

        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            Formplcl cl = new Formplcl();
            cl.Show();
        }

       

        
    }
}
