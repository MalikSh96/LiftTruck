#pragma checksum "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd9eb5699590079bcefa387bc33b428c99de0281"
// <auto-generated/>
#pragma warning disable 1591
namespace LiftTruck.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\_Imports.razor"
using LiftTruck.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\_Imports.razor"
using LiftTruck.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page" + " " + (
#nullable restore
#line 5 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Shared\MainLayout.razor"
                  GetCssClass()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "b-gdjpbe2ncw");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-gdjpbe2ncw");
            __builder.OpenComponent<LiftTruck.Client.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-gdjpbe2ncw");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4");
            __builder.AddAttribute(13, "b-gdjpbe2ncw");
            __builder.AddMarkupContent(14, "\r\n            Theme\r\n            ");
            __builder.OpenElement(15, "select");
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Shared\MainLayout.razor"
                               ChangingTheme

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "style", "margin-left: 1rem");
            __builder.AddAttribute(18, "b-gdjpbe2ncw");
#nullable restore
#line 15 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Shared\MainLayout.razor"
                 foreach (var theme in Themes)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "option");
            __builder.AddAttribute(20, "selected", 
#nullable restore
#line 17 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Shared\MainLayout.razor"
                                       IsSelectedTheme(theme)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "value", 
#nullable restore
#line 17 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Shared\MainLayout.razor"
                                                                       theme

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "b-gdjpbe2ncw");
            __builder.AddContent(23, 
#nullable restore
#line 17 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Shared\MainLayout.razor"
                                                                               theme

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Shared\MainLayout.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            \r\n            ");
            __builder.AddMarkupContent(25, "<a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-gdjpbe2ncw>About</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "content px-4");
            __builder.AddAttribute(29, "b-gdjpbe2ncw");
            __builder.AddContent(30, 
#nullable restore
#line 25 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Shared\MainLayout.razor"
       
    private string SelectedTheme { get; set; } = "Light";
    private List<string> Themes = new List<string> { "Light", "Dark" };
    private readonly string KeyTheme = "theme";

    //getting the theme from previous website visit by client
    protected override async Task OnInitializedAsync()
    {
        var themeFromLocalStorage = await js.InvokeAsync<string>("readLocalStorage", KeyTheme);
        if(!string.IsNullOrEmpty(themeFromLocalStorage))
            SelectedTheme = themeFromLocalStorage;
    }

    private string GetCssClass()
    {
        if (SelectedTheme == "Light")
            return String.Empty;
        else
            return "dark-mode";
    }

    private bool IsSelectedTheme(string theme)
    {
        return theme == SelectedTheme;
    }

    //using async programming, so we use the keyword async
    private async Task ChangingTheme(ChangeEventArgs e)
    {
        SelectedTheme = e.Value.ToString();
        await js.InvokeVoidAsync("addToLocalStorage", KeyTheme, SelectedTheme);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
