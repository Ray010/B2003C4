using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using B2003C4.Client.Data;

namespace B2003C4.Client.Shared
{
    public partial class NavMenu
    {
        [Inject]
        public NavigationManager Navi { get; set; }

        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        [Parameter]
        public FormSearchDataModel CurrentPage { get; set; }
        [Parameter]
        public EventCallback<FormSearchDataModel> CurrentPageChanged { get; set; }


        public async void JumpPage(string URLx)
        {
            CurrentPage.CurrentURL = CurrentPage.IndexURL;
            CurrentPage.IndexURL = URLx;
            await CurrentPageChanged.InvokeAsync(CurrentPage);
            StateHasChanged();
        }
        
        /*
        public void JumpPage(string URLx)
        {
            JSRuntime.InvokeVoidAsync("JumpPage", Navi.BaseUri + URLx);
        }
        */

    }
}
