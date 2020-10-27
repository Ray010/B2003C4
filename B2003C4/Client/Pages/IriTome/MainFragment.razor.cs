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
        { get => SelectedValue; set { SelectedValue = value; } }

        

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
        public void OnChangeEventNengetu(string X)
        {
            SelectedValue =X;
            SelectedFlg = true;
        }

        public void OnChangeEventNengetuX(EventArgs e)
        {
            SelectedValue = e.ToString();
            SelectedFlg = true;
        }



        public Boolean Kuiki_SelectedFlg { get; set; } = false;
        string Kuiki_SelectedValue;
        string Kuiki_SelectValue
        { get => Kuiki_SelectedValue; set { Kuiki_SelectedValue = value; } }




        public void OnChangeEventKuiki(string X)
        {
            Kuiki_SelectedValue = X;
            Kuiki_SelectedFlg = true;
        }




        //海老沼書き足しｽﾞｲ₍₍(ง˘ω˘)ว⁾⁾ｽﾞｲ（仮）

        //仮-----------------------------------------------------------

        public int IriCount { get; set; }

        public int TomeCount { get; set; }

        public string Y = null;

        List<Kuiki> IriKuiki = new List<Kuiki>()
        {
            new Kuiki("1","工藤　栄吉", "", "2002-2002"),
            new Kuiki("1","工藤　栄", "", "2002-2002"),
            new Kuiki("1","海老沼　綱木", "死後", "2002-2010"),
            new Kuiki("1","エビヌマ　ツナキ", "死後", "1902-2010"),
            
        };
        List<Kuiki> TomeKuiki = new List<Kuiki>()
        {
            new Kuiki("1","工藤　栄吉", "", "2002-2010"),
            new Kuiki("1","工藤　栄吉", "", "2002-2010"),
            new Kuiki("1","海老沼　綱木", "死後", "2002-2010"),
            new Kuiki("1","エビヌマ　ツナキ", "カレ", "1902-2010"),
            new Kuiki("1","エビヌマ　ツナキ", "カレ", "1902-2010"),

        };


        public class Kuiki
        {

            public string KuikiNo;
            public string DokusyaName; //読者名
            public string B; //？（死後とか書いてあるやつ)
            public string Keiyaku;
            

            public Kuiki(string kuikiNo , string dokusyaName, string b, string keiyaku)
            {
                KuikiNo = kuikiNo;

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
