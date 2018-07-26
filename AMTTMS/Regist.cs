using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMTTMS
{
    public class Regist
    {
        AMTTMS_MYSQL amttmsmysql = new AMTTMS_MYSQL();
        /*打开数据库*/
        public void Regist_Open_MySQL()
        {
            
            if (amttmsmysql.MySqlOpen())
            {
                MessageBox.Show("打开数据库成功！");
            }
            else
            {
                MessageBox.Show("打开数据库失败或没有关闭数据库！");
            }
        }

        /*关闭数据库*/
        public void Regist_Close_MySQL()
        {
            if (amttmsmysql.MySqlClose())
            {
                MessageBox.Show("关闭数据库成功！");
            }
            else
            {
                MessageBox.Show("关闭数据库失败或没有打开数据库！");
            }
        }
        /*验证某一字段是否与数据库字段相匹配*/
        public string Regist_Search_gameid(string gameid)
        {
            return amttmsmysql.MySQL_Search_Gameid(gameid);
        }
        /*用户注册*/
        public void Regist_User(string username, string userpass, string gamename, string gameid)
        {
            if (amttmsmysql.MySQL_Regist_User(username, userpass, gamename, gameid))
            {
                MessageBox.Show("恭喜，" + username + "注册成功", "注册成功");
            }
            else
            {
                MessageBox.Show("很遗憾，" + username + "注册失败", "注册失败");
            }
        }

        //用户是否重复注册
        public bool Regist_Multiple(string gameid, string username, string gamename)
        {
            if (amttmsmysql.MySQL_Regist_Multiple(gameid, username, gamename))
                return true;
            return false;
        }

    }
}
