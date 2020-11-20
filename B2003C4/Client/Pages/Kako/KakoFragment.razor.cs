using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using B2003C4.Client.Data;

namespace B2003C4.Client.Pages.Kako
{
    public partial class KakoFragment
    {

        //年月関連
        public Boolean SelectedFlag { get; set; } = false;

        string SelectedValue; //選択された月

        string SelectValue { get => SelectedValue; set { SelectedValue = value; } } //選択された月（”年”、”月”こみ）


        //区域関連
        public Boolean Kuiki_SelectedFlag { get; set; } = false;

        string Kuiki_SelectedValue = "1"; //選択された区域（数値のみ）

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

        [Parameter]
        public FormSearchDataModel SearchResultData { get; set; }
        [Parameter]
        public EventCallback<FormSearchDataModel> SearchResultDataChanged { get; set; }


        List<DummyDataModel.Dokusya> DokusyaList = new List<DummyDataModel.Dokusya>();







        string TenpoNo { get; set; } = "0"; //仮


        //仮データ

        List<Nengetu> NengetuList = new List<Nengetu>() {
                    new Nengetu ("20/10", "2020年10月"),
                    new Nengetu ("20/11", "2020年11月"),
                    new Nengetu ("20/12", "2020年12月")
        };

        List<Kuiki> TenpoKuiki = new List<Kuiki>()
        {
            new Kuiki("0","1","1区"),
            new Kuiki("0","2","2区"),
            new Kuiki("0","3","3区"),
            new Kuiki("0","4","4区"),
            new Kuiki("0","5","5区"),

            new Kuiki("1","1","1区"),
            new Kuiki("1","2","2区"),
            new Kuiki("1","3","3区"),
            new Kuiki("1","4","4区"),

            new Kuiki("2","1","1区"),
            new Kuiki("2","2","2区"),
            new Kuiki("2","3","3区"),
            new Kuiki("2","4","4区"),
            new Kuiki("2","5","5区"),

        };


        /*
        List<Dokusya> DokusyaList = new List<Dokusya>()
        {
            new Dokusya("1" , "桜井　清" , "妻田北１" , "12-41" , "あ朝" , "1911-2004"),
            new Dokusya("1" , "桜井　新" , "妻田北１" , "12-41" , "い朝" , "1911-2004"),
            new Dokusya("1" , "桜井　深" , "妻田北１" , "12-41" , "う朝" , "1911-2004"),
            new Dokusya("1" , "桜井　槙" , "妻田北１" , "12-41" , "え朝" , "1911-2004"),
            new Dokusya("1" , "桜井　信" , "妻田北１" , "12-41" , "お朝" , "1911-2004"),

            new Dokusya("2" , "桜井　シン" , "妻田北１" , "12-41" , "か朝" , "1911-2004"),
            new Dokusya("2" , "桜井　晋" , "妻田北１" , "12-41" , "き朝" , "1911-2004"),
            new Dokusya("2" , "桜井　侵" , "妻田北１" , "12-41" , "く朝" , "1911-2004"),
            new Dokusya("2" , "桜井　臣" , "妻田北１" , "12-41" , "け朝" , "1911-2004"),

            new Dokusya("3" , "桜井　審" , "妻田北１" , "12-41" , "さ朝" , "1911-2004"),
            new Dokusya("3" , "桜井　蓁" , "妻田北１" , "12-41" , "し朝" , "1911-2004"),

            new Dokusya("4" , "桜井　薪" , "妻田北１" , "12-41" , "た朝" , "1911-2004"),
            new Dokusya("4" , "桜井　寝" , "妻田北１" , "12-41" , "ち朝" , "1911-2004"),
            new Dokusya("4" , "エビヌマ　ツナキ" , "平松本町２" , "1103-3256" , "つ朝" , "1911-2004"),
            new Dokusya("4" , "エビヌマ　ツナキⅤ" , "平松本町４" , "1103-56" , "" , ""),
        };
        */




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
            public string TenpoNo { get; set; } //店舗ナンバー
            public string KuikiNo { get; set; } //区域ナンバー

            public string KuikiName { get; set; } //区域名

            public Kuiki(string tenpoNo , string kuikiNo, string kuikiName)
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
            foreach (var x in DokusyaList)
            {
                if (Kuiki_SelectedValue == x.Kuiki.ToString())
                {
                    Count++;
                }

            }

        }

        public void OnChangeEventKuiki(ChangeEventArgs f)
        {
            Count = 0;
            Kuiki_SelectedValue = f.Value.ToString();
            Kuiki_SelectedFlag = true;

            //検索総数
            foreach (var x in DokusyaList)
            {
                if (Kuiki_SelectedValue == x.Kuiki.ToString())
                {
                    Count++;
                }
            }

        }


        [Inject]
        protected NavigationManager Navi { get; set; }
        public async void JumpPage(DummyDataModel.Dokusya OnDokusya)
        {

            SearchResultData.S_DokusyaCode = OnDokusya.DokusyaCode;
            SearchResultData.S_DokusyaName = OnDokusya.DokusyaName;
            SearchResultData.S_BuildingName = OnDokusya.BuildingName;
            SearchResultData.S_CityName = OnDokusya.CityName;
            SearchResultData.S_CityAddress = OnDokusya.CityAddress;
            SearchResultData.S_PhoneNo_Sub = OnDokusya.PhoneNo_Sub;
            SearchResultData.S_KuikiNo = OnDokusya.Kuiki;

            SearchResultData.PhaseNo = 2;
            await SearchResultDataChanged.InvokeAsync(SearchResultData);
            StateHasChanged();
        }

    }

}

