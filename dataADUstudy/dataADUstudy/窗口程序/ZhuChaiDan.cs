using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dataADUstudy.数据实体类;
using dataADUstudy.窗口程序;

namespace dataADUstudy
{
    public partial class ZhuChaiDan : Form
    {
        //生成注册界面的新窗口并将其隐藏，在管理员点击添加新用户时才使其显示
        regist RG = new regist();
        public ZhuChaiDan()
        {
            InitializeComponent();
        }
//--------------------------------------------------------------主菜单初始化---------------------------------------------
        private void ZhuChaiDan_Load(object sender, EventArgs e)
        {
            RG.Visible = false;             //隐藏注册面板
            adminmnue.Visible = false;      //隐藏管理员菜单
            stumnue.Visible = false;        //隐藏学生菜单
            teamnue.Visible = false;        //隐藏教师菜单
            dataGridView1.Visible = false;  //隐藏显示成绩信息的dataGridView
            GeRenChengji_op.Visible = false;//隐藏个人成绩查询操作面板
            MaximizeBox = false;            //关闭主菜单窗口的最大化功能
            dataGridView2.Visible = false;  //隐藏显示用户信息的dataGridView
            daishenghe.Visible = false;     //隐藏管理员进行审核操作的面板
            panel1.Visible = false;         //隐藏删除操作的面板
            label3.Text = "";               //提示信息为空
            label5.Text = "";               //提示信息为空
            button1.Enabled = false;        //审核按钮不可点击
            button2.Enabled = false;        //删除用户按钮不可点击
            Search_TS.Text = "";            //查询成绩的提示信息置空

            //根据登录系统的身份不同，提示不同欢迎语和显示主菜单
            if(LoginInfo.sf.Equals("s")){
                this.Text =LoginInfo.username+ "同学您好！欢迎使用学生成绩管理系统。";
                stumnue.Visible = true;     //显示学生菜单
            }
            else if (LoginInfo.sf.Equals("t")){
                this.Text = LoginInfo.username + "老师您好！欢迎使用学生成绩管理系统。";
                teamnue.Visible = true;     //显示教师菜单
            }
            else if (LoginInfo.sf.Equals("a"))
            {
                this.Text = LoginInfo.username + "管理员您好！欢迎使用学生成绩管理系统。";
                adminmnue.Visible = true;   //显示管理员菜单
               
            }
        }
//--------------------------------------------------------------管理员功能---------------------------------------------
 //一、审核管理
//1.待审核
        //待审核列表
        public void 待审核ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBlink db = new DBlink();       //创建数据库连接实例
            if (db.DBconn())
            {              //打开数据库连接
                db.GetUserInfoData("select * from login_info where tag=0");
            }
            db.DBclose();//关闭数据库连接
            dataGridView2.Rows.Clear(); //初始化dataGridView
            for (int i = 0; i < LoginInfo.idList.Count; i++)    //循环将数据实体类的数据存放到dataGridView中
            {
                int index = this.dataGridView2.Rows.Add();
                //实现隔行换色
                if (i % 2 == 0)
                {
                    this.dataGridView2.Rows[index].DefaultCellStyle.BackColor = Color.Gainsboro;//双数行
                }
                else
                {
                    this.dataGridView2.Rows[index].DefaultCellStyle.BackColor = Color.GhostWhite;//单数行
                }
                this.dataGridView2.Rows[index].Cells[0].Value = LoginInfo.idList[i];      //填充序号
                this.dataGridView2.Rows[index].Cells[1].Value = LoginInfo.usernameList[i];//填充用户名
                this.dataGridView2.Rows[index].Cells[2].Value = LoginInfo.passwordList[i];//填充密码
                if (LoginInfo.SfList[i].Equals("s"))                                      //根据SF的值填充用户身份
                {
                    this.dataGridView2.Rows[index].Cells[3].Value = "学生";
                }
                else if (LoginInfo.SfList[i].Equals("t"))
                {
                    this.dataGridView2.Rows[index].Cells[3].Value = "教师";
                }
                else
                {
                    this.dataGridView2.Rows[index].Cells[3].Value = "管理员";
                }
                this.dataGridView2.Rows[index].Cells[4].Value = LoginInfo.numberList[i];//填充用户编号
                this.dataGridView2.Rows[index].Cells[5].Value = LoginInfo.banjiList[i];//填充用户所属班级
            }
            //控制显示用户信息数据的dataGridView出现的位置
            dataGridView2.Top = 25;
            dataGridView2.Left = 30;
            dataGridView2.Height = 350;
            dataGridView2.Visible = true;//显示数据集
            //控制操作的出现位置，给控件赋值
            daishenghe.Top = 400;
            daishenghe.Left = 30;
            daishenghe.Visible = true;  //显示审核操作面板
            panel1.Visible = false;     //隐藏删除操作面板
            RG.Visible = false;//隐藏注册窗体
            
        }
        //管理员输入审核用户名时验证该用户是否存在，并提示
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            DBlink db = new DBlink();
            if (db.DBconn())
            {
                string str = "select * from login_info where tag=0 and username='" + textBox1.Text + "'";
                if (db.search(str))
                {
                    label3.Text = "*该用户未审核！";
                    button1.Enabled = true;
                }
                else
                {
                    label3.Text = "*用户不存在！";
                    button1.Enabled = false;
                }
            }
        }
        //管理员审核按钮点击事件
        private void button1_Click(object sender, EventArgs e)
        {
            string str = "update login_info set tag=1 where username='" + textBox1.Text + "'";
            DBlink db = new DBlink();
            if (db.DBconn())
            {
                if (db.UpdataDeletAdd(str))//修改当前用户的tag标志
                {
                    DialogResult dr = MessageBox.Show("用户" + textBox1.Text + "审核成功！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    待审核ToolStripMenuItem_Click(null, null);//重新加载数据
                    //将用户输入的内容和提示信息文本置空
                    textBox1.Text = "";
                    label3.Text = "";
                }
            }
        }
 //2.已审核
        private void 审核ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBlink db = new DBlink();       //创建数据库连接实例
            if (db.DBconn())
            {              //打开数据库连接
                db.GetUserInfoData("select * from login_info where tag=1");
            }
            db.DBclose();//关闭数据库连接
            dataGridView2.Rows.Clear(); //初始化dataGridView
            for (int i = 0; i < LoginInfo.idList.Count; i++)    //循环将数据实体类的数据存放到dataGridView中
            {
                int index = this.dataGridView2.Rows.Add();
                //实现隔行换色
                if (i % 2 == 0)
                {
                    this.dataGridView2.Rows[index].DefaultCellStyle.BackColor = Color.Gainsboro;//双数行
                }
                else
                {
                    this.dataGridView2.Rows[index].DefaultCellStyle.BackColor = Color.GhostWhite;//单数行
                }
                this.dataGridView2.Rows[index].Cells[0].Value = LoginInfo.idList[i];      //填充序号
                this.dataGridView2.Rows[index].Cells[1].Value = LoginInfo.usernameList[i];//填充用户名
                this.dataGridView2.Rows[index].Cells[2].Value = LoginInfo.passwordList[i];//填充密码
                if (LoginInfo.SfList[i].Equals("s"))                                      //根据SF的值填充用户身份
                {
                    this.dataGridView2.Rows[index].Cells[3].Value = "学生";
                }
                else if (LoginInfo.SfList[i].Equals("t"))
                {
                    this.dataGridView2.Rows[index].Cells[3].Value = "教师";
                }
                else
                {
                    this.dataGridView2.Rows[index].Cells[3].Value = "管理员";
                }
                this.dataGridView2.Rows[index].Cells[4].Value = LoginInfo.numberList[i];//填充用户编号
                this.dataGridView2.Rows[index].Cells[5].Value = LoginInfo.banjiList[i];//填充用户所属班级
            }
            //控制显示用户信息数据的dataGridView出现的位置
            dataGridView2.Top = 25;
            dataGridView2.Left = 30;
            dataGridView2.Height = 350;
            dataGridView2.Visible = true;//显示数据集
            daishenghe.Visible = false;//隐藏操作面板
            panel1.Visible = false;//隐藏删除操作面板
            RG.Visible = false;//隐藏注册窗体
        }
 //二、用户管理
