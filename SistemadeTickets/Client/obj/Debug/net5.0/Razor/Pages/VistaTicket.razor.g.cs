#pragma checksum "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\VistaTicket.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56e609e75ffd4640a43a13d635e330ab5c0f5462"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/VistaTicket")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/VistaTicket/{id:int}")]
    public partial class VistaTicket : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3></h3>");
#nullable restore
#line 11 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\VistaTicket.razor"
 if (ticket == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"d-flex align-items-center\"><strong>Cargando...</strong>\r\n  <div class=\"spinner-border ml-auto\" role=\"status\" aria-hidden=\"true\"></div></div>");
#nullable restore
#line 17 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\VistaTicket.razor"
}else
{
    
    

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 21 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\VistaTicket.razor"
                  ticket

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "card");
                __builder2.AddMarkupContent(7, "<h5 class=\"card-header\">Vista de Ticket</h5>\r\n          ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "card-body");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "container");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "row");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-md-6 mb-3");
                __builder2.AddMarkupContent(16, "<label for>Usuario</label>\r\n                              ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "readonly", true);
                __builder2.AddAttribute(20, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\VistaTicket.razor"
                                                                           ticket.Usuario

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ticket.Usuario = __value, ticket.Usuario))));
                __builder2.AddAttribute(22, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ticket.Usuario));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                       ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "col-md-3 ");
                __builder2.AddMarkupContent(26, "<label for>Fecha de Solicitud</label>\r\n                              ");
                __Blazor.SistemadeTickets.Client.Pages.VistaTicket.TypeInference.CreateInputDate_0(__builder2, 27, 28, "form-control", 29, true, 30, 
#nullable restore
#line 35 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\VistaTicket.razor"
                                                                           ticket.Fecha

#line default
#line hidden
#nullable disable
                , 31, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ticket.Fecha = __value, ticket.Fecha)), 32, () => ticket.Fecha);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                        ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "col-md-4 mb-3");
                __builder2.AddMarkupContent(36, "<label for>Estado</label>\r\n                              ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(37);
                __builder2.AddAttribute(38, "class", "form-control");
                __builder2.AddAttribute(39, "readonly", true);
                __builder2.AddAttribute(40, "placeholder", "Sin Asignar");
                __builder2.AddAttribute(41, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\VistaTicket.razor"
                                                                           ticket.Estado

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ticket.Estado = __value, ticket.Estado))));
                __builder2.AddAttribute(43, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ticket.Estado));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n\r\n                        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "col-md-4 mb-3");
                __builder2.AddMarkupContent(47, "<label for>Prioridad</label>\r\n                              ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(48);
                __builder2.AddAttribute(49, "class", "form-control");
                __builder2.AddAttribute(50, "readonly", true);
                __builder2.AddAttribute(51, "placeholder", "Baja");
                __builder2.AddAttribute(52, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\VistaTicket.razor"
                                                                           ticket.prioridad

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ticket.prioridad = __value, ticket.prioridad))));
                __builder2.AddAttribute(54, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ticket.prioridad));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\r\n                        ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "col-md-6 mb-3");
                __builder2.AddMarkupContent(58, "<label for>Asunto</label>\r\n                              ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(59);
                __builder2.AddAttribute(60, "class", "form-control");
                __builder2.AddAttribute(61, "readonly", true);
                __builder2.AddAttribute(62, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\VistaTicket.razor"
                                                                           ticket.Asunto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ticket.Asunto = __value, ticket.Asunto))));
                __builder2.AddAttribute(64, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ticket.Asunto));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                      ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "col-md-4 mb-3");
                __builder2.AddMarkupContent(68, "<label for>Asignado A</label>\r\n                              ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(69);
                __builder2.AddAttribute(70, "class", "form-control");
                __builder2.AddAttribute(71, "readonly", true);
                __builder2.AddAttribute(72, "placeholder", "Sin Asignar");
                __builder2.AddAttribute(73, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\VistaTicket.razor"
                                                                           ticket.Ingeniero

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ticket.Ingeniero = __value, ticket.Ingeniero))));
                __builder2.AddAttribute(75, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ticket.Ingeniero));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n\r\n                        ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "col-md-12 mb-3");
                __builder2.AddMarkupContent(79, "<label for>Mensaje</label>\r\n                              ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(80);
                __builder2.AddAttribute(81, "class", "form-control");
                __builder2.AddAttribute(82, "readonly", true);
                __builder2.AddAttribute(83, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\VistaTicket.razor"
                                                                               ticket.Mensaje

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(84, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ticket.Mensaje = __value, ticket.Mensaje))));
                __builder2.AddAttribute(85, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ticket.Mensaje));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n                  ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "row");
                __builder2.AddMarkupContent(89, "<div class=\"col-mb-4 mb-3\"></div>\r\n                      ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "col-md-4 mb-3");
                __builder2.OpenComponent<MudBlazor.MudButton>(92);
                __builder2.AddAttribute(93, "ButtonType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 67 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\VistaTicket.razor"
                                                  ButtonType.Button

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(94, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 67 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\VistaTicket.razor"
                                                                            Color.Info

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\VistaTicket.razor"
                                                                                                  Home

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(97, "Volver");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n                      <div class=\"col-mb-4 mb-3\"></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 82 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\VistaTicket.razor"

    

   
    
    
    


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\VistaTicket.razor"
       
    public Ticket ticket;
    [Parameter]
    public int id { get; set; }

    protected async override Task OnInitializedAsync()
    {
 
            ticket = await servicesticket.GetDetails(id);

    }


    public async Task Home()
    {
        navigation.NavigateTo("/tablero");
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IservicesTicket servicesticket { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
    }
}
namespace __Blazor.SistemadeTickets.Client.Pages.VistaTicket
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "readonly", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
