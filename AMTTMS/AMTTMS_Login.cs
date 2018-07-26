using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMTTMS
{
    public partial class AMTTMS_Login : Form
    {
        public AMTTMS_Login()
        {
            InitializeComponent();
        }

        private void AMTTMS_Login_Load(object sender, EventArgs e)
        {
            String message = "欢迎使用本软件,有任何疑问或意见请联系作者AM.老僧，版本v1.0.0，联系QQ：3029197009，版权所有AM技术组by凌梦工作室，仅供学习，请勿用于商业用途!";
            String caption = "信息提示";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Information;

            if (MessageBox.Show(message, caption, buttons, icon) == DialogResult.No)
                Application.Exit();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出吗？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            Application.Exit();
        }

        private void btn_regist_Click(object sender, EventArgs e)
        {
            new AMTTMS_Regist().Show();
            this.Hide();
        }
    }
}
