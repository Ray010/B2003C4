using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

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



    }
}
