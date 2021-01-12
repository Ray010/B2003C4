using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;

using B2003C4.Class;
using B2003C4.Data;


namespace B2003C4.Pages.IriTome
{
    public partial class MainFragment
    {
        //年月関連
        public Boolean SelectedFlg { get; set; } = false;
        string SelectedValue;
        string SelectValue
        { get => SelectedValue; set { SelectedValue = value; } }

        public int? Nengetu_SelectedValue = 0;

        //区域関連
        public Boolean Kuiki_SelectedFlg { get; set; } = false;
        int? Kuiki_SelectedValue = 1;
        

        [Parameter]
        public FormSearchDataModel Phase1Data { get; set; }
        [Parameter]
        public EventCallback<FormSearchDataModel> Phase1DataChanged { get; set; }

        [Parameter]
        public DummyDataModel DBSourceData { get; set; }

        [Parameter]
        public EventCallback<DummyDataModel> DBSourceDataChanged { get; set; }

        //DB-----------------------------------------------------------------------------------

        [Parameter]
        public List<Iri_K95010> C_IriList { get; set; }

        [Parameter]
        public EventCallback<List<Iri_K95010>> C_IriListChanged { get; set; }

        [Parameter]
        public List<Tome_K95010> C_TomeList { get; set; }

        [Parameter]
        public EventCallback<List<Tome_K95010>> C_TomeListChanged { get; set; }

        [Parameter]
        public List<Kuiki_K95010> C_KuikiList { get; set; }

        [Parameter]
        public EventCallback<List<Kuiki_K95010>> C_KuikiListChanged { get; set; }

        [Parameter]
        public List<Nengetu_K95010> C_NengetuList { get; set; }

        [Parameter]
        public EventCallback<List<Nengetu_K95010>> C_NengetuListChanged { get; set; }


        //DB-----------------------------------------------------------------------------------


        //その他
        public Boolean IriActive { get; set; } = true;

        public Boolean TomeActive { get; set; } = true;


        public int IriCount { get; set; }

        public int TomeCount { get; set; }



        List<Nengetu> NengetuList = new List<Nengetu>() {
                    new Nengetu (2010, "2020年10月"),
                    new Nengetu (2011, "2020年11月"),
                    new Nengetu (2012, "2020年12月")
        };

        /* 年月用クラス */
        public class Nengetu
        {
            public int nengetu { get; set; }
            public string dispNengetu { get; set; }
            public Nengetu(int Nengetu, string DispNengetu)
            {
                nengetu = Nengetu;
                dispNengetu = DispNengetu;
            }
        }

        /* 
        * セレクトリストのonchangeイベント
        * 引数の「ChangeEventArgs」内に、選択された項目のValue値が入り込んで受け取ることができる。
        */
        /*
        public void OnChangeEventNengetu(int X)
        {
            SelectedValue = X;
            SelectedFlg = true;
            Y = null;
        }
        */

        /*
        public void OnChangeEventKuiki(string X)
        {
            
            Kuiki_SelectedValue = X;
            Kuiki_SelectedFlg = true;
        }
        */

        //海老沼書き足しｽﾞｲ₍₍(ง˘ω˘)ว⁾⁾ｽﾞｲ（仮）

        //-------------------------------------------------------------

        List<DummyDataModel.Dokusya> IriDokusyaList = new List<DummyDataModel.Dokusya>();
        List<DummyDataModel.Dokusya> TomeDokusyaList = new List<DummyDataModel.Dokusya>();

        public int Count = 0;
        protected override void OnInitialized()
        {
            //---------------------------------------------------------
            //履歴の処理

            /*
            Phase1Data.Back_History.Add(Phase1Data);
            Phase1DataChanged.InvokeAsync(Phase1Data);
            */
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
            //System.Threading.Thread.Sleep(1000);
            Console.WriteLine("MainFragment OK");
        }

        //区域
        public void OnChangeEventKuikiX(ChangeEventArgs e)
        {

        }
        //区域終わり

