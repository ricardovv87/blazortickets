#pragma checksum "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\ListaIngenieros.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d6eb28f827633427bbae462c8484c6752511428"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemadeTickets.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\_Imports.razor"
using SistemadeTickets.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\_Imports.razor"
using SistemadeTickets.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\_Imports.razor"
using SistemadeTickets.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\_Imports.razor"
using MudBlazor.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listaingenieros")]
    public partial class ListaIngenieros : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ListaIngenieros</h3>");
#nullable restore
#line 6 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\ListaIngenieros.razor"
 if (ingeniero == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"d-flex align-items-center\"><strong>Cargando...</strong>\r\n  <div class=\"spinner-border ml-auto\" role=\"status\" aria-hidden=\"true\"></div></div>");
#nullable restore
#line 12 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\ListaIngenieros.razor"
}else
{
    

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.OpenElement(3, "Thead");
            __builder.AddMarkupContent(4, "<tr><th>Ingenieros</th></tr>");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 22 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\ListaIngenieros.razor"
             foreach (var item in ingeniero)
           {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
#nullable restore
#line 25 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\ListaIngenieros.razor"
__builder.AddContent(9, item.ingeniero);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\ListaIngenieros.razor"
           }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\ListaIngenieros.razor"



}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\ListaIngenieros.razor"
       
    IEnumerable<Ingeniero> ingeniero;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            ingeniero = await ServicesIngeniero.GetIngenieros();
        }
        catch (Exception e)
        {
            throw e;
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IservicesIngeniero ServicesIngeniero { get; set; }
    }
}
#pragma warning restore 1591