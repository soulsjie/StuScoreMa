using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using dataADUstudy.窗口程序;
namespace dataADUstudy
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
            //设置应用初始的窗体程序
            //application.run(new zhuchaidan());
            //测试创建数据库连接
            //DBlink sjklj = new DBlink();
            //if (sjklj.DBconn()) {
            //    if (sjklj.UpdataDeletAdd("delete from login_info where username='tom'"))
            //    {
            //        Console.WriteLine("成功删除一条数据");
            //    }
            //    else {
            //        Console.WriteLine("删除失败");
            //    }
            //    //插入数据的语句sjklj.search("insert into login_info(username,pass,SF,tag,number,sex,class) values('tom','tom@yahoo.com','a',1,'00001','男','36班');");
            //}
            //sjklj.DBclose();
        }
    }
}
