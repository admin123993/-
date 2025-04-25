using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace nzjl
{
    public partial class 关于 : Form
    {
        public 关于()
        {
            InitializeComponent();
        }

        private void 关于_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://www.bilibili.com/video/BV1UT42167xb/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetDataObject("https://www.bilibili.com/video/BV1UT42167xb/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("复制失败，" + ex, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("复制成功", "复制链接", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
