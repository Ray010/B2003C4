using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

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

        List<Lists> IriTomeList = new List<Lists>();

        public class Lists
        {
            public Iri_K95010 IriList;
            public Tome_K95010 TomeList;

            public Lists(Iri_K95010 iriList,Tome_K95010 tomeList)
            {
                IriList = iriList;
                TomeList = tomeList;
            }
        }

        public List<Iri_K95010> IriList = new List<Iri_K95010>();
        public List<Tome_K95010> TomeList = new List<Tome_K95010>();

        public int Count = 0;

        /*レイアウト*/
        public string Device = "iPhone5s";

        public string Layout_Button;

        public string Layout_Long;

        public string Layout_Middle_M;

        public string Layout_Middle_S;

        public string Layout_Small;

        public string Active_Layout_Middle_S;




        public void ListSort()
        {
            IriList = C_IriList.Where(x => x.Kuiki == Kuiki_SelectedValue)
                .ToList();

            for (IriCount = 0 ; IriCount < IriList.Count; IriCount++)
            {
                if(IriList[IriCount].NextKeiyaku == 1)
                {
                    IriList[IriCount].NextKeiyaku = 13626623;
                }
                else if (IriList[IriCount].NextKeiyaku == 2)
                {
                    IriList[IriCount].NextKeiyaku = 11597763;
                }
                else if(IriList[IriCount].NextKeiyaku == 0)
                {
                    IriList[IriCount].NextKeiyaku = 16777215;
                }


                if(IriList[IriCount].Tantokbn == 1)
                {
                    IriList[IriCount].Tantokbn = 16711680;
                }
                else if( IriList[IriCount].Tantokbn != 16711680)
                {
                    IriList[IriCount].Tantokbn = 0;
                }
            }

            TomeList = C_TomeList.Where(x => x.Kuiki == Kuiki_SelectedValue)
                .ToList();

            for (TomeCount = 0; TomeCount < TomeList.Count; TomeCount++)
            {
                if (TomeList[TomeCount].NextKeiyaku == 1)
                {
                    TomeList[TomeCount].NextKeiyaku = 13626623;
                }
                else if (TomeList[TomeCount].NextKeiyaku == 2)
                {
                    TomeList[TomeCount].NextKeiyaku = 11597763;
                }
                else if (TomeList[TomeCount].NextKeiyaku == 0)
                {
                    TomeList[TomeCount].NextKeiyaku = 16777215;
                }


                if (TomeList[TomeCount].Tantokbn == 1)
                {
                    TomeList[TomeCount].Tantokbn = 16711680;
                }
                else if (TomeList[TomeCount].Tantokbn != 16711680)
                {
                    TomeList[TomeCount].Tantokbn = 0;
                }
            }
        }
        public object Convert(int? x)
        {
            if (x == null)
            {
                X = 0;
            }
            else
            {
                X = (int)x;
            }
            ColorCode = X.ToString("X4");
            return ColorCode;
        }



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
                    Active_Layout_Middle_S = Layout_Middle_S;
                    break;

                default:
                    break;

            }

            ListSort();

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
            if ("null" == e.Value.ToString())
            {
                SelectedValue = null;
            }
            else
            {
                SelectedValue = e.Value.ToString();
                SelectedFlg = true;
            }

            ListSort();
        }
        //年月終わり

        public void ButtonActive(string ButtonName)
        {
            if(ButtonName == "Iri")
            {
                if (Phase1Data.TomeActive == true)
                {
                    Active_Layout_Middle_S = "mat-layout-grid-cell-span-4";
                    Phase1Data.TomeActive = false;
                }
                else
                {
                    Active_Layout_Middle_S = "mat-layout-grid-cell-span-2";
                    Phase1Data.TomeActive = true;
                }
            }
            else if(ButtonName == "Tome")
            {
                if (Phase1Data.IriActive == true)
                {
                    Active_Layout_Middle_S = "mat-layout-grid-cell-span-4";
                    Phase1Data.IriActive = false;
                }
                else
                {
                    Active_Layout_Middle_S = "mat-layout-grid-cell-span-2";
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
