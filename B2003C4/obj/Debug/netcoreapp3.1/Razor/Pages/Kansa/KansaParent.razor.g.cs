#pragma checksum "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02d10e2b88d5ddbcc54837d3aa16626fd242d11a"
// <auto-generated/>
#pragma warning disable 1591
namespace B2003C4.Pages.Kansa
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
#line 4 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
using B2003C4.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
using B2003C4.Pages.Common;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Kansa/KansaParent")]
    public partial class KansaParent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 31 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
 switch (CurrentPage.PhaseNo)
{
    case 0:
        goto default;

    case 1:

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
         if (P_DokusyaList.Count != 0 && P_KuikiList.Count != 0)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "            ");
            __builder.OpenComponent<B2003C4.Pages.Kansa.KansaSearchFragment>(1);
            __builder.AddAttribute(2, "Phase1Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<B2003C4.Data.FormSearchDataModel>(
#nullable restore
#line 40 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
                                                   CurrentPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Phase1DataChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<B2003C4.Data.FormSearchDataModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<B2003C4.Data.FormSearchDataModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrentPage = __value, CurrentPage))));
            __builder.AddAttribute(4, "DBSourceData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<B2003C4.Data.DummyDataModel>(
#nullable restore
#line 40 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
                                                                                    DBData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "DBSourceDataChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<B2003C4.Data.DummyDataModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<B2003C4.Data.DummyDataModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DBData = __value, DBData))));
            __builder.AddAttribute(6, "C_KuikiList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<B2003C4.Data.Kuiki_K95080>>(
#nullable restore
#line 40 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
                                                                                                               P_KuikiList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "C_KuikiListChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.List<B2003C4.Data.Kuiki_K95080>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.List<B2003C4.Data.Kuiki_K95080>>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => P_KuikiList = __value, P_KuikiList))));
            __builder.AddAttribute(8, "C_DokusyaList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<B2003C4.Data.Dokusya_K95080>>(
#nullable restore
#line 40 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
                                                                                                                                                 P_DokusyaList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "C_DokusyaListChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.List<B2003C4.Data.Dokusya_K95080>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.List<B2003C4.Data.Dokusya_K95080>>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => P_DokusyaList = __value, P_DokusyaList))));
            __builder.AddAttribute(10, "C_SearchingList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<B2003C4.Data.Dokusya_K95080>>(
#nullable restore
#line 40 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
                                                                                                                                                                                       P_SearchingList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "C_SearchingListChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.List<B2003C4.Data.Dokusya_K95080>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.List<B2003C4.Data.Dokusya_K95080>>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => P_SearchingList = __value, P_SearchingList))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 41 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
        }
        else
        {

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
         





        goto End;

    case 2:

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "        ");
            __builder.OpenComponent<B2003C4.Pages.Kansa.SearchActivity>(14);
            __builder.AddAttribute(15, "Phase2Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<B2003C4.Data.FormSearchDataModel>(
#nullable restore
#line 54 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
                                          CurrentPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "Phase2DataChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<B2003C4.Data.FormSearchDataModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<B2003C4.Data.FormSearchDataModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrentPage = __value, CurrentPage))));
            __builder.AddAttribute(17, "DBSourceData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<B2003C4.Data.DummyDataModel>(
#nullable restore
#line 54 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
                                                                           DBData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "DBSourceDataChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<B2003C4.Data.DummyDataModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<B2003C4.Data.DummyDataModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DBData = __value, DBData))));
            __builder.AddAttribute(19, "C_SearchingList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<B2003C4.Data.Dokusya_K95080>>(
#nullable restore
#line 54 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
                                                                                                          P_SearchingList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "C_SearchingListChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.List<B2003C4.Data.Dokusya_K95080>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.List<B2003C4.Data.Dokusya_K95080>>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => P_SearchingList = __value, P_SearchingList))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 55 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
        goto End;

    case 11:

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "        ");
            __builder.OpenComponent<B2003C4.Pages.Common.DokusyaActivity>(23);
            __builder.AddAttribute(24, "CommonPhase1", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<B2003C4.Data.FormSearchDataModel>(
#nullable restore
#line 58 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
                                             CurrentPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "CommonPhase1Changed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<B2003C4.Data.FormSearchDataModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<B2003C4.Data.FormSearchDataModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrentPage = __value, CurrentPage))));
            __builder.AddAttribute(26, "DBSourceData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<B2003C4.Data.DummyDataModel>(
#nullable restore
#line 58 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
                                                                              DBData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "DBSourceDataChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<B2003C4.Data.DummyDataModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<B2003C4.Data.DummyDataModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DBData = __value, DBData))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 59 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
        //@bind-KoudokuList="KoudokuDBData"/>
        goto End;

    case 12:

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "        ");
            __builder.OpenComponent<B2003C4.Pages.Common.MeihanActivity>(30);
            __builder.AddAttribute(31, "CommonPhase2", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<B2003C4.Data.FormSearchDataModel>(
#nullable restore
#line 63 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
                                            CurrentPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "CommonPhase2Changed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<B2003C4.Data.FormSearchDataModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<B2003C4.Data.FormSearchDataModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrentPage = __value, CurrentPage))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 64 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"

        End:
            break;


        default:


#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "            ");
            __builder.OpenElement(35, "div");
            __builder.AddMarkupContent(36, "ハンドリングエラー:存在しないページ（PhaseNo:");
            __builder.AddContent(37, 
#nullable restore
#line 71 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
                                             CurrentPage.S_PhoneNo

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(38, " )");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 72 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
            break;

    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(40, "\r\n");
            __builder.AddContent(41, 
#nullable restore
#line 76 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
 P_SearchingList.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(42, "\r\n");
            __builder.AddContent(43, 
#nullable restore
#line 77 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
 P_DokusyaList.Count

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "C:\Work\B2003C4\B2003C4\Pages\Kansa\KansaParent.razor"
       

    private DummyDataModel DBData = new DummyDataModel();
    //private KoudokuDummyData KoudokuDBData = new KoudokuDummyData();
    private FormSearchDataModel ResultData = new FormSearchDataModel();
    private List<Dokusya_K95080> P_SearchingList = new List<Dokusya_K95080>();

    private List<Dokusya_K95080> P_DokusyaList = new List<Dokusya_K95080>();
    private List<Koudoku_K95080> P_KoudokuList = new List<Koudoku_K95080>();
    private List<Kuiki_K95080> P_KuikiList = new List<Kuiki_K95080>();
    private List<Nengetu_K95080> P_NengetuList = new List<Nengetu_K95080>();
    private List<Kakuzai_K95080> P_KakuzaiList = new List<Kakuzai_K95080>();


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
