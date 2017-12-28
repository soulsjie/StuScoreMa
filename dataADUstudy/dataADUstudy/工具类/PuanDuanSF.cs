using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dataADUstudy.数据实体类;

namespace dataADUstudy.工具类
{
    class PuanDuanSF
    {
        //创建判断用户身份的工具类
        public static void panduanshenfen( int temp) { 
            if(temp==0){
                quanju.sf = "s";
            }
            else if(temp==1){
                quanju.sf = "t";
            }
            else{
                quanju.sf = "a";
            }
        }
    }
}
