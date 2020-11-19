using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B2003C4.Client.Pages;
using B2003C4.Client.Pages.Common;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using B2003C4.Client.Pages.Kansa;


namespace B2003C4.Client.Pages.Kansa
{
    public partial class KansaParent
    {
        public uint? PhaseNo = null;
        public string year { get; set; } = "KansaSearchFragment";

        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        [Inject]
        public NavigationManager CurrentURL { get; set; }


        public string ConvertText;
        public string URLParam;

        protected override async void OnInitialized()
        {

            URLParam = CurrentURL.ToBaseRelativePath(CurrentURL.Uri);
            //await JSRuntime.InvokeVoidAsync("Back" , CurrentURL.Uri);
            //string PNo
            //formDataModel.PhaseNo = await JSRuntime.InvokeAsync<uint>("IfURL", URLParam,formDataModel.PhaseNo);
            //formDataModel.PhaseNo = uint.Parse(PNo);
            Console.WriteLine("れんだりんぐとぅるー");

        }

    }
}
