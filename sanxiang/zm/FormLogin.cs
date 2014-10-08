using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using model;
using System.Xml;
using utils;

namespace sanxiang
{
    public partial class FormLogin : Form
    {
        private static int time_count = 0;
    
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_password.Text;
            if (username == "")
            {
                MessageBox.Show("请输入用户名");
                txt_username.Focus();
            }
            else if (password == "")
            {
                MessageBox.Show("请输入密码");
                txt_password.Focus();
            }
            else
            {
                probar_auto_login.Visible = true;
                btn_login.Enabled = false;
                btn_exit.Enabled = false;
                this.timer1.Start();
            }
            
          
           
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
         
            string remeber_pass = Utils.GetConfig("remeber_pass", "no");
            string auto_login = Utils.GetConfig("auto_login", "no");
            string username = Utils.GetConfig("username", "");
            string password = Utils.GetConfig("password", "");
            txt_username.Text = username;
            if (password != "" && remeber_pass == "yes")
            {
                txt_password.Text = Utils.GetJiemi("auth", password);
            }

            if (remeber_pass == "yes")
            {
                chk_password.Checked = true;

            }
            else
            {
                chk_password.Checked = false;
            }
            if (auto_login == "yes")
            {
                chk_auto_login.Checked = true;
                probar_auto_login.Visible = true;
                btn_login.Visible = false;
                btn_exit.Visible = false;
                btn_cancel.Visible = true;
                if (username != "" && password != "")
                {
                    timer2.Start();

                }


            }
            else
            {

                chk_auto_login.Checked = false;
                probar_auto_login.Visible = false;
                btn_login.Visible = true;
                btn_exit.Visible = true;
                btn_cancel.Visible = false;
            }

          
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult Close_Result = MessageBox.Show("是否退出本系统？", "确认退出", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Close_Result == DialogResult.Yes)
            {
                e.Cancel = false;

            }
            else
            {
                e.Cancel = true;
            }
        }

  

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time_count >= 50)
            {
                time_count = 0;
                probar_auto_login.Visible = false;
                btn_login.Enabled = true;
                btn_exit.Enabled = true;
                timer1.Stop();
                string username = txt_username.Text.Trim();
                string password = txt_password.Text;
                if (username == "")
                {
                    MessageBox.Show("请输入用户名");
                    txt_username.Focus();
                }
                else if (password == "")
                {
                    MessageBox.Show("请输入密码");
                    txt_password.Focus();
                }
                else
                {
                    string user_id = UserPro.Login(username, password);

                    if (user_id != "")
                    {
                        Utils.SetConfig("username", username);
                        Utils.SetConfig("password", Utils.GetJiaMi("auth", password));
                        if (chk_password.Checked == true)
                        {
                            Utils.SetConfig("remeber_pass", "yes");
                            if (chk_auto_login.Checked == true)
                            {
                                Utils.SetConfig("auto_login", "yes");

                            }
                            else
                            {
                                Utils.SetConfig("auto_login", "no");
                            }

                        }
                        else
                        {
                            Utils.SetConfig("remeber_pass", "no");
                            if (chk_auto_login.Checked == true)
                            {
                                Utils.SetConfig("auto_login", "yes");

                            }
                            else
                            {
                                Utils.SetConfig("auto_login", "no");
                            }

                        }
                        Utils.SetConfig("login_user_id", user_id);
                        MainForm formMain = new MainForm();
                        this.Hide();
                        formMain.Show();

                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误");
                    }


                }

            }
            else
            {

                time_count = time_count + 1;
            }
           
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            time_count = 0;
            btn_login.Visible = true;
            btn_exit.Visible = true;
            btn_cancel.Visible = false;
            probar_auto_login.Visible = false;
            try
            {
                timer2.Stop();
            }
            catch (Exception)
            {


            }
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (time_count >= 50)
            {
                time_count = 0;
                probar_auto_login.Visible = false;
                btn_cancel.Visible = false;
                btn_login.Visible = true;
                btn_exit.Visible = true;
                timer2.Stop();
                string username = Utils.GetConfig("username", "");
                string password = Utils.GetConfig("password", "");

                string user_id = UserPro.Login(username, Utils.GetJiemi("auth", password));

                if (user_id!="")
                {
                    Utils.SetConfig("login_user_id", user_id);
                    MainForm formMain = new MainForm();
                    this.Hide();
                    formMain.Show();

                }
                else
                {

                    MessageBox.Show("用户名或密码错误");
                }

            }
            else
            {

                time_count = time_count + 1;
            }

        }

       
    }
}
