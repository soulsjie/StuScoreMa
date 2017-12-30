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

namespace dataADUstudy.窗口程序
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        //登录窗口初始化
        private void login_Load(object sender, EventArgs e)
        {
            label6.Text = "";
            identity.SelectedIndex = 0; //登录系统的身份默认是学生
            MaximizeBox = false;        //关闭登录窗口的最大化功能
            Verification_Code.Text=YanZhenMa.Code();                     //动态生成验证码
            DoLogin.Enabled = false;    //默认在不输入验证码时无法点击登录按钮
//-------------------------测试数据开始-------------------------
            //学生测试数据
            //Tusername.Text = "jie";
            //Tpass.Text = "jie";

            //管理员测试数据
            //Tusername.Text = "ad";
            //Tpass.Text = "ad";
            //identity.SelectedIndex = 2;

            //教师测试数据
            //Tusername.Text = "te";
            //Tpass.Text = "te";
            //identity.SelectedIndex = 1;

            //Verification_Code_in.Text = Verification_Code.Text;//测试时将填写验证码的步骤省略
            //DoLogin.Enabled = true;    //辅助测试
//-------------------------测试数据结束-------------------------
            
            
        }
        
        //实时验证用户输入验证码是否正确
        private void Verification_Code_in_KeyUp(object sender, EventArgs e)
        {
            if (Verification_Code_in.Text != Verification_Code.Text)
            {
                label6.Text = "验证码错误！";
            }
            else
            {
                label6.Text = "";
                DoLogin.Enabled = true;
            }
        }
        //验证用户登录
        private void DoLogin_Click(object sender, EventArgs e)
        {
            DBlink db = new DBlink();//创建数据库连接对象
            PuanDuanSF.panduanshenfen(identity.SelectedIndex);//根据用户选择的值判断用户身份
            if (db.DBconn()) { 
                //数据库连接成功
                if (db.GetLoginData("select * from login_info where SF='" + quanju.sf + "'and username='" + Tusername.Text + "'"))
                {
                    //用户存在
                    if (LoginInfo.tag == 1)//账号已被审核允许登录
                    {
                        if (Tpass.Text.Equals(LoginInfo.password))//登录成功
                        {
                            ZhuChaiDan zcd = new ZhuChaiDan();
                            zcd.Show();     //显示主菜单界面
                        }
                        else {  //密码错误
                            label6.Text = "密码错误！";
                        }
                    }
                    else {  //账号未审核
                        label6.Text = "该账号未审核，请联系管理员";
                    }
                }
                else {
                    label6.Text = "登录失败，用户名不存在！";
                }
            }
            db.DBclose();//关闭数据库连接
        }
        //用户点击取消事件
        private void DoNo_Click(object sender, EventArgs e)
        {
            Verification_Code.Text = YanZhenMa.Code();              //刷新验证码
            Tusername.Text = "";//将用户输入的信息置空
            Tpass.Text = "";
        }
        //用户点击注册事件
        private void DoRegist_Click(object sender, EventArgs e)
        {
            //生成注册界面的新窗口
            regist RG = new regist();
            RG.Show();
        }

    }
}
