#pragma checksum "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54c4818f0bb0ba5b6aecb32e30f1db51a00ff3ec"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/services")]
    public partial class Services : ServiceBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Vi tilbyder følgende ydelser</h1>\r\n    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "standard");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "LessThan2T");
            __builder.AddMarkupContent(5, "<h3>Køretøjer der vejer mindre end 2ton (2000kg)</h3>");
#nullable restore
#line 8 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
              
                string Transport = "Transport distance mellem 0 - 19 km";
                string Price = "600kr, -ekskl. moms";
            

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "h5");
            __builder.AddMarkupContent(7, "\r\n                Service ydelse: ");
            __builder.AddContent(8, 
#nullable restore
#line 13 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
                                 SetServiceType(Transport)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, " <br>\r\n                Pris: ");
            __builder.AddContent(10, 
#nullable restore
#line 14 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
                       SetPrice(Price)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            <br>");
#nullable restore
#line 17 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
              
                Transport = "Transport distance mellem 20 - 49 km";
                Price = "800kr, -ekskl. moms";
            

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "h5");
            __builder.AddMarkupContent(13, "\r\n                Service ydelse: ");
            __builder.AddContent(14, 
#nullable restore
#line 22 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
                                 SetServiceType(Transport)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, " <br>\r\n                Pris: ");
            __builder.AddContent(16, 
#nullable restore
#line 23 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
                       SetPrice(Price)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            <br>");
#nullable restore
#line 26 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
              
                Transport = "Transport distance mellem 50 - 89 km";
                Price = "1200kr, -ekskl. moms";
            

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "h5");
            __builder.AddMarkupContent(19, "\r\n                Service ydelse: ");
            __builder.AddContent(20, 
#nullable restore
#line 31 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
                                 SetServiceType(Transport)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(21, " <br>\r\n                Pris: ");
            __builder.AddContent(22, 
#nullable restore
#line 32 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
                       SetPrice(Price)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            <br>");
#nullable restore
#line 35 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
              
                Transport = "Transport distance mellem 90 - 150 km";
                Price = "1700kr, -ekskl. moms";
            

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "h5");
            __builder.AddMarkupContent(25, "\r\n                Service ydelse: ");
            __builder.AddContent(26, 
#nullable restore
#line 40 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
                                 SetServiceType(Transport)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(27, " <br>\r\n                Pris: ");
            __builder.AddContent(28, 
#nullable restore
#line 41 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
                       SetPrice(Price)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n        <br>\r\n        <br>\r\n\r\n        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "HigherThan2T");
            __builder.AddMarkupContent(32, "<h3>Køretøjer der vejer over 2ton (2000kg)</h3>");
#nullable restore
#line 50 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
              
                Transport = "Transport distance mellem 0 - 19 km";
                Price = "700kr, -ekskl. moms";
            

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "h5");
            __builder.AddMarkupContent(34, "\r\n                Service ydelse: ");
            __builder.AddContent(35, 
#nullable restore
#line 55 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
                                 SetServiceType(Transport)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(36, " <br>\r\n                Pris: ");
            __builder.AddContent(37, 
#nullable restore
#line 56 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
                       SetPrice(Price)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            <br>");
#nullable restore
#line 59 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
              
                Transport = "Transport distance mellem 20 - 49 km";
                Price = "900kr, -ekskl. moms";
            

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "h5");
            __builder.AddMarkupContent(40, "\r\n                Service ydelse: ");
            __builder.AddContent(41, 
#nullable restore
#line 64 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
                                 SetServiceType(Transport)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(42, " <br>\r\n                Pris: ");
            __builder.AddContent(43, 
#nullable restore
#line 65 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
                       SetPrice(Price)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            <br>");
#nullable restore
#line 68 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
              
                Transport = "Transport distance mellem 50 - 89 km";
                Price = "1400kr, -ekskl. moms";
            

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "h5");
            __builder.AddMarkupContent(46, "\r\n                Service ydelse: ");
            __builder.AddContent(47, 
#nullable restore
#line 73 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
                                 SetServiceType(Transport)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(48, " <br>\r\n                Pris: ");
            __builder.AddContent(49, 
#nullable restore
#line 74 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
                       SetPrice(Price)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            <br>");
#nullable restore
#line 77 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
              
                Transport = "Transport distance mellem 90 - 150 km";
                Price = "2000kr, -ekskl. moms";
            

#line default
#line hidden
#nullable disable
            __builder.OpenElement(51, "h5");
            __builder.AddMarkupContent(52, "\r\n                Service ydelse: ");
            __builder.AddContent(53, 
#nullable restore
#line 82 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
                                 SetServiceType(Transport)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(54, " <br>\r\n                Pris: ");
            __builder.AddContent(55, 
#nullable restore
#line 83 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
                       SetPrice(Price)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        <br>\r\n        ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "AddOns");
#nullable restore
#line 88 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
              
                string addOn = "20% ekstra -ekskl. moms";
            

#line default
#line hidden
#nullable disable
            __builder.OpenElement(59, "h3");
            __builder.OpenElement(60, "i");
            __builder.AddMarkupContent(61, "\r\n                    Der er aften-/nattillæg på ");
            __builder.AddContent(62, 
#nullable restore
#line 93 "C:\Users\malik\OneDrive\Documents\Projects\LiftTruckProject\LiftTruck\LiftTruck\Client\Pages\Services.razor"
                                                SetAddOn(addOn)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
