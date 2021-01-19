using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Internal;
using B2003C4.Data;
using B2003C4.Class;
//using Microsoft.EntityFrameworkCore.Internal;

namespace B2003C4.Pages.Kansa
{
    public partial class SearchActivity
    {
        public int Count { get; set; }


        //Phase1から受け取ったサーチしたいデータ-----------------------------------------------------------
        [Parameter]
        public FormSearchDataModel Phase2Data { get; set; }

        [Parameter]
        public EventCallback<FormSearchDataModel> Phase2DataChanged { get; set; }
        //--------------------------------------------------------------------------------------------------

        //サーチにかけるソースデータ（DB）------------------------------------------------------------------
        [Parameter]
        public DummyDataModel DBSourceData { get; set; }

        [Parameter]
        public EventCallback<DummyDataModel> DBSourceDataChanged { get; set; }
        //--------------------------------------------------------------------------------------------------

        //DB------------------------------------------------------------------------------------------------


        [Parameter]
        public List<Kuiki_K95080> C_KuikiList { get; set; }

        [Parameter]
        public EventCallback<List<Kuiki_K95080>> C_KuikiListChanged { get; set; }








        //DB------------------------------------------------------------------------------------------------

        //受け渡し用のリザルトデータ------------------------------------------------------------------------
        /*
        [Parameter]
        public FormSearchDataModel SearchResultData { get; set; }

        [Parameter]
        public EventCallback<FormSearchDataModel> SearchResultDataChanged { get; set; }
        */
        //--------------------------------------------------------------------------------------------------

        List<Dokusya_K95080> DokusyaSearchEdList = new List<Dokusya_K95080> { };

        



        protected override Task OnInitializedAsync()
        {
            /*
            foreach (var x in C_DokusyaList)
            {
                Boolean DokusyaNameNull = false;
                Boolean DokusyaKanaNameNull = false;
                Boolean SigaiNull = false;
                Boolean TelNull = false;
                Boolean BuildingNameNull = false;
                Boolean BuildingKanaNameNull = false;
                Boolean CheckResultNull = false;

                //StartWithのnullチェック
                try
                {
                    DokusyaNameNull = x.DokuName.StartsWith(Phase2Data.S_DokuName);
                }
                catch(ArgumentNullException)
                {
                    DokusyaNameNull = true;
                }
                try
                {
                    if(x.DokuKana == null)
                    {
                        DokusyaKanaNameNull = true;
                    }
                    else
                    { 
                        DokusyaKanaNameNull = x.DokuKana.StartsWith(Phase2Data.S_DokuKana);
    
                    }
                }
                catch (ArgumentNullException)
                {
                    DokusyaKanaNameNull = true;
                }

                try
                {
                    //SigaiNull = x.Sigai1.StartsWith(Phase2Data.S_Sigai);
                }
                catch (ArgumentNullException)
                {
                    SigaiNull = true;
                }
                try
                {
                    //TelNull = x.Sigai1.StartsWith(Phase2Data.S_Tel);
                }
                catch (ArgumentNullException)
                {
                    //TelNull = true;
                }
                try
                {
                    //BuildingNameNull = x.BuildName.StartsWith(Phase2Data.S_BuildName);
                }
                catch (ArgumentNullException)
                {
                    BuildingNameNull = true;
                }
                try
                {
                    //BuildingKanaNameNull = x.BuildKana.StartsWith(Phase2Data.S_BuildKana);
                }
                catch (ArgumentNullException)
                {
                    BuildingKanaNameNull = true;
                }
                try
                {
                    /*
                    if (Array.IndexOf(Phase2Data.CheckResult,x.DokusyaStatus) != -1)
                    {
                        CheckResultNull = true;
                    }
                    else if (Phase2Data.CheckResult.Length == 0)
                    {
                        CheckResultNull = true;
                    }
                    *
                }
                catch(ArgumentNullException)
                {
                    CheckResultNull = true;
                    Console.WriteLine("Catch: true");
                }
                //StartWithのnull例外チェック終わり
                /*
                if (
                (x.DokuCode == Phase2Data.S_DokuCode || null == Phase2Data.S_DokuCode) &&
                (x.Kuiki == Phase2Data.S_KuikiNo || null == Phase2Data.S_KuikiNo) &&
                DokusyaNameNull &&
                DokusyaKanaNameNull &&
                SigaiNull &&
                TelNull &&
                (x.ChomeiName == Phase2Data.S_ChomeiName || null == Phase2Data.S_ChomeiName) &&
                (x.CityAddress == Phase2Data.S_CityAddress || null == Phase2Data.S_CityAddress) &&
                BuildingNameNull &&
                BuildingKanaNameNull &&
                (x.RoomNo == Phase2Data.S_RoomNo || null == Phase2Data.S_RoomNo) &&
                CheckResultNull
                )
                {
                    
                }
                *
            }

            DokusyaSearchEdList = C_DokusyaList.Where(x => (x.DokuCode == Phase2Data.S_DokuCode || null == Phase2Data.S_DokuCode) && (x.Kuiki == Phase2Data.S_KuikiNo || x.Kuiki == null) ).ToList();

            */
            //履歴処理
            /*

                            (x.Junro_K95080 == Phase2Data.S_Junro || null == Phase2Data.S_Junro) &&
                (x.Junro_Sub == Phase2Data.S_Junro_Sub || null == Phase2Data.S_Junro_Sub) &&

            */

            Count = DokusyaSearchEdList.Count;


            
            if( Count == 0 )
            {
                //検索結果が０人の時
                return PhaseShift(1, "検索条件に一致しませんでした。","");
            }
            else
            {
                
                if (Phase2Data.HistoryBackState == false)
                {
                    History.Back_History.Add(Phase2Data.Deep_Copy());   //.Add(CurrentPage);
                    Phase2DataChanged.InvokeAsync(Phase2Data);
                }
                else if (Phase2Data.HistoryBackState == true)
                {
                    Phase2Data.HistoryBackState = false;
                    Phase2DataChanged.InvokeAsync(Phase2Data);
                }
                
                return PhaseShift(2, "。", "");
            }
            


            //履歴の処理




        }

