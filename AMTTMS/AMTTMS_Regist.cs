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
            
    public partial class AMTTMS_Regist : Form
    {
        string username = null;
        string userpass = null;
        string gamename = null;
        string gameid = null;
        Regist regist = new Regist();
        public AMTTMS_Regist()
        {
            InitializeComponent();
        }

        private void btn_user_regist_Click(object sender, EventArgs e)
        {
            this.username = txt_regist_name.Text;
            this.userpass = txt_regist_pass.Text;
            this.gamename = txt_regist_gamename.Text;
            this.gameid = txt_regist_gameid.Text;
            
            //验证注册信息不为空
            if (username == "")
            {
                MessageBox.Show("用户名不能为空！","信息提示");
            }
            else if (userpass == "")
            {
                MessageBox.Show("密码不能为空！", "信息提示");
            }
            else if (gameid == "")
            {
                MessageBox.Show("游戏ID不能为空！", "信息提示");
            }
            else if (gamename == "")
            {
                MessageBox.Show("游戏名不能为空！", "信息提示");
            }
            else
            {
                this.Regist_User();
            }         
        }

        public void Regist_User()
        {
            //连接数据库
            regist.Regist_Open_MySQL();
            //验证是否是AM技术组内部成员成员
            if ((regist.Regist_Search_gameid(gameid)) == "")
            {
                MessageBox.Show("抱歉，该游戏ID所有者为非AM技术组内部成员");
                //关闭数据库
                regist.Regist_Close_MySQL();
                Application.Exit();
            }
            else
            {
                if ((regist.Regist_Search_gameid(gameid) == gameid))
                {
                    //MessageBox.Show(gameid);
                    //验证用户是否重复注册
                    if (regist.Regist_Multiple(gameid, username, gamename))
                    {
                        MessageBox.Show("用户名或游戏名或游戏ID已经注册！");
                    }
                    else
                    {
                        //用户进行注册
                        regist.Regist_User(username, userpass, gamename, gameid);

                    }
                }

            }
            regist.Regist_Close_MySQL();
        }
    }
}
