using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dataADUstudy.数据实体类;

namespace dataADUstudy
{
    public partial class ZhuChaiDan : Form
    {
        public ZhuChaiDan()
        {
            InitializeComponent();
        }

        private void ZhuChaiDan_Load(object sender, EventArgs e)
        {  
            //根据登录系统的身份不同，提示不同欢迎语
            if(LoginInfo.sf.Equals("s")){
                this.Text =LoginInfo.username+ "同学您好！欢迎使用学生成绩管理系统。";
            }
            else if (LoginInfo.sf.Equals("t")){
                this.Text = LoginInfo.username + "老师您好！欢迎使用学生成绩管理系统。";
            }
            else if (LoginInfo.sf.Equals("a"))
            {
                this.Text = LoginInfo.username + "管理员您好！欢迎使用学生成绩管理系统。";
            }
        }
    }
}
