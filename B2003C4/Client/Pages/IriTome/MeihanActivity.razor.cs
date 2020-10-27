using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace B2003C4.Client.Pages.IriTome
{
    public partial class MeihanActivity
    {


        //海老沼書き足しｽﾞｲ₍₍(ง˘ω˘)ว⁾⁾ｽﾞｲ（仮）

        public int Count { get; set; }

        public string temp;


        public string ButtonColor = "#01579B";
        public string Riyu = "入理由";
        public string Keiyaku = "契約日";

        List<Koumoku> KoumokuList = new List<Koumoku>()
        {
            new Koumoku ("銘版","Meihan"),
            new Koumoku ("契約期間","Keiyaku"),
            new Koumoku ("契約区分","KeiyakuKubun"),
            new Koumoku ("契約者","KeiyakuSya"),
            new Koumoku ("契約日","KeiyakuBi"),
            new Koumoku ("入理由","IriRiyu"),
            new Koumoku ("配達日","HaitatsuBi"),
            new Koumoku ("止理由","TomeRiyu"),
            new Koumoku ("止め日","TomeBi"),

        };

        List<Koumoku> MeihanList = new List<Koumoku>()
        {
            new Koumoku("朝日新聞　朝刊","Meihan"),
            new Koumoku("","Keiyaku"),
            new Koumoku("先起し","KeiyakuKubun"),
            new Koumoku("","KeiyakuSya"),
            new Koumoku("","KeiyakuBi"),
            new Koumoku("","IriRiyu"),
            new Koumoku("","HaitatsuBi"),
            new Koumoku("","止理由"),
            new Koumoku("","TomeBi"),

        };

        List<Dokusya> DokusyaList = new List<Dokusya>()
        {
            new Dokusya("114514","えびぬま　つなき","えびぬますかいたわーX 114514","海老沼北１","１１４－５１４","11-4514-1919")

        };

        List<HinMei> HinMeiList = new List<HinMei>()
        {
            new HinMei("1","2","3"),
            new HinMei("3","4","5"),
            new HinMei("5","6","7"),
            new HinMei("4","3","3"),
            new HinMei("7","8",""),
            new HinMei("","",""),
            new HinMei("","",""),
            new HinMei("","",""),
        };

        /*保留
        List<Meihan> MeihanListX = new List<Meihan>()
        {

            new Meihan("朝日新聞　朝刊","","先起し","","","先起","","契約",""),

        };
        */


        public class Dokusya //読者情報格納用（仮）
        {
            public string DokusyaNo; //読者番号
            public string DokusyaName; //読者名
            public string BuildingName; //建物名
            public string CityName; //町名（必要？）
            public string CityAddress; //町名以降
            public string CityFullName; //二人は住所
            public string PhoneNo; //電話番号


            public Dokusya(string dokusyaNo, string dokusyaName, string buildingName, string cityName, string cityAddress, string phoneNo)
            {
                DokusyaNo = dokusyaNo;
                DokusyaName = dokusyaName;
                BuildingName = buildingName;
                CityFullName = cityName + cityAddress;
                PhoneNo = phoneNo;

            }

        }

        public class Koumoku //表示情報格納用（仮）
        {
            public string Heading; //読者番号

            public string HeadingCode;


            public Koumoku(string heading, string headingCode)
            {
                Heading = heading;

                HeadingCode = headingCode;

            }

        }

        public class HinMei
        {
            public string HinName;
            public string Hiduke;
            public string Suryou;

            public HinMei(string hinName, string hiduke, string suryou)
            {

                HinName = hinName;
                Hiduke = hiduke;
                Suryou = suryou;
            }
        }

        /*銘版
        public class Meihan
        {

            public string MeihanName; //銘版
            public string KeiyakuKikan; //契約期間
            public string KeiyakuKubun; //契約区分
            public string KeiyakuSya; //契約者
            public string KeiyakuSt; //契約開始
            public string IriRiyu; //入理由
            public string HaitatsuBi; //配達日
            public string TomeRiyu; //止理由
            public string TomeBi; //止日

            public Meihan(string meihanName, string keiyakuKikan, string keiyakuKubun, string keiyakuSya, string keiyakuSt , string iriRiyu, string haitatsuBi ,string tomeRiyu, string tomeBi)
            {
                MeihanName = meihanName;
                KeiyakuKikan = keiyakuKikan;
                KeiyakuKubun = keiyakuKubun;
                KeiyakuSya=keiyakuSya;
                KeiyakuSt = keiyakuSt;
                IriRiyu = iriRiyu;
                HaitatsuBi = haitatsuBi;
                TomeRiyu = tomeRiyu;
                TomeBi = tomeBi;
          
            }
        }
        */


        [Inject]
        protected NavigationManager Navi { get; set; }

        public void JumpPage(string URLx)
        {

            Navi.NavigateTo(URLx);

        }

        public void GoToGoogleMap(string address)
        {
            Navi.NavigateTo("https://www.google.com/maps/search/?api=1&query=" + address);
        }

    }
}
