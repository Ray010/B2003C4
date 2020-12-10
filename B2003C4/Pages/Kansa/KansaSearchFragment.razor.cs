using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Dynamic;
using System.Text;
using Microsoft.JSInterop;

using B2003C4.Data;
using B2003C4.Class;


namespace B2003C4.Pages.Kansa
{

    public partial class KansaSearchFragment
    {

        //海老沼書き足しｽﾞｲ₍₍(ง˘ω˘)ว⁾⁾ｽﾞｲ（仮
        //精神と時の部屋
        [Parameter]
        public FormSearchDataModel Phase1Data { get; set; }
        [Parameter]
        public EventCallback<FormSearchDataModel> Phase1DataChanged { get; set; }

        [Parameter]
        public DummyDataModel DBSourceData { get; set; }

        [Parameter]
        public EventCallback<DummyDataModel> DBSourceDataChanged { get; set; }

        [Parameter]
        public FormSearchDataModel SearchResultData { get; set; }
        [Parameter]
        public EventCallback<FormSearchDataModel> SearchResultDataChanged { get; set; }



        private async Task UpdateModelDataOrPhaseShift()
        {
            SearchResultData.PhaseNo = 2;
            await SearchResultDataChanged.InvokeAsync(SearchResultData);
            StateHasChanged();
        
           
        }
        //-------------------------------------------------------


        public int KubunCount { get; set; }

        public Boolean Kuiki_SelectFlg { get; set; } = false;
        //string Kuiki_SelectedValue;
        uint? Kuiki_SelectedValue;
        uint? Kuiki_SelectValue
        { get => Kuiki_SelectedValue; set { Kuiki_SelectedValue = value; } }



        public Boolean CityName_SelectFlg { get; set; } = false;
        //string Kuiki_SelectedValue;
        string CityName_SelectedValue;
        string CityName_SelectValue
        { get => CityName_SelectedValue; set { CityName_SelectedValue = value; } }



        public int KubunButton;
        public int X;
        public string y;

        public string Checked = "checked";



 //ユーザーが入力した値

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
            new Kubun("未読","Midoku",""),
            new Kubun("現読","Gendoku",""),
            new Kubun("予約","Yoyaku",""),
            new Kubun("止め","Tome",""),
            new Kubun("休読","Kyudoku",""),
            new Kubun("保留","Horyu",""),
            new Kubun("発証","Hassyo",""),
            new Kubun("順路","Junro",""),
            new Kubun("不良","Huryo",""),
            new Kubun("空家","Akiya",""),
            new Kubun("他現","Tagen",""),
        };


        public class Kubun
        {
            

            public string KubunName { get; set; }
            public string KubunCode { get; set; }

            public string Active;

            public Kubun(string kubunName , string kubunCode , string active)
            {
                KubunName = kubunName;
                KubunCode = kubunCode;
                Active = active;
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

        public string[] CityList = new string[0] { };
        public int CityCount;

        protected override void OnInitialized()
        {
            for(int x = 0; x <= Phase1Data.CheckResult.Length ; x++)
            {
                foreach(var y in KubunList)
                {
                    try
                    { 
                        if(y.KubunCode.Contains(Phase1Data.CheckResult[x]) == true )
                        {
                            y.Active = "checked";
                        }
                    }
                    catch(IndexOutOfRangeException)
                    { }
                }
            }

            foreach(var CityName in DBSourceData.DokusyaList)
            {
                if(Array.IndexOf(CityList , CityName.CityName) == -1)
                {
                    Array.Resize(ref CityList, CityList.Length + 1);
                    CityList[CityList.Length - 1] = CityName.CityName;
                }

            }
            CityCount = CityList.Count();

            //---------------------------------------------------------
            //履歴の処理
            if (Phase1Data.HistoryBackState == false)
            {
                History.Back_History.Add(Phase1Data.Deep_Copy());   //.Add(CurrentPage);
                Phase1DataChanged.InvokeAsync(Phase1Data);
            }
            else if (Phase1Data.HistoryBackState == true)
            {
                Phase1Data.HistoryBackState = false;
                Phase1DataChanged.InvokeAsync(Phase1Data);
            }
        }

        public void Clear()
        {
            Kuiki_SelectValue = null;
            CheckResult = null;
            Phase1Data = new FormSearchDataModel();
            Phase1DataChanged.InvokeAsync(Phase1Data);
        }

        public void OnChangeEventKuiki(uint? X)
        {
            Kuiki_SelectedValue = X;
            Kuiki_SelectFlg = true;
            Phase1Data.S_KuikiNo = Kuiki_SelectedValue;
        }

        public void OnChangeEventCityName(string X)
        {
            CityName_SelectedValue = X;
            CityName_SelectFlg = true;
            Phase1Data.S_CityName = CityName_SelectedValue;
        }

        /*
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
        */
        public string CheckResult { get; set; }

        public void CheckBoxResulte(string Code)
        {

            if(Array.IndexOf(Phase1Data.CheckResult , Code ) != -1)
            {
                Phase1Data.CheckResult[Array.IndexOf(Phase1Data.CheckResult, Code)] = Phase1Data.CheckResult[Phase1Data.CheckResult.Length - 1];
                Array.Resize(ref Phase1Data.CheckResult, Phase1Data.CheckResult.Length - 1);

            } 
            else
            {
                Array.Resize(ref Phase1Data.CheckResult, Phase1Data.CheckResult.Length + 1);
                Phase1Data.CheckResult[Phase1Data.CheckResult.Length - 1] = Code;
                Phase1DataChanged.InvokeAsync(Phase1Data);
                Console.WriteLine(Phase1Data.CheckResult[Phase1Data.CheckResult.Length - 1]);
                Console.WriteLine(Phase1Data.CheckResult.Length);
            }
        }

        //JavaScript

        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        public  string ConvertText;

        public async void ConvertString(string X) 
        {
            //ConvertText 
            ConvertText = await JSRuntime.InvokeAsync<string> ("Convert", X);
            Console.WriteLine("Return is : " + ConvertText);
            Phase1Data.S_BuildingKanaName = ConvertText;

            StateHasChanged();
        }
    }
}
