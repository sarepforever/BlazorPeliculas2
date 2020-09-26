function pruebaPuntoNetStatic() {
    DotNet.invokeMethodAsync("BlazorPeliculas.Client", "ObtenerCurrentCount")
        .then(resultado => {
            console.log("conteo desde Js " + resultado);
        });
}
function pruebaPuntoNetInstancia(dotnetHeper) {
    dotnetHeper.invokeMethodAsync("IncrementCount");
}