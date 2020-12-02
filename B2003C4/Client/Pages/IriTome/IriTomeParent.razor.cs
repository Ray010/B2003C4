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
        [Parameter]
        public FormSearchDataModel CurrentPage { get; set; }
        [Parameter]
        public EventCallback<FormSearchDataModel> CurrentPageChanged { get; set; }

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


            CurrentPageChanged.InvokeAsync(CurrentPage);



        }
        
        void a()
        {
            StateHasChanged();
            Console.WriteLine("リセット");
            Console.WriteLine(CurrentPage.IndexURL);
            Console.WriteLine(CurrentPage.PhaseNo);
        }

        protected override void OnInitialized()
        {
            CurrentPageChanged.InvokeAsync(CurrentPage);
        }
    }
}