//1.添加用户
        private void 添加用户ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginInfo.isadmin = true;//将数据实体类中的管理员表示置为true，注册时判断该值执行不同sql
            RG.Visible = true;//显示注册窗体
            //RG.Show();
        } 
//2.删除用户
        private void 删除用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBlink db = new DBlink();       //创建数据库连接实例
            if (db.DBconn())
            {              //打开数据库连接
                db.GetUserInfoData("select * from login_info");
            }
            db.DBclose();//关闭数据库连接
            dataGridView2.Rows.Clear(); //初始化dataGridView
            for (int i = 0; i < LoginInfo.idList.Count; i++)    //循环将数据实体类的数据存放到dataGridView中
            {
                int index = this.dataGridView2.Rows.Add();
                //实现隔行换色
                if (i % 2 == 0)
                {
                    this.dataGridView2.Rows[index].DefaultCellStyle.BackColor = Color.Gainsboro;//双数行
                }
                else
                {
                    this.dataGridView2.Rows[index].DefaultCellStyle.BackColor = Color.GhostWhite;//单数行
                }
                this.dataGridView2.Rows[index].Cells[0].Value = LoginInfo.idList[i];      //填充序号
                this.dataGridView2.Rows[index].Cells[1].Value = LoginInfo.usernameList[i];//填充用户名
                this.dataGridView2.Rows[index].Cells[2].Value = LoginInfo.passwordList[i];//填充密码
                if (LoginInfo.SfList[i].Equals("s"))                                      //根据SF的值填充用户身份
                {
                    this.dataGridView2.Rows[index].Cells[3].Value = "学生";
                }
                else if(LoginInfo.SfList[i].Equals("t")){
                    this.dataGridView2.Rows[index].Cells[3].Value = "教师";
                }
                else
                {
                    this.dataGridView2.Rows[index].Cells[3].Value = "管理员";
                }

                this.dataGridView2.Rows[index].Cells[4].Value = LoginInfo.numberList[i];//填充用户编号
                this.dataGridView2.Rows[index].Cells[5].Value = LoginInfo.banjiList[i];//填充用户所属班级
            }
            //控制显示用户信息数据的dataGridView出现的位置
            dataGridView2.Top = 25;
            dataGridView2.Left = 30;
            dataGridView2.Height = 350;
            dataGridView2.Visible = true;//显示数据集
            //控制操作的出现位置，给控件赋值
            panel1.Top = 400;
            panel1.Left = 30;
            panel1.Visible = true;  //显示删除操作面板
            daishenghe.Visible = false; //隐藏审核操作面板
            RG.Visible = false;         //隐藏注册窗体
        }
        //管理员输入审核用户名时验证该用户是否存在，并提示
        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            DBlink db = new DBlink();
            if (db.DBconn())
            {
                string str = "select * from login_info where username='" + textBox2.Text + "'";
                if (db.search(str))
                {
                    label5.Text = "*删除用户！" + textBox2.Text+"?请点击删除按钮";
                    button2.Enabled = true;
                }
                else
                {
                    label5.Text = "*用户不存在！";
                    button2.Enabled = false;
                }
            }
        }
        //删除用户的按钮事件
        private void button2_Click(object sender, EventArgs e)
        {

            string str = "delete from login_info where username='" + textBox2.Text + "' and SF!= 'a'";
            DBlink db = new DBlink();
            if (db.DBconn())
            {
                if (db.UpdataDeletAdd(str))//修改当前用户的tag标志
                {
                    DialogResult dr = MessageBox.Show("用户" + textBox1.Text + "删除成功！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    删除用户ToolStripMenuItem_Click(null, null);//重新加载数据
                    //将用户输入的内容和提示信息文本置空
                    textBox2.Text = "";
                    label5.Text = "";

                }

            }
        }
//三、退出系统
        private void 退出登录ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }
