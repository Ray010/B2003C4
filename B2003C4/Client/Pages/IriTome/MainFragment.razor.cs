using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace B2003C4.Client.Pages.IriTome
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

        public int[] Kuiki; //区域の数


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

        //-------------------------------------------------------------



        protected override void OnInitialized()
        {
            //区域総数
            int IriTemp = 0;
            int[] IriKuiki = new int[0];

            int TomeTemp = 0;
            int[] TomeKuiki = new int[0];


            foreach (var x in IriDokusyaList)
            {
                if(IriTemp != x.KuikiNo )
                {
                    Array.Resize(ref IriKuiki, IriKuiki.Length + 1);
                    IriKuiki[IriKuiki.Length -1] = x.KuikiNo;
                    IriTemp = x.KuikiNo;
                }
                else
                {
                    continue;
                }
            }
            foreach (var x in TomeDokusyaList)
            {
                if(TomeTemp != x.KuikiNo)
                {
                    Array.Resize(ref TomeKuiki, TomeKuiki.Length + 1);
                    TomeKuiki[TomeKuiki.Length -1] = x.KuikiNo;
                    TomeTemp = x.KuikiNo;
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
                if( Kuiki_SelectedValue == x.KuikiNo)
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
                if( Kuiki_SelectedValue == x.KuikiNo)
                {
                    TomeCount++;
                }
                else
                {
                    continue;
                }
            }

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


                if(Kuiki_SelectedValue == x.KuikiNo &&
                  (SelectValue == x.KeiyakuSt || SelectValue == null))

                //if (Kuiki_SelectedValue == x.KuikiNo)
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

                if (Kuiki_SelectedValue == x.KuikiNo &&
                    (SelectValue -1 == x.KeiyakuEd || SelectValue == null))

                    //if (Kuiki_SelectedValue == x.KuikiNo)
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


                if (Kuiki_SelectedValue == x.KuikiNo &&
                  (SelectValue == x.KeiyakuSt || SelectValue == null))

                //if (Kuiki_SelectedValue == x.KuikiNo)
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

                if (Kuiki_SelectedValue == x.KuikiNo &&
                    (SelectValue - 1 == x.KeiyakuEd || SelectValue == null))

                //if (Kuiki_SelectedValue == x.KuikiNo)
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


        public void IriButtonActive() //入ボタンが押されたとき入を全画面に表示する
        {
            if (TomeActive == true)
            {
                TomeActive = false;
            }
            else
            {
                TomeActive = true;
            }

        }
        public void TomeButtonActive() //止ボタンが押されたとき止を全画面に表示する
        {
            if (IriActive == true)
            {
                IriActive = false;
            }
            else
            {
                IriActive = true;
            }

        }

        [Inject]
        protected NavigationManager Navi { get; set; }


        public void JumpPage(string URLx)
        {

            Navi.NavigateTo(URLx);

        }



    }
}
