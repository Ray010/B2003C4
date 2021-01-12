using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B2003C4.Pages;
using B2003C4.Pages.Common;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using B2003C4.Data;
using B2003C4.Service;



namespace B2003C4.Pages.Kansa
{
    public partial class KansaParent
    {
        public uint? PhaseNo = null;
        public string year { get; set; } = "KansaSearchFragment";

        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        [Inject]
        public NavigationManager Navi { get; set; }


        public string ConvertText;
        public string URLParam;

        [Parameter]
        public FormSearchDataModel CurrentPage { get; set; }
        [Parameter]
        public EventCallback<FormSearchDataModel> CurrentPageChanged { get; set; }



        protected override async void OnInitialized()
        {
            /*
            URLParam = Navi.ToBaseRelativePath(Navi.Uri);
            formDataModel.PhaseNo = await JSRuntime.InvokeAsync<uint>("PhaseNo");
            
            //await JSRuntime.InvokeVoidAsync("PhaseShift" , formDataModel.PhaseNo);
            //string PNo
            //formDataModel.PhaseNo = uint.Parse(PNo);
            Console.WriteLine("れんだりんぐとぅるー");
            */

        }

        [Inject]
        private NewsPaperDataService NewsPaperData { get; set; }
        protected override async Task OnInitializedAsync()
        {
            P_DokusyaList = await NewsPaperData.GetDokusya_K95080_ListAsync();
            P_KoudokuList = await NewsPaperData.GetKoudoku_K95080_ListAsync();
            P_KuikiList = await NewsPaperData.GetKuiki_K95080_ListAsync();
            P_KakuzaiList = await NewsPaperData.GetKakuzai_K95080_ListAsync();
        }
    }
}
