#pragma checksum "E:\Github\repo\TodoL\Pages\Temp_humi.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ce8737099030d578fc85b5ab237d68269b011c9"
// <auto-generated/>
#pragma warning disable 1591
namespace TodoL.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Github\repo\TodoL\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Github\repo\TodoL\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Github\repo\TodoL\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Github\repo\TodoL\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Github\repo\TodoL\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Github\repo\TodoL\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Github\repo\TodoL\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Github\repo\TodoL\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Github\repo\TodoL\_Imports.razor"
using TodoL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Github\repo\TodoL\_Imports.razor"
using TodoL.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/temp_humi")]
    public partial class Temp_humi : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>temp_humi</h3>\r\n<br>\r\n");
            __builder.OpenElement(1, "span");
            __builder.AddContent(2, 
#nullable restore
#line 5 "E:\Github\repo\TodoL\Pages\Temp_humi.razor"
       current

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, " &nbsp;\r\n");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "E:\Github\repo\TodoL\Pages\Temp_humi.razor"
                    update

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "새로고침");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "E:\Github\repo\TodoL\Pages\Temp_humi.razor"
       
    string current = Dht11.getData() ;

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Github\repo\TodoL\Pages\Temp_humi.razor"
                                                    
    void update()
    {
        current = Dht11.getData() ;

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\Github\repo\TodoL\Pages\Temp_humi.razor"
            
    }    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
