using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dataADUstudy.数据实体类
{
    class LoginInfo
    {
        //保存用户登录信息的数据实体
        public static string username;//用户名
        public static string password;//密码
        public static int tag;        //审核标记
        public static string sf;      //身份标记
        public static string number;  //学号--学生信息表中的主键
        public static string banji;   //班级
    }
}
