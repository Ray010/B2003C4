#pragma checksum "C:\Work\B2003C4\B2003C4\Pages\Kansa\SearchActivity.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8511a9b948a5ea734ddc0ceed74dc10d3d689bb0"
// <auto-generated/>
#pragma warning disable 1591
namespace B2003C4.Pages.Kansa
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
#line 4 "C:\Work\B2003C4\B2003C4\Pages\Kansa\SearchActivity.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Work\B2003C4\B2003C4\Pages\Kansa\SearchActivity.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Kansa/SearchActivity")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Kansa/SearchActivity/{Param}")]
    public partial class SearchActivity : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!DOCTYPE HTML>\r\n");
            __builder.OpenElement(1, "html");
            __builder.AddAttribute(2, "lang", "ja");
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.AddMarkupContent(4, "<head>\r\n    <meta charset=\"Shift-JIS\">\r\n    <meta http-equiv=\"content-language\" content=\"ja\">\r\n    <meta name=\"google\" content=\"notranslate\">\r\n\r\n    <style>\r\n        .mb-3 { margin-bottom: 0.5rem; }\r\n\r\n        .BackGr {\r\n            background: #80989b;\r\n            width: 100%;\r\n            height: 100%;\r\n            margin: 0px;\r\n            padding: 0px;\r\n            overflow: hidden;\r\n\r\n        }\r\n\r\n        .Btn-Color{\r\n            background-color: #ffffff;\r\n        }\r\n\r\n        .Margin_Bottom{\r\n            margin-bottom: 2rem;\r\n        }\r\n\r\n\r\n                .mb-3 { margin-bottom: 0.5rem; }\r\n\r\n        .BackGr {\r\n            background: #80989b;\r\n            width: 100%;\r\n            height: 100%;\r\n            margin: 0px;\r\n            padding: 0px;\r\n            overflow: hidden;\r\n        }\r\n\r\n        .td_padding_Fixed{\r\n            padding: 0%;\r\n        }\r\n\r\n\r\n\r\n        .Scroll_Control {\r\n            width: 100%;\r\n            overflow-y: scroll;\r\n            overflow-x: hidden;\r\n        }\r\n        .Scroll_Control::-webkit-scrollbar {\r\n            width: 0.3vw;\r\n            height: 5px;\r\n\r\n        }\r\n            .Scroll_Control::-webkit-scrollbar-thumb {\r\n            background: linear-gradient(0deg,#43e2c6,#3183d0);\r\n            border-radius: 3px;\r\n        }\r\n\r\n        .Card_child {\r\n            position: absolute;\r\n            bottom: 13rem;\r\n\r\n        }\r\n        .Button_Child{\r\n            position: absolute;\r\n            top: 0%;\r\n            right: 0%;\r\n\r\n        }\r\n\r\n        .px-4{\r\n            padding-top: 0em 0em 0em 0em;\r\n        }\r\n\r\n        .section {\r\n            margin-right: calc(50% - 50vw);\r\n            margin-left: calc(50% - 50vw);\r\n        }\r\n        .Border_Bottom {\r\n            border-bottom: outset;\r\n            width: 100%\r\n        }\r\n        .Border {\r\n            border: 0.1rem solid;\r\n            border-color: #FFFFFF;\r\n        }\r\n        .R-Border {\r\n            border-right: 0.1rem solid;\r\n\r\n        }\r\n        .B-Border {\r\n            border-bottom: 0.1rem solid;\r\n            border-color: #FFFFFF;\r\n\r\n        }\r\n        .T-Border {\r\n            border-top: 0.1rem solid;\r\n            border-color: #FFFFFF;\r\n\r\n        }\r\n        .ColorB {\r\n            border-bottom-color: #000000;\r\n        }\r\n        .R-ColorW {\r\n            border-right-color: #E0E0E0;\r\n        }\r\n\r\n        .Bg_Sub_Color {\r\n            background-color: #039BE5;\r\n        }\r\n\r\n        .Button_Color {\r\n            background-color: #FFFFFF;\r\n\r\n        }\r\n        .button_Fixed{\r\n            border-radius: 0;\r\n        }\r\n        .button_Cube {\r\n            border-radius: 100%;\r\n        }\r\n        .Text_Color{\r\n            color: #FFFFFF;\r\n        }\r\n        .btn:hover{\r\n            color: #FFFFFF;\r\n\r\n        }\r\n        footer {\r\n            position: fixed;\r\n            bottom: 0;\r\n            width: 85%\r\n        }\r\n        .Button_Padding_Fixed {\r\n            padding: 1rem;\r\n            bottom:2%;\r\n            right:2%;\r\n            position:fixed;\r\n        }\r\n\r\n        .Button_Border_Fixed{\r\n            border-bottom-width: 0px;\r\n        }\r\n        .Button_Block_Fixed{\r\n            width: calc(100% + 0.3vw);\r\n        }\r\n\r\n        .Position_Fixed{\r\n            position : fixed;\r\n        }\r\n\r\n\r\n\r\n        .btn-info{\r\n            color: #000000;\r\n            background-color: #FFFFFF;\r\n            border-color: #FFFFFF;\r\n        }\r\n        .btn-info:hover {\r\n            color: #000000;\r\n            background-color: #CFD8DC;\r\n            border-color: #CFD8DC;\r\n        }\r\n\r\n        .btn-info:not(:disabled):not(.disabled):active, .btn-info:not(:disabled):not(.disabled).active,\r\n        .show > .btn-info.dropdown-toggle {\r\n            color: #FFFFFF;\r\n            background-color: #90A4AE;\r\n            border-color: #90A4AE;\r\n        }\r\n\r\n        .btnW{\r\n            color:#FFFFFF;\r\n        }\r\n\r\n\r\n        .Meihan_Color {\r\n            background-color: #00C853;\r\n        }\r\n        .R-Padding{\r\n            padding-left: 1rem;\r\n        }\r\n\r\n        .fontSizeMAX767_Fixed{\r\n            font-size: 1rem;\r\n        }\r\n        .fontSizeMAX767_Fixed05 {\r\n            font-size: 0.5rem;\r\n        }\r\n        .Card_table_Fixed\r\n        {\r\n            text-align:left;\r\n        }\r\n\r\n        .Scroll_Height_40 {\r\n            height: 100vw;\r\n        }\r\n        .card-body{\r\n            padding:0.25rem;\r\n        }\r\n\r\n        .btn:hover {\r\n            color: #808080;\r\n        }\r\n\r\n    </style>\r\n</head>\r\n\r\n");
            __builder.OpenElement(5, "body");
            __builder.AddAttribute(6, "class", "Bg_Color");
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "Scroll_Control Scroll_Height_40 fontSizeMAX767 ");
            __builder.AddMarkupContent(10, "\r\n\r\n        \r\n");
