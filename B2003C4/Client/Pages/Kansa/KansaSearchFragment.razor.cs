using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Dynamic;
using Microsoft.Data.SqlClient.DataClassification;
using System.Text;
using Microsoft.JSInterop;
using System.Security.Cryptography.X509Certificates;

namespace B2003C4.Client.Pages.Kansa
{

    public partial class KansaSearchFragment
    {


        //精神と時の部屋
        [Parameter]
        public FormDataModel Phase1Data { get; set; }
        [Parameter]
        public EventCallback<FormDataModel> Phase1DataChanged { get; set; }
        



        private async Task UpdateModelDataOrPhaseShift()
        {
            //nullCheck!!
            Phase1Data.DokusyaCode = Phase1Data.DokusyaCode ?? 0;
            Phase1Data.KuikiNo = Phase1Data.KuikiNo ?? 0;
            Phase1Data.Junro = Phase1Data.Junro ?? 0;
            Phase1Data.Junro_Sub = Phase1Data.Junro_Sub ?? 0;
            Phase1Data.DokusyaName = Phase1Data.DokusyaName ?? "none";
            Phase1Data.DokusyaKanaName = Phase1Data.DokusyaKanaName ?? "none";
            Phase1Data.PhoneNo = Phase1Data.PhoneNo ?? 0;
            Phase1Data.PhoneNo_Sub = Phase1Data.PhoneNo_Sub ?? "none";
            Phase1Data.CityName = Phase1Data.CityName ?? "none";
            Phase1Data.CityAddress = Phase1Data.CityAddress ?? "none";
            Phase1Data.BuildingName = Phase1Data.BuildingName ?? "none";
            Phase1Data.BuildingKanaName = Phase1Data.BuildingKanaName ?? "none";
            Phase1Data.ShitsuBan = Phase1Data.ShitsuBan ?? 0;
            Phase1Data.CheckResult = Phase1Data.CheckResult ?? "none";
            //終わり

            Phase1Data.PhaseNo = 2;
            await Phase1DataChanged.InvokeAsync(Phase1Data);
            StateHasChanged();

        }

        //-------------------------------------------------------

        public string strX = "\u24C8 \u2075 \u221E";

        static int x;
        

        //海老沼書き足しｽﾞｲ₍₍(ง˘ω˘)ว⁾⁾ｽﾞｲ（仮）

        public int KubunCount { get; set; }

        public Boolean Kuiki_SelectFlg { get; set; } = false;
        //string Kuiki_SelectedValue;
        uint? Kuiki_SelectedValue;
        uint? Kuiki_SelectValue
        { get => Kuiki_SelectedValue; set { Kuiki_SelectedValue = value; } }


        public int KubunButton;
        public int X;
        public string y;


        public uint? DokusyaCode = null;
        public uint? KuikiNo = null;
        public uint? Junro;
        public uint? Junro_Sub;
        public string DokusyaName;
        public string DokusyaKanaName;
        public uint? PhoneNo;
        public string PhoneNo_Sub;
        public string CityName;
        public string CityAddress;
        public string BuildingName; //建物名
        public string BuildingKanaName; //建物名(カナ)
        public uint? ShitsuBan;

        public string MessageForError; //エラーメッセ内容

 //ユーザーが入力した値


        public string a { get; set; }


        List<Kuiki> KuikiList = new List<Kuiki>()
        {
            new Kuiki("",null),
            new Kuiki("1区",1),
            new Kuiki("2区",2),
            new Kuiki("3区",3),
            new Kuiki("4区",4),
            new Kuiki("5区",5),
        };

        List<Kubun> KubunList = new List<Kubun>()
        {
            new Kubun("未読","Midoku"),
            new Kubun("現読","Gendoku"),
            new Kubun("予約","Yoyaku"),
            new Kubun("止め","Tome"),
            new Kubun("休読","Kyudoku"),
            new Kubun("保留","Horyu"),
            new Kubun("発証","Hassyo"),
            new Kubun("順路","Junro"),
            new Kubun("不良","Huryo"),
            new Kubun("空家","Akiya"),
            new Kubun("他現","Tagen"),
        };


        public class Kubun
        {
            public string KubunName { get; set; }
            public string KubunCode { get; set; }

            public Kubun(string kubunName , string kubunCode)
            {
                KubunName = kubunName;
                KubunCode = kubunCode;
            }

        }

        public class Kuiki
        {
            public string KuikiName { get; set; }
            public uint? KuikiCode { get; set; }

            public Kuiki(string kuikiName, uint? kuikiCode)
            {
                KuikiName = kuikiName;
                KuikiCode = kuikiCode;

            }

        }


        public List<Kubun> Button ;


