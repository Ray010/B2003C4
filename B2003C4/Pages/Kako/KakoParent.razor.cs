using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;
using B2003C4.Data;
using B2003C4.Service;

namespace B2003C4.Pages.Kako
{
    public partial class KakoParent
    {
            [Parameter]
            public FormSearchDataModel CurrentPage { get; set; }
            [Parameter]
            public EventCallback<FormSearchDataModel> CurrentPageChanged { get; set; }

            [Parameter]
            public DummyDataModel DBSourceData { get; set; }

            [Parameter]
            public EventCallback<DummyDataModel> DBSourceDataChanged { get; set; }


        [Inject]
        private NewsPaperDataService NewsPaperData { get; set; }

        protected override async Task OnInitializedAsync()
        {
            P_DokusyaList = await NewsPaperData.GetDokusya_K95020_ListAsync();
            P_KoudokuList = await NewsPaperData.GetKoudoku_K95020_ListAsync();

            P_TomeList = await NewsPaperData.GetTome_K95020_ListAsync();
            P_KuikiList = await NewsPaperData.GetKuiki_K95020_ListAsync();
            P_NengetuList = await NewsPaperData.GetNengetu_K95020_ListAsync();
            P_KakuzaiList = await NewsPaperData.GetKakuzai_K95020_ListAsync();
        }




        /*
            public void Rewrite() //フェーズを戻るとk
            {
                
                formDataModel = CurrentPage;
                ResultData = CurrentPage;

            }
            public void write() //次のフェーズに行く
            {
                if (formDataModel.PhaseNo != ResultData.PhaseNo)
                {
                    formDataModel = ResultData;
                    CurrentPage.PhaseNo = ResultData.PhaseNo;
                    CurrentPageChanged.InvokeAsync(CurrentPage);
                }

            }
        */

    }
}