//--------------------------------------------------------------教师功能---------------------------------------------
 //一、成绩查询
 //1.查询所有成绩
        //查询所有成绩
        private void 查询所有成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //控制显示学生成绩的控件的初始位置
            dataGridView1.Top = 25;
            dataGridView1.Left = 30;
            dataGridView1.Height = 350;
            dataGridView1.Rows.Clear(); //初始化dataGridView
            dataGridView1.Visible = true;   //显示控件
            GeRenChengji_op.Visible = false;
            DBlink db = new DBlink();       //创建数据库连接实例
            if (db.DBconn())                //连接数据库
            {

                db.GetScoreData("select * from student_score"); //执行sql
            }
            db.DBclose();                   //关闭数据库连接

            for (int i = 0; i < ScoreInfo.id.Count; i++)    //循环将数据实体类的数据存放到dataGridView中
            {
                int index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = ScoreInfo.id[i];        //填充编号
                this.dataGridView1.Rows[index].Cells[1].Value = ScoreInfo.number[i];    //填充学号
                this.dataGridView1.Rows[index].Cells[2].Value = ScoreInfo.xueqi[i];     //填充课程归属
                this.dataGridView1.Rows[index].Cells[3].Value = ScoreInfo.kecheng[i];   //填充课程名
                this.dataGridView1.Rows[index].Cells[4].Value = ScoreInfo.chengji[i];   //填充成绩
                this.dataGridView1.Rows[index].Cells[5].Value = ScoreInfo.name[i];      //填充姓名
            }
        }
