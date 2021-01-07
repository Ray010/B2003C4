using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using B2003C4.Data;
using B2003C4.Class;

namespace B2003C4.Pages.Common
{
    public partial class MeihanActivity
    {


        //海老沼書き足しｽﾞｲ₍₍(ง˘ω˘)ว⁾⁾ｽﾞｲ（仮）


        [Parameter]
        public FormSearchDataModel CommonPhase2 { get; set; }
        [Parameter]
        public EventCallback<FormSearchDataModel> CommonPhase2Changed { get; set; }


        //DB--------------------------------------------------------------------------------------
        [Parameter]
        public List<Dokusya> C_DokusyaList { get; set; }

        [Parameter]
        public EventCallback<List<Dokusya>> C_DokusyaListChanged { get; set; }

        [Parameter]
        public List<Koudoku> C_KoudokuList { get; set; }

        [Parameter]
        public EventCallback<List<Koudoku>> C_KoudokuListChanged { get; set; }

        [Parameter]
        public List<Kakuzai_K95010> C_KakuzaiList { get; set; }
        [Parameter]
        public EventCallback<List<Kakuzai_K95010>> C_KakuzaiListChanged { get; set; }

        //DB--------------------------------------------------------------------------------------

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

        List<Koumoku> S_Koudoku = new List<Koumoku>();




        List<HinMei> HinMeiList = new List<HinMei>()
        {
            /*
            new HinMei("1","2","3"),
            new HinMei("3","4","5"),
            new HinMei("5","6","7"),
            new HinMei("4","3","3"),
            new HinMei("7","8",""),
            new HinMei("","",""),
            new HinMei("","",""),
            new HinMei("","",""),
            */
        };


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
            public int? Suryou;

            public HinMei(string hinName, string hiduke, int? suryou)
            {

                HinName = hinName;
                Hiduke = hiduke;
                Suryou = suryou;
            }
        }

        [Inject]
        protected NavigationManager Navi { get; set; }

        public void JumpPage(string URLx)
        {

            Navi.NavigateTo(URLx);

        }

        protected override void OnInitialized()
        {
            var DokusyaList = C_KakuzaiList.Where(n => n.DokuCode == CommonPhase2.S_DokusyaCode);

            var Temp_S_Koudoku = C_KoudokuList.FirstOrDefault(n => n.DokuCode == CommonPhase2.S_DokusyaCode);

            S_Koudoku.Add(new Koumoku(Temp_S_Koudoku.MgFullName,""));
            S_Koudoku.Add(new Koumoku(Temp_S_Koudoku.KeiyakuDay + Temp_S_Koudoku.TomeDay, ""));
            S_Koudoku.Add(new Koumoku(Temp_S_Koudoku.KeiyakuKbn, ""));
            S_Koudoku.Add(new Koumoku(Temp_S_Koudoku.Keiyakusya, ""));
            S_Koudoku.Add(new Koumoku(Temp_S_Koudoku.KeiyakuDay, ""));
            S_Koudoku.Add(new Koumoku(Temp_S_Koudoku.IriRiyuu, ""));
            S_Koudoku.Add(new Koumoku(Temp_S_Koudoku.DispHaitatubi, ""));
            S_Koudoku.Add(new Koumoku(Temp_S_Koudoku.TomeRiyuu, ""));
            S_Koudoku.Add(new Koumoku(Temp_S_Koudoku.TomeDay, ""));



            foreach (var x in DokusyaList)
            {
                HinMeiList.Add(new HinMei(x.HinmeiName1, x.HinmeiDate1, x.HinmeiCnt1));
                HinMeiList.Add(new HinMei(x.HinmeiName2, x.HinmeiDate2, x.HinmeiCnt2));
                HinMeiList.Add(new HinMei(x.HinmeiName3, x.HinmeiDate3, x.HinmeiCnt3));
                HinMeiList.Add(new HinMei(x.HinmeiName4, x.HinmeiDate4, x.HinmeiCnt4));
                HinMeiList.Add(new HinMei(x.HinmeiName5, x.HinmeiDate5, x.HinmeiCnt5));
                HinMeiList.Add(new HinMei(x.HinmeiName6, x.HinmeiDate6, x.HinmeiCnt6));
                HinMeiList.Add(new HinMei(x.HinmeiName7, x.HinmeiDate7, x.HinmeiCnt7));
                HinMeiList.Add(new HinMei(x.HinmeiName8, x.HinmeiDate8, x.HinmeiCnt8));
                HinMeiList.Add(new HinMei(x.HinmeiName9, x.HinmeiDate9, x.HinmeiCnt9));

            }




            //-------------------------------------------------------------------------------
            if (CommonPhase2.HistoryBackState == false)
            {
                History.Back_History.Add(CommonPhase2.Deep_Copy());   //.Add(CurrentPage);
                CommonPhase2Changed.InvokeAsync(CommonPhase2);
            }
            else if (CommonPhase2.HistoryBackState == true)
            {
                CommonPhase2.HistoryBackState = false;
                CommonPhase2Changed.InvokeAsync(CommonPhase2);
            }
        }


        public void GoToGoogleMap(string address)
        {
            Navi.NavigateTo("https://www.google.com/maps/search/?api=1&query=" + address);
        }

    }
}
