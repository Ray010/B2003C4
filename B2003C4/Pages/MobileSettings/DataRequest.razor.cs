using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;


namespace B2003C4.Pages.MobileSettings
{
    public partial class DataRequest
    {




        public string TenpoNoTemp;


        //海老沼書き足しｽﾞｲ₍₍(ง˘ω˘)ว⁾⁾ｽﾞｲ（仮）
        List<Tenpo> TenpoList = new List<Tenpo>()
        {

            new Tenpo("0","ASA 桜ヶ丘西部"),
            new Tenpo("1","ASA 紅葉ヶ丘"),
            new Tenpo("2","ASA 相模大野東部"),

        };

        List<ReceiveTenpoFiles> ReceiveTenpoFileList = new List<ReceiveTenpoFiles>()
        {
            new ReceiveTenpoFiles("0","1",true,true,true,true),
            new ReceiveTenpoFiles("0","2",true,true,false,true),
            new ReceiveTenpoFiles("0","3",true,true,true,true),
            new ReceiveTenpoFiles("0","4",true,false,true,true),
            new ReceiveTenpoFiles("0","5",true,true,true,true),

            new ReceiveTenpoFiles("1","1",true,true,true,true),
            new ReceiveTenpoFiles("1","2",true,true,false,true),
            new ReceiveTenpoFiles("1","3",true,true,true,true),
            new ReceiveTenpoFiles("1","4",true,false,true,true),

            new ReceiveTenpoFiles("2","1",true,true,true,true),
            new ReceiveTenpoFiles("2","2",true,true,false,true),
            new ReceiveTenpoFiles("2","3",true,true,true,true),
            new ReceiveTenpoFiles("2","4",true,false,true,true),
            new ReceiveTenpoFiles("2","5",true,true,true,true),


        };

        public class Tenpo
        {
            public string TenpoNo; //店舗ナンバー           
            public string TenpoName; //店舗名

            public Tenpo(string tenpoNo , string tenpoName)
            {

                TenpoNo = tenpoNo;
                TenpoName = tenpoName;

            }

        }

        public class ReceiveTenpoFiles
        {
            public string TenpoNo; //店舗ナンバー
            public string KuikiNo; //区域番号
            public Boolean IriTome; //入止用DBファイルがあるかどうか
            public Boolean Kako;　//過去用DBファイルがあるかどうか
            public Boolean Haitatsu; //配達用DBファイルがあるかどうか
            public Boolean Kansa; //監査用DBファイルがあるかどうか


            public ReceiveTenpoFiles(string tenpoNo , string kuikiNo , Boolean iriTome , Boolean kako , Boolean haitatsu , Boolean kansa)
            {

                TenpoNo = tenpoNo;
                KuikiNo = kuikiNo;
                IriTome = iriTome;
                Kako = kako;
                Haitatsu = haitatsu;
                Kansa = kansa;

            }
            

        }


    }
}
