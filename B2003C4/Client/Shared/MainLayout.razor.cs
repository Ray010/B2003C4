using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using B2003C4.Client.Data;

namespace B2003C4.Client.Shared
{
    public partial class MainLayout
    {



        //各ページと値を共有させる。
        public FormSearchDataModel formSearchModel = new FormSearchDataModel();

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

        protected override void OnInitialized()
        {
            Console.WriteLine("MainLayout-----------------------------");
            foreach (var i in formSearchModel.Back_History)
            {
                Console.WriteLine(i.IndexURL);
                Console.WriteLine(i.Back_History.Count);
            }
            Console.WriteLine("MainLayout-----------------------------");
        }

        public void BackPage()
        {
            if (formSearchModel.Back_History.Count <= 0)
            {
                //BackHistoryに値が入っていない場合エラー
                Console.WriteLine("予期せぬエラー");
                formSearchModel.Back_History.Clear();
                formSearchModel.IndexURL = "Index";
                StateHasChanged();
            }
            else 
            {
                Console.WriteLine("ButtonOn↓-----------------------------");
                formSearchModel = formSearchModel.Back_History[formSearchModel.Back_History.Count - 2];
                //formSearchModel.Back_History.RemoveAt(formSearchModel.Back_History.Count - 1);
                

                foreach (var i in formSearchModel.Back_History)
                {
                    Console.WriteLine(i.IndexURL);
                    Console.WriteLine(i.Back_History.Count);
                    for(int y = 0; y < i.Back_History.Count; y++)
                    {
                        Console.WriteLine("┗" + i.Back_History[y].IndexURL);
                    }
                }
               
                Console.WriteLine("ButtonOn-----------------------------");
                //StateHasChanged();
            }



            /*
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
            */

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
