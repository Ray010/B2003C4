#pragma checksum "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cc2daf2d5cdce802ebf6ebf11862160d79f72df"
// <auto-generated/>
#pragma warning disable 1591
namespace B2003C4.Pages.Common
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
#line 4 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
using B2003C4.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Common/DokusyaActivity")]
    public partial class DokusyaActivity : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!DOCTYPE HTML>\r\n");
            __builder.OpenElement(1, "html");
            __builder.AddAttribute(2, "lang", "ja");
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "head");
            __builder.AddMarkupContent(5, "\r\n    <meta charset=\"Shift-JIS\">\r\n    <meta http-equiv=\"content-language\" content=\"ja\">\r\n    <meta name=\"google\" content=\"notranslate\">\r\n\r\n\r\n    ");
            __builder.OpenElement(6, "style");
            __builder.AddMarkupContent(7, "\r\n        .mb-3 { margin-bottom: 0.5rem; }\r\n\r\n        .BackGr {\r\n            background: #80989b;\r\n            width: 100%;\r\n            height: 100%;\r\n            margin: 0px;\r\n            padding: 0px;\r\n            overflow: hidden;\r\n        }\r\n\r\n        .td_padding_Fixed{\r\n            padding: 0%;\r\n        }\r\n\r\n\r\n\r\n        .Scroll_Control {\r\n            width: 100%;\r\n            overflow-y: scroll;\r\n            overflow-x: hidden;\r\n        }\r\n        .Scroll_Control::-webkit-scrollbar {\r\n            width: 0.3vw;\r\n            height: 5px;\r\n\r\n        }\r\n            .Scroll_Control::-webkit-scrollbar-thumb {\r\n            background: linear-gradient(0deg,#43e2c6,#3183d0);\r\n            border-radius: 3px;\r\n        }\r\n\r\n        .Card_child {\r\n            position: absolute;\r\n            bottom: 13rem;\r\n\r\n        }\r\n        .Button_Child{\r\n            position: absolute;\r\n            top: 0%;\r\n            right: 0%;\r\n\r\n        }\r\n\r\n        .px-4{\r\n            padding-top: 0em 0em 0em 0em;\r\n        }\r\n\r\n        .section {\r\n            margin-right: calc(50% - 50vw);\r\n            margin-left: calc(50% - 50vw);\r\n        }\r\n        .Border_Bottom {\r\n            border-bottom: outset;\r\n\r\n        }\r\n        .Border {\r\n            border: 0.1rem solid;\r\n            border-color: #FFFFFF;\r\n        }\r\n        .R-Border {\r\n            border-right: 0.1rem solid;\r\n\r\n        }\r\n        .B-Border {\r\n            border-bottom: 0.1rem solid;\r\n            border-color: #FFFFFF;\r\n\r\n        }\r\n        .T-Border {\r\n            border-top: 0.1rem solid;\r\n            border-color: #FFFFFF;\r\n\r\n        }\r\n        .ColorB {\r\n            border-bottom-color: #000000;\r\n        }\r\n        .R-ColorW {\r\n            border-right-color: #E0E0E0;\r\n        }\r\n\r\n        .Bg_Sub_Color {\r\n            background-color: #039BE5;\r\n        }\r\n\r\n        .Button_Color {\r\n            background-color: ");
            __builder.AddContent(8, 
#nullable restore
#line 128 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                               ButtonColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, ";\r\n\r\n        }\r\n        .button_Fixed{\r\n            border-radius: 0;\r\n        }\r\n        .button_Cube {\r\n            border-radius: 100%;\r\n        }\r\n        .Text_Color{\r\n            color: #FFFFFF;\r\n        }\r\n        .btn:hover{\r\n            color: #FFFFFF;\r\n\r\n        }\r\n        footer {\r\n            position: fixed;\r\n            bottom: 0;\r\n            width: 85%\r\n        }\r\n        .Button_Padding_Fixed {\r\n            padding: 1rem;\r\n            bottom:2vh;\r\n            left:75vw;\r\n            position:fixed;\r\n        }\r\n\r\n        .Button_Border_Fixed{\r\n            border-bottom-width: 0px;\r\n        }\r\n        .Button_Block_Fixed{\r\n            width: calc(100% + 0.3vw);\r\n        }\r\n\r\n        .Position_Fixed{\r\n            position : fixed;\r\n        }\r\n\r\n\r\n\r\n        .btn-info{\r\n            color: #000000;\r\n            background-color: #FFFFFF;\r\n            border-color: #FFFFFF;\r\n        }\r\n        .btn-info:hover {\r\n            color: #000000;\r\n            background-color: #CFD8DC;\r\n            border-color: #CFD8DC;\r\n        }\r\n\r\n        .btn-info:not(:disabled):not(.disabled):active, .btn-info:not(:disabled):not(.disabled).active,\r\n        .show > .btn-info.dropdown-toggle {\r\n            color: #FFFFFF;\r\n            background-color: #90A4AE;\r\n            border-color: #90A4AE;\r\n        }\r\n\r\n        .btnW{\r\n            color:#FFFFFF;\r\n        }\r\n\r\n\r\n        .Meihan_Color {\r\n            background-color: #00C853;\r\n        }\r\n        .R-Padding{\r\n            padding-left: 1rem;\r\n        }\r\n\r\n        .fontSizeMAX767_Fixed{\r\n            font-size: 1rem;\r\n        }\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenElement(12, "body");
            __builder.AddAttribute(13, "style", "overflow:hidden");
            __builder.AddMarkupContent(14, "\r\n    \r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "Card_parent");
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "Scroll_Control Scroll_Height_20 fontSizeMAX767 ");
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "table");
            __builder.AddAttribute(22, "class", "Card_table_Fixed  fontSizeMAX767_Fixed");
            __builder.AddMarkupContent(23, "\r\n\r\n\r\n");
