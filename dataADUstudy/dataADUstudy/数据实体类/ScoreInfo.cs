using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections; 

namespace dataADUstudy.数据实体类
{
    class ScoreInfo
    {
        //创建list存储查询的结果集
        public static ArrayList id = new ArrayList();   //存储成绩表id
        public static ArrayList number = new ArrayList();//存储成绩表学号、教师编号
        public static ArrayList xueqi = new ArrayList();//存储成绩表课程归属
        public static ArrayList kecheng = new ArrayList();//存储成绩表中的课程名
        public static ArrayList chengji = new ArrayList();//存储成绩表的成绩
        public static ArrayList name = new ArrayList();//存储成绩表的学生名
    }
}
