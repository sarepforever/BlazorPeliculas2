using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Helpers
{
    public static class IJSRuntimeExtesionMethods
    {
        public static async ValueTask<bool> Confirm( this IJSRuntime js,string mensaje)
        {
            await js.InvokeVoidAsync("console.log", "Consola JS");
            return await js.InvokeAsync<bool>("confirm", $"¿Desea borrar la pelicula {mensaje}?");
        }
    }
}
