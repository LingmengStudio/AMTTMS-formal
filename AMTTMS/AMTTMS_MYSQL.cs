using System;
using System.Collections;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace AMTTMS
{
    public class AMTTMS_MYSQL
    {
        /*连接数据库*/
        //数据库连接字符串 
        static string strConn = "Database='AMTTMS';Data Source='192.161.49.116';User Id='root';Password='TangHao@733';charset='utf8';pooling=true";
        //连接并数据库
        MySqlConnection objConnection = new MySqlConnection(strConn);
        public bool MySqlOpen()
        {
            
            //判断数据库是否连接成功
            try
            {
                objConnection.Open();
                return true;
                //MessageBox.Show("数据库连接成功");
                //objConnection.Close();
            }
            catch
            {
                //MessageBox.Show("数据库连接失败！");
                return false;
            }
        }

        /*关闭数据库*/
        public bool MySqlClose()
        {
            //判断数据库是否关闭成功
            try
            {
                objConnection.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }
        /*在数据库中进行查询操作*/
        //在数据库中查询gameid
        public string MySQL_Search_Gameid(string gameid)
        {
            //执行数据库语句
            string sql = "select AMTTMS_USER_GAMEID from AMTTMS_USER where AMTTMS_USER_GAMEID=" + gameid;
            MySqlCommand cmd = new MySqlCommand(sql, objConnection);
            object result = cmd.ExecuteScalar();
            return this.toString(result);
        }

        public string toString(object obj)
        {
            return (obj == null ? "" : obj.ToString());
        }

        //给数据库添加注册数据
        public bool MySQL_Regist_User(string username, string userpass, string gamename, string gameid)
        {
            int user_regist = 1;
            string sql = "update AMTTMS_USER set AMTTMS_USER_NAME=@username, AMTTMS_USER_PASS=@userpass, AMTTMS_USER_GAMENAME=@gamename, AMTTMS_USER_REGIST=@regist where AMTTMS_USER_GAMEID=@gameid";
            MySqlCommand cmd = new MySqlCommand(sql, objConnection);
            
            MySqlParameter usernameparm = new MySqlParameter("@username", username);
            cmd.Parameters.Add(usernameparm);

            MySqlParameter userpassparm = new MySqlParameter("@userpass", userpass);
            cmd.Parameters.Add(userpassparm);

            MySqlParameter gamenameparm = new MySqlParameter("@gamename", gamename);
            cmd.Parameters.Add(gamenameparm);

            MySqlParameter registparm = new MySqlParameter("@regist", user_regist);
            cmd.Parameters.Add(registparm);

            MySqlParameter gameidparm = new MySqlParameter("@gameid", gameid);
            cmd.Parameters.Add(gameidparm);

            int result = cmd.ExecuteNonQuery();
            return true;
        }
        
        //在数据库查询注册字段是否为1，如果true返回表示用户已经注册，如果假表示用户没有注册
        public bool MySQL_Regist_Multiple(string gameid, string username, string gamename)
        {
            string regist = null;
            string registUserName = null;
            string registGameName = null;
            bool isRegist = false;
            //执行数据库语句
            string strsql = "SELECT * FROM AMTTMS_USER WHERE AMTTMS_USER_GAMEID=" + gameid;
            MySqlCommand cmd = new MySqlCommand(strsql,objConnection);

            DataSet dataSet = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dataSet, "AMTTMS_USER");

            DataTable dataTable = dataSet.Tables["AMTTMS_USER"];
            int num = dataTable.Rows.Count;
            //MessageBox.Show(num.ToString());
            foreach (DataRow row in dataTable.Rows)
            {
                regist = row[4].ToString();
                registUserName = row[0].ToString();
                registGameName = row[3].ToString();
                //MessageBox.Show(result);
            }

            if ((regist == "1") || (registUserName == username) || (registGameName == gamename))
            {
                isRegist = true;
            }
            return isRegist;
            
        }

    }
}
