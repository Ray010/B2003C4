// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace B2003C4.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Work\B2003C4_Blazor\B2003C4\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Work\B2003C4_Blazor\B2003C4\_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Work\B2003C4_Blazor\B2003C4\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Work\B2003C4_Blazor\B2003C4\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Work\B2003C4_Blazor\B2003C4\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Work\B2003C4_Blazor\B2003C4\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Work\B2003C4_Blazor\B2003C4\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Work\B2003C4_Blazor\B2003C4\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Work\B2003C4_Blazor\B2003C4\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Work\B2003C4_Blazor\B2003C4\_Imports.razor"
using B2003C4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Work\B2003C4_Blazor\B2003C4\_Imports.razor"
using B2003C4.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Work\B2003C4_Blazor\B2003C4\_Imports.razor"
using B2003C4.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Work\B2003C4_Blazor\B2003C4\_Imports.razor"
using B2003C4.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Work\B2003C4_Blazor\B2003C4\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Work\B2003C4_Blazor\B2003C4\Pages\IdentityX.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Work\B2003C4_Blazor\B2003C4\Pages\IdentityX.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/IdentityX")]
    public partial class IdentityX : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Work\B2003C4_Blazor\B2003C4\Pages\IdentityX.razor"
       
    private string _authMessage;
    private string _surnameMessage;
    private IEnumerable<Claim> _claims = Enumerable.Empty<Claim>();

    private async Task GetClaimsPrincipalData()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        if (user.Identity.IsAuthenticated)
        {
            _authMessage = $"{user.Identity.Name} is authenticated.";
            _claims = user.Claims;
            _surnameMessage =
                $"Surname: {user.FindFirst(c => c.Type == ClaimTypes.Surname)?.Value}";
        }
        else
        {
            _authMessage = "The user is NOT authenticated.";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
