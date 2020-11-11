using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace B2003C4.Client.Pages.Kansa
{
    public partial class SearchActivity
    {
        //精神と時の部屋
        [Parameter]
        public FormDataModel Phase2Data { get; set; }

        [Parameter]
        public EventCallback<FormDataModel> Phase2DataChanged { get; set; }

        List<Dokusya> DokusyaSearchEdList = new List<Dokusya> { };

        protected override void OnInitialized()
        {
            foreach(var x in DokusyaList)
            {
                
                if (
                (x.DokusyaCode == Phase2Data.DokusyaCode || 0 == Phase2Data.DokusyaCode) &&
                (x.Kuiki == Phase2Data.KuikiNo || 0 == Phase2Data.KuikiNo) &&
                (x.Junro == Phase2Data.Junro || 0 == Phase2Data.Junro) &&
                (x.Junro_Sub == Phase2Data.Junro_Sub || 0 == Phase2Data.Junro_Sub) &&
                (x.DokusyaName.StartsWith(Phase2Data.DokusyaName) || "none" == Phase2Data.DokusyaName) &&
                (x.DokusyaKanaName.StartsWith(Phase2Data.DokusyaKanaName) || "none" == Phase2Data.DokusyaKanaName) &&
                //(x.PhoneNo == PhoneNoParam || "none" == PhoneNoParam) &&
                (x.PhoneNo_Sub.StartsWith(Phase2Data.PhoneNo_Sub) || "none" == Phase2Data.PhoneNo_Sub) &&
                (x.CityName == Phase2Data.CityName || "none" == Phase2Data.CityName) &&
                (x.CityAddress == Phase2Data.CityAddress || "none" == Phase2Data.CityAddress) &&
                (x.BuildingName.StartsWith(Phase2Data.BuildingName) || "none" == Phase2Data.BuildingName) &&
                (x.BuildingKanaName.StartsWith(Phase2Data.BuildingKanaName) || "none" == Phase2Data.BuildingKanaName) &&
                (x.ShitsuBan == Phase2Data.ShitsuBan || 0 == Phase2Data.ShitsuBan) 
                //&&
                //(x.DokusyaStatus == Phase2Data.CheckResult || "none" == Phase2Data.CheckResult)
                )
                {
                    DokusyaSearchEdList.Add(x);
                }



            }
            Count = DokusyaSearchEdList.Count;



        }




        static int x { get; set; }



        [Parameter]
        public string Param { get; set; }


        //各検索パラメータ
        string[] SearchParam = new string[]
        {
            "CheckResultParam",
            "DokuCodeParam",
            "KuikiParam",
            "JunroParam",
            "Junro_SubParam",
            "DokusyaNameParam",
            "DokusyaKanaNameParam",
            "PhoneNoParam",
            "PhoneNo_SubParam",
            "CityNameParam",
            "CityAddressParam",
            "BuildingNameParam",
            "BuildingKanaNameParam",
            "ShitsuBanParam",

        };



        public string CheckResultParam { get; set; }

        public uint DokuCodeParam { get; set; }

        public uint KuikiParam { get; set; }
        
        public uint JunroParam { get; set; }
        
        public uint Junro_SubParam { get; set; }
        
        public string DokusyaNameParam { get; set; }
        
        public string DokusyaKanaNameParam { get; set; }

        public uint PhoneNoParam { get; set; }

        public string PhoneNo_SubParam { get; set; }

        public string CityNameParam { get; set; }
        
        public string CityAddressParam { get; set; }

        public string BuildingNameParam { get; set; }

        public string BuildingKanaNameParam { get; set; }

        public uint? ShitsuBanParam { get; set; }


        //終わり！

        public int Count { get; set; }




        List<Dokusya> DokusyaList = new List<Dokusya>
        {
            new Dokusya("Gendoku",117,1,0001,00,"加藤　次男","ｶﾄｳ","080-0888-0088","戸部町1","9","none","none",0,"M"),
            new Dokusya("Gendoku",48,1,0002,00,"横浜市健康保険福祉総合センタ","ﾖｺﾊﾏｼ","0120-111-111","戸部町1","10","none","none",0,"M"),
            new Dokusya("Tome",49,1,0003,00,"（有）沼田石版印刷所","ﾕｳｹﾞﾝ","","戸部町1","8","none","none",0,"M"),
            new Dokusya("Kyudoku",122,1,0011,00,"入居","ｲﾘｽｴ","080-0000-0000","戸部町1","2","ヒルトップ","ﾋﾙﾄｯﾌﾟ",401,"M"),
            new Dokusya("Gendoku",52,1,0016,00,"川島　捷男","ｶﾜｼﾏ","012-345-6789","宮崎町","","伊勢山ハイツＡ棟","ｲｾﾔﾏﾊｲﾂｴｰﾄｳ",102,"M"),
            new Dokusya("Yoyaku",256,2,0001,00,"野口","ﾉｸﾞﾁ","03-6925-8147","紅葉町","44","紅葉坂レジデンス","ｺｳﾖｳｻｶﾚｼﾞﾃﾞﾝｽ",102,"M"),
            new Dokusya("Gendoku",269,2,0006,00,"横浜　三郎","ﾖｺﾊﾏ","070-7418-5236","紅葉町","44","紅葉坂レジデンス","ｺｳﾖｳｻｶﾚｼﾞﾃﾞﾝｽ",206,"M"),
            new Dokusya("Kyudoku",270,2,0013,00,"関　洋","ｾｷ","236-5478-9999","紅葉町","44","紅葉坂レジデンス","ｺｳﾖｳｻｶﾚｼﾞﾃﾞﾝｽ",409,"M"),
            new Dokusya("Huryou",5462,3,0001,00,"海老沼　綱紀","ｴﾋﾞﾇﾏ","38-6548-9875","武蔵野10","44-88","武蔵野タワー","ﾑｻｼﾉﾀﾜｰ",9901,"M"),
            new Dokusya("Junro",1975,4,0001,00,"田中　信","ﾀﾅｶ","48-6325-7458","桐生","1152","none","none",0,"M"),
            new Dokusya("Midoku",2422,5,001,00,"高久","ﾀｶｸ","028-658-8745","那須町","1110","none","none",0,"M"),
            new Dokusya("Kyudoku",1955,2,0099,00,"東京都庁","ﾄｳｷｮｳ","00-0000-0000","西新宿２丁目","8-1","none","none",0,"M"),
        };

        List<Status> DokusyaStatusList = new List<Status>
        {
            new Status("未読","Midoku"),
            new Status("現読","Gendoku"),
            new Status("予約","Yoyaku"),
            new Status("止め","Tome"),
            new Status("休読","Kyudoku"),
            new Status("保留","Horyu"),
            new Status("発証","Hassyo"),
            new Status("順路","Junro"),
            new Status("不良","Huryo"),
            new Status("空家","Akiya"),
            new Status("他現","Tagen"),
        };

        public class Dokusya
        {
            public string DokusyaStatus; //読者の状態（現、休、止　等）
            public uint DokusyaCode; //読者コード
            public uint Kuiki; //区域
            public uint Junro;
            public uint Junro_Sub;
            public string DokusyaName; //読者名
            public string DokusyaKanaName; //読者名

            public uint PhoneNo;
            public string PhoneNo_Sub;

            public string CityName; //町名
            public string CityAddress; //町名以降
            public string CityFullName; //町名＋町名以降

            public string BuildingName;
            public string BuildingKanaName;
            public uint? ShitsuBan;
            public string M; // M（わからない）
        
            public Dokusya(
                            string dokusyaStatus , 
                            uint dokusyaCode ,
                            uint kuiki,

                            uint junro,
                            uint junro_Sub,

                            string dokusyaName ,
                            string dokusyaKanaName,

                            //uint phoneNo,
                            string phoneNo_Sub,

                            string cityName , 
                            string cityAddress , 
                            
                            string buildingName,
                            string buildingKanaName,
                            uint? shitsuBan,
                            
                            string m
                )
            {

                DokusyaStatus = dokusyaStatus;
                DokusyaCode = dokusyaCode;
                Kuiki = kuiki;

                Junro = junro;
                Junro_Sub = junro_Sub;

                DokusyaName = dokusyaName;
                DokusyaKanaName = dokusyaKanaName;


                //PhoneNo = phoneNo;
                PhoneNo_Sub = phoneNo_Sub;

                CityName = cityName;
                CityAddress = cityAddress;
                
                BuildingName = buildingName;
                BuildingKanaName = buildingKanaName;
                
                ShitsuBan = shitsuBan;


                CityFullName = cityName + cityAddress;
                M = m;

            }
        
        }






        public class Status
        {
            public string StatusCode;
            public string StatusName;

            public Status(string statusName , string statusCode)
            {
                StatusName = statusName;
                StatusCode = statusCode;
                
            }
        }
        public string CheckMasterX;


        /* 建設中
        
List<Status> ParamList = new List<Status>();
protected override void OnInitialized()
{
CheckResultParam = Param.Substring(0, Param.IndexOf("$"));
Count = 0;
//DokuCodeParam = uint.Parse(Param.Substring(CheckResultParam.Length, Param.IndexOf("$")));
CheckMasterX = Param.Substring(CheckResultParam.Length + 1, Param.IndexOf("$"));
ParamList.Add(new Status(SearchParam[Count], Param.Substring(0, Param.IndexOf("$"))));


while(Param.IndexOf("$") >= 0)
{
    ParamList.Add(new Status(SearchParam[Count],Param.Substring(0, Param.IndexOf("$"))));
    Count++;
}

    public string CheckResultParam { get; set; }

public uint DokuCodeParam { get; set; }

public uint KuikiParam { get; set; }

public uint JunroParam { get; set; }

public uint Junro_SubParam { get; set; }

public string DokusyaNameParam { get; set; }

public string DokusyaKanaNameParam { get; set; }

public uint PhoneNoParam { get; set; }

public string PhoneNo_SubParam { get; set; }

public string CityNameParam { get; set; }

public string CityAddressParam { get; set; }

public string BuildingNameParam { get; set; }

public string BuildingKanaNameParam { get; set; }

public uint? ShitsuBanParam { get; set; }


}
*/

        [Inject]
        protected NavigationManager Navi { get; set; }
        public void JumpPage(string URLx)
        {

            Navi.NavigateTo(URLx);

        }

        



    }
}
