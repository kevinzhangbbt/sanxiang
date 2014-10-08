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
    public partial class Formjibentongji : Form
    {
        public Formjibentongji()
        {
            InitializeComponent();
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem == null)
            {
                MessageBox.Show("请选择要移动的文件");
            }
            else
            {
                for (int i = 0; i < this.listBox1.SelectedItems.Count; i++)
                {
                    this.listBox2.Items.Add(this.listBox1.SelectedItems[i]);
                }
                int num = listBox1.SelectedItems.Count;
                for (int i = 0; i < num; i++)
                {
                    this.listBox1.Items.Remove(this.listBox1.SelectedItems[0]);
                }

            }
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            if (this.listBox2.SelectedItem == null)
            {
                MessageBox.Show("请选择要移动的文件");
            }
            else
            {
                for (int i = 0; i < this.listBox2.SelectedItems.Count; i++)
                {
                    this.listBox1.Items.Add(this.listBox2.SelectedItems[i]);
                }
                int num = listBox2.SelectedItems.Count;
                for (int i = 0; i < num; i++)
                {
                    this.listBox2.Items.Remove(this.listBox2.SelectedItems[0]);
                }

            }
        }

        private void buttonX9_Click(object sender, EventArgs e)
        {
            if (this.listBox3.SelectedItem == null)
            {
                MessageBox.Show("请选择要移动的文件");
            }
            else
            {
                for (int i = 0; i < this.listBox3.SelectedItems.Count; i++)
                {
                    this.listBox4.Items.Add(this.listBox3.SelectedItems[i]);
                }
                int num = listBox3.SelectedItems.Count;
                for (int i = 0; i < num; i++)
                {
                    this.listBox3.Items.Remove(this.listBox3.SelectedItems[0]);
                }

            }
        }

        private void buttonX10_Click(object sender, EventArgs e)
        {
            if (this.listBox4.SelectedItem == null)
            {
                MessageBox.Show("请选择要移动的文件");
            }
            else
            {
                for (int i = 0; i < this.listBox4.SelectedItems.Count; i++)
                {
                    this.listBox3.Items.Add(this.listBox4.SelectedItems[i]);
                }
                int num = listBox4.SelectedItems.Count;
                for (int i = 0; i < num; i++)
                {
                    this.listBox4.Items.Remove(this.listBox4.SelectedItems[0]);
                }

            }
        }

        private void buttonX12_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }

        private void buttonX12_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
