#pragma checksum "C:\Work\B2003C4\B2003C4\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d8006c6f3c07626fa3869bd20794232e737cfe8"
// <auto-generated/>
#pragma warning disable 1591
namespace B2003C4.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Work\B2003C4\B2003C4\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Work\B2003C4\B2003C4\_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Work\B2003C4\B2003C4\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Work\B2003C4\B2003C4\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Work\B2003C4\B2003C4\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Work\B2003C4\B2003C4\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Work\B2003C4\B2003C4\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Work\B2003C4\B2003C4\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Work\B2003C4\B2003C4\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Work\B2003C4\B2003C4\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Work\B2003C4\B2003C4\_Imports.razor"
using B2003C4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Work\B2003C4\B2003C4\_Imports.razor"
using B2003C4.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Work\B2003C4\B2003C4\_Imports.razor"
using B2003C4.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Work\B2003C4\B2003C4\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "C:\Work\B2003C4\B2003C4\Shared\MainLayout.razor"
using B2003C4.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "C:\Work\B2003C4\B2003C4\Shared\MainLayout.razor"
using B2003C4.Pages.IriTome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\Work\B2003C4\B2003C4\Shared\MainLayout.razor"
using B2003C4.Pages.Kako;

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "C:\Work\B2003C4\B2003C4\Shared\MainLayout.razor"
using B2003C4.Pages.Kansa;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>

    .bg {
        background-color: #ededed;
    }

    .wrapper {
        position: relative;
    }

    footer {
        width: 100%;
        position: fixed;
        bottom: 0vh;
        left: 0vw;
    }

    .Text_Color {
        color: #FFFFFF;
    }

    #Back_button_Fixed {
        padding: 1rem;
        bottom: 2vh;
        left: 4vw;
        position: fixed;
        border-radius: 100%;
    }
    #Next_button_Fixed {
        padding: 1rem;
        bottom: 16vh;
        left: 4vw;
        position: fixed;
        border-radius: 100%;
    }
</style>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "sidebar fixed-top");
            __builder.OpenComponent<B2003C4.Shared.NavMenu>(3);
            __builder.AddAttribute(4, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<B2003C4.Data.FormSearchDataModel>(
#nullable restore
#line 42 "C:\Work\B2003C4\B2003C4\Shared\MainLayout.razor"
                                formSearchModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "CurrentPageChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<B2003C4.Data.FormSearchDataModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<B2003C4.Data.FormSearchDataModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => formSearchModel = __value, formSearchModel))));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "wrapper main Page-Margin bg");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "top-row px-4 fixed-top");
#nullable restore
#line 52 "C:\Work\B2003C4\B2003C4\Shared\MainLayout.razor"
         if (true == true)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<div>サーバーステータス：接続</div>");
#nullable restore
#line 55 "C:\Work\B2003C4\B2003C4\Shared\MainLayout.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<div>サーバーステータス：未接続</div>");
#nullable restore
#line 59 "C:\Work\B2003C4\B2003C4\Shared\MainLayout.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "content px-4 Bg_Color");
#nullable restore
#line 65 "C:\Work\B2003C4\B2003C4\Shared\MainLayout.razor"
         switch (formSearchModel.IndexURL)
        {
            case "":

                break;

            case "Index":

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<B2003C4.Pages.Index>(16);
            __builder.AddAttribute(17, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<B2003C4.Data.FormSearchDataModel>(
#nullable restore
#line 72 "C:\Work\B2003C4\B2003C4\Shared\MainLayout.razor"
                                          formSearchModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "CurrentPageChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<B2003C4.Data.FormSearchDataModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<B2003C4.Data.FormSearchDataModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => formSearchModel = __value, formSearchModel))));
            __builder.CloseComponent();
#nullable restore
#line 73 "C:\Work\B2003C4\B2003C4\Shared\MainLayout.razor"
                break;

            case "IriTome":

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<B2003C4.Pages.IriTome.IriTomeParent>(19);
            __builder.AddAttribute(20, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<B2003C4.Data.FormSearchDataModel>(
#nullable restore
#line 76 "C:\Work\B2003C4\B2003C4\Shared\MainLayout.razor"
                                                  formSearchModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "CurrentPageChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<B2003C4.Data.FormSearchDataModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<B2003C4.Data.FormSearchDataModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => formSearchModel = __value, formSearchModel))));
            __builder.CloseComponent();
#nullable restore
#line 77 "C:\Work\B2003C4\B2003C4\Shared\MainLayout.razor"
                break;

            case "Kako":

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<B2003C4.Pages.Kako.KakoParent>(22);
            __builder.AddAttribute(23, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<B2003C4.Data.FormSearchDataModel>(
#nullable restore
#line 80 "C:\Work\B2003C4\B2003C4\Shared\MainLayout.razor"
                                               formSearchModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "CurrentPageChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<B2003C4.Data.FormSearchDataModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<B2003C4.Data.FormSearchDataModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => formSearchModel = __value, formSearchModel))));
            __builder.CloseComponent();
#nullable restore
#line 81 "C:\Work\B2003C4\B2003C4\Shared\MainLayout.razor"
                break;

            case "Kansa":

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<B2003C4.Pages.Kansa.KansaParent>(25);
            __builder.AddAttribute(26, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<B2003C4.Data.FormSearchDataModel>(
#nullable restore
#line 84 "C:\Work\B2003C4\B2003C4\Shared\MainLayout.razor"
                                                formSearchModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "CurrentPageChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<B2003C4.Data.FormSearchDataModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<B2003C4.Data.FormSearchDataModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => formSearchModel = __value, formSearchModel))));
            __builder.CloseComponent();
#nullable restore
#line 85 "C:\Work\B2003C4\B2003C4\Shared\MainLayout.razor"
                break;
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, 
#nullable restore
#line 97 "C:\Work\B2003C4\B2003C4\Shared\MainLayout.razor"
         formSearchModel.Select_TenpoNo

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.AddMarkupContent(30, "<div>No</div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n");
            __builder.OpenElement(32, "div");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "id", "Back_button_Fixed");
            __builder.AddAttribute(35, "class", "btn btn-warning Text_Color");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 113 "C:\Work\B2003C4\B2003C4\Shared\MainLayout.razor"
                                                                                BackPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(37, @"<svg width=""2em"" height=""2em"" viewBox=""0 0 16 16"" class=""bi bi-arrow-bar-left"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M12.5 15a.5.5 0 0 1-.5-.5v-13a.5.5 0 0 1 1 0v13a.5.5 0 0 1-.5.5zM10 8a.5.5 0 0 1-.5.5H3.707l2.147 2.146a.5.5 0 0 1-.708.708l-3-3a.5.5 0 0 1 0-.708l3-3a.5.5 0 1 1 .708.708L3.707 7.5H9.5a.5.5 0 0 1 .5.5z""></path></svg>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591