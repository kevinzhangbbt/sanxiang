using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tongjifenxi
{
    public partial class Formchaxun : Form
    {
        public Formchaxun()
        {
            InitializeComponent();
        }

        private void Form21_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Formchaxunjieguo22 s = new Formchaxunjieguo22();
            s.Show();
            this.Hide();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
