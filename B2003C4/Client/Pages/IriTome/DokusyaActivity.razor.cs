using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2003C4.Client.Pages.IriTome
{
    public partial class DokusyaActivity
    {

        //海老沼書き足しｽﾞｲ₍₍(ง˘ω˘)ว⁾⁾ｽﾞｲ（仮）
        
        public int Count { get; set; }

        List<Dokusya> DokusyaList = new List<Dokusya>()
        {
            new Dokusya("114514","えびぬま　つなき","えびぬますかいたわーX 114514","海老沼北１","１１４－５１４","11-4514-1919")

        };

        List<List> HyoudaiList = new List<List>()
        {

            new List("読者番号","名前","建物","町名","電話番号")

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

        public class List //表示情報格納用（仮）
        {
            public string DokusyaNo; //読者番号
            public string DokusyaName; //読者名
            public string BuildingName; //建物名
            public string CityName; //住所
            public string PhoneNo; //電話番号


            public List(string dokusyaNo, string dokusyaName, string buildingName, string cityName, string phoneNo)
            {
                DokusyaNo = dokusyaNo;
                DokusyaName = dokusyaName;
                BuildingName = buildingName;
                CityName = cityName;
                PhoneNo = phoneNo;

            }

        }

    }
}
