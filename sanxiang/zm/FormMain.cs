using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;

using model;
using tongjifenxi;
using sangxiang;
namespace sanxiang
{
    public partial class MainForm : Office2007RibbonForm
    {
        private eOffice2007ColorScheme m_BaseColorScheme = eOffice2007ColorScheme.VistaGlass;
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonItem_style_Click(object sender, EventArgs e)
        {

        }

        private void command1_Executed(object sender, EventArgs e)
        {
            ICommandSource source = sender as ICommandSource;
            if (source.CommandParameter is string)
            {
                eOffice2007ColorScheme colorScheme = (eOffice2007ColorScheme)Enum.Parse(typeof(eOffice2007ColorScheme), source.CommandParameter.ToString());
                ribbonControl_main.Office2007ColorTable = colorScheme;
            }
            else if (source.CommandParameter is Color)
            {
                RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, m_BaseColorScheme, (Color)source.CommandParameter);
            }
            this.Invalidate();
        }

        private void buttonItem_theme_silver_Click(object sender, EventArgs e)
        {

        }

        private void ribbonTabItem_jiankong_Click(object sender, EventArgs e)
        {
            
        }


        /// <summary>
        /// 防止打开多个同样的子窗体,检查是否已打开某个子窗体,如果打开了就返回true,否则返回false
        /// </summary>
        /// <param name="tabName">子窗体的窗体名称</param>
        /// <returns></returns>
        private bool IsOpenTab(string tabName)
        {
            bool isOpened = false;

            foreach (TabItem tab in tabStrip1.Tabs)
            {
                if (tab.Text.Trim() == tabName)
                {
                    isOpened = true;
                    tabStrip1.SelectedTab = tab;
                    break;
                }
            }

            return isOpened;
        }

        private void ribbonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem_dianya_Click(object sender, EventArgs e)
        {
            
           string tabName = "三相电压";

            if (!IsOpenTab(tabName))
            {

                FormJianKongDianYa doc = new FormJianKongDianYa();
                doc.MdiParent = this;
                doc.WindowState = FormWindowState.Maximized;
                doc.Show();
                doc.Update();
            }
          

         
        }

        private void buttonItem_dianliu_Click(object sender, EventArgs e)
        {
            string tabName = "三相电流";

            if (!IsOpenTab(tabName))
            {

                FormJianKongDianLiu doc = new FormJianKongDianLiu();
                doc.MdiParent = this;
                doc.WindowState = FormWindowState.Maximized;
                doc.Show();
                doc.Update();
            }
        }

        private void buttonItem26_Click(object sender, EventArgs e)
        {
            Formchaxun s = new Formchaxun();
            s.Show();   
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            Formjibentongji s = new Formjibentongji();
            s.Show();
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            Formdianya s = new Formdianya();
            s.Show();
        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {
            Formpinshufebxi17 s = new Formpinshufebxi17();
            s.Show();
        }

        private void buttonItem19_Click(object sender, EventArgs e)
        {
            Formzuzhongzhi14 a = new Formzuzhongzhi14();
            a.Show();
        }

        private void buttonItem20_Click(object sender, EventArgs e)
        {
            Formdongtaiqushifenxi18 b = new Formdongtaiqushifenxi18();
            b.Show();
        }

        private void buttonItem21_Click(object sender, EventArgs e)
        {
            Form19fangchafenxi c = new Form19fangchafenxi();
            c.Show();
        }

        private void buttonItem22_Click(object sender, EventArgs e)
        {
            Formjuleifenxi20 d = new Formjuleifenxi20();
            d.Show();
        }

        private void buttonItem27_Click(object sender, EventArgs e)
        {
            Formshujudaoru26 s = new Formshujudaoru26();
            s.Show();
        }

        private void buttonItem40_Click(object sender, EventArgs e)
        {
            Formxingchengbaobiao23 s = new Formxingchengbaobiao23();
            s.Show();
        }

        private void buttonItem28_Click(object sender, EventArgs e)
        {
            ld s = new ld();
            s.Show();
        }

        private void buttonItem24_Click(object sender, EventArgs e)
        {
            bjls s = new bjls();
            s.Show();
        }

        private void buttonItem25_Click(object sender, EventArgs e)
        {

        }




     
    }
}
