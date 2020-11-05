using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Dynamic;
using Microsoft.Data.SqlClient.DataClassification;



namespace B2003C4.Client.Pages.Kansa
{

    public partial class KansaSearchFragment
    {


        

        static int x;
        

        //海老沼書き足しｽﾞｲ₍₍(ง˘ω˘)ว⁾⁾ｽﾞｲ（仮）

        public int KubunCount { get; set; }

        public Boolean Kuiki_SelectFlg { get; set; } = false;
        //string Kuiki_SelectedValue;
        uint? Kuiki_SelectedValue;
        uint? Kuiki_SelectValue
        { get => Kuiki_SelectedValue; set { Kuiki_SelectedValue = value; } }


        public int KubunButton;
        public int X;
        public string y;


        public uint? DokusyaCode = null;
        public uint? KuikiNo = null;
        public uint? Junro;
        public uint? Junro_Sub;
        public string DokusyaName;
        public uint PhoneNo;
        public uint? PhoneNo_Sub;
        public string CityAddress;
        public string BuildingName;
        public string ShitsuBan;

        public string MessageForError; //エラーメッセ内容

 //ユーザーが入力した値


        public string a { get; set; }


        List<Kuiki> KuikiList = new List<Kuiki>()
        {
            new Kuiki("",null),
            new Kuiki("1区",1),
            new Kuiki("2区",2),
            new Kuiki("3区",3),
            new Kuiki("4区",4),
            new Kuiki("5区",5),
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

        public class Kuiki
        {
            public string KuikiName { get; set; }
            public uint? KuikiCode { get; set; }

            public Kuiki(string kuikiName, uint? kuikiCode)
            {
                KuikiName = kuikiName;
                KuikiCode = kuikiCode;
            }

        }


        public List<Kubun> Button ;


        /*
        protected override void OnInitialized()
        {
            int Count=0;

            for(int y = 1; y == 5; y++)
            {
                for(int x = 0; x == 4; x++)
                    //Range(x*y,KubunList.Count))
                {
                    Button[y, x] = KubunList[x];
                }
            }

        }
        */



        public void Boom()
        {
            Kuiki_SelectValue = null;

        }

        public void ButtonX(string e)
        {
  
            //.ToString();
            //ListX.Add();

        }
        public void OnChangeEventKuiki(uint? X)
        {
            Kuiki_SelectedValue = X;
            Kuiki_SelectFlg = true;
            KuikiNo = Kuiki_SelectedValue;

        }


        [Inject]
        protected NavigationManager Navi { get; set; }
        public void JumpResultPage(string URLx)
        {

            if (null == DokusyaCode && null == KuikiNo)
            {
                MessageForError = "0001：検索条件を１つ以上指定してください";
            }
            else { 


                if (null == DokusyaCode)
                {
                    DokusyaCode = null; 
                }
                if(null == KuikiNo)
                {
                    KuikiNo = null;
                }

                Navi.NavigateTo(URLx + "/" + DokusyaCode + "/" + KuikiNo);
            }
        }
    }
}