#nullable restore
#line 216 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                 foreach (var x in KoumokuList)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "                    ");
            __builder.OpenElement(25, "tr");
            __builder.AddAttribute(26, "class", "Card_VerticalFix");
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "td");
            __builder.AddAttribute(29, "class", "td_padding_Fixed Border_Bottom R-Border R-ColorW");
            __builder.AddAttribute(30, "colspan", "4");
            __builder.AddContent(31, 
#nullable restore
#line 219 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                                                                                                  x.Heading

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.OpenElement(33, "td");
            __builder.AddAttribute(34, "class", "td_padding_Fixed Border_Bottom");
            __builder.AddAttribute(35, "colspan", "9");
            __builder.AddContent(36, 
#nullable restore
#line 220 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                                                                                x.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 222 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "fontSizeMAX767 Text_Color");
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "table");
            __builder.AddAttribute(46, "class", "Card_table_Fixed Border Bg_Sub_Color");
            __builder.AddMarkupContent(47, "\r\n\r\n                ");
            __builder.OpenElement(48, "tr");
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.AddMarkupContent(50, "<td colspan=\"3\" class=\"R-Border \">銘版</td>\r\n                    ");
            __builder.AddMarkupContent(51, "<td colspan=\"6\" class=\"R-Border \">契約期間</td>\r\n                    ");
            __builder.OpenElement(52, "td");
            __builder.AddAttribute(53, "colspan", "5");
            __builder.AddAttribute(54, "class", "td_padding_Fixed");
            __builder.AddMarkupContent(55, "\r\n                        ");
            __builder.OpenElement(56, "table");
            __builder.AddAttribute(57, "class", "Card_TableMargin0 Card_table_Fixed Bg_Sub_Color");
            __builder.AddMarkupContent(58, "\r\n                            ");
            __builder.AddMarkupContent(59, @"<tr align=""center"">
                                <td colspan=""5"" class=""R-Border"">契約者</td>
                                <td colspan=""2"" class=""R-Border"">月数</td>
                                <td colspan=""1"">配</td>
                            </tr>

                            ");
            __builder.OpenElement(60, "tr");
            __builder.AddAttribute(61, "class", "T-Border");
            __builder.AddMarkupContent(62, "\r\n                                ");
            __builder.OpenElement(63, "td");
            __builder.AddAttribute(64, "colspan", "8");
            __builder.AddAttribute(65, "class", "Button_Color");
            __builder.AddMarkupContent(66, "\r\n                                    ");
            __builder.OpenElement(67, "button");
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 247 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                                                      ButtonChange

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "class", "Text_Color Button_Color btn button_Fixed Card_TablePadding0");
            __builder.AddMarkupContent(70, "\r\n                                        ");
            __builder.OpenElement(71, "table");
            __builder.AddAttribute(72, "class", "Card_table_Fixed");
            __builder.AddMarkupContent(73, "\r\n                                            ");
            __builder.OpenElement(74, "tr");
            __builder.AddMarkupContent(75, "\r\n                                                ");
            __builder.OpenElement(76, "td");
            __builder.AddAttribute(77, "colspan", "3");
            __builder.AddAttribute(78, "class", "R-Border fontSizeMAX767");
            __builder.AddMarkupContent(79, "\r\n                                                    ");
            __builder.AddContent(80, 
#nullable restore
#line 251 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                                                     Riyu

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(81, "\r\n\r\n                                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                                                ");
            __builder.OpenElement(83, "td");
            __builder.AddAttribute(84, "colspan", "5 ");
            __builder.AddAttribute(85, "class", "fontSizeMAX767");
            __builder.AddMarkupContent(86, "\r\n                                                    ");
            __builder.AddContent(87, 
#nullable restore
#line 255 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                                                     Keiyaku

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(88, "\r\n\r\n                                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n\r\n            ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "Scroll_Control Scroll_Height_40");
            __builder.AddMarkupContent(101, "\r\n\r\n\r\n");
#nullable restore
#line 273 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                     foreach (var x in S_KoudokuList)
                    {


#line default
#line hidden
#nullable disable
            __builder.AddContent(102, "                        ");
            __builder.OpenElement(103, "button");
            __builder.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 276 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                                            s => JumpPage("./IriTome/MeihanActivity")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(105, "class", "fontSizeMAX767 btn btn-info Button_Block_Fixed Button_Border_Fixed button_Fixed td_padding_Fixed");
            __builder.AddMarkupContent(106, "\r\n                            ");
            __builder.OpenElement(107, "table");
            __builder.AddAttribute(108, "class", "Card_table_Fixed Border_Bottom");
            __builder.AddMarkupContent(109, "\r\n                                \r\n                                ");
            __builder.OpenElement(110, "tr");
            __builder.AddMarkupContent(111, "\r\n                                    ");
            __builder.OpenElement(112, "td");
            __builder.AddAttribute(113, "colspan", "3");
            __builder.AddAttribute(114, "class", "btnW Meihan_Color");
            __builder.AddContent(115, 
#nullable restore
#line 280 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                                                                               x.MgName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                                    ");
            __builder.OpenElement(117, "td");
            __builder.AddAttribute(118, "colspan", "6");
            __builder.AddContent(119, 
#nullable restore
#line 281 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                                                      x.KeiyakuSt

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(120, " - ");
            __builder.AddContent(121, 
#nullable restore
#line 281 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                                                                     x.KeiyakuEd

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(122, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                                    ");
            __builder.OpenElement(124, "td");
            __builder.AddAttribute(125, "colspan", "5");
            __builder.AddMarkupContent(126, "\r\n                                        ");
            __builder.OpenElement(127, "table");
            __builder.AddAttribute(128, "class", "Card_TableMargin0 Card_table_Fixed");
            __builder.AddMarkupContent(129, "\r\n                                            ");
            __builder.OpenElement(130, "tr");
            __builder.AddAttribute(131, "align", "center");
            __builder.AddMarkupContent(132, "\r\n                                                ");
            __builder.OpenElement(133, "td");
            __builder.AddAttribute(134, "colspan", "5");
            __builder.AddContent(135, 
#nullable restore
#line 285 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                                                                  x.Keiyakusya

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                                                ");
            __builder.OpenElement(137, "td");
            __builder.AddAttribute(138, "colspan", "2");
            __builder.AddContent(139, 
#nullable restore
#line 286 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                                                                  x.Tukisu

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n                                                ");
            __builder.OpenElement(141, "td");
            __builder.AddAttribute(142, "colspan", "1");
            __builder.AddContent(143, 
#nullable restore
#line 287 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                                                                 x.DispHaitatubi

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n\r\n                                            ");
            __builder.OpenElement(146, "tr");
            __builder.AddMarkupContent(147, "\r\n                                                ");
            __builder.OpenElement(148, "td");
            __builder.AddAttribute(149, "colspan", "3");
            __builder.AddMarkupContent(150, "\r\n");
#nullable restore
#line 292 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                                                     if(ButtonColor == "#01579B")
                                                    {
                                                        

#line default
#line hidden
#nullable disable
            __builder.AddContent(151, 
#nullable restore
#line 294 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                                                         x.IriRiyuu

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 294 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                                                                   
                                                    }
                                                    else
                                                    {
                                                        

#line default
#line hidden
#nullable disable
            __builder.AddContent(152, 
#nullable restore
#line 298 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                                                         x.TomeRiyuu

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 298 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                                                                    
                                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(153, "                                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n                                                ");
            __builder.OpenElement(155, "td");
            __builder.AddAttribute(156, "colspan", "5");
            __builder.AddMarkupContent(157, "\r\n");
#nullable restore
#line 302 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                                                     if (ButtonColor == "#01579B")
                                                    {
                                                        

#line default
#line hidden
#nullable disable
            __builder.AddContent(158, 
#nullable restore
#line 304 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                                                         x.KeiyakuDay

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 304 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                                                                     
                                                    }
                                                    else
                                                    {
                                                        

#line default
#line hidden
#nullable disable
            __builder.AddContent(159, 
#nullable restore
#line 308 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                                                         x.TomeDay

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 308 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                                                                  
                                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(160, "                                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(167, "\r\n");
#nullable restore
#line 318 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(168, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\r\n\r\n\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n   \r\n    ");
            __builder.OpenElement(172, "button");
            __builder.AddAttribute(173, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 327 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
                        s => GoToGoogleMap("MAP")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(174, "class", "btn btn-warning button_Cube Text_Color Button_Padding_Fixed");
            __builder.AddMarkupContent(175, "\r\n        ");
            __builder.AddMarkupContent(176, @"<svg width=""2em"" height=""2em"" viewBox=""0 0 16 16"" class=""bi bi-map"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
            <path fill-rule=""evenodd"" d=""M15.817.113A.5.5 0 0 1 16 .5v14a.5.5 0 0 1-.402.49l-5 1a.502.502 0 0 1-.196 0L5.5 15.01l-4.902.98A.5.5 0 0 1 0 15.5v-14a.5.5 0 0 1 .402-.49l5-1a.5.5 0 0 1 .196 0L10.5.99l4.902-.98a.5.5 0 0 1 .415.103zM10 1.91l-4-.8v12.98l4 .8V1.91zm1 12.98l4-.8V1.11l-4 .8v12.98zm-6-.8V1.11l-4 .8v12.98l4-.8z""></path>
        </svg>
    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(177, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 336 "C:\Work\B2003C4\B2003C4\Pages\Common\DokusyaActivity.razor"
       
    private DummyDataModel DBData = new DummyDataModel();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
