#pragma checksum "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Info.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc6eee4f6766f9ea0cbf4e4cb706f21fe3099a1c"
// <auto-generated/>
#pragma warning disable 1591
namespace LiftTruck.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/information")]
    public partial class Info : InfoBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Information</h1>\r\n");
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, "Name: ");
            __builder.AddContent(3, 
#nullable restore
#line 4 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Info.razor"
            GetName()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "h3");
            __builder.AddContent(6, "Phone: ");
            __builder.AddContent(7, 
#nullable restore
#line 5 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Info.razor"
            GetNumber()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
