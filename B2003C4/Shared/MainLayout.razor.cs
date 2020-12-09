using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using B2003C4.Data;
using B2003C4.Class;

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
            Console.WriteLine(History.Next_History.Count);
        }

        /*
        public void NextPage()
        {
            if(History.Next_History.Count <= 0)
            {
                //何もしない
            }
            else if(History.Next_History.Count >= 1)
            {
                try
                {
                    formSearchModel = History.Next_History[History.Next_History.Count - (History.Next_History.Count - 1) - 1];
                }
                catch(System.ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("予期せぬエラー -> MainLayout:001(配列不正)");
                    History.Back_History.Clear();
                    History.Next_History.Clear();
                    formSearchModel.IndexURL = "Index";

                }
            }
            else
            {
                Console.WriteLine("予期せぬエラー -> MainLayout:002(Back_Historyエラー)");
                History.Back_History.Clear();
                History.Next_History.Clear();
                formSearchModel.IndexURL = "Index";

            }
        }
        */
        public void BackPage()
        {
            Console.WriteLine("ButtonOn↓-----------------------------");
            if (History.Back_History.Count <= 1)
            {
                //何もしない
            }
            /*
            else if((formSearchModel.IriActive == false || formSearchModel.TomeActive == false)&& 
                    formSearchModel.IndexURL == "IriTome" && formSearchModel.PhaseNo == 1)
            {
                formSearchModel.IriActive = true;
                formSearchModel.TomeActive = true;

            }
            */
            else if(1 < History.Back_History.Count)
            {
                try
                {
                    //現在値、退避用
                    //FormSearchDataModel Temp_formSearchModel;
                    //Temp_formSearchModel = History.Back_History[History.Back_History.Count - 1]; //.Deep_Copy(); //今の値をTempにDコピー 進がなくなったため無効化

                    formSearchModel = null;
                    formSearchModel = History.Back_History[History.Back_History.Count - 2].Deep_Copy(); //ひとつ前の値をコピー
                    History.Back_History.RemoveAt(History.Back_History.Count - 1);

                    /*
                    if (History.Back_History.Count >= 12) //削除処理
                    {
                        Console.WriteLine("Dele");
                        History.Back_History.RemoveRange(0, 2 );
                    } //ここまで
                    */

                    //History.Next_History.Add(Temp_formSearchModel.Deep_Copy()); 進がなくなったため無効化


                    formSearchModel.HistoryBackState = true;
                    //StateHasChanged();
                }
                catch (System.ArgumentOutOfRangeException e) //Back_History-2の位置に値が入っていなかったとき
                {
                    Console.WriteLine("予期せぬエラー -> MainLayout:003(配列不正)");
                    History.Back_History.Clear();
                    History.Next_History.Clear();
                    formSearchModel.IndexURL = "Index";

                }
            }
            else
            {
                //BackHistoryに値が入っていない場合エラー
                Console.WriteLine("予期せぬエラー -> MainLayout:004(Back_Historyエラー)");
                History.Back_History.Clear();
                History.Next_History.Clear();
                formSearchModel.IndexURL = "Index";

            }
            Console.WriteLine("ButtonOn-----------------------------");
        }

        public void test()
        {
            for(int i=0;i<=10;i++)
            { 
                History.Back_History.Add(formSearchModel);
            }
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
