#pragma checksum "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee4324cc93355bb0135ce5f30fd5c27c3656387a"
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
#line 1 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\_Imports.razor"
using SistemadeTickets.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\_Imports.razor"
using SistemadeTickets.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\_Imports.razor"
using SistemadeTickets.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/TicketdetailsIngeniero")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/TicketdetailsIngeniero/{id:int}")]
    public partial class TicketDetailsIngeniero : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3></h3>");
#nullable restore
#line 12 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
 if (ticket == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"d-flex align-items-center\"><strong>Cargando...</strong>\r\n  <div class=\"spinner-border ml-auto\" role=\"status\" aria-hidden=\"true\"></div></div>");
#nullable restore
#line 18 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
}else
{
    

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 21 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                     ticket

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 21 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                            Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "card");
                __builder2.AddMarkupContent(8, "<h5 class=\"card-header\">Formulario de Ticket</h5>\r\n          ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "card-body");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "container");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "row");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "col-md-6 mb-3");
                __builder2.AddMarkupContent(17, "<label for>Usuario</label>\r\n                              ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "required", true);
                __builder2.AddAttribute(21, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                                           ticket.Usuario

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ticket.Usuario = __value, ticket.Usuario))));
                __builder2.AddAttribute(23, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ticket.Usuario));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                       ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "col-md-3 ");
                __builder2.AddMarkupContent(27, "<label for>Fecha de Solicitud</label>\r\n                              ");
                __Blazor.SistemadeTickets.Client.Pages.TicketDetailsIngeniero.TypeInference.CreateInputDate_0(__builder2, 28, 29, "form-control", 30, 
#nullable restore
#line 35 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                                           ticket.Fecha

#line default
#line hidden
#nullable disable
                , 31, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ticket.Fecha = __value, ticket.Fecha)), 32, () => ticket.Fecha);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                        ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "col-md-4 mb-3");
                __builder2.AddMarkupContent(36, "<label for>Estado</label>\r\n                             ");
                __builder2.OpenElement(37, "select");
                __builder2.AddAttribute(38, "class", "form-control");
                __builder2.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                                 ticket.Estado

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ticket.Estado = __value, ticket.Estado));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(41, "option");
                __builder2.AddContent(42, "Sin Asignar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                                 ");
                __builder2.OpenElement(44, "option");
                __builder2.AddContent(45, "En Proceso");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                                 ");
                __builder2.OpenElement(47, "option");
                __builder2.AddContent(48, "Resuelto");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                                 ");
                __builder2.OpenElement(50, "option");
                __builder2.AddContent(51, "Cerrado");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                        ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "col-md-4 mb-3");
                __builder2.AddMarkupContent(55, "<label for>Prioridad</label>\r\n                             ");
                __builder2.OpenElement(56, "select");
                __builder2.AddAttribute(57, "class", "form-control");
                __builder2.OpenElement(58, "option");
                __builder2.AddContent(59, "Baja");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                                 ");
                __builder2.OpenElement(61, "option");
                __builder2.AddContent(62, "Media");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                                 ");
                __builder2.OpenElement(64, "option");
                __builder2.AddContent(65, "Alta");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                                 ");
                __builder2.OpenElement(67, "option");
                __builder2.AddContent(68, "Urgente");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                        ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "col-md-6 mb-3");
                __builder2.AddMarkupContent(72, "<label for>Asunto</label>\r\n                              ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(73);
                __builder2.AddAttribute(74, "class", "form-control");
                __builder2.AddAttribute(75, "required", true);
                __builder2.AddAttribute(76, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 60 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                                           ticket.Asunto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ticket.Asunto = __value, ticket.Asunto))));
                __builder2.AddAttribute(78, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ticket.Asunto));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n                      ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "col-md-4 mb-3");
                __builder2.AddMarkupContent(82, "<label for>Asignado A</label>\r\n                              ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(83);
                __builder2.AddAttribute(84, "class", "form-control");
                __builder2.AddAttribute(85, "required", true);
                __builder2.AddAttribute(86, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 64 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                                           ticket.Ingeniero

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ticket.Ingeniero = __value, ticket.Ingeniero))));
                __builder2.AddAttribute(88, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ticket.Ingeniero));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n\r\n                        ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "col-md-12 mb-3");
                __builder2.AddMarkupContent(92, "<label for>Mensaje</label>\r\n                              ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(93);
                __builder2.AddAttribute(94, "class", "form-control");
                __builder2.AddAttribute(95, "required", true);
                __builder2.AddAttribute(96, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 69 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                                               ticket.Mensaje

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(97, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ticket.Mensaje = __value, ticket.Mensaje))));
                __builder2.AddAttribute(98, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ticket.Mensaje));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n\r\n                  ");
                __builder2.AddMarkupContent(100, @"<div class=""row""><div class=""col-mb-4 mb-3""></div>
                      <div class=""col-md-4 mb-3""><input type=""submit"" class=""btn btn-success"" value=""Guardar"">
                           <input type=""button"" class=""btn btn-secundary"" value=""Cancelar""></div>
                      <div class=""col-mb-4 mb-3""></div></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 94 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"




}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "C:\Users\Ricardo Velazquez\source\repos\SistemadeTickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
       
    public Ticket ticket;
    public Ingeniero ingeniero;

    [Parameter]
    public int id { get; set; }

    protected async override Task OnInitializedAsync()
    {
        if (id == 0)
            ticket = new Ticket();
         else
            ticket = await servicesticket.GetDetails(id);


        ticket = new Ticket();
        ticket.Fecha = DateTime.Today;
        
    }

    private async Task Guardar()
    {
        await servicesticket.SaveTicket(ticket);
        Home();
        
    }

    private async Task Home()
    {
        navigation.NavigateTo("/tablero");
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IservicesIngeniero ServicesIngeniero { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IservicesTicket servicesticket { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
    }
}
namespace __Blazor.SistemadeTickets.Client.Pages.TicketDetailsIngeniero
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591