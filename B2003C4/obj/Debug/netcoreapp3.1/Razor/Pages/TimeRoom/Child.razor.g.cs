#pragma checksum "C:\Work\B2003C4_Blazor\B2003C4\Pages\TimeRoom\Child.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba93925461ecb62ab55c57c55d1f19f8af466c1f"
// <auto-generated/>
#pragma warning disable 1591
namespace B2003C4.Pages.TimeRoom
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/TimeRoom/Child")]
    public partial class Child : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card bg-light mt-3");
            __builder.AddAttribute(2, "style", "width:18rem ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.AddMarkupContent(5, "<h3 class=\"card-title\">Child Component</h3>\r\n        ");
            __builder.OpenElement(6, "p");
            __builder.AddAttribute(7, "class", "card-text");
            __builder.AddContent(8, "Child ");
            __builder.AddMarkupContent(9, "<code>Year</code>: ");
            __builder.AddContent(10, 
#nullable restore
#line 7 "C:\Work\B2003C4_Blazor\B2003C4\Pages\TimeRoom\Child.razor"
                                                       Year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, " \r\n        ");
            __builder.AddContent(12, 
#nullable restore
#line 8 "C:\Work\B2003C4_Blazor\B2003C4\Pages\TimeRoom\Child.razor"
         Year1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Work\B2003C4_Blazor\B2003C4\Pages\TimeRoom\Child.razor"
                  UpdateYearFromChild

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Update Year from Child");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Work\B2003C4_Blazor\B2003C4\Pages\TimeRoom\Child.razor"
       
    private Random r = new Random();

    [Parameter]
    public int Year { get; set; }

    [Parameter]
    public int Year1 { get; set; }

    [Parameter]
    public EventCallback<int> YearChanged { get; set; }

    private async Task UpdateYearFromChild()
    {
        await YearChanged.InvokeAsync(r.Next(1950, 2021));
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
