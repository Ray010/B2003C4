#pragma checksum "C:\Work\B2003C4_Blazor\B2003C4\Pages\Kansa\KansaParent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d565f4e7f19b62f876a46e00576b6415e227b9da"
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
#line 4 "C:\Work\B2003C4_Blazor\B2003C4\Pages\Kansa\KansaParent.razor"
using B2003C4.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Work\B2003C4_Blazor\B2003C4\Pages\Kansa\KansaParent.razor"
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
#line 27 "C:\Work\B2003C4_Blazor\B2003C4\Pages\Kansa\KansaParent.razor"
 switch (CurrentPage.PhaseNo)
{
    case 0:
        goto default;
        
    case 1:

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<B2003C4.Pages.Kansa.KansaSearchFragment>(0);
            __builder.AddAttribute(1, "Phase1Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<B2003C4.Data.FormSearchDataModel>(
#nullable restore
#line 33 "C:\Work\B2003C4_Blazor\B2003C4\Pages\Kansa\KansaParent.razor"
                                               CurrentPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Phase1DataChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<B2003C4.Data.FormSearchDataModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<B2003C4.Data.FormSearchDataModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrentPage = __value, CurrentPage))));
            __builder.AddAttribute(3, "DBSourceData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<B2003C4.Data.DummyDataModel>(
#nullable restore
#line 33 "C:\Work\B2003C4_Blazor\B2003C4\Pages\Kansa\KansaParent.razor"
                                                                                DBData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "DBSourceDataChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<B2003C4.Data.DummyDataModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<B2003C4.Data.DummyDataModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DBData = __value, DBData))));
            __builder.CloseComponent();
#nullable restore
#line 34 "C:\Work\B2003C4_Blazor\B2003C4\Pages\Kansa\KansaParent.razor"
        goto End;

    case 2:

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<B2003C4.Pages.Kansa.SearchActivity>(5);
            __builder.AddAttribute(6, "Phase2Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<B2003C4.Data.FormSearchDataModel>(
#nullable restore
#line 37 "C:\Work\B2003C4_Blazor\B2003C4\Pages\Kansa\KansaParent.razor"
                                          CurrentPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Phase2DataChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<B2003C4.Data.FormSearchDataModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<B2003C4.Data.FormSearchDataModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrentPage = __value, CurrentPage))));
            __builder.AddAttribute(8, "DBSourceData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<B2003C4.Data.DummyDataModel>(
#nullable restore
#line 37 "C:\Work\B2003C4_Blazor\B2003C4\Pages\Kansa\KansaParent.razor"
                                                                           DBData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "DBSourceDataChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<B2003C4.Data.DummyDataModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<B2003C4.Data.DummyDataModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DBData = __value, DBData))));
            __builder.CloseComponent();
#nullable restore
#line 38 "C:\Work\B2003C4_Blazor\B2003C4\Pages\Kansa\KansaParent.razor"
        goto End;

    case 11:

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<B2003C4.Pages.Common.DokusyaActivity>(10);
            __builder.AddAttribute(11, "CommonPhase1", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<B2003C4.Data.FormSearchDataModel>(
#nullable restore
#line 41 "C:\Work\B2003C4_Blazor\B2003C4\Pages\Kansa\KansaParent.razor"
                                             CurrentPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "CommonPhase1Changed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<B2003C4.Data.FormSearchDataModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<B2003C4.Data.FormSearchDataModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrentPage = __value, CurrentPage))));
            __builder.AddAttribute(13, "DBSourceData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<B2003C4.Data.DummyDataModel>(
#nullable restore
#line 41 "C:\Work\B2003C4_Blazor\B2003C4\Pages\Kansa\KansaParent.razor"
                                                                              DBData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "DBSourceDataChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<B2003C4.Data.DummyDataModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<B2003C4.Data.DummyDataModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DBData = __value, DBData))));
            __builder.AddAttribute(15, "KoudokuList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<B2003C4.Data.KoudokuDummyData>(
#nullable restore
#line 41 "C:\Work\B2003C4_Blazor\B2003C4\Pages\Kansa\KansaParent.razor"
                                                                                                         KoudokuDBData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "KoudokuListChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<B2003C4.Data.KoudokuDummyData>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<B2003C4.Data.KoudokuDummyData>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => KoudokuDBData = __value, KoudokuDBData))));
            __builder.CloseComponent();
#nullable restore
#line 42 "C:\Work\B2003C4_Blazor\B2003C4\Pages\Kansa\KansaParent.razor"
        goto End;

    case 12:

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<B2003C4.Pages.Common.MeihanActivity>(17);
            __builder.AddAttribute(18, "CommonPhase2", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<B2003C4.Data.FormSearchDataModel>(
#nullable restore
#line 45 "C:\Work\B2003C4_Blazor\B2003C4\Pages\Kansa\KansaParent.razor"
                                            CurrentPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "CommonPhase2Changed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<B2003C4.Data.FormSearchDataModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<B2003C4.Data.FormSearchDataModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrentPage = __value, CurrentPage))));
            __builder.CloseComponent();
#nullable restore
#line 46 "C:\Work\B2003C4_Blazor\B2003C4\Pages\Kansa\KansaParent.razor"

    End:
        break;


    default:


#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "div");
            __builder.AddMarkupContent(21, "ハンドリングエラー:存在しないページ（PhaseNo:");
            __builder.AddContent(22, 
#nullable restore
#line 53 "C:\Work\B2003C4_Blazor\B2003C4\Pages\Kansa\KansaParent.razor"
                                         CurrentPage.S_PhoneNo

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, " )");
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Work\B2003C4_Blazor\B2003C4\Pages\Kansa\KansaParent.razor"
        break;

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Work\B2003C4_Blazor\B2003C4\Pages\Kansa\KansaParent.razor"
       

    private DummyDataModel DBData = new DummyDataModel();
    private KoudokuDummyData KoudokuDBData = new KoudokuDummyData();
    private FormSearchDataModel ResultData = new FormSearchDataModel();

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
