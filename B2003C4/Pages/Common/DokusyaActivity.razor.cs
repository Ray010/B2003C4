using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using B2003C4.Data;
using B2003C4.Class;
using Microsoft.JSInterop;

using System.Text;

namespace B2003C4.Pages.Common
{
    public partial class DokusyaActivity
    {

        //海老沼書き足しｽﾞｲ₍₍(ง˘ω˘)ว⁾⁾ｽﾞｲ（仮）
        //バインド受け取り
        [Parameter]
        public FormSearchDataModel CommonPhase1 { get; set; }
        [Parameter]
        public EventCallback<FormSearchDataModel> CommonPhase1Changed { get; set; }

        [Parameter]
        public DummyDataModel DBSourceData { get; set; }

        [Parameter]
        public EventCallback<DummyDataModel> DBSourceDataChanged { get; set; }

        /*
        [Parameter]
        public KoudokuDummyData KoudokuList { get; set; }

        [Parameter]
        public EventCallback<KoudokuDummyData> KoudokuListChanged { get; set; }

        
        */

        //DB------------------------------------------------------------------------------------------

        [Parameter]
        public List<Dokusya_K95010> C_DokusyaList { get; set; }

        [Parameter]
        public EventCallback<List<Dokusya_K95010>> C_DokusyaListChanged { get; set; }

        [Parameter]
        public List<Koudoku_K95010> C_KoudokuList { get; set; }

        [Parameter]
        public EventCallback<List<Koudoku_K95010>> C_KoudokuListChanged { get; set; }


        //K95010
        [Parameter]
        public List<Dokusya_K95010> C_Dokusya_K95010_List { get; set; }

        [Parameter]
        public EventCallback<List<Dokusya_K95010>> C_Dokusya_K95010_ListChanged { get; set; }

        [Parameter]
        public List<Koudoku_K95010> C_Koudoku_K95010_List { get; set; }

        [Parameter]
        public EventCallback<List<Koudoku_K95010>> C_Koudoku_K95010_ListChanged { get; set; }

        //K95020
        [Parameter]
        public List<Dokusya_K95020> C_Dokusya_K95020_List { get; set; }

        [Parameter]
        public EventCallback<List<Dokusya_K95020>> C_Dokusya_K95020_ListChanged { get; set; }

        [Parameter]
        public List<Koudoku_K95020> C_Koudoku_K95020_List { get; set; }

        [Parameter]
        public EventCallback<List<Koudoku_K95020>> C_Koudoku_K95020_ListChanged { get; set; }



        
        //K95080
        [Parameter]
        public List<Dokusya_K95080> C_DokusyaList_K95080 { get; set; }

        [Parameter]
        public EventCallback<List<Dokusya_K95080>> C_DokusyaList_K95080Changed { get; set; }

        [Parameter]
        public List<Koudoku_K95080> C_KoudokuList_K95080 { get; set; }

        [Parameter]
        public EventCallback<List<Koudoku_K95080>> C_KoudokuList_K95080Changed { get; set; }



        //DB------------------------------------------------------------------------------------------

        public List<Dokusya_K95010> Temp_DokusyaList { get; set; } = new List<Dokusya_K95010>(); //検索済み購読リスト

        public List<Koudoku_K95010> Temp_KoudokuList { get; set; } = new List<Koudoku_K95010>(); //購読リスト(Temp)
        public List<Koudoku_K95010> S_KoudokuList { get; set; } = new List<Koudoku_K95010>(); //検索済み購読リスト


        

        /*
        private async Task UpdateModelDataOrPhaseShift()
        {
            CommonPhase1.PhaseNo = 2;
            await CommonPhase1Changed.InvokeAsync(CommonPhase1);
            StateHasChanged();


        }
        */

