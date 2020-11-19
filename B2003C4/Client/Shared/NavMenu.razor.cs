using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;

namespace B2003C4.Client.Shared
{
    public partial class NavMenu
    {
        [Inject]
        public NavigationManager Navi { get; set; }

        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        public void JumpPage(string URLx)
        {
            JSRuntime.InvokeVoidAsync("JumpPage", Navi.BaseUri + URLx);
        }


    }
}
