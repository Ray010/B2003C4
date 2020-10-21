using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace B2003C4.Client.Pages.IriTome
{
    public partial class DokusyaActivity
    {

        //海老沼書き足しｽﾞｲ₍₍(ง˘ω˘)ว⁾⁾ｽﾞｲ（仮）
        
        public int Count { get; set; }

        public string temp;

        List<Koumoku> KoumokuList = new List<Koumoku>()
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



        [Inject]
        protected NavigationManager Navi { get; set; }

        public void JumpPage(string URLx)
        {

            Navi.NavigateTo(URLx);

        }



    }
}
