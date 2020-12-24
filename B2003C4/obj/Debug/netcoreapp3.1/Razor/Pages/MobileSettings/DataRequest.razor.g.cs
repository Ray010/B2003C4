#pragma checksum "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e342e5a76cd96c15de54688bd01a5e2f5a6a0bd"
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
#line 4 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"
using Microsoft.AspNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ReceiveDataFragment")]
    public partial class DataRequest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "html");
            __builder.AddMarkupContent(1, @"<head><meta charset=""Shift-JIS"">
    <meta http-equiv=""content-language"" content=""ja"">
    <meta name=""google"" content=""notranslate"">
    <style type=""text/css"">

        table {
            display: table;
            table-layout: fixed;
            text-align: center;
            width: 100%;
        }

        .form-check-inline {
            margin-right: 0rem;
        }

        .table-top-margin{
            margin-top: 3rem;
        }
    </style></head>

");
            __builder.OpenElement(2, "body");
            __builder.AddMarkupContent(3, "<h6>受信するデータを選択して、<p></p>データ受信をタップしてください。</h6>\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddAttribute(6, "style", "width: 100%");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table table-sm");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, @"<tr align=""center""><th colspan=""3"">&nbsp;</th>
                    <th><button type=""button"" class=""Bug btn btn-primary"">入止</button></th>
                    <th><button type=""button"" class=""Bug btn btn-primary"">過去</button></th>
                    <th><button type=""button"" class=""Bug btn btn-primary"">配達</button></th>
                    <th><button type=""button"" class=""Bug btn btn-primary"">監査</button></th></tr>");
#nullable restore
#line 64 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"
                 foreach (var x in TenpoList)
                {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
            __builder.AddAttribute(13, "align", "left");
            __builder.AddAttribute(14, "colspan", "7");
            __builder.AddContent(15, 
#nullable restore
#line 68 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"
                                                      x.TenpoName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 70 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"

                    TenpoNoTemp = x.TenpoNo;

                    foreach (var y in ReceiveTenpoFileList)
                    {

                        if (TenpoNoTemp == y.TenpoNo)
                        {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "tr");
            __builder.AddAttribute(17, "align", "center");
            __builder.OpenElement(18, "td");
            __builder.AddAttribute(19, "align", "right");
            __builder.AddAttribute(20, "class", "Chktext-Base");
            __builder.AddAttribute(21, "colspan", "3");
            __builder.AddContent(22, 
#nullable restore
#line 81 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"
                                                                                    y.KuikiNo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 84 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"
                                 if (true == y.IriTome)
                                {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "<td><input class=\"form-check form-check-inline\" type=\"checkbox\" id=\"check4\" checked></td>");
#nullable restore
#line 88 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"

                                }
                                else
                                {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(24, "<td><input class=\"form-check form-check-inline\" type=\"checkbox\" id=\"check4\" disabled></td>");
#nullable restore
#line 94 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"
                                 if (true == y.Kako)
                                {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "<td><input class=\"form-check form-check-inline\" type=\"checkbox\" id=\"check4\" checked></td>");
#nullable restore
#line 102 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"

                                }
                                else
                                {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(26, "<td><input class=\"form-check form-check-inline\" type=\"checkbox\" id=\"check4\" disabled></td>");
#nullable restore
#line 108 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"
                                 if (true == y.Haitatsu)
                                {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(27, "<td><input class=\"form-check form-check-inline\" type=\"checkbox\" id=\"check4\" checked></td>");
#nullable restore
#line 116 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"

                                }
                                else
                                {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, "<td><input class=\"form-check form-check-inline\" type=\"checkbox\" id=\"check4\" disabled></td>");
#nullable restore
#line 122 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"
                                 if (true == y.Kansa)
                                {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "<td><input class=\"form-check form-check-inline\" type=\"checkbox\" id=\"check4\" checked></td>");
#nullable restore
#line 130 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"

                                }
                                else
                                {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "<td><input class=\"form-check form-check-inline\" type=\"checkbox\" id=\"check4\" disabled></td>");
#nullable restore
#line 136 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"

                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 141 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"

                        }

                    }

                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.AddMarkupContent(32, @"<table class=""table-top-margin""><tr align=""center""><th colspan=""1"">&nbsp;</th>
            <th colspan=""3""><button type=""button"" class=""Bug btn btn-secondary btn-block"">全選択</button></th>
            <th colspan=""1"">&nbsp;</th>
            <th colspan=""3""><button type=""button"" class=""Bug btn btn-secondary btn-block"">全解除</button></th>
            <th colspan=""1"">&nbsp;</th></tr>
        <tr><th colspan=""1"">&nbsp;</th>
            <th colspan=""7""><button type=""button"" class=""Bug btn btn-primary btn-block"">データ受信</button></th>
            <th colspan=""1"">&nbsp;</th></tr></table>




    ");
            __builder.AddMarkupContent(33, @"<h6><svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""Bug bi bi-bug"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M4.355.522a.5.5 0 0 1 .623.333l.291.956A4.979 4.979 0 0 1 8 1c1.007 0 1.946.298 2.731.811l.29-.956a.5.5 0 1 1 .957.29l-.41 1.352A4.985 4.985 0 0 1 13 6h.5a.5.5 0 0 0 .5-.5V5a.5.5 0 0 1 1 0v.5A1.5 1.5 0 0 1 13.5 7H13v1h1.5a.5.5 0 0 1 0 1H13v1h.5a1.5 1.5 0 0 1 1.5 1.5v.5a.5.5 0 1 1-1 0v-.5a.5.5 0 0 0-.5-.5H13a5 5 0 0 1-10 0h-.5a.5.5 0 0 0-.5.5v.5a.5.5 0 1 1-1 0v-.5A1.5 1.5 0 0 1 2.5 10H3V9H1.5a.5.5 0 0 1 0-1H3V7h-.5A1.5 1.5 0 0 1 1 5.5V5a.5.5 0 0 1 1 0v.5a.5.5 0 0 0 .5.5H3c0-1.364.547-2.601 1.432-3.503l-.41-1.352a.5.5 0 0 1 .333-.623zM4 7v4a4 4 0 0 0 3.5 3.97V7H4zm4.5 0v7.97A4 4 0 0 0 12 11V7H8.5zM12 6H4a3.99 3.99 0 0 1 1.333-2.982A3.983 3.983 0 0 1 8 2c1.025 0 1.959.385 2.666 1.018A3.989 3.989 0 0 1 12 6z""></path></svg></h6>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 191 "C:\Work\B2003C4_Blazor\B2003C4\Pages\MobileSettings\DataRequest.razor"
       

    /*とりあえず保留

    private DirectoryInfo di;

    private FileInfo[] dx;

    public string IriDomeDBPath = @"~/";

    string ParamX;

    string CountX;

    public async void callJS()
    {
        string Param = "ninnin";
        await JSRuntime.InvokeVoidAsync("FromBlazorFanc",Param);
        ParamX = await JSRuntime.InvokeAsync<string>("FromBlazorFanc");
        CountX = await JSRuntime.InvokeAsync<string>("SystemStatus");

    }



    private void IncrementCount()
    {

        di = new DirectoryInfo(IriDomeDBPath).Root;
        dx = di.GetFiles();


    }
    */


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
