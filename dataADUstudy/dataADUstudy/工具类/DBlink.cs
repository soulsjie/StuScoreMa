using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data.OleDb;
using dataADUstudy.数据实体类;

namespace dataADUstudy
{
    //创建数据库连接的工具类
    class DBlink
    {
        MySqlConnection sqlCnn = new MySqlConnection(); //创建数据库连接对象
        MySqlCommand sqlCmd = new MySqlCommand();       //创建执行sql的对象
        //LoginInfo lgI = new LoginInfo();    //创建登录数据的实例
        public Boolean DBtag=false;
        //创建数据库连接
        public Boolean DBconn()
        {
            sqlCnn.ConnectionString = "server = '127.0.0.1'; uid = 'root'; pwd = ''; database = 'student_manage_system';";//连接字符串
            sqlCmd.Connection = sqlCnn;
            try
            {
                sqlCnn.Open();
                DBtag = true;
                if (DBtag) {
                    Console.WriteLine("数据库连接成功");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "error");
                Console.WriteLine(ex.Message);
                Console.WriteLine("数据库连接失败");
            }
            finally
            {
                //textBox2.AppendText("数据库连接关闭！");
                
            }
            return DBtag;
        }
       
        //执行查询的sql
        public MySqlDataReader search(String str)
        {
            sqlCmd.CommandText = str;
            MySqlDataReader rec = sqlCmd.ExecuteReader();//创建结果集
            while (rec.Read())
            {
                Console.WriteLine(rec.GetInt32(0));
                Console.WriteLine(rec.GetString(1));
                Console.WriteLine(rec.GetString(2));
            }
            return rec;
        }
        //执行增删改的sql
        public Boolean UpdataDeletAdd(string str)
        {
            sqlCmd.CommandText = str;
            return sqlCmd.ExecuteNonQuery()>0;  
        }
        //关闭数据库连接
        public void DBclose()
        {
            sqlCnn.Close();
            Console.WriteLine("数据库连接关闭");
            //Console.ReadKey();
        }
        //获取login所需要的数据
        public Boolean GetLoginData(string str) {
            sqlCmd.CommandText = str;
            MySqlDataReader rec = sqlCmd.ExecuteReader();//创建结果集
            while (rec.Read())  //查询到数据结果
            {
                LoginInfo.username = rec.GetString(1);  //将用户名存放到数据实体类
                LoginInfo.password = rec.GetString(2);  //将密码存放在数据实体类
                LoginInfo.sf = rec.GetString(3);      //将身份标记存放到数据实体类
                LoginInfo.tag = rec.GetInt32(4);      //将审核标记存放在数据实体类
                Console.WriteLine("查询到的信息：用户名{0},密码{1},身份标记{2},审核标记{3}", LoginInfo.username, LoginInfo.password, LoginInfo.sf, LoginInfo.tag);
                return true;    //查询到用户数据
            }
            return false;
        }
    }
}
