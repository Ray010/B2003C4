#pragma checksum "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\ReceiveSettingsFragment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f639771efe4d2c18efe34a1d78e3bc0abda570e0"
// <auto-generated/>
#pragma warning disable 1591
namespace B2003C4.Pages.MobileSettings
{
    #line hidden
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
#line 8 "C:\Work\B2003C4_Blazor\B2003C4\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

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
#line 5 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\ReceiveSettingsFragment.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\ReceiveSettingsFragment.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\ReceiveSettingsFragment.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\ReceiveSettingsFragment.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\ReceiveSettingsFragment.razor"
using Microsoft.AspNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\ReceiveSettingsFragment.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\ReceiveSettingsFragment.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ReceiveSettingsFragment")]
    public partial class ReceiveSettingsFragment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.AddAttribute(1, "class", "bg-light");
            __builder.OpenElement(2, "div");
            __builder.OpenElement(3, "form");
            __builder.AddAttribute(4, "method", "post");
            __builder.AddMarkupContent(5, "<h6></h6>\r\n \r\n            ");
            __builder.AddMarkupContent(6, "<label asp-for=\"Settings.Key_Mobile_No\">サーバーIPアドレス</label>\r\n            ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "id", "name");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\ReceiveSettingsFragment.razor"
                                     MobileIPAddress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => MobileIPAddress = __value, MobileIPAddress));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            <p></p>\r\n            <label class=\"text-white bg-danger\"></label>\r\n\r\n            <input asp-page-handler=\"~/Login\" type=\"submit\" value=\"適用\" class=\"btn btn-danger btn-block\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n        <p></p>\r\n        ");
            __builder.AddMarkupContent(14, "<form method=\"post\"><input asp-page-handler=\"~/Login\" type=\"submit\" value=\"戻る\" class=\"btn btn-secondary btn-block\"></form>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\ReceiveSettingsFragment.razor"
       

    private string MobileIPAddress { set; get; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
