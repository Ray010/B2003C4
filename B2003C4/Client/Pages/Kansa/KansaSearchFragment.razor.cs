using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace B2003C4.Client.Pages.Kansa
{
    public partial class KansaSearchFragment
    {



        //海老沼書き足しｽﾞｲ₍₍(ง˘ω˘)ว⁾⁾ｽﾞｲ（仮）

        public int KubunCount { get; set; }

        public Boolean Kuiki_SelectFlg { get; set; } = false;
        string Kuiki_SelectedValue;
        string Kuiki_SelectValue
        { get => Kuiki_SelectedValue; set { Kuiki_SelectedValue = value; } }


        public void OnChangeEventKuiki(string X)
        {
            Kuiki_SelectedValue = X;
            Kuiki_SelectFlg = true;

        }

        List<Kubun> KuikiList = new List<Kubun>()
        {
            new Kubun("",""),
            new Kubun("1区","1"),
            new Kubun("2区","2"),
        };

        List<Kubun> KubunList = new List<Kubun>()
        {
            new Kubun("未読","Midoku"),
            new Kubun("現読","Gendoku"),
            new Kubun("予約","Yoyaku"),
            new Kubun("止め","Tome"),
            new Kubun("休読","Kyudoku"),
            new Kubun("保留","Horyu"),
            new Kubun("発証","Hassyo"),
            new Kubun("順路","Junro"),
            new Kubun("不良","Huryo"),
            new Kubun("空家","Akiya"),
            new Kubun("他現","Tagen"),
        };




        public class Kubun
        {
            public string KubunName { get; set; }
            public string KubunCode { get; set; }

            public Kubun(string kubunName , string kubunCode)
            {
                KubunName = kubunName;
                KubunCode = kubunCode;
            }

        }


        public int KubunButton;
        public int X;

        protected override async Task OnParametersSetAsync()
        {
            KubunButton = KubunList.Count();

        }



        public void KubunS()
        {

        }

        [Inject]
        protected NavigationManager Navi { get; set; }
        public void JumpPage(string URLx)
        {

            Navi.NavigateTo(URLx);

        }
    }
}
