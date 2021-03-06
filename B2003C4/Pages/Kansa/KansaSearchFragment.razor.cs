﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Dynamic;
using System.Text;
using Microsoft.JSInterop;

using B2003C4.Data;
using B2003C4.Class;

using MatBlazor;


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
        public List<Dokusya_K95080> C_SearchingList { get; set; }

        [Parameter]
        public EventCallback<List<Dokusya_K95080>> C_SearchingListChanged { get; set; }


        //DB-------------------------------------------------------------------------------

        [Parameter]
        public List<Dokusya_K95080> C_DokusyaList { get; set; }

        [Parameter]
        public EventCallback<List<Dokusya_K95080>> C_DokusyaListChanged { get; set; }

        [Parameter]
        public List<Kuiki_K95080> C_KuikiList { get; set; }
        [Parameter]
        public EventCallback<List<Kuiki_K95080>> C_KuikiListChanged { get; set; }





        /*
        [Parameter]
        public FormSearchDataModel SearchResultData { get; set; }
        [Parameter]
        public EventCallback<FormSearchDataModel> SearchResultDataChanged { get; set; }
        */
        //public List<Dokusya_K95080> SearchList = new List<Dokusya_K95080>();

        [Inject]
        protected IMatToaster Toaster { get; set; }

        private async Task UpdateModelDataOrPhaseShift()
        {

            if( null == Phase1Data.S_KuikiNo && 
                null == Phase1Data.S_Junro && 
                null == Phase1Data.S_KuikiJunro && 
                null == Phase1Data.S_DokuCode && 
                null == Phase1Data.S_DokuName && 
                null == Phase1Data.S_DokuKana && 
                null == Phase1Data.S_Sigai && 
                null == Phase1Data.S_Tel && 
                null == Phase1Data.S_ChomeiCode && 
                null == Phase1Data.S_Banti && 
                null == Phase1Data.S_Gou && 
                null == Phase1Data.S_BuildName &&
                null == Phase1Data.S_BuildKana && 
                null == Phase1Data.S_RoomNo )
            {
                Toaster.Add("条件を一つ以上選択してください", MatToastType.Danger, "エラー");
            }
            else
            {
                //検索
                C_SearchingList = C_DokusyaList.Where(x => (x.Kuiki == Phase1Data.S_KuikiNo || null == Phase1Data.S_KuikiNo) &&
                                                                (x.Junro_K95080 >= Phase1Data.S_Junro * 100 || null == Phase1Data.S_Junro) &&
                                                                (x.KuikiJunro % 100 >= Phase1Data.S_KuikiJunro % 100 || null == Phase1Data.S_KuikiJunro) &&
                                                                (x.DokuCode == Phase1Data.S_DokuCode || null == Phase1Data.S_DokuCode) &&
                                                                (null == Phase1Data.S_DokuName || x.DokuName.Contains(Phase1Data.S_DokuName)) &&
                                                                (null == Phase1Data.S_DokuKana || x.DokuKana.Contains(Phase1Data.S_DokuKana)) &&

                                                                (null == Phase1Data.S_Sigai || x.Sigai1.Contains(Phase1Data.S_Sigai)) &&
                                                                (null == Phase1Data.S_Sigai || x.Sigai2.Contains(Phase1Data.S_Sigai)) &&
                                                                (null == Phase1Data.S_Sigai || x.Sigai3.Contains(Phase1Data.S_Sigai)) &&
                                                                (null == Phase1Data.S_Sigai || x.Sigai4.Contains(Phase1Data.S_Sigai)) &&
                                                                (null == Phase1Data.S_Sigai || x.Sigai5.Contains(Phase1Data.S_Sigai)) &&
                                                                (null == Phase1Data.S_Sigai || x.Sigai6.Contains(Phase1Data.S_Sigai)) &&

                                                                (null == Phase1Data.S_Tel || x.Tel1.Contains(Phase1Data.S_Tel)) &&
                                                                (null == Phase1Data.S_Tel || x.Tel2.Contains(Phase1Data.S_Tel)) &&
                                                                (null == Phase1Data.S_Tel || x.Tel3.Contains(Phase1Data.S_Tel)) &&
                                                                (null == Phase1Data.S_Tel || x.Tel4.Contains(Phase1Data.S_Tel)) &&
                                                                (null == Phase1Data.S_Tel || x.Tel5.Contains(Phase1Data.S_Tel)) &&
                                                                (null == Phase1Data.S_Tel || x.Tel6.Contains(Phase1Data.S_Tel)) &&
                                                                
                                                                (null == Phase1Data.S_ChomeiCode || x.ChomeiCode == Phase1Data.S_ChomeiCode) &&
                                                                (null == Phase1Data.S_Banti || x.Banti_Kansa == Phase1Data.S_Banti) &&
                                                                (null == Phase1Data.S_Gou || x.Gou == Phase1Data.S_Gou) &&
                                                                (null == Phase1Data.S_BuildName || x.BuildName.Contains(Phase1Data.S_BuildName)) &&
                                                                (null == Phase1Data.S_BuildKana || x.BuildName.Contains(Phase1Data.S_BuildKana)) &&
                                                                (null == Phase1Data.S_RoomNo || x.RoomNo.Contains(Phase1Data.S_RoomNo.ToString())) &&
                                                                (x.Tenpo == Phase1Data.Select_TenpoNo) &&

                                                                ((true == KubunList[0].Active && x.DokuKbn == KubunList[0].KubunCode)) ||
                                                                ((true == KubunList[1].Active && x.DokuKbn == KubunList[1].KubunCode)) ||
                                                                ((true == KubunList[2].Active && x.DokuKbn == KubunList[2].KubunCode)) ||
                                                                ((true == KubunList[3].Active && x.DokuKbn == KubunList[3].KubunCode)) ||
                                                                ((true == KubunList[4].Active && x.DokuKbn == KubunList[4].KubunCode)) ||
                                                                ((true == KubunList[5].Active && x.DokuKbn == KubunList[5].KubunCode)) ||
                                                                ((true == KubunList[6].Active && x.DokuKbn == KubunList[6].KubunCode)) ||
                                                                ((true == KubunList[7].Active && x.DokuKbn == KubunList[7].KubunCode)) ||
                                                                ((true == KubunList[8].Active && x.DokuKbn == KubunList[8].KubunCode)) ||
                                                                ((true == KubunList[9].Active && x.DokuKbn == KubunList[9].KubunCode)) ||
                                                                ((true == KubunList[10].Active && x.DokuKbn == KubunList[10].KubunCode))
                                                                
                                                                
                                                                ).ToList();
            
                if (C_SearchingList.Count == 0)
                {
                    Toaster.Add("存在しませんでした", MatToastType.Danger, "エラー");
                }
                else
                {
                    Console.WriteLine("OK");
                    Phase1Data.PhaseNo = 2;
                    await C_SearchingListChanged.InvokeAsync(C_SearchingList);
                    await Phase1DataChanged.InvokeAsync(Phase1Data);
                    StateHasChanged();
                }
            }
        }
        
        //-------------------------------------------------------


        public int KubunCount { get; set; }

        public Boolean Kuiki_SelectFlg { get; set; } = false;
        //string Kuiki_SelectedValue;
        int? Kuiki_SelectedValue;
        int? Kuiki_SelectValue
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




        List<Kubun> KubunList = new List<Kubun>()
        {
            new Kubun("未読",0,true),
            new Kubun("現読",1,true),
            new Kubun("予約",2,true),
            new Kubun("止め",3,true),
            new Kubun("休読",4,true),
            new Kubun("保留",5,true),
            new Kubun("発証",6,true),
            new Kubun("順路",7,true),
            new Kubun("不良",8,true),
            new Kubun("空家",9,true),
            new Kubun("他現",10,true),
        };




        public string[] CityList = new string[0] { };
        public int CityCount;

        List<Kuiki> KuikiList = new List<Kuiki>();

        //チェックボックス生成用
        public List<List<Kubun>> ChkBoxList = new List<List<Kubun>>();
        public int ChkBox_Count = 0;



        public string Device = "iPhone5s";

        public string Layout_Button;

        public string Layout_Long;

        public string Layout_Middle_M;

        public string Layout_Middle_S;

        public string Layout_Small;

        public string Scroll_Size = "120vw";

        public Boolean TextInputActive = true; //順路、枝番号の制御用
        
        public List<Chomei> ChomeiList = new List<Chomei>();
        protected override void OnInitialized()
        {   
 

                switch (Device)
                {
                    case "iPhone5s":
                        Layout_Button = "mat-layout-grid-cell-span-2";
                        Layout_Long = "mat-layout-grid-cell-span-12";
                        Layout_Middle_M = "mat-layout-grid-cell-span-3";
                        Layout_Middle_S = "mat-layout-grid-cell-span-2";
                        Layout_Small = "mat-layout-grid-cell-span-1";

                        break;

                    default:
                        break;

                }

                foreach (var x in C_DokusyaList)
                {
                    ChomeiList.Add(new Chomei(x.ChomeiName, x.ChomeiCode));
                }

                //区域
                foreach (var Kuiki in C_KuikiList)
                {
                    if (Phase1Data.Select_TenpoNo == Kuiki.Tenpo)
                    {
                        KuikiList.Add(new Kuiki(Kuiki.Name, Kuiki.Kuiki));
                    }
                    else
                    {
                        continue;
                    }
                }



                foreach (var CityName in DBSourceData.DokusyaList)
                {
                    if (Array.IndexOf(CityList, CityName.CityName) == -1)
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
            foreach(var Kubun in KubunList)
            {
                Kubun.Active = true;
            }

            Phase1Data = new FormSearchDataModel();
            Phase1DataChanged.InvokeAsync(Phase1Data);
        }

        public void OnChangeEventKuiki(int? X)
        {
            Kuiki_SelectedValue = X;
            Kuiki_SelectFlg = true;
            Phase1Data.S_KuikiNo = Kuiki_SelectedValue;
        }

        public void OnChangeEventCityName(string X)
        {
            CityName_SelectedValue = X;
            CityName_SelectFlg = true;
            Phase1Data.S_ChomeiName = CityName_SelectedValue;
        }

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
            Phase1Data.S_BuildKana = ConvertText;

            StateHasChanged();
        }
    }
    public class Kubun
    {
        public string KubunName { get; set; }
        public int? KubunCode { get; set; }

        public Boolean Active;

        public Kubun(string kubunName, int? kubunCode, Boolean active)
        {
            KubunName = kubunName;
            KubunCode = kubunCode;
            Active = active;
        }
    }

    public class Chomei
    {
        public string ChomeiName { get; set; }
        public int? ChomeiCode { get; set; }

        public Chomei(string chomeiName, int? chomeiCode)
        {
            ChomeiName = chomeiName;
            ChomeiCode = chomeiCode;

        }
    }

    public class Kuiki
    {
        public string KuikiName { get; set; }
        public int? KuikiCode { get; set; }

        public Kuiki(string kuikiName, int? kuikiCode)
        {
            KuikiName = kuikiName;
            KuikiCode = kuikiCode;
        }
    }
}