//2.查询个人成绩
        private void 个人成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //设置dataGridView1的属性
            dataGridView1.Top = 25;
            dataGridView1.Left = 30;
            dataGridView1.Height = 350;
            dataGridView1.Rows.Clear(); //初始化dataGridView
            dataGridView1.Visible = true;   //显示控件
            //初始化个人成绩查询出现的面板
            GeRenChengji_op.Top = 400;
            GeRenChengji_op.Left = 30;
            GeRenChengji_op.Visible = true;  //显示个人成绩查询的操作面板
        }
        //教师输入要查询的学号时验证该学号的成绩信息是否已经存在
        private void StuNum_in_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1.Rows.Clear(); //初始化dataGridView
            DBlink db = new DBlink();
            Boolean tag = false;    //辅助标记，先查询该学号是否存在，若存在再进行数据查询的操作
            string str = "select * from login_info where number='" + StuNum_in.Text + "'";
            if (db.DBconn()) {//连接数据库成功
                if (db.search(str)) {
                    Search_TS.Text = "查询到" + StuNum_in.Text+"同学的成绩信息如上！";
                    tag = true;
                }
                else{
                    Search_TS.Text = "该用户不存在";
                }
            }
            db.DBclose();//避免多线程操作数据库，影响系统报错，先关闭数据连接

            if (tag) {  //输入的学号在用户名中存在
                if (db.DBconn()) {
                    db.GetScoreData("select * from student_score where number='" + StuNum_in.Text + "'"); //执行sql
                    for (int i = 0; i < ScoreInfo.id.Count; i++)    //循环将数据实体类的数据存放到dataGridView中
                    {
                        int index = this.dataGridView1.Rows.Add();
                        this.dataGridView1.Rows[index].Cells[0].Value = ScoreInfo.id[i];        //填充编号
                        this.dataGridView1.Rows[index].Cells[1].Value = ScoreInfo.number[i];    //填充学号
                        this.dataGridView1.Rows[index].Cells[2].Value = ScoreInfo.xueqi[i];     //填充课程归属
                        this.dataGridView1.Rows[index].Cells[3].Value = ScoreInfo.kecheng[i];   //填充课程名
                        this.dataGridView1.Rows[index].Cells[4].Value = ScoreInfo.chengji[i];   //填充成绩
                        this.dataGridView1.Rows[index].Cells[5].Value = ScoreInfo.name[i];      //填充姓名
                    }
                }
                db.DBclose();
            }
        }
//二、账号管理
 //1.修改登录密码
//三、退出系统
        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
//--------------------------------------------------------------学生功能---------------------------------------------
//一、成绩查询
 //1.查询个人成绩
        private void 个人成绩查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.Top = 25;
            dataGridView1.Left = 30;
            dataGridView1.Height = 350;
            dataGridView1.Rows.Clear(); //初始化dataGridView
            dataGridView1.Visible = true;   //显示控件
            DBlink db = new DBlink();
            if (db.DBconn())
            {
                db.GetScoreData("select * from student_score where number='" + LoginInfo.number + "'"); //执行sql
                for (int i = 0; i < ScoreInfo.id.Count; i++)    //循环将数据实体类的数据存放到dataGridView中
                {
                    int index = this.dataGridView1.Rows.Add();
                    this.dataGridView1.Rows[index].Cells[0].Value = ScoreInfo.id[i];        //填充编号
                    this.dataGridView1.Rows[index].Cells[1].Value = ScoreInfo.number[i];    //填充学号
                    this.dataGridView1.Rows[index].Cells[2].Value = ScoreInfo.xueqi[i];     //填充课程归属
                    this.dataGridView1.Rows[index].Cells[3].Value = ScoreInfo.kecheng[i];   //填充课程名
                    this.dataGridView1.Rows[index].Cells[4].Value = ScoreInfo.chengji[i];   //填充成绩
                    this.dataGridView1.Rows[index].Cells[5].Value = ScoreInfo.name[i];      //填充姓名
                }
            }
            db.DBclose();
           
        }
//二、账号管理
 //1.修改登录密码
 //三、退出系统
        private void 退出登录ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

//--------------------------------------------------------------窗体退出按钮被点击时---------------------------------------------
        private void ZhuChaiDan_Closing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否退出本系统?", "确认...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
