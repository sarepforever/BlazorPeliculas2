using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BlazorPeliculas.Client.Shared.MainLayout;

namespace BlazorPeliculas.Client.Pages
{
    public class CounterBase : ComponentBase
    {
        [Inject] protected ServicioSingleton Singleton { get; set; }
        [Inject] protected ServicioTransient Transient { get; set; }
        [Inject] protected IJSRuntime JS { get; set; }
   
        static int currentCountStatic = 0;
        protected int currentCount = 0;

        [JSInvokable]
        public async Task IncrementCount()
        {
            currentCount++;
            Singleton.Valor = currentCount;
            Transient.Valor = currentCount;
            currentCountStatic++;
            await JS.InvokeVoidAsync("pruebaPuntoNetStatic");

        }

        [JSInvokable]
        public static Task<int> ObtenerCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
        protected async Task IncrementCountJavaScrip()
        {
            await JS.InvokeVoidAsync("pruebaPuntoNetInstancia",
                DotNetObjectReference.Create(this)
                );
        }
    }
}
