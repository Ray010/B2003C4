#pragma checksum "C:\Work\B2003C4\B2003C4\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb08e60db8e0eb0444aa4d09eb4879660a10095d"
// <auto-generated/>
#pragma warning disable 1591
namespace B2003C4.Pages
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
#line 4 "C:\Work\B2003C4\B2003C4\Pages\Index.razor"
using B2003C4.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Work\B2003C4\B2003C4\Pages\Index.razor"
using B2003C4.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Work\B2003C4\B2003C4\Pages\Index.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "html");
            __builder.AddMarkupContent(1, "<head><meta charset=\"Shift-JIS\">\r\n    <meta http-equiv=\"content-language\" content=\"ja\">\r\n    <meta name=\"google\" content=\"notranslate\">\r\n\r\n    <style>        .mb-3 { margin-bottom: 0.5rem; }\r\n\r\n        .BackGr {\r\n            background: #80989b;\r\n            width: 100%;\r\n            height: 100%;\r\n            margin: 0px;\r\n            padding: 0px;\r\n            overflow: hidden;\r\n        }\r\n\r\n        .Index_Font_Size{\r\n            font-size:2.5rem;\r\n        }\r\n        .IndexMark_Font_Size {\r\n            font-size: 4rem;\r\n        }\r\n        .IndexSub_Font_Size {\r\n            font-size: 1.5rem;\r\n        }\r\n        .Card_table_Fixed{\r\n            text-align:left;\r\n        }\r\n\r\n        .Button_Margin{\r\n            margin-bottom: 1rem;\r\n        }\r\n        .btn-Base-05 {\r\n            height: 5rem;\r\n            background: linear-gradient( 45deg, #808080 0%, #808080 100%);\r\n        }\r\n\r\n        .btn-Tenpo {\r\n            display: inline-block;\r\n            color: black;\r\n            width: 100%;\r\n            text-align:left;\r\n        }\r\n\r\n\r\n            .btn-Tenpo:not(:disabled):not(.disabled):active,\r\n            .btn-Tenpo:not(:disabled):not(.disabled).active,\r\n            .show > .btn-menu.dropdown-toggle {\r\n                background-color: rgba(0, 0, 0, 0.00);\r\n            }\r\n\r\n        .Tenpo {\r\n            font-size: 1.5rem;\r\n            width: 100%;\r\n        }\r\n\r\n        .mdc-select__selected-text {\r\n            font-size: 1.5rem;\r\n        }\r\n\r\n        .mdc-select:not(.mdc-select--disabled) .mdc-select__anchor {\r\n            background-color: rgba(0, 0, 0, 0.00);\r\n        }\r\n\r\n\r\n\r\n    </style></head>");
