using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using B2003C4.Data;

namespace B2003C4.Shared
{
    public partial class MainLayout
    {
        //各ページと値を共有させる。
        public FormSearchDataModel formSearchModel = new FormSearchDataModel();

        //JavaScript関連
        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        //ナビゲーター
        [Inject]
        public NavigationManager Navi { get; set; }

        protected override void OnInitialized()
        {
            Console.WriteLine(formSearchModel.Next_History.Count);
        }



        public void NextPage()
        {
            if(formSearchModel.Next_History.Count <= 0)
            {
                //何もしない
            }

            else if(formSearchModel.Next_History.Count >= 1)
            {
                try
                {
                    formSearchModel = formSearchModel.Next_History[formSearchModel.Next_History.Count - (formSearchModel.Next_History.Count - 1) - 1];
                }
                catch(System.ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("予期せぬエラー -> MainLayout:001(配列不正)");
                    formSearchModel.Back_History.Clear();
                    formSearchModel.Next_History.Clear();
                    formSearchModel.IndexURL = "Index";

                }
            }
            else
            {
                Console.WriteLine("予期せぬエラー -> MainLayout:002(Back_Historyエラー)");
                formSearchModel.Back_History.Clear();
                formSearchModel.Next_History.Clear();
                formSearchModel.IndexURL = "Index";

            }
        }

        public void BackPage()
        {
            Console.WriteLine("ButtonOn↓-----------------------------");
            if (formSearchModel.Back_History.Count <= 1)
            {
                //何もしない
            }
            else if(1 < formSearchModel.Back_History.Count)
            {
                try
                {
                    //現在値、退避用
                    FormSearchDataModel Temp_formSearchModel;
                    Temp_formSearchModel = formSearchModel.Back_History[formSearchModel.Back_History.Count - 1].Deep_Copy();
                    
                    formSearchModel = formSearchModel.Back_History[formSearchModel.Back_History.Count - 2];
                    formSearchModel.Next_History.Add(Temp_formSearchModel.Deep_Copy());

                    //デバッグ用
                    foreach (var i in formSearchModel.Back_History)
                    {
                        Console.WriteLine(i.IndexURL);
                        Console.WriteLine(i.Back_History.Count);
                        for (int y = 0; y < i.Back_History.Count; y++)
                        {
                            Console.WriteLine("┗" + i.Back_History[y].IndexURL);
                        }
                    }   
                    //StateHasChanged();
                }
                catch (System.ArgumentOutOfRangeException e) //Back_History-2の位置に値が入っていなかったとき
                {
                    Console.WriteLine("予期せぬエラー -> MainLayout:003(配列不正)");
                    formSearchModel.Back_History.Clear();
                    formSearchModel.Next_History.Clear();
                    formSearchModel.IndexURL = "Index";
                    StateHasChanged();
                }
            }
            else
            {
                //BackHistoryに値が入っていない場合エラー
                Console.WriteLine("予期せぬエラー -> MainLayout:004(Back_Historyエラー)");
                formSearchModel.Back_History.Clear();
                formSearchModel.Next_History.Clear();
                formSearchModel.IndexURL = "Index";
                StateHasChanged();
            }
            Console.WriteLine("ButtonOn-----------------------------");
        }

        /*接続状態表示（保留）
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
