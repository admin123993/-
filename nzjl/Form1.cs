using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nzjl
{
    public partial class window : Form
    {
        public window()
        {
            InitializeComponent();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 如何领取ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("很简单\n看见那个“领取”按钮了吧，对就是它\n然后对着那个按钮按下鼠标左键就可以了", "很简单", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("explorer.exe", "https://www.bilibili.com/video/BV1UT42167xb/");
        }

        private void 关于恭喜你中大奖了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new 关于();
            form.ShowDialog();
        }
    }
}
