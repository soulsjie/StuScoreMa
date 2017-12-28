using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dataADUstudy.工具类
{
    class YanZhenMa
    {
        //随机生成验证码
        public static string Code()
        {
            string code = "";           //验证码字符串
            Random ran = new Random();
            for (int i = 0; i < 4; i++) //随机生成四位验证码功能
            {
                int n = ran.Next(9);
                code += n;
            }
            return code;
        }
    }
}
