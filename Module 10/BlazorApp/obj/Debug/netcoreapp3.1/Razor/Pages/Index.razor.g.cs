#pragma checksum "/Users/pratikpatel/Desktop/CS504/hop10-blazordeployment-PratikPatel3900/Module 10/BlazorApp/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e8d85e4c0b42e45d19b0e2f09fdf1c75e7bd0e1"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/pratikpatel/Desktop/CS504/hop10-blazordeployment-PratikPatel3900/Module 10/BlazorApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/pratikpatel/Desktop/CS504/hop10-blazordeployment-PratikPatel3900/Module 10/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/pratikpatel/Desktop/CS504/hop10-blazordeployment-PratikPatel3900/Module 10/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/pratikpatel/Desktop/CS504/hop10-blazordeployment-PratikPatel3900/Module 10/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/pratikpatel/Desktop/CS504/hop10-blazordeployment-PratikPatel3900/Module 10/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/pratikpatel/Desktop/CS504/hop10-blazordeployment-PratikPatel3900/Module 10/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/pratikpatel/Desktop/CS504/hop10-blazordeployment-PratikPatel3900/Module 10/BlazorApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/pratikpatel/Desktop/CS504/hop10-blazordeployment-PratikPatel3900/Module 10/BlazorApp/_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/pratikpatel/Desktop/CS504/hop10-blazordeployment-PratikPatel3900/Module 10/BlazorApp/_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<BlazorApp.Pages.Counter>(1);
            __builder.AddAttribute(2, "IncrementAmount", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "/Users/pratikpatel/Desktop/CS504/hop10-blazordeployment-PratikPatel3900/Module 10/BlazorApp/Pages/Index.razor"
                          -10

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "p");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "/Users/pratikpatel/Desktop/CS504/hop10-blazordeployment-PratikPatel3900/Module 10/BlazorApp/Pages/Index.razor"
                  onHitValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => onHitValue = __value, onHitValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(8, " On Keyboard Hit Value: ");
            __builder.AddContent(9, 
#nullable restore
#line 10 "/Users/pratikpatel/Desktop/CS504/hop10-blazordeployment-PratikPatel3900/Module 10/BlazorApp/Pages/Index.razor"
                                                         onHitValue

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n\r\n");
            __builder.OpenElement(11, "p");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "/Users/pratikpatel/Desktop/CS504/hop10-blazordeployment-PratikPatel3900/Module 10/BlazorApp/Pages/Index.razor"
                  CurrentValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CurrentValue = __value, CurrentValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(15, " Real Time Value: ");
            __builder.AddContent(16, 
#nullable restore
#line 15 "/Users/pratikpatel/Desktop/CS504/hop10-blazordeployment-PratikPatel3900/Module 10/BlazorApp/Pages/Index.razor"
                                                                          CurrentValue

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "/Users/pratikpatel/Desktop/CS504/hop10-blazordeployment-PratikPatel3900/Module 10/BlazorApp/Pages/Index.razor"
       

   
    private string CurrentValue { get; set;}

    private string onHitValue { get; set;}
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
