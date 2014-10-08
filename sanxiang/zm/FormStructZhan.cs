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
    public partial class FormStructZhan : Form
    {
        public FormStructZhan()
        {
            InitializeComponent();
        }

        private void btn_zhan_add_Click(object sender, EventArgs e)
        {
            String suo = cob_suo.Text.Trim();
            String zhan = txt_zhan_name.Text.Trim();
            if (suo == "" || zhan == "")
            {

                MessageBox.Show("请输入内容");

            }
            NodeStruct node_suo = NodeStructPro.getNodeStruct(suo, "suo", NodeStructPro.getQuId());
            if (NodeStructPro.isExist(zhan, "zhan", node_suo.Id) == 1)
            {

                MessageBox.Show("信息已存在");
            }
            else
            {
                NodeStruct node = new NodeStruct();
                node.Id = Utils.GetId();
                node.Name = zhan;
                node.Type = "zhan";
                node.Parent_id = node_suo.Id;
                node.Admin_user = "";
                NodeStructPro.Add(node);
                MessageBox.Show("添加成功");


            }

            

        }

        private void btn_zhan_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormStructZhan_Load(object sender, EventArgs e)
        {

        }

    
      
    }
}