        List<Status> DokusyaStatusList = new List<Status>
        {
            new Status("未読","Midoku"),
            new Status("現読","Gendoku"),
            new Status("予約","Yoyaku"),
            new Status("止め","Tome"),
            new Status("休読","Kyudoku"),
            new Status("保留","Horyu"),
            new Status("発証","Hassyo"),
            new Status("順路","Junro"),
            new Status("不良","Huryo"),
            new Status("空家","Akiya"),
            new Status("他現","Tagen"),
        };

        public class Status
        {
            public string StatusCode;
            public string StatusName;

            public Status(string statusName , string statusCode)
            {
                StatusName = statusName;
                StatusCode = statusCode;
            }
        }
        public string CheckMasterX;

        //Page移動
        [Inject]
        protected NavigationManager Navi { get; set; }
        public void JumpPage(string URLx)
        {

            Navi.NavigateTo(URLx);
        }

        public async Task PhaseShift(int ShiftNo , string ShiftReason ,string etc)
        {
            Phase2Data.PhaseNo = ShiftNo;
            Phase2Data.ShiftReason = ShiftReason;
            Phase2Data.Etc = etc;
            await Phase2DataChanged.InvokeAsync(Phase2Data);
            StateHasChanged();
        }


        public async Task ValueForModel(Dokusya_K95080 X)
        {
            Console.WriteLine( X.DokuCode);
            Console.WriteLine(X.DokuName);
            Console.WriteLine(X.BuildKana);


            //---------------------------------------------
 
            Phase2Data.S_DokuCode = X.DokuCode;


            await Phase2DataChanged.InvokeAsync(Phase2Data);
            await PhaseShift(11,"","");

        }



    }
}
