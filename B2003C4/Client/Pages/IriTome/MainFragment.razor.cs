using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace B2003C4.Client.Pages.IriTome
{
    public partial class MainFragment
    {
        public Boolean SelectedFlg { get; set; } = false;
        string SelectedValue;
        string SelectValue
        { get => SelectedValue; set{ SelectedValue = value; } }

        List<Nengetu> NengetuList = new List<Nengetu>() {
                    new Nengetu ("20/10", "2020年10月"),
                    new Nengetu ("20/11", "2020年11月"),
                    new Nengetu ("20/12", "2020年12月")
        };

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

        /* 
        * セレクトリストのonchangeイベント
        * 引数の「ChangeEventArgs」内に、選択された項目のValue値が入り込んで受け取ることができる。
        */
        public void OnChangeEventNengetu(ChangeEventArgs e)
        {
            SelectedValue = e.Value.ToString();
            SelectedFlg = true;
        }



        


        //海老沼書き足しｽﾞｲ₍₍(ง˘ω˘)ว⁾⁾ｽﾞｲ（仮）

        //仮-----------------------------------------------------------

        public int IriCount { get; set; }

        public int TomeCount { get; set; }


        List<Kuiki> IriKuiki1 = new List<Kuiki>()
        {
            new Kuiki("工藤　栄吉", "", "2002-2002"),
            new Kuiki("工藤　栄", "", "2002-2002"),
            new Kuiki("海老沼　綱木", "死後", "2002-2010"),
            new Kuiki("エビヌマ　ツナキ", "死後", "1902-2010"),
            
        };
        List<Kuiki> TomeKuiki1 = new List<Kuiki>()
        {
            new Kuiki("工藤　栄吉", "", "2002-2010"),
            new Kuiki("工藤　栄吉", "", "2002-2010"),
            new Kuiki("海老沼　綱木", "死後", "2002-2010"),
            new Kuiki("エビヌマ　ツナキ", "カレ", "1902-2010"),
            new Kuiki("エビヌマ　ツナキ", "カレ", "1902-2010"),

        };


        public class Kuiki
        {

            public string DokusyaName; //読者名
            public string B; //？（死後とか書いてあるやつ)
            public string Keiyaku;

            public Kuiki(string dokusyaName, string b, string keiyaku)
            {
                DokusyaName = dokusyaName;

                B = b;

                Keiyaku = keiyaku;

            }

        }

        //-------------------------------------------------------------

        [Inject]
        protected NavigationManager Navi { get; set; }


        public void JumpPage(string URLx)
        {

            Navi.NavigateTo(URLx);

        }



    }
}