        /*
        protected override void OnInitialized()
        {
            int Count=0;

            for(int y = 1; y == 5; y++)
            {
                for(int x = 0; x == 4; x++)
                    //Range(x*y,KubunList.Count))
                {
                    Button[y, x] = KubunList[x];
                }
            }

        }
        */

        protected override void OnParametersSet()
        {
            Console.WriteLine("OnRef");
        }



        public void Clear()
        {
            Kuiki_SelectValue = null;
            CheckResult = null;
        }

        public void ButtonX(string e)
        {
  
            //.ToString();
            //ListX.Add();

        }
        public void OnChangeEventKuiki(uint? X)
        {
            Kuiki_SelectedValue = X;
            Kuiki_SelectFlg = true;
            KuikiNo = Kuiki_SelectedValue;

        }


        [Inject]
        protected NavigationManager Navi { get; set; }
        public void JumpResultPage(string URLx)
        {

            string url = "";

            if (null == DokusyaCode && null == KuikiNo)
            {
                MessageForError = "0001：検索条件を１つ以上指定してください";
            }
            else {

                if (null == CheckResult)
                {
                    url += "/CheckResult=" + CheckResult;
                    CheckResult = "none";
                }
                if (null == DokusyaCode)
                {
                    url += "/DokuCode=" + DokusyaCode;
                    DokusyaCode = 0; 
                }
                if(null == KuikiNo)
                {
                    url += "/KuikiNo=" + KuikiNo;
                    KuikiNo = 0;
                }
                if(null == Junro)
                {
                    url += "/Junro=" + Junro;
                    Junro = 0;
                }
                if(null == Junro_Sub)
                {
                    url += "/Junro_Sub=" + Junro_Sub;
                    Junro_Sub = 0;
                }
                if(null == DokusyaName)
                {
                    url += "/DokusyaName=" + DokusyaName;
                    DokusyaName = "none";
                }
                if (null == DokusyaKanaName)
                {
                    url += "/DokusyaKanaName=" + DokusyaKanaName;
                    DokusyaKanaName = "none";
                }
                //stringの可能性
                if (null == PhoneNo)
                {
                    url += "/PhoneNo=" + PhoneNo;
                    PhoneNo = 000;
                }
                //stringの可能性
                if(null == PhoneNo_Sub)
                {
                    url += "/PhoneNo_Sub=" + PhoneNo_Sub;
                    PhoneNo_Sub = "none";
                }
                if (null == CityName)
                {
                    url += "/CityName=" + CityName;
                    CityName = "none";
                }

                if (null == CityAddress)
                {
                    url += "/CityAddress=" + CityAddress;
                    CityAddress = "none";
                }
                if(null == BuildingName)
                {
                    url += "/BuildingName=" + BuildingName;
                    BuildingName = "none";
                }
                if(null == BuildingKanaName)
                {
                    url += "/BuildingKanaName=" + BuildingKanaName;
                    BuildingKanaName = "none";
                }
                if(null == ShitsuBan)
                {
                    url += "/ShitsuBan=" + ShitsuBan;
                    ShitsuBan = 0;
                }

                Console.Write(url);

                Navi.NavigateTo(URLx + "/" + CheckResult +"$" + DokusyaCode + "$" + KuikiNo + "$" +  Junro + "$" + Junro_Sub + "$" + DokusyaName + "$" + DokusyaKanaName + "$" + PhoneNo + "$" + PhoneNo_Sub + "$" + CityAddress + "$" + BuildingName + "$" + BuildingKanaName + "$" + ShitsuBan);

                //Navi.NavigateTo(URLx + "/" + DokusyaCode + "/" + KuikiNo);

                //Navi.NavigateTo(URLx + "/" + DokusyaCode + "/" + KuikiNo + "/" + Junro + "/" + Junro_Sub + "/" + DokusyaName + "/" + DokusyaKanaName + "/" + PhoneNo + "/" + PhoneNo_Sub + "/" + CityAddress + "/" + BuildingName + "/" + BuildingKanaName + "/" + ShitsuBan + "/" + CheckResult + "/");
            }
        }

        public string CheckResult { get; set; }

        public void CheckBoxResulte(string Code , object CheckedValue)
        {

            CheckResult = CheckResult + Code + "or";
        
        }

        //JavaScript

        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        public  string ConvertText;

        public string A;
        public Boolean B =false;




        public async void ConvertString(string X) 
        {
            //ConvertText 
            ConvertText = await JSRuntime.InvokeAsync<string> ("Convert", X);
            Console.WriteLine("Return is : " + ConvertText);
            BuildingKanaName = ConvertText;

            StateHasChanged();
        }


    }
}