        protected override void OnInitialized()
        {



            switch (CommonPhase1.IndexURL)
            {
                case "IriTome":
           
                    goto End;

                case "Kako":
                    
                    goto End;



                case "Kansa":
                    var DokusyaList_K95080 = C_DokusyaList_K95080.FirstOrDefault(n => n.DokuCode == CommonPhase1.S_DokuCode);
                    
                    KoumokuList[0].Value = DokusyaList_K95080.DokuCode.ToString();
                    KoumokuList[1].Value = DokusyaList_K95080.DokuName;
                    KoumokuList[2].Value = DokusyaList_K95080.BuildName;
                    KoumokuList[3].Value = DokusyaList_K95080.ChomeiName + " " + DokusyaList_K95080.Banti_Kansa +"-"+ DokusyaList_K95080.Gou;
                    KoumokuList[4].Value = DokusyaList_K95080.Tel1;
                    KoumokuList[5].Value = DokusyaList_K95080.Misebi1; //DokusyaList.S_MiseBikou;
                    KoumokuList[6].Value = DokusyaList_K95080.Syumemo1; // DokusyaList.S_Junro_Bikou;
                    KoumokuList[7].Value = DokusyaList_K95080.Bunrui; //DokusyaList.S_MoneyRemarks;
                    KoumokuList[8].Value = DokusyaList_K95080.Rank; //DokusyaList.S_Class;
                    //KoumokuList[9].Value = " "; //DokusyaList.S_Lank

                    foreach (var Temp_KoudokuList in C_KoudokuList_K95080)
                    {
                        if (CommonPhase1.S_DokuCode == Temp_KoudokuList.DokuCode)
                        {
                            S_KoudokuList.Add(Temp_KoudokuList);
                        }
                        else
                        {
                            continue;
                        }
                    }

                    break;                                         
                    
                End:
                    var DokusyaList = C_DokusyaList.FirstOrDefault(n => n.DokuCode == CommonPhase1.S_DokuCode);

                    KoumokuList[0].Value = DokusyaList.DokuCode.ToString();
                    KoumokuList[1].Value = DokusyaList.Name;
                    KoumokuList[2].Value = DokusyaList.Build;
                    KoumokuList[3].Value = DokusyaList.AddressRyaku + " " + DokusyaList.Banti;
                    KoumokuList[4].Value = DokusyaList.Tel;
                    KoumokuList[5].Value = DokusyaList.Misebi1; //DokusyaList.S_MiseBikou;
                    KoumokuList[6].Value = DokusyaList.Syumemo1; // DokusyaList.S_Junro_Bikou;
                    KoumokuList[7].Value = DokusyaList.Bunrui; //DokusyaList.S_MoneyRemarks;
                    KoumokuList[8].Value = DokusyaList.Rank; //DokusyaList.S_Class;

                    foreach (var Temp_KoudokuList in C_KoudokuList)
                    {
                        if (CommonPhase1.S_DokuCode == Temp_KoudokuList.DokuCode)
                        {
                            S_KoudokuList.Add(Temp_KoudokuList);
                        }
                        else
                        {
                            continue;
                        }
                    }

                    break;                                         //KoumokuList[9].Value = " "; //DokusyaList.S_Lank


            }
            /*
            var x = C_Dokusya_K95020_List.Cast<Dokusya_K95010>();

            List<Dokusya_K95010> y = x.ToList();
        */

            if(CommonPhase1.HistoryBackState == false)
            {
                History.Back_History.Add(CommonPhase1.Deep_Copy());   //.Add(CurrentPage);
                CommonPhase1Changed.InvokeAsync(CommonPhase1);
            }
            else if (CommonPhase1.HistoryBackState == true)
            {
                CommonPhase1.HistoryBackState = false;
                CommonPhase1Changed.InvokeAsync(CommonPhase1);
            }
        } 

        public int Count { get; set; }

        public string temp;


        public string ButtonColor = "#01579B";
        public string Riyu = "入理由";
        public string Keiyaku="契約日";

        List <Koumoku> KoumokuList = new List<Koumoku>()
        {
            new Koumoku ("読者番号","DokusyaNo",""),
            new Koumoku ("読者名","DokusyaName",""),
            new Koumoku ("建物名","BuildingName",""),
            new Koumoku ("町名","CityFullName",""),
            new Koumoku ("電話番号","PhoneNo",""),
            new Koumoku ("店備考","TenpoRemarks",""),
            new Koumoku ("集金メモ","MoneyRemarks",""),
            new Koumoku ("分類","Class",""),
            new Koumoku ("ランク","Lank",""),
        };


        [Inject]
        protected NavigationManager Navi { get; set; }

        public void JumpPage(string URLx)
        {
            CommonPhase1.PhaseNo = 12;
            CommonPhase1Changed.InvokeAsync(CommonPhase1);

            //Navi.NavigateTo(URLx);
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



        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        public async void GoToGoogleMap(string address)
        {
            string returnDevice = await JSRuntime.InvokeAsync<string>("Device");
            if(returnDevice == "Mobile" )
            {
                Navi.NavigateTo("https://www.google.com/maps/search/?api=1&query=" + CommonPhase1.S_ChomeiName + "丁目" + CommonPhase1.S_CityAddress);
            }
            else if(returnDevice == "PC")
            {
                await JSRuntime.InvokeAsync<object>("open", "https://www.google.com/maps/search/?api=1&query=" + CommonPhase1.S_ChomeiName +
                "丁目" + CommonPhase1.S_CityAddress, "_blank");
            }
            else if(returnDevice == "iPhone")
            {

                Navi.NavigateTo("https://maps.apple.com/?q=" + CommonPhase1.S_ChomeiName + "丁目" + CommonPhase1.S_CityAddress);
                /*Navi.NavigateTo("comgooglemaps://?q=" + CommonPhase1.S_CityName + "丁目" + CommonPhase1.S_CityAddress);*/
            }
        }
    }

    public class Koumoku //表示情報格納用（仮）
    {
        public string Heading; //読者番号

        public string HeadingCode;

        public string Value;

        public Koumoku(string heading, string headingCode, string value)
        {
            Heading = heading;

            HeadingCode = headingCode;

            Value = value;
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

        public Meihan(string dokusyaNo, string meihanName, string keiyakuSt, string keiyakuEd, string keiyakusyaName, string tsukisu, string hey, string iririyu, string keiyakubi, string tomeriyu, string tomebi)
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




}
