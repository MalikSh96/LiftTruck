// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Shared\MainLayout.razor"
       
    private string SelectedTheme { get; set; } = "Light";
    private List<string> Themes = new List<string> { "Light", "Dark" };

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

    private void ChangingTheme(ChangeEventArgs e)
    {
        SelectedTheme = e.Value.ToString();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
