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

        public void Rewrite() //フェーズを戻るとk
        {
            formDataModel = CurrentPage;
            ResultData = CurrentPage;

        }
        public void write() //次のフェーズに行く
        {
            if(formDataModel.PhaseNo != ResultData.PhaseNo)
            {
                formDataModel = ResultData;
                CurrentPage.PhaseNo = ResultData.PhaseNo;
                CurrentPageChanged.InvokeAsync(CurrentPage);
            }

        }




    }
}
