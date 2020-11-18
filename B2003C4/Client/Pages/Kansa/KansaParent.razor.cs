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

        /*
        protected override Task OnInitializedAsync()
        {
            URLParam = CurrentURL.ToBaseRelativePath(CurrentURL.Uri);


            formDataModel.PhaseNo = JSRuntime.InvokeAsync("IfURL", URLParam);


            Console.WriteLine("れんだりんぐとぅるー");

        }
        */

        protected override async void OnInitialized()
        {

            
            URLParam = CurrentURL.ToBaseRelativePath(CurrentURL.Uri);
            //string PNo
            //formDataModel.PhaseNo = await JSRuntime.InvokeAsync<uint>("IfURL", URLParam,formDataModel.PhaseNo);
            //formDataModel.PhaseNo = uint.Parse(PNo);
            Console.WriteLine("れんだりんぐとぅるー");

        }

        [JSInvokable]
        public static void JSFunc()
        {
            Console.WriteLine("Hello");
        }


        public void PhaseShift(uint phaseNo)
        {
            JSRuntime.InvokeVoidAsync("PhaseNo",phaseNo);
        }
        

        [JSInvokable]
        public void ReturnShift()
        {
            Console.WriteLine("OK");
            StateHasChanged();
        
        }


    }
}