#nullable restore
#line 90 "C:\Work\B2003C4\B2003C4\Pages\Index.razor"
 if (P_TenpoList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<div>Loading...</div>");
#nullable restore
#line 93 "C:\Work\B2003C4\B2003C4\Pages\Index.razor"
}
else
{





#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "body");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", " text-left Bg_Color");
            __builder.OpenElement(6, "div");
            __Blazor.B2003C4.Pages.Index.TypeInference.CreateMatSelect_0(__builder, 7, 8, "", 9, "", 10, 
#nullable restore
#line 129 "C:\Work\B2003C4\B2003C4\Pages\Index.razor"
                                                            Tenpo_SelectedValue

#line default
#line hidden
#nullable disable
            , 11, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Tenpo_SelectedValue = __value, Tenpo_SelectedValue)), 12, () => Tenpo_SelectedValue, 13, (__builder2) => {
#nullable restore
#line 130 "C:\Work\B2003C4\B2003C4\Pages\Index.razor"
                 foreach (var Temp_Tenpo in P_TenpoList)
                {

#line default
#line hidden
#nullable disable
                __Blazor.B2003C4.Pages.Index.TypeInference.CreateMatOption_1(__builder2, 14, 15, 
#nullable restore
#line 132 "C:\Work\B2003C4\B2003C4\Pages\Index.razor"
                                       Temp_Tenpo.Tenpo

#line default
#line hidden
#nullable disable
                , 16, (__builder3) => {
                    __builder3.AddContent(17, 
#nullable restore
#line 132 "C:\Work\B2003C4\B2003C4\Pages\Index.razor"
                                                          Temp_Tenpo.TenpoName

#line default
#line hidden
#nullable disable
                    );
                }
                );
#nullable restore
#line 133 "C:\Work\B2003C4\B2003C4\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n        \r\n        ");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 138 "C:\Work\B2003C4\B2003C4\Pages\Index.razor"
                            s => JumpPage("IriTome")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "type", "button");
            __builder.AddAttribute(22, "class", "Button_Margin btn-Base btn-Base-01 btn text-dark btn-outline-info");
            __builder.AddMarkupContent(23, @"<div align=""justify""><table class=""Card_table_Fixed""><tr><td align=""center"" colspan=""2""><span class=""Index_Font_Size oi oi-list-rich""></span></td>
                        <td align=""left"" colspan=""10"" class=""Index_Font_Size"">入止表</td></tr>
                    <tr><td colspan=""1"">&nbsp;</td>
                        <td colspan=""10"" class=""IndexSub_Font_Size"">1区～5区</td></tr></table></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n\r\n        \r\n        ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 160 "C:\Work\B2003C4\B2003C4\Pages\Index.razor"
                            s => JumpPage("Kako")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "type", "button");
            __builder.AddAttribute(28, "class", "Button_Margin btn-Base btn-Base-02 btn text-dark btn-outline-info");
            __builder.AddMarkupContent(29, @"<div align=""justify""><table class=""Card_table_Fixed""><tr><td align=""center"" colspan=""2""><span class=""Index_Font_Size oi oi-document""></span></td>
                        <td align=""left"" colspan=""10"" class=""Index_Font_Size"">過去台帳</td></tr>
                    <tr><td colspan=""1"">&nbsp;</td>
                        <td colspan=""10"" class=""IndexSub_Font_Size"">1区～5区</td></tr></table></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n\r\n        \r\n\r\n        ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 203 "C:\Work\B2003C4\B2003C4\Pages\Index.razor"
                            s => JumpPage("Kansa")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "type", "button");
            __builder.AddAttribute(34, "class", "Button_Margin btn-Base btn-Base-04 btn text-dark btn-outline-info");
            __builder.AddMarkupContent(35, @"<div align=""justify""><table class=""Card_table_Fixed""><tr><td align=""center"" colspan=""2""><span class=""Index_Font_Size oi oi-eye""></span></td>
                        <td align=""left"" colspan=""10"" class=""Index_Font_Size"">監査</td></tr>
                    <tr><td colspan=""1"">&nbsp;</td>
                        <td colspan=""10"" class=""IndexSub_Font_Size"">1区～5区</td></tr></table></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.AddContent(37, 
#nullable restore
#line 240 "C:\Work\B2003C4\B2003C4\Pages\Index.razor"
         Tenpo_SelectedValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.AddContent(39, 
#nullable restore
#line 241 "C:\Work\B2003C4\B2003C4\Pages\Index.razor"
         Tenpo_SelectValue

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 244 "C:\Work\B2003C4\B2003C4\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 264 "C:\Work\B2003C4\B2003C4\Pages\Index.razor"
      

    /*
    List<Dokusya> DokusyaList;

    protected override async Task OnInitializedAsync()
    {
        var DokusyaLista = await NewsPaperData.GetdokusyaAsync();

        DokusyaList = await NewsPaperData.GetdokusyaAsync();
    }
    */

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.B2003C4.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::MatBlazor.MatSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "HelperText", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMatOption_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MatBlazor.MatOption<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591