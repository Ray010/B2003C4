using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;







namespace B2003C4.Client.Shared
{
    public partial class MainLayout
    {

        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        [Inject]
        public NavigationManager Navi { get; set; }

        //public int 
        /*
        public async void BackPage()
        {
            await JSRuntime.InvokeVoidAsync("Back", Navi.Uri);
            //formDataModel.PhaseNo = await JSRuntime.InvokeAsync<uint>("IfURL", URLParam,formDataModel.PhaseNo);
            StateHasChanged();
            Console.WriteLine("OK");
        }
        */

        public void BackPage()
        {
            if (formSearchModel.PhaseNo == 1)
            {
                formSearchModel.IndexURL = formSearchModel.CurrentURL;
                StateHasChanged();
            }
            else
            {
                formSearchModel.PhaseNo = formSearchModel.PhaseNo - 1;
                formSearchModel.State = true;
                StateHasChanged();

            }
            Console.WriteLine(formSearchModel.IndexURL);
            Console.WriteLine(formSearchModel.CurrentURL);
        }









        /*保留
        //public static ValueTask<Boolean> NetworkState { get; set; }

        public static Boolean NetworkState { get; set; }

        public static ValueTask<string> A;
        public async void Test()
        {

            //NetworkState = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();

        }        

        public class OnlineState
        {
            private readonly IJSRuntime jsRuntime;
            public OnlineState(IJSRuntime jsRuntime )
            {
                this.jsRuntime = jsRuntime;

                var networkState = jsRuntime.InvokeAsync<string>("OnlineTrue");

                //NetworkState = networkState;

                A = networkState;
            }


        }
        */

    }
}
