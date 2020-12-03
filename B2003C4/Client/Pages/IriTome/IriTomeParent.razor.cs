using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;
using B2003C4.Client.Data;


namespace B2003C4.Client.Pages.IriTome
{
    public partial class IriTomeParent
    {

        //---------------------------------------------------------------------------------
        //MainLayout
        [Parameter]
        public FormSearchDataModel CurrentPage
        {
            get;
            set;
            /*
            get { return _currentPage; }
            set
            {
                _currentPage = value;
                Console.WriteLine("02" + _currentPage.S_DokusyaCode);
                if ( 
                    _currentPage.Back_History.Count != CurrentPage.Back_History.Count || 
                    _currentPage.PhaseNo != CurrentPage.PhaseNo 
                    )
                {
                    CurrentPageChanged.InvokeAsync(CurrentPage);
                    _currentPage = CurrentPage;
                    Console.WriteLine("IriTome ->" + "ValueReplace");
                }
            }
            */
        }
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
        
        void a()
        {
            Random rnd = new Random();
            CurrentPage.S_DokusyaCode = uint.Parse(rnd.Next(1,10).ToString());
            CurrentPageChanged.InvokeAsync(CurrentPage);

            StateHasChanged();
            Console.WriteLine("IriTome---------------------------");
            Console.WriteLine("リセット");
            Console.WriteLine(CurrentPage.IndexURL);
            Console.WriteLine(CurrentPage.PhaseNo);
            Console.WriteLine(CurrentPage.S_DokusyaCode);

            foreach (var i in CurrentPage.Back_History)
            {
                Console.WriteLine(i.IndexURL);
            }


            foreach (var i in CurrentPage.Back_History)
            {
                Console.WriteLine(i.IndexURL);
                Console.WriteLine(i.Back_History.Count);
                for (int y = 0; y < i.Back_History.Count; y++)
                {
                    Console.WriteLine("┗" + i.Back_History[y].IndexURL);
                }
            }




            Console.WriteLine("IriTomeParent OK");
            Console.WriteLine("IriTome---------------------------");
        }

        protected override void OnInitialized()
        {
            //CurrentPageChanged.InvokeAsync(CurrentPage);
            
            Console.WriteLine("IriTome---------------------------");
            foreach (var i in CurrentPage.Back_History)
            {
                Console.WriteLine(i.IndexURL);
            }
            Console.WriteLine("IriTomeParent OK");
            Console.WriteLine("IriTome---------------------------");




        }
    }
}
