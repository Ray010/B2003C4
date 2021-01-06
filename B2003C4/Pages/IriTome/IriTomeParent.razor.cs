using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;
using B2003C4.Data;
using B2003C4.Service;

namespace B2003C4.Pages.IriTome
{
    public partial class IriTomeParent
    {

        [Inject]
        private NewsPaperDataService NewsPaperData { get; set; }

        protected override async Task OnInitializedAsync()
        {

            P_IriList = await NewsPaperData.GetIriListAsync();
            P_TomeList = await NewsPaperData.GetTomeListAsync();
            P_KuikiList = await NewsPaperData.GetKuikiListAsync();
            P_NengetuList = await NewsPaperData.GetNengetuListAsync();
        }




        //---------------------------------------------------------------------------------
        //MainLayout
        [Parameter]
        public FormSearchDataModel CurrentPage {get; set;}
        [Parameter]
        public EventCallback<FormSearchDataModel> CurrentPageChanged { get; set; }

        private FormSearchDataModel _currentPage;

        //---------------------------------------------------------------------------------





        [Parameter]
        public DummyDataModel DBSourceData { get; set; }

        [Parameter]
        public EventCallback<DummyDataModel> DBSourceDataChanged { get; set; }

        /*
        public void Rewrite() //フェーズを戻るとk
        {
            formDataModel = CurrentPage;
            ResultData = CurrentPage;
        }
        */
        public void write() //次のフェーズに行く
        {
            //CurrentPageChanged.InvokeAsync(CurrentPage);
        }

        public List<string> DebugText = new List<string>{
            new string("Start"),
        
        };

        
        void Debug()
        {
            /*
            Random rnd = new Random();
            CurrentPage.S_DokusyaCode = uint.Parse(rnd.Next(1,10).ToString());
            CurrentPageChanged.InvokeAsync(CurrentPage);

            StateHasChanged();
            */
            DebugText.Clear();
            string msg = "IriTomeParent ->";
            Console.WriteLine("IriTomeParent↓---------------------------");
            DebugText.Add("IriTomeParent↓---------------------------");

            Console.WriteLine("リセット");

            foreach (var i in History.Back_History)
            {
                Console.WriteLine("Back------------------------------------");
                Console.WriteLine(i.IndexURL);
                /*
                Console.WriteLine(i.Back_History.Count);
                for (int y = 0; y < i.Back_History.Count; y++)
                {
                    Console.WriteLine("┗" + i.Back_History[y].IndexURL);
                }
                Console.WriteLine("----------------------------------------");
                */

                DebugText.Add("Back------------------------------------");
                DebugText.Add(i.IndexURL);

                /*
                for (int y = 0; y < i.Back_History.Count; y++)
                {
                    DebugText.Add("┗" + i.Back_History[y].IndexURL);
                }
                */
                DebugText.Add("----------------------------------------");

            }

            foreach (var i in History.Next_History)
            {
                Console.WriteLine("Next------------------------------------");
                Console.WriteLine(i.IndexURL);
                /*
                Console.WriteLine(i.Next_History.Count);
                for (int y = 0; y < i.Next_History.Count; y++)
                {
                    Console.WriteLine("┗" + i.Next_History[y].IndexURL);
                }
                */
                Console.WriteLine("----------------------------------------");
            }
            Console.WriteLine("IriTomeParent OK");
            Console.WriteLine("IriTome---------------------------");
        }
    }
}
