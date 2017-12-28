using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dataADUstudy.数据实体类;
using dataADUstudy.工具类;
using dataADUstudy;

namespace dataADUstudy.窗口程序
{
    //用户注册界面
    public partial class regist : Form
    {
        public regist()
        {
            InitializeComponent();
        }
        //注册界面初始化
        private void regist_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;        //关闭登录窗口的最大化功能
            RegistIdentity.SelectedIndex = 2;//设置下拉菜单的默认选项
            //将所有提示信息的lable置空
            label8 .Text= "";
            label9.Text = "";
            label11.Text = "";
            label12.Text = "";
            button1.Enabled = false; //用户未输入注册信息时，默认注册按钮不可点击
            PuanDuanSF.panduanshenfen(RegistIdentity.SelectedIndex);//根据用户选择的值判断用户身份
            if(quanju.sf.Equals("s")){
                label2.Text = "学生注册";
                this.Text = "学生注册";
            }
            else{
                label2.Text = "教师注册";
                this.Text = "教师注册";
            }
            label2.Text = "选择身份";
            this.Text = "注册";
            Verification_Code.Text = YanZhenMa.Code(); //加载验证码
            panel1.Visible = false;  //未选择注册身份之前默认不显示所有输入框
        }
        //选择用户身份改变时触发的事件
        private void RegistIdentity_SelectedIndexChanged(object sender, EventArgs e)
        {
            PuanDuanSF.panduanshenfen(RegistIdentity.SelectedIndex);//根据用户选择的值判断用户身份
            if (quanju.sf.Equals("s"))
            {
                label2.Text = "学生注册";
                this.Text = "学生注册";
                label6.Text = "学号：";
            }
            else
            {
                label2.Text = "教师注册";
                this.Text = "教师注册";
                label6.Text = "教师编号：";
            }
            Verification_Code.Text = YanZhenMa.Code(); //刷新验证码
            panel1.Visible = true;//显示用户输入面板
            if (RegistIdentity.SelectedIndex == 2) {
                label2.Text = "选择身份";
                this.Text = "注册";
                panel1.Visible = false;
            }
        }
        //当用户输入用户名完成时验证用户名是否可以注册
        private void RGname_Leave(object sender, EventArgs e)
        {
            DBlink db = new DBlink();   //创建数据库连接对象
            if (db.DBconn()) {          //创建数据库连接
                string str = "select * from login_info where SF='" + quanju.sf + "'and username='" + RGname.Text + "'";
                if (db.GetLoginData(str))//执行sql检测该用户是否已经被注册
                {
                    label9.Text = "该用户已经存在!";
                }
                else {
                    label9.Text = "恭喜，可以注册!";
                }
            }
            db.DBclose();   //关闭数据库连接

        }
        //当第二次输入密码被弹起时验证密码是否一致
        private void RGpass2_KeyUp(object sender, KeyEventArgs e)
        {
            if (!RGpass.Text.Equals(RGpass2.Text))
            {
                label8.Text = "密码不一致！";
            }
            else
            {
                label8.Text = "";
            }
        }
        //当第二次输入密码被弹起时验证密码是否一致
        private void code_KeyUp(object sender, KeyEventArgs e)
        {
            if (!code.Text.Equals(Verification_Code.Text))
            {
                label12.Text = "验证码错误！";
                button1.Enabled = false;
            }
            else
            {
                label12.Text = "";
                button1.Enabled = true;
            }
        }
        //注册事件
        private void button1_Click_1(object sender, EventArgs e)
        {
            DBlink db = new DBlink();   //创建数据库连接对象
            if (db.DBconn()) { //连接数据库
                string str ="insert into login_info(username,pass,SF,number,banji) values('"+RGname.Text+"','"+RGpass.Text+"','"+quanju.sf+"','"+RGnumber.Text+"','"+RGbanji.Text+"');";
                if (db.UpdataDeletAdd(str)) {
                    DialogResult dr = MessageBox.Show("注册成功返回登录", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        this.Visible = false;//隐藏当前窗口
                    }
                }
            }
            db.DBclose();//关闭数据连接
        }
        //取消事件
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
