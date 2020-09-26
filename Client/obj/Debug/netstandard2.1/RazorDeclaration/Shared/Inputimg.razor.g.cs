// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorPeliculas.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Users\SarepDeveloper\Documents\Blazor\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\SarepDeveloper\Documents\Blazor\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\SarepDeveloper\Documents\Blazor\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Users\SarepDeveloper\Documents\Blazor\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Users\SarepDeveloper\Documents\Blazor\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Users\SarepDeveloper\Documents\Blazor\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Users\SarepDeveloper\Documents\Blazor\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Users\SarepDeveloper\Documents\Blazor\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Users\SarepDeveloper\Documents\Blazor\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Users\SarepDeveloper\Documents\Blazor\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Users\SarepDeveloper\Documents\Blazor\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Shared.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Users\SarepDeveloper\Documents\Blazor\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Repositorios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Users\SarepDeveloper\Documents\Blazor\BlazorPeliculas\BlazorPeliculas\Client\Shared\Inputimg.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\SarepDeveloper\Documents\Blazor\BlazorPeliculas\BlazorPeliculas\Client\Shared\Inputimg.razor"
using Tewr.Blazor.FileReader;

#line default
#line hidden
#nullable disable
    public partial class Inputimg : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "D:\Users\SarepDeveloper\Documents\Blazor\BlazorPeliculas\BlazorPeliculas\Client\Shared\Inputimg.razor"
       
    [Parameter] public string Label { get; set; } = "Imagen";
    [Parameter] public string ImagenTemporal { get; set; } = "Imagen";
    [Parameter] public EventCallback<string> ImagenSeleccionada { get; set; }
    private string imagenBase64;
    ElementReference inputElement;

    async Task ImageFileSelected()
    {
        foreach (var file in await fileReaderService.CreateReference(inputElement).EnumerateFilesAsync())
        {
            using(MemoryStream memoryStream = await file.CreateMemoryStreamAsync(4 * 1024))
            {
                var bytesImagen = new byte[memoryStream.Length];
                memoryStream.Read(bytesImagen);
                imagenBase64 = Convert.ToBase64String(bytesImagen);
                await ImagenSeleccionada.InvokeAsync(imagenBase64);
                ImagenTemporal = null;
                StateHasChanged();
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService fileReaderService { get; set; }
    }
}
#pragma warning restore 1591
