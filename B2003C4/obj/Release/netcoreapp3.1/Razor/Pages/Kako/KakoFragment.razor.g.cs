#pragma checksum "C:\Work\B2003C4\B2003C4\Pages\Kako\KakoFragment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bed428d12af5e6ee0275ea24d150af603792def"
// <auto-generated/>
#pragma warning disable 1591
namespace B2003C4.Pages.Kako
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 17 "C:\Work\B2003C4\B2003C4\_Imports.razor"
using B2003C4.Data;

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
#line 6 "C:\Work\B2003C4\B2003C4\Pages\Kako\KakoFragment.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Kako/KakoFragment")]
    public partial class KakoFragment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!DOCTYPE HTML>\r\n");
            __builder.OpenElement(1, "html");
            __builder.AddAttribute(2, "lang", "ja");
            __builder.AddMarkupContent(3, @"<head><meta charset=""Shift-JIS"">
    <meta http-equiv=""content-language"" content=""ja"">
    <meta name=""google"" content=""notranslate"">

    <style>        .mb-3 { margin-bottom: 0.5rem; }

        .BackGr {
            background: #80989b;
            width: 100%;
            height: 100%;
            margin: 0px;
            padding: 0px;
            overflow: hidden;
        }

        table {
            display: table;
            table-layout: fixed;
            text-align: center;
            width: 100%;
            vertical-align: top;
        }
        .NameButtonMargin{
            padding: 0.2rem 0.2rem 0.2rem 0.2rem;

        }
        .TableMargin{
            margin: 1em 1em 1em 1em;
        }
        .VerticalFix {
            vertical-align: top;
        }
        tr{
            height: 1.1em;
        }

        .btnW {
            color: #FFFFFF;
        }

        .btn-KakoButton {
            border-radius: 0;
            background-color: #ffffff;
        }

            .btn-KakoButton:not(:disabled):not(.disabled):active,
            .btn-KakoButton:not(:disabled):not(.disabled).active,
            .show > .btn-menu.dropdown-toggle {
            }

    </style></head>

");
            __builder.OpenElement(4, "body");
            __builder.OpenElement(5, "div");
            __builder.OpenElement(6, "table");
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddAttribute(9, "colspan", "5");
            __builder.OpenElement(10, "select");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 80 "C:\Work\B2003C4\B2003C4\Pages\Kako\KakoFragment.razor"
                                                             OnChangeEventKuiki

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 82 "C:\Work\B2003C4\B2003C4\Pages\Kako\KakoFragment.razor"
                         foreach (var x in TenpoKuiki)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "option");
            __builder.AddAttribute(14, "value", 
#nullable restore
#line 84 "C:\Work\B2003C4\B2003C4\Pages\Kako\KakoFragment.razor"
                                            x.KuikiNo

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, 
#nullable restore
#line 84 "C:\Work\B2003C4\B2003C4\Pages\Kako\KakoFragment.razor"
                                                         x.KuikiName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 85 "C:\Work\B2003C4\B2003C4\Pages\Kako\KakoFragment.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddAttribute(18, "align", "right");
            __builder.AddAttribute(19, "colspan", "5");
            __builder.AddContent(20, 
#nullable restore
#line 90 "C:\Work\B2003C4\B2003C4\Pages\Kako\KakoFragment.razor"
                     Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(21, " 件\r\n");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n        ");
            __builder.OpenElement(23, "table");
            __builder.AddAttribute(24, "class", "Card_parent Bg_Color");
#nullable restore
#line 127 "C:\Work\B2003C4\B2003C4\Pages\Kako\KakoFragment.razor"
             foreach (var x in C_TomeList)
            {
                if(x.Tenpo == Phase1Data.Select_TenpoNo && x.Kuiki == Kuiki_SelectedValue)
                { 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "tr");
            __builder.OpenElement(26, "td");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "Card_parent");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 134 "C:\Work\B2003C4\B2003C4\Pages\Kako\KakoFragment.razor"
                                                    s => JumpPage(x)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "type", "button");
            __builder.AddAttribute(32, "class", "btn btn-KakoButton btn-block");
            __builder.OpenElement(33, "table");
            __builder.OpenElement(34, "tr");
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "colspan", "9");
            __builder.AddAttribute(37, "align", "left");
            __builder.AddContent(38, 
#nullable restore
#line 137 "C:\Work\B2003C4\B2003C4\Pages\Kako\KakoFragment.razor"
                                                                          x.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                                            ");
            __builder.OpenElement(40, "td");
            __builder.AddAttribute(41, "colspan", "1");
            __builder.AddContent(42, 
#nullable restore
#line 138 "C:\Work\B2003C4\B2003C4\Pages\Kako\KakoFragment.razor"
                                                             x.MgNo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                                        ");
            __builder.OpenElement(44, "tr");
            __builder.AddAttribute(45, "align", "left");
            __builder.OpenElement(46, "td");
            __builder.AddAttribute(47, "colspan", "4");
            __builder.AddContent(48, 
#nullable restore
#line 141 "C:\Work\B2003C4\B2003C4\Pages\Kako\KakoFragment.razor"
                                                             x.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                                            ");
            __builder.AddMarkupContent(50, "<td colspan=\"4\">x.CityAddress</td>\r\n                                            ");
            __builder.AddMarkupContent(51, "<td colspan=\"2\">&nbsp;</td>");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                                        ");
            __builder.OpenElement(53, "tr");
            __builder.AddMarkupContent(54, "<td colspan=\"2\" align=\"left\">x.B</td>\r\n                                            ");
            __builder.OpenElement(55, "td");
            __builder.AddAttribute(56, "colspan", "6");
            __builder.AddAttribute(57, "align", "left");
            __builder.AddContent(58, 
#nullable restore
#line 147 "C:\Work\B2003C4\B2003C4\Pages\Kako\KakoFragment.razor"
                                                                          x.iri

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(59, " - ");
            __builder.AddContent(60, 
#nullable restore
#line 147 "C:\Work\B2003C4\B2003C4\Pages\Kako\KakoFragment.razor"
                                                                                   x.tome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 158 "C:\Work\B2003C4\B2003C4\Pages\Kako\KakoFragment.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591