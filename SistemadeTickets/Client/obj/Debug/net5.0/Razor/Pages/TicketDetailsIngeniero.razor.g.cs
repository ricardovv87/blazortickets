#pragma checksum "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34d8a1def38f9bfd09389ec2e5b4a0f6ff94ce5f"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/TicketdetailsIngeniero")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/TicketdetailsIngeniero/{id:int}")]
    public partial class TicketDetailsIngeniero : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 12 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
 if (ticket == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"d-flex align-items-center\"><strong>Cargando...</strong>\r\n  <div class=\"spinner-border ml-auto\" role=\"status\" aria-hidden=\"true\"></div></div>");
#nullable restore
#line 18 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
}else
{
    

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 21 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                     ticket

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 21 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                            Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "card");
                __builder2.AddMarkupContent(7, "<h5 class=\"card-header\">Formulario de Ticket</h5>\r\n          ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "card-body");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "container");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "row");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-md-6 mb-3");
                __Blazor.SistemadeTickets.Client.Pages.TicketDetailsIngeniero.TypeInference.CreateMudTextField_0(__builder2, 16, 17, "Usuario", 18, 
#nullable restore
#line 30 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                                                               Variant.Text

#line default
#line hidden
#nullable disable
                , 19, 
#nullable restore
#line 30 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                                                                                     Margin.Dense

#line default
#line hidden
#nullable disable
                , 20, 
#nullable restore
#line 30 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                       ticket.Usuario

#line default
#line hidden
#nullable disable
                , 21, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ticket.Usuario = __value, ticket.Usuario)));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n                       ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "col-md-3 ");
                __builder2.OpenComponent<MudBlazor.MudDatePicker>(25);
                __builder2.AddAttribute(26, "Label", "Fecha");
                __builder2.AddAttribute(27, "Date", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?>(
#nullable restore
#line 33 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                              ticket.Fecha

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "col-md-4 mb-3");
                __builder2.OpenComponent<MudBlazor.MudSelect<string>>(31);
                __builder2.AddAttribute(32, "Label", "Estado");
                __builder2.AddAttribute(33, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 37 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                                         ticket.Estado

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ticket.Estado = __value, ticket.Estado))));
                __builder2.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.SistemadeTickets.Client.Pages.TicketDetailsIngeniero.TypeInference.CreateMudSelectItem_1(__builder3, 36, 37, 
#nullable restore
#line 38 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                     "Abierto"

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(38, "\r\n                             ");
                    __Blazor.SistemadeTickets.Client.Pages.TicketDetailsIngeniero.TypeInference.CreateMudSelectItem_2(__builder3, 39, 40, 
#nullable restore
#line 39 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                     "En Proceso"

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(41, "\r\n                             ");
                    __Blazor.SistemadeTickets.Client.Pages.TicketDetailsIngeniero.TypeInference.CreateMudSelectItem_3(__builder3, 42, 43, 
#nullable restore
#line 40 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                     "Resuelto"

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(44, "\r\n                             ");
                    __Blazor.SistemadeTickets.Client.Pages.TicketDetailsIngeniero.TypeInference.CreateMudSelectItem_4(__builder3, 45, 46, 
#nullable restore
#line 41 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                     "Cerrado"

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                        ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "col-md-4 mb-3");
                __builder2.OpenComponent<MudBlazor.MudSelect<string>>(50);
                __builder2.AddAttribute(51, "Label", "Prioridad");
                __builder2.AddAttribute(52, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 47 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                                                  ticket.prioridad

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ticket.prioridad = __value, ticket.prioridad))));
                __builder2.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.SistemadeTickets.Client.Pages.TicketDetailsIngeniero.TypeInference.CreateMudSelectItem_5(__builder3, 55, 56, 
#nullable restore
#line 48 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                        "Baja"

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(57, "\r\n                                ");
                    __Blazor.SistemadeTickets.Client.Pages.TicketDetailsIngeniero.TypeInference.CreateMudSelectItem_6(__builder3, 58, 59, 
#nullable restore
#line 49 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                        "Media"

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(60, "\r\n                                ");
                    __Blazor.SistemadeTickets.Client.Pages.TicketDetailsIngeniero.TypeInference.CreateMudSelectItem_7(__builder3, 61, 62, 
#nullable restore
#line 50 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                        "Alta"

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(63, "\r\n                                ");
                    __Blazor.SistemadeTickets.Client.Pages.TicketDetailsIngeniero.TypeInference.CreateMudSelectItem_8(__builder3, 64, 65, 
#nullable restore
#line 51 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                        "Urgente"

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                        ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "col-md-5 mb-3");
                __Blazor.SistemadeTickets.Client.Pages.TicketDetailsIngeniero.TypeInference.CreateMudTextField_9(__builder2, 69, 70, "Asunto", 71, 
#nullable restore
#line 55 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                                                           Variant.Text

#line default
#line hidden
#nullable disable
                , 72, 
#nullable restore
#line 55 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                                                                                 Margin.Dense

#line default
#line hidden
#nullable disable
                , 73, 
#nullable restore
#line 55 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                     ticket.Asunto

#line default
#line hidden
#nullable disable
                , 74, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ticket.Asunto = __value, ticket.Asunto)));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                      ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "col-md-4 mb-3");
                __Blazor.SistemadeTickets.Client.Pages.TicketDetailsIngeniero.TypeInference.CreateMudSelect_10(__builder2, 78, 79, "Asignar Ingeniero", 80, 
#nullable restore
#line 58 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                       ticket.Ingeniero

#line default
#line hidden
#nullable disable
                , 81, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ticket.Ingeniero = __value, ticket.Ingeniero)), 82, (__builder3) => {
#nullable restore
#line 59 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                    foreach ( var item in ingeniero)
                                     {

#line default
#line hidden
#nullable disable
                    __Blazor.SistemadeTickets.Client.Pages.TicketDetailsIngeniero.TypeInference.CreateMudSelectItem_11(__builder3, 83, 84, 
#nullable restore
#line 61 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                               item.ingeniero

#line default
#line hidden
#nullable disable
                    , 85, (__builder4) => {
#nullable restore
#line 61 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
__builder4.AddContent(86, item.ingeniero);

#line default
#line hidden
#nullable disable
                    }
                    );
#nullable restore
#line 62 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                     }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                      ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "col-md-3");
                __Blazor.SistemadeTickets.Client.Pages.TicketDetailsIngeniero.TypeInference.CreateMudCheckBox_12(__builder2, 90, 91, "Solucionado?", 92, 
#nullable restore
#line 67 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                                             FS

#line default
#line hidden
#nullable disable
                , 93, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => FS = __value, FS)), 94, (__builder3) => {
#nullable restore
#line 68 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                             if (FS == true)
                                {
                                    ticket.FechaSolucion = DateTime.Today;
                                }
                                else ticket.FechaSolucion = DateTime.MaxValue;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n\r\n                        ");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "col-md-6 mb-3");
                __builder2.AddMarkupContent(98, "<label for>Mensaje</label>\r\n                            ");
                __Blazor.SistemadeTickets.Client.Pages.TicketDetailsIngeniero.TypeInference.CreateMudTextField_13(__builder2, 99, 100, "Describa el problema", 101, 
#nullable restore
#line 78 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                                                                            Variant.Outlined

#line default
#line hidden
#nullable disable
                , 102, 
#nullable restore
#line 78 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                                                                                                      Margin.Dense

#line default
#line hidden
#nullable disable
                , 103, 
#nullable restore
#line 78 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                                                                                                                           5

#line default
#line hidden
#nullable disable
                , 104, 
#nullable restore
#line 78 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                       ticket.Mensaje

#line default
#line hidden
#nullable disable
                , 105, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ticket.Mensaje = __value, ticket.Mensaje)));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n                      ");
                __builder2.OpenElement(107, "div");
                __builder2.AddAttribute(108, "class", "col-md-6 mb-3");
                __builder2.AddMarkupContent(109, "<label for>Mensaje de Solucion</label>\r\n                            ");
                __Blazor.SistemadeTickets.Client.Pages.TicketDetailsIngeniero.TypeInference.CreateMudTextField_14(__builder2, 110, 111, "Solucion del Problema", 112, 
#nullable restore
#line 82 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                                                                                      Variant.Outlined

#line default
#line hidden
#nullable disable
                , 113, 
#nullable restore
#line 82 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                                                                                                                Margin.Dense

#line default
#line hidden
#nullable disable
                , 114, 
#nullable restore
#line 82 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                                                                                                                                     5

#line default
#line hidden
#nullable disable
                , 115, 
#nullable restore
#line 82 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                       ticket.IngenieroMensaje

#line default
#line hidden
#nullable disable
                , 116, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ticket.IngenieroMensaje = __value, ticket.IngenieroMensaje)));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n\r\n                  ");
                __builder2.OpenElement(118, "div");
                __builder2.AddAttribute(119, "class", "row");
                __builder2.AddMarkupContent(120, "<div class=\"col-mb-4 mb-3\"></div>\r\n                      ");
                __builder2.OpenElement(121, "div");
                __builder2.AddAttribute(122, "class", "col-md-4 mb-3");
                __builder2.AddMarkupContent(123, "<input type=\"submit\" class=\"btn btn-success\" value=\"Guardar\">\r\n                           ");
                __builder2.OpenElement(124, "input");
                __builder2.AddAttribute(125, "type", "button");
                __builder2.AddAttribute(126, "class", "btn btn-secundary");
                __builder2.AddAttribute(127, "value", "Cancelar");
                __builder2.AddAttribute(128, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 94 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
                                                                                                     Home

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n                      <div class=\"col-mb-4 mb-3\"></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 109 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"

    
    

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 118 "C:\Users\redes\source\repos\blazortickets\SistemadeTickets\Client\Pages\TicketDetailsIngeniero.razor"
       
    public Ticket ticket;
    public string MensajeInge = string.Empty;
    IEnumerable<Ingeniero> ingeniero;
    public bool FS { get; set; }


    [Parameter]
    public int id { get; set; }

    protected async override Task OnInitializedAsync()
    {
        try
        {

            ingeniero = await ServicesIngeniero.GetIngenieros();

            if (id == 0)

                ticket = new Ticket() {Fecha = DateTime.Today,IngenieroMensaje = MensajeInge};

            else
                ticket = await servicesticket.GetDetails(id);

        }
        catch (Exception e)
        {
            throw e;
        }

    }

    private async Task Guardar()
    {
        await servicesticket.SaveTicket(ticket);
        Home();
        
    }

    private async Task Home()
    {
        navigation.NavigateTo("/tableroIngenieros");
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
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Margin", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_6<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_7<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_8<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_9<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Margin", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudSelect_10<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, T __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelect<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_11<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudCheckBox_12<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, T __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudCheckBox<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Checked", __arg1);
        __builder.AddAttribute(__seq2, "CheckedChanged", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_13<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, global::System.Int32 __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Margin", __arg2);
        __builder.AddAttribute(__seq3, "Lines", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_14<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, global::System.Int32 __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Margin", __arg2);
        __builder.AddAttribute(__seq3, "Lines", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
