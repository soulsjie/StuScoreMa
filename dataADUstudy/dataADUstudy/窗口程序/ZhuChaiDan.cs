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
            //根据登录系统的身份不同，提示不同欢迎语和显示主菜单
            DBlink db = new DBlink();       //创建数据库连接实例
            adminmnue.Visible = false;     //默认不显示菜单
            stumnue.Visible = false;
            teamnue.Visible = false;
            if(LoginInfo.sf.Equals("s")){
                this.Text =LoginInfo.username+ "同学您好！欢迎使用学生成绩管理系统。";
                stumnue.Visible = true;
                if (db.DBconn()) {

                    db.GetScoreData("select * from student_score");
                }
                db.DBclose();
                for (int i = 0; i < ScoreInfo.id.Count; i++)    //循环将数据实体类的数据存放到dataGridView中
                {
                    int index = this.dataGridView1.Rows.Add();
                    this.dataGridView1.Rows[index].Cells[0].Value = ScoreInfo.id[i];
                    this.dataGridView1.Rows[index].Cells[1].Value = ScoreInfo.number[i];
                    this.dataGridView1.Rows[index].Cells[2].Value = ScoreInfo.xueqi[i];
                    this.dataGridView1.Rows[index].Cells[3].Value = ScoreInfo.kecheng[i];
                    this.dataGridView1.Rows[index].Cells[4].Value = ScoreInfo.chengji[i];
                    this.dataGridView1.Rows[index].Cells[5].Value = ScoreInfo.name[i];
                }      
            }
            else if (LoginInfo.sf.Equals("t")){
                this.Text = LoginInfo.username + "老师您好！欢迎使用学生成绩管理系统。";
                teamnue.Visible = true;
            }
            else if (LoginInfo.sf.Equals("a"))
            {
                this.Text = LoginInfo.username + "管理员您好！欢迎使用学生成绩管理系统。";
                adminmnue.Visible = true;
               
            }
        }
    }
}
