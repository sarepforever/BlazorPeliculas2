// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorPeliculas.Client.Pages.Pelculas
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/peliculas/buscar")]
    public partial class FiltroPeliculas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "D:\Users\SarepDeveloper\Documents\Blazor\BlazorPeliculas\BlazorPeliculas\Client\Pages\Pelculas\FiltroPeliculas.razor"
       
    private List<Pelicula> Peliculas;
    string titulo = "";
    string generoSeleccionado = "0";
    private bool futurosEstrenos = false;
    private bool enCartelera = false;
    private bool masVotadas = false;
    private List<Genero> generos = new List<Genero>();

    private void TituloKeyPress (KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            CargarNuevasPeliculas();
        }
    }
    private void CargarNuevasPeliculas()
    {
        Peliculas = Peliculas.Where(x => x.Titulo.ToLower().Contains(titulo.ToLower())).ToList();
        Console.WriteLine($"titulo: { titulo}");
        Console.WriteLine($"generoSeleccionado: { generoSeleccionado}");
        Console.WriteLine($"futurosEstrenos: { futurosEstrenos}");
        Console.WriteLine($"enCartelera: { enCartelera}");
        Console.WriteLine($"masVotadas: { masVotadas}");
    }
    private void LimpiarOnClick()
    {
        OnInitialized();
        titulo = "";
        generoSeleccionado = "";
        futurosEstrenos = false;
        enCartelera = false;
        masVotadas = false;
    }
    protected override void OnInitialized()
    {
        Peliculas = repositorio.ObtenerPeliculas();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
