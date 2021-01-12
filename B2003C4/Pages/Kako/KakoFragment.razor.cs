using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using B2003C4.Data;
using B2003C4.Class;

namespace B2003C4.Pages.Kako
{
    public partial class KakoFragment
    {

        //年月関連
        public Boolean SelectedFlag { get; set; } = false;

        string SelectedValue; //選択された月

        string SelectValue { get => SelectedValue; set { SelectedValue = value; } } //選択された月（”年”、”月”こみ）


        //区域関連
        public Boolean Kuiki_SelectedFlag { get; set; } = false;

        uint Kuiki_SelectedValue = 1; //選択された区域（数値のみ）

        string Kuiki_SelectValue { get => SelectedValue; set { SelectedValue = value; } } //選択された区域（”区”こみ）

        //その他
        public int Count { get; set; } //検索結果の総数

        [Parameter]
        public FormSearchDataModel Phase1Data { get; set; }
        [Parameter]
        public EventCallback<FormSearchDataModel> Phase1DataChanged { get; set; }

        [Parameter]
        public DummyDataModel DBSourceData { get; set; }

        [Parameter]
        public EventCallback<DummyDataModel> DBSourceDataChanged { get; set; }


        //DB-------------------------------------------------------------------------
        
        [Parameter]
        public List<Tome_K95020> C_TomeList { get; set; }

        [Parameter]
        public EventCallback<List<Tome_K95020>> C_TomeListChanged { get; set; }

        [Parameter]
        public List<Kuiki_K95020> C_KuikiList { get; set; }

        [Parameter]
        public EventCallback<List<Kuiki_K95020>> C_KuikiListChanged { get; set; }

        //DB-------------------------------------------------------------------------

        /*
        [Parameter]
        public FormSearchDataModel SearchResultData { get; set; }
        [Parameter]
        public EventCallback<FormSearchDataModel> SearchResultDataChanged { get; set; }
        */
        List<DummyDataModel.Dokusya> TomeDokusyaList = new List<DummyDataModel.Dokusya>();

        string TenpoNo { get; set; } = "0"; //仮


        //仮データ
        List<Nengetu> NengetuList = new List<Nengetu>() {
                    new Nengetu ("20/10", "2020年10月"),
                    new Nengetu ("20/11", "2020年11月"),
                    new Nengetu ("20/12", "2020年12月")
        };

        List<Kuiki> TenpoKuiki = new List<Kuiki>();

        /* 年月用クラス */
        public class Nengetu
        {
            public string nengetu { get; set; }
            public string dispNengetu { get; set; }
            public Nengetu(string Nengetu, string DispNengetu)
            {
                nengetu = Nengetu;
                dispNengetu = DispNengetu;
            }
        }

        //区域用クラス
        public class Kuiki
        {
            public int? TenpoNo { get; set; } //店舗ナンバー
            public int? KuikiNo { get; set; } //区域ナンバー
            public string KuikiName { get; set; } //区域名

            public Kuiki(int? tenpoNo , int? kuikiNo, string kuikiName)
            {
                TenpoNo = tenpoNo;
                KuikiNo = kuikiNo;
                KuikiName = kuikiName;
            }
        }

        public class Dokusya
        {
            public string Kuiki; //区域番号
            public string DokusyaName; //読者名
            public string CityName; //町名
            public string CityAddress; //町名以降
            public string B; //わからん
            public string Keiyaku;

            public Dokusya(string kuiki , string dokusyaName , string cityName ,string cityAddress , string b , string keiyaku)
            {
                Kuiki = kuiki;
                DokusyaName = dokusyaName;
                CityName = cityName;
                CityAddress = cityAddress;
                B = b;
                Keiyaku = keiyaku;
            }
        }

        //検索総数(ページ開始直後)
        protected override void OnInitialized()
        {
            foreach(var Kuiki in C_KuikiList)
            {
                if(Kuiki.Tenpo == Phase1Data.Select_TenpoNo)
                {
                    TenpoKuiki.Add(new Kuiki(Kuiki.Tenpo, Kuiki.Kuiki, Kuiki.Name));
                }
                else
                {
                    continue;
                }
                    
            }




            foreach (var x in DBSourceData.DokusyaList)
            {
                if (Kuiki_SelectedValue == x.Kuiki)
                {
                    TomeDokusyaList.Add(x);
                    Count++;
                }
                else
                {
                    continue;
                }
            }

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

        public void OnChangeEventKuiki(ChangeEventArgs f)
        {
            Count = 0;
            Kuiki_SelectedValue = uint.Parse(f.Value.ToString());
            Kuiki_SelectedFlag = true;
            TomeDokusyaList.Clear();

            //検索総数
            foreach (var x in DBSourceData.DokusyaList)
            {
                if (Kuiki_SelectedValue == x.Kuiki)
                {
                    TomeDokusyaList.Add(x);
                    Count++;
                }
                else
                {
                    continue;
                }
            }
        }

        [Inject]
        protected NavigationManager Navi { get; set; }
        public async void JumpPage(Tome_K95020 OnDokusya)
        {
            Phase1Data.S_DokuCode = OnDokusya.DokuCode;


            Phase1Data.PhaseNo = 11;
            await Phase1DataChanged.InvokeAsync(Phase1Data);
            StateHasChanged();
        }
    }
}