#nullable restore
#line 255 "C:\Work\B2003C4\B2003C4\Pages\Kansa\SearchActivity.razor"
         foreach (var x in C_SearchingList)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 275 "C:\Work\B2003C4\B2003C4\Pages\Kansa\SearchActivity.razor"
                                s => ValueForModel(x)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "class", "Button_Block_Fixed btn td_padding_Fixed");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "card ");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "card-body");
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "class", "Card_table_Fixed");
            __builder.AddMarkupContent(24, "\r\n                            ");
            __builder.OpenElement(25, "tr");
            __builder.AddAttribute(26, "class", "fontSizeMAX767");
            __builder.AddMarkupContent(27, "\r\n                                ");
            __builder.OpenElement(28, "td");
            __builder.AddAttribute(29, "colspan", "1");
            __builder.AddContent(30, 
#nullable restore
#line 280 "C:\Work\B2003C4\B2003C4\Pages\Kansa\SearchActivity.razor"
                                                 x.DokuKbnName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                                ");
            __builder.OpenElement(32, "td");
            __builder.AddAttribute(33, "colspan", "11");
            __builder.AddContent(34, 
#nullable restore
#line 281 "C:\Work\B2003C4\B2003C4\Pages\Kansa\SearchActivity.razor"
                                                  x.DokuName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "tr");
            __builder.AddAttribute(38, "class", "fontSizeMAX767_Fixed05");
            __builder.AddMarkupContent(39, "\r\n                                ");
            __builder.OpenElement(40, "td");
            __builder.AddAttribute(41, "colspan", "3");
            __builder.AddContent(42, 
#nullable restore
#line 284 "C:\Work\B2003C4\B2003C4\Pages\Kansa\SearchActivity.razor"
                                                 x.KuikiJunroView

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                                ");
            __builder.OpenElement(44, "td");
            __builder.AddAttribute(45, "colspan", "9");
            __builder.AddContent(46, 
#nullable restore
#line 285 "C:\Work\B2003C4\B2003C4\Pages\Kansa\SearchActivity.razor"
                                                 x.ChomeiName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 291 "C:\Work\B2003C4\B2003C4\Pages\Kansa\SearchActivity.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n    ");
            __builder.OpenElement(55, "table");
            __builder.AddAttribute(56, "class", "Card_table_Fixed");
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.OpenElement(58, "tr");
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.OpenElement(60, "td");
            __builder.AddAttribute(61, "align", "right");
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.AddContent(63, 
#nullable restore
#line 302 "C:\Work\B2003C4\B2003C4\Pages\Kansa\SearchActivity.razor"
                 Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(64, " 件\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 309 "C:\Work\B2003C4\B2003C4\Pages\Kansa\SearchActivity.razor"
      
   
    private DummyDataModel DBData = new DummyDataModel();


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
