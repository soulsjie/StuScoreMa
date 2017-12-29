using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections; 

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
        public static Boolean isadmin=false;      //管理员标记
        //创建list存储查询的用户信息结果集
        public static ArrayList idList = new ArrayList();   //用户id
        public static ArrayList usernameList = new ArrayList();//用户名
        public static ArrayList passwordList = new ArrayList();//登录密码
        public static ArrayList SfList = new ArrayList();//用户身份
        public static ArrayList numberList = new ArrayList();//用户编号
        public static ArrayList banjiList = new ArrayList();//所属班级
    }
}
