#pragma checksum "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TableroIngeniero.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ebd291f2068b89b18477fc2f4187e879b1c2b17"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/tableroingenieros")]
    public partial class TableroIngeniero : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TableroIngeniero.razor"
__builder.AddContent(0, Message);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "\r\n");
            __builder.AddMarkupContent(2, "<h3>Tablero de Tickets</h3>");
#nullable restore
#line 8 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TableroIngeniero.razor"
 if (ticket == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<div class=\"d-flex align-items-center\"><strong>Cargando...</strong>\r\n        <div class=\"spinner-border ml-auto\" role=\"status\" aria-hidden=\"true\"></div></div>");
#nullable restore
#line 14 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TableroIngeniero.razor"
} else
{



#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(4);
            __builder.AddAttribute(5, "Roles", "Admin");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(7, "button");
                __builder2.AddAttribute(8, "type", "button");
                __builder2.AddAttribute(9, "class", "btn btn-success");
                __builder2.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TableroIngeniero.razor"
                                                                NuevoIng

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(11, "\r\n            Nuevo Ticket\r\n        ");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "<br> <br>");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "class", "form-control");
            __builder.AddAttribute(17, "type", "text");
            __builder.AddAttribute(18, "placeholder", "Buscar");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TableroIngeniero.razor"
                       Filter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Filter = __value, Filter));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    <br>");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "table-responsive");
            __builder.OpenElement(24, "table");
            __builder.AddAttribute(25, "class", "table");
            __builder.AddMarkupContent(26, @"<thead><tr><th>Acciones</th>
                    <th>Usuario</th>
                    <th>Fecha</th>
                    <th>Estado</th>
                    <th>Prioridad</th>
                    <th>Asunto</th>
                    <th>Ingeniero</th>
                    <th>Mensaje</th></tr></thead>
            ");
            __builder.OpenElement(27, "tbody");
#nullable restore
#line 48 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TableroIngeniero.razor"
                 foreach (var solicitud in ticket)
                {
                    if (!IsVisible(solicitud))
                        continue;


#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "tr");
            __builder.OpenElement(29, "td");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "href", "/TicketdetailsIngeniero/" + (
#nullable restore
#line 54 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TableroIngeniero.razor"
                                                              solicitud.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, @"<svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-pencil-square"" viewBox=""0 0 16 16""><path d=""M15.502 1.94a.5.5 0 0 1 0 .706L14.459 3.69l-2-2L13.502.646a.5.5 0 0 1 .707 0l1.293 1.293zm-1.75 2.456-2-2L4.939 9.21a.5.5 0 0 0-.121.196l-.805 2.414a.25.25 0 0 0 .316.316l2.414-.805a.5.5 0 0 0 .196-.12l6.813-6.814z""></path>
                                    <path fill-rule=""evenodd"" d=""M1 13.5A1.5 1.5 0 0 0 2.5 15h11a1.5 1.5 0 0 0 1.5-1.5v-6a.5.5 0 0 0-1 0v6a.5.5 0 0 1-.5.5h-11a.5.5 0 0 1-.5-.5v-11a.5.5 0 0 1 .5-.5H9a.5.5 0 0 0 0-1H2.5A1.5 1.5 0 0 0 1 2.5v11z""></path></svg>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "td");
#nullable restore
#line 62 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TableroIngeniero.razor"
__builder.AddContent(35, solicitud.Usuario);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.OpenElement(37, "td");
#nullable restore
#line 63 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TableroIngeniero.razor"
__builder.AddContent(38, solicitud.Fecha.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.OpenElement(40, "td");
#nullable restore
#line 64 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TableroIngeniero.razor"
__builder.AddContent(41, solicitud.Estado);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.OpenElement(43, "td");
#nullable restore
#line 65 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TableroIngeniero.razor"
__builder.AddContent(44, solicitud.prioridad);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "td");
#nullable restore
#line 66 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TableroIngeniero.razor"
__builder.AddContent(47, solicitud.Asunto);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.OpenElement(49, "td");
#nullable restore
#line 67 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TableroIngeniero.razor"
__builder.AddContent(50, solicitud.Ingeniero);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                        ");
            __builder.OpenElement(52, "td");
#nullable restore
#line 68 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TableroIngeniero.razor"
__builder.AddContent(53, solicitud.Mensaje);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 72 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TableroIngeniero.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 77 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TableroIngeniero.razor"












}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TableroIngeniero.razor"
       
    IEnumerable<Ticket> ticket;
    public string Filter { get; set; }
    public string Message { get; set; }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            ticket = await servicesticket.GetTicket();
        }
        catch (Exception e)
        {
            Message ="Error encontrado... "+ e.Message;
        }
    }

    private async Task NuevoUsr()
    {
        navigation.NavigateTo("/Ticketdetails");
    }

    private async Task NuevoIng()
    {
        navigation.NavigateTo("/TicketdetailsIngeniero");
    }

    public bool IsVisible(Ticket filtro)
    {
        if (string.IsNullOrEmpty(Filter))
            return true;

        if (filtro.Usuario.Contains(Filter, StringComparison.OrdinalIgnoreCase))
            return true;

        if (filtro.Asunto.Contains(Filter, StringComparison.OrdinalIgnoreCase))
            return true;

        return false;
    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IservicesTicket servicesticket { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
    }
}
#pragma warning restore 1591
