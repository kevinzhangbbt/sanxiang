using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using model;
using utils;
namespace sanxiang
{
    public partial class FormStructSuo : Form
    {
        public FormStructSuo()
        {
            InitializeComponent();
        }

        private void btn_suo_add_Click(object sender, EventArgs e)
        {
            String suo = txt_suo.Text.Trim();
            if (suo == "")
            {
                MessageBox.Show("请输入内容");
            }
            else
            {
                if (NodeStructPro.isExist(suo, "suo",NodeStructPro.getQuId())==1)
                {
                    MessageBox.Show("该信息已存在");
                }
                else
                {
                    NodeStruct node =new NodeStruct();
                    node.Id=Utils.GetId();
                    node.Name=suo;
                    node.Type="suo";
                    node.Parent_id=NodeStructPro.getQuId();
                    node.Admin_user = "";
                    NodeStructPro.Add(node);
                    MessageBox.Show("添加成功");
                }

            }
        }

        private void btn_suo_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
