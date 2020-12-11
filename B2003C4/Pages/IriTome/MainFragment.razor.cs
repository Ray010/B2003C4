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
        int? SelectedValue;
        int? SelectValue
        { get => SelectedValue; set { SelectedValue = value; } }

        //区域関連
        public Boolean Kuiki_SelectedFlg { get; set; } = false;
        int? Kuiki_SelectedValue = 1;
        int? Kuiki_SelectValue
        { get => Kuiki_SelectedValue; set { Kuiki_SelectedValue = value; } }

        public uint[] Kuiki; //区域の数


        [Parameter]
        public FormSearchDataModel Phase1Data { get; set; }
        [Parameter]
        public EventCallback<FormSearchDataModel> Phase1DataChanged { get; set; }

        [Parameter]
        public DummyDataModel DBSourceData { get; set; }

        [Parameter]
        public EventCallback<DummyDataModel> DBSourceDataChanged { get; set; }

        /*
        [Parameter]
        public FormSearchDataModel SearchResultData { get; set; }
        [Parameter]
        public EventCallback<FormSearchDataModel> SearchResultDataChanged { get; set; }
        */


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


        /*
        List<Dokusya> IriDokusyaList = new List<Dokusya>()
        {
            new Dokusya(1,"工藤　栄吉", "", 2010,2102),
            new Dokusya(1,"工藤　栄", "", 1902,2102),
            new Dokusya(1,"海老沼　綱木", "死後", 1902,2010),
            new Dokusya(1,"エビヌマ　ツナキ", "死後", 1902,2010),



            new Dokusya(2,"田中　栄吉", "", 1912,2002),
            new Dokusya(2,"藤井　徹", "", 2002,2010),
            new Dokusya(2,"海老沼　剛木", "死後", 2002,2020),
            new Dokusya(2,"エビヌマ　ツナキ", "死後", 2002,2010),

            new Dokusya(3,"山田　栄吉", "", 2002,2011),
            new Dokusya(3,"工藤　栄", "", 2002,2012),
            new Dokusya(3,"海老沼　綱木", "死後", 2002,2510),
            new Dokusya(3,"エビスマ　ツナキ", "死後", 1902,2811),
            
        };
        List<Dokusya> TomeDokusyaList = new List<Dokusya>()
        {
            new Dokusya(1,"工藤　栄吉", "", 2002,2010),
            new Dokusya(1,"工藤　栄吉", "", 2002,2010),
            new Dokusya(1,"海老沼　綱木", "死後", 2002,2011),
            new Dokusya(1,"エビヌマ　ツナキ", "カレ", 1902,2011),
            new Dokusya(1,"エビヌマ　ツナキ", "カレ", 1902,2012),

            new Dokusya(2,"田中　栄吉", "", 2022,2012),
            new Dokusya(2,"藤井　徹", "", 2002,2011),
            new Dokusya(2,"海老沼　剛木", "死後", 2002,2010),
            new Dokusya(2,"エビヌマ　ツナキ", "死後", 1902,2010),

            new Dokusya(3,"山田　栄吉", "", 2002,2012),
            new Dokusya(3,"海老沼　綱木", "死後", 2010,2009),
            new Dokusya(3,"エビスマ　ツナキ", "死後", 1902,2010),

            new Dokusya(4,"エビスマ　ツナキ", "死後", 1902,2010),


        };


        public class Dokusya
        {

            public int KuikiNo;
            public string DokusyaName; //読者名
            public string B; //？（死後とか書いてあるやつ)
            public string Keiyaku;
            public int KeiyakuSt;
            public int KeiyakuEd;

            

            public Dokusya(int kuikiNo , string dokusyaName, string b, int keiyakuSt , int keiyakuEd)
            {
                KuikiNo = kuikiNo;

                DokusyaName = dokusyaName;

                B = b;

                Keiyaku = keiyakuSt + "-" + keiyakuEd;

                KeiyakuSt = keiyakuSt;

                KeiyakuEd = keiyakuEd;


            }
        }
        */
        //-------------------------------------------------------------

        List<DummyDataModel.Dokusya> IriDokusyaList = new List<DummyDataModel.Dokusya>();
        List<DummyDataModel.Dokusya> TomeDokusyaList = new List<DummyDataModel.Dokusya>();

        protected override void OnInitialized()
        {
            //区域総数
            uint IriTemp = 0;
            uint[] IriKuiki = new uint[0];

            uint TomeTemp = 0;
            uint[] TomeKuiki = new uint[0];

            foreach(var IriTome in DBSourceData.DokusyaList)
            {
                if(IriTome.DokusyaStatus == "Gendoku")
                {
                    IriDokusyaList.Add(IriTome);
                } 
                else if(IriTome.DokusyaStatus == "Tome")
                {
                    TomeDokusyaList.Add(IriTome);
                }
                else
                {
                    continue;
                }
            }

            foreach (var x in IriDokusyaList)
            {
                if(IriTemp != x.Kuiki )
                {
                    Array.Resize(ref IriKuiki, IriKuiki.Length + 1);
                    IriKuiki[IriKuiki.Length -1] = x.Kuiki;
                    IriTemp = x.Kuiki;
                }
                else
                {
                    continue;
                }
            }
            foreach (var x in TomeDokusyaList)
            {
                if(TomeTemp != x.Kuiki)
                {
                    Array.Resize(ref TomeKuiki, TomeKuiki.Length + 1);
                    TomeKuiki[TomeKuiki.Length -1] = x.Kuiki;
                    TomeTemp = x.Kuiki;
                }
                else
                {
                    continue;
                }
            }

            if(IriKuiki.Length >= TomeKuiki.Length)
            {
                //Array.Copy(IriKuiki, Kuiki, IriKuiki.Length); //保留
                Kuiki = IriKuiki;
            }
            else
            {
                //Array.Copy(TomeKuiki, Kuiki, TomeKuiki.Length); //保留
                Kuiki = TomeKuiki;
            }
            //区域総数終わり

            foreach(var x in IriDokusyaList)
            {
                if( Kuiki_SelectedValue == x.Kuiki)
                {
                    IriCount++;
                }
                else
                {
                    continue;
                }
            }
            foreach(var x in TomeDokusyaList)
            {
                if( Kuiki_SelectedValue == x.Kuiki)
                {
                    TomeCount++;
                }
                else
                {
                    continue;
                }
            }

            //---------------------------------------------------------
            //履歴の処理

            /*
            Phase1Data.Back_History.Add(Phase1Data);
            Phase1DataChanged.InvokeAsync(Phase1Data);
            */
            if(Phase1Data.HistoryBackState == false)
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
            Kuiki_SelectedValue = int.Parse(e.Value.ToString());
            Kuiki_SelectedFlg = true;
            IriCount = 0;
            TomeCount = 0;

            foreach (var x in IriDokusyaList)
            {
                if(Kuiki_SelectedValue == x.Kuiki &&
                  (SelectValue == x.KeiyakuSt || SelectValue == null))

                //if (Kuiki_SelectedValue == x.Kuiki)
                {
                    IriCount++;
                }
                else
                {
                    continue;
                }
            }
            foreach (var x in TomeDokusyaList)
            {
                if (Kuiki_SelectedValue == x.Kuiki &&
                    (SelectValue -1 == x.KeiyakuEd || SelectValue == null))

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
                SelectedValue = int.Parse(e.Value.ToString());
                SelectedFlg = true;
            }

            foreach (var x in IriDokusyaList)
            {
                if (Kuiki_SelectedValue == x.Kuiki &&
                  (SelectValue == x.KeiyakuSt || SelectValue == null))

                //if (Kuiki_SelectedValue == x.Kuiki)
                {
                    IriCount++;
                }
                else
                {
                    continue;
                }
            }
            foreach (var x in TomeDokusyaList)
            {
                if (Kuiki_SelectedValue == x.Kuiki &&
                    (SelectValue - 1 == x.KeiyakuEd || SelectValue == null))

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


        public async void JumpPage(DummyDataModel.Dokusya OnDokusya)
        {
            Phase1Data.S_DokusyaCode = OnDokusya.DokusyaCode;
            Phase1Data.S_DokusyaName = OnDokusya.DokusyaName;
            Phase1Data.S_BuildingName = OnDokusya.BuildingName;
            Phase1Data.S_CityName = OnDokusya.CityName;
            Phase1Data.S_CityAddress = OnDokusya.CityAddress;
            Phase1Data.S_PhoneNo_Sub = OnDokusya.PhoneNo_Sub;
            Phase1Data.S_KuikiNo = OnDokusya.Kuiki;

            Phase1Data.PhaseNo = 11;
            await Phase1DataChanged.InvokeAsync(Phase1Data);
            StateHasChanged();
        }



    }
}