        //年月
        public void OnChangeEventNengetuX(ChangeEventArgs e)
        {
            IriCount = 0;
            TomeCount = 0;

            if ("null" == e.Value.ToString())
            {
                SelectedValue = null;
            }
            else
            {
                SelectedValue = e.Value.ToString();
                SelectedFlg = true;
            }

            foreach (var x in C_IriList)
            {
                if (Kuiki_SelectedValue == x.Kuiki &&
                  (SelectValue == x.iri || SelectValue == null))

                //if (Kuiki_SelectedValue == x.Kuiki)
                {
                    IriCount++;
                }
                else
                {
                    continue;
                }
            }
            foreach (var x in C_TomeList)
            {
                if (Kuiki_SelectedValue == x.Kuiki &&
                    (SelectValue  == x.tome || SelectValue == null))

                //if (Kuiki_SelectedValue == x.Kuiki)
                {
                    TomeCount++;
                }
                else
                {
                    continue;
                }
            }
        }
        //年月終わり

        public void ButtonActive(string ButtonName)
        {
            if(ButtonName == "Iri")
            {
                if (Phase1Data.TomeActive == true)
                {
                    Phase1Data.TomeActive = false;
                }
                else
                {
                    Phase1Data.TomeActive = true;
                }
            }
            else if(ButtonName == "Tome")
            {
                if (Phase1Data.IriActive == true)
                {
                    Phase1Data.IriActive = false;
                }
                else
                {
                    Phase1Data.IriActive = true;
                }
            }

            if((Phase1Data.IriActive == true && Phase1Data.TomeActive == true))
            {
                History.Back_History.RemoveAt(History.Back_History.Count - 1);
                History.Back_History[History.Back_History.Count - 1].ButtonState = false;
                Phase1Data.ButtonState = false;

            }
            else
            {

                History.Back_History[History.Back_History.Count-1].ButtonState = true;
                History.Back_History.Add(Phase1Data.Deep_Copy());
                
            }
            Phase1DataChanged.InvokeAsync(Phase1Data);
        }


        public void IriButtonActive() //入ボタンが押されたとき入を全画面に表示する
        {
            if (Phase1Data.TomeActive == true)
            {
                Phase1Data.TomeActive = false;
            }
            else
            {
                Phase1Data.TomeActive = true;
            }

        }
        public void TomeButtonActive() //止ボタンが押されたとき止を全画面に表示する
        {
            if (Phase1Data.IriActive == true)
            {
                Phase1Data.IriActive = false;
            }
            else
            {
                Phase1Data.IriActive = true;
            }

        }

        [Inject]
        protected NavigationManager Navi { get; set; }


        public async void JumpPageIri(Iri_K95010 OnDokusya)
        {
            Phase1Data.S_DokuCode = OnDokusya.DokuCode;
            Phase1Data.S_DokuName = OnDokusya.Name;
            Phase1Data.S_BuildName = OnDokusya.Build;
            Phase1Data.S_ChomeiName = OnDokusya.Address;
            //Phase1Data.S_CityAddress = OnDokusya.CityAddress;
            //Phase1Data.S_PhoneNo_Sub = OnDokusya.PhoneNo_Sub;
            //Phase1Data.S_KuikiNo = OnDokusya.Kuiki;

            Phase1Data.PhaseNo = 11;
            await Phase1DataChanged.InvokeAsync(Phase1Data);
            StateHasChanged();
        }

        public async void JumpPageTome(Tome_K95010 OnDokusya)
        {
            Phase1Data.S_DokuCode = OnDokusya.DokuCode;
            Phase1Data.S_DokuName = OnDokusya.Name;
            Phase1Data.S_BuildName = OnDokusya.Build;
            Phase1Data.S_ChomeiName = OnDokusya.Address;
            //Phase1Data.S_CityAddress = OnDokusya.CityAddress;
            //Phase1Data.S_PhoneNo_Sub = OnDokusya.PhoneNo_Sub;
            //Phase1Data.S_KuikiNo = OnDokusya.Kuiki;

            Phase1Data.PhaseNo = 11;
            await Phase1DataChanged.InvokeAsync(Phase1Data);
            StateHasChanged();
        }


    }
}
