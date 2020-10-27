using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace B2003C4.Client.Pages.Common
{
    public partial class DokusyaActivity
    {

        //海老沼書き足しｽﾞｲ₍₍(ง˘ω˘)ว⁾⁾ｽﾞｲ（仮）
        
        public int Count { get; set; }

        public string temp;


        public string ButtonColor = "#01579B";
        public string Riyu = "入理由";
        public string Keiyaku="契約日";

        List <Koumoku> KoumokuList = new List<Koumoku>()
        {
            new Koumoku ("読者番号","DokusyaNo"),
            new Koumoku ("読者名","DokusyaName"),
            new Koumoku ("建物名","BuildingName"),
            new Koumoku ("町名","CityFullName"),
            new Koumoku ("電話番号","PhoneNo"),
            new Koumoku ("店備考","TenpoRemarks"),
            new Koumoku ("順路備考","JunroRemarks"),
            new Koumoku ("集金メモ","MoneyRemarks"),
            new Koumoku ("分類","Class"),
            new Koumoku ("ランク","Lank"),

        };

        List<Dokusya> DokusyaList = new List<Dokusya>()
        {
            new Dokusya("114514","えびぬま　つなき","えびぬますかいたわーX 114514","海老沼北１","１１４－５１４","11-4514-1919")

        };

        List<Meihan> MeihanList = new List<Meihan>()
        {
            new Meihan("114514","朝","19/19","20/11","海老沼団","1","","先起こし","19/11/19","契約","25/12"),
            new Meihan("114514","朝","19/19","20/11","海老沼団","2","","先起こし","19/11/19","契約","25/12"),
            new Meihan("114514","朝","19/19","20/11","海老沼団","3","","先起こし","19/11/19","契約","25/12"),
            new Meihan("114514","朝","19/19","20/11","海老沼団","4","","先起こし","19/11/19","契約","25/12"),
            new Meihan("114514","朝","19/19","20/11","海老沼団","5","","先起こし","19/11/19","契約","25/12"),
            new Meihan("114514","朝","19/19","20/11","海老沼団","6","","先起こし","19/11/19","契約","25/12"),
            new Meihan("114514","朝","19/19","20/11","海老沼団","7","","先起こし","19/11/19","契約","25/12"),
            new Meihan("114514","朝","19/19","20/11","海老沼団","8","","先起こし","19/11/19","契約","25/12"),
            new Meihan("114514","朝","19/19","20/11","海老沼団","9","","先起こし","19/11/19","契約","25/12"),
            new Meihan("114514","朝","19/19","20/11","海老沼団","10","","先起こし","19/11/19","契約","25/12"),
            new Meihan("114514","朝","19/19","20/11","海老沼団","11","","先起こし","19/11/19","契約","25/12"),
        };


        public class Dokusya //読者情報格納用（仮）
        {
            public string DokusyaNo; //読者番号
            public string DokusyaName; //読者名
            public string BuildingName; //建物名
            public string CityName; //町名（必要？）
            public string CityAddress; //町名以降
            public string CityFullName; //二人は住所
            public string PhoneNo; //電話番号


            public Dokusya(string dokusyaNo , string dokusyaName , string buildingName , string cityName ,string cityAddress , string phoneNo )
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


            public Koumoku(string heading , string headingCode)
            {
                Heading = heading;

                HeadingCode = headingCode;

            }

        }

        public class Meihan
        {

            public string DokusyaNo; //読者番号
            public string MeihanName; //銘版
            public string KeiyakuSt; //契約開始
            public string KeiyakuEd; //契約終了
            public string KeiyakusyaName; //契約者
            public string Tsukisu; //月数
            public string Hey; //配
            public string Iririyu; //入理由
            public string Keiyakubi; //契約日
            public string Tomeriyu; //止理由
            public string Tomebi; //止日

            public Meihan(string dokusyaNo , string meihanName, string keiyakuSt, string keiyakuEd, string keiyakusyaName, string tsukisu, string hey , string iririyu , string keiyakubi , string tomeriyu , string tomebi)
            {
                DokusyaNo = dokusyaNo;
                MeihanName = meihanName;
                KeiyakuSt = keiyakuSt;
                KeiyakuEd = keiyakuEd;
                KeiyakusyaName = keiyakusyaName;
                Tsukisu = tsukisu;
                Hey = hey;
                Iririyu = iririyu;
                Keiyakubi = keiyakubi;
                Tomeriyu = tomeriyu;
                Tomebi = tomebi;
            }
        }



        [Inject]
        protected NavigationManager Navi { get; set; }

        public void JumpPage(string URLx)
        {

            Navi.NavigateTo(URLx);

        }

        public void ButtonChange()
        {

            if(ButtonColor == "#01579B")
            {
                ButtonColor = "#B71C1C";
                Riyu = "止理由";
                Keiyaku = "止め日";
            }
            else
            {
                ButtonColor = "#01579B";
                Riyu = "入理由";
                Keiyaku = "契約日";



            }

        }

        public void GoToGoogleMap(string address)
        {
            Navi.NavigateTo("https://www.google.com/maps/search/?api=1&query=" + address);
        }



    }
}
