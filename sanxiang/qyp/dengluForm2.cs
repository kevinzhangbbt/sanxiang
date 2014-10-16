using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//[qyp]this is just a test


namespace tongjifenxi
{
    public partial class dengluForm : Form
    {
        public dengluForm()
        {
            InitializeComponent();
        }

        private void dengluForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtname = this.txtname.Text;
            string txtpass = this.txtpass.Text;
            if (txtname == "")
            {
                MessageBox.Show("请输入用户名", "错误提示");
            }
            else if (txtpass == "")

            {
                MessageBox.Show("请输入密码", "错误提示");
            }
            else if (txtname == "三相" & txtpass == "q19911019")
            {

                Formzhujiemian g = new Formzhujiemian();
                g.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("用户名或密码错误，请重新输入", "错误提示");
            }


        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }
    }
}
