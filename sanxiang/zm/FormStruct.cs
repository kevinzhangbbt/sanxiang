using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using model;

namespace sanxiang
{
    public partial class FormStruct : Form
    {
        public FormStruct()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string suo = cob_suo.SelectedText.Trim();
            string zhan = cob_zhan.SelectedText.Trim();
            string xianlu = cob_xianlu.SelectedText.Trim();
            string taiqu = txt_taiqu.Text.Trim();
            NodeStruct node = new NodeStruct();
            if (suo == "" && zhan == "" && xianlu == "" && taiqu=="")
            {
                MessageBox.Show("请输入信息");

            }
            else if (!(suo != "" && zhan != "" && xianlu != "" ) && taiqu != "")
            {
                MessageBox.Show("请选择台区所在外置");

            }
           
        

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormStructSuo s = new FormStructSuo();
           
            s.Show();
            
        }
    }
}
