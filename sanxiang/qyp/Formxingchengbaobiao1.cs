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
    public partial class Formxingchengbaobiao23 : Form
    {
        public Formxingchengbaobiao23()
        {
            InitializeComponent();
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            Formxingchengbaobiao24 s = new Formxingchengbaobiao24();
            s.Show();
            this.Hide();

        }
    }
}
