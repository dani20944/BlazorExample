#pragma checksum "C:\Users\DanielF\Documents\Daniel\BlazorProjects\BlazorFirstExample\BlazorFirstExample\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f37727120807eefe3ab6efb80a649af21e891e8a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorFirstExample.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\DanielF\Documents\Daniel\BlazorProjects\BlazorFirstExample\BlazorFirstExample\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DanielF\Documents\Daniel\BlazorProjects\BlazorFirstExample\BlazorFirstExample\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DanielF\Documents\Daniel\BlazorProjects\BlazorFirstExample\BlazorFirstExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DanielF\Documents\Daniel\BlazorProjects\BlazorFirstExample\BlazorFirstExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DanielF\Documents\Daniel\BlazorProjects\BlazorFirstExample\BlazorFirstExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\DanielF\Documents\Daniel\BlazorProjects\BlazorFirstExample\BlazorFirstExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\DanielF\Documents\Daniel\BlazorProjects\BlazorFirstExample\BlazorFirstExample\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\DanielF\Documents\Daniel\BlazorProjects\BlazorFirstExample\BlazorFirstExample\_Imports.razor"
using BlazorFirstExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\DanielF\Documents\Daniel\BlazorProjects\BlazorFirstExample\BlazorFirstExample\_Imports.razor"
using BlazorFirstExample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DanielF\Documents\Daniel\BlazorProjects\BlazorFirstExample\BlazorFirstExample\Pages\Index.razor"
using BlazorFirstExample.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "max-width:600px");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenComponent<BlazorFirstExample.Components.CustomInput>(3);
            __builder.AddAttribute(4, "ID", "firstname");
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(6, "First Name");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenComponent<BlazorFirstExample.Components.CustomInput>(8);
            __builder.AddAttribute(9, "ID", "lastname");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(11, "Last Name");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenComponent<BlazorFirstExample.Components.CustomInput>(13);
            __builder.AddAttribute(14, "ID", "number");
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(16, "Phone Number");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
