using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace B2003C4.Client.Pages.Kansa
{
    public partial class SearchActivity
    {
        static int x { get; set; }


        //とりあえずURLから値の取得
        [Parameter]
        public string DokuCodeParam { get; set; }

        [Parameter]
        public string KuikiParam { get; set; }


        public int Count { get; set; }





        List<Dokusya> DokusyaList = new List<Dokusya>
        {
            new Dokusya("現","117","加藤　次男","1","戸部町1","9","M"),
            new Dokusya("現","48","横浜市健康保険福祉総合センタ","1","戸部町1","10","M"),
            new Dokusya("止","49","（有）沼田石版印刷所","1","戸部町1","8","M"),
            new Dokusya("休","122","入居","1","戸部町1","2","M"),
            new Dokusya("現","52","川島　捷男","1","宮崎町","","M"),
            new Dokusya("予","256","野口","2","紅葉町","44","M"),
            new Dokusya("現","269","横浜　三郎","2","紅葉町","44","M"),
            new Dokusya("休","270","関　洋","2","紅葉町","44","M"),
            new Dokusya("現","5462","海老沼　綱紀","3","武蔵野10","44-88","M"),
            new Dokusya("休","1975","田中　信","4","桐生","1152","M"),
            new Dokusya("止","2422","山田","5","那須町","1110","M"),
            new Dokusya("休","1955","東京都庁","2","西新宿２丁目","8-1","M"),

        };

        public class Dokusya
        {
            public string DokusyaStatus; //読者の状態（現、休、止　等）
            public string DokusyaCode; //読者コード
            public string DokusyaName; //読者名
            public string Kuiki; //区域

            public string CityFullName; //町名＋町名以降
            public string CityName; //町名
            public string CityAddress; //町名以降
            public string M; // M（わからない）
        
            public Dokusya(string dokusyaStatus , string dokusyaCode , string dokusyaName , string kuiki , string cityName , string cityAddress , string m)
            {

                DokusyaStatus = dokusyaStatus;
                DokusyaCode = dokusyaCode;
                DokusyaName = dokusyaName;
                Kuiki = kuiki;
                CityFullName = cityName + cityAddress;
                M = m;

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
