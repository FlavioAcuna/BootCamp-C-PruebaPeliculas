using Microsoft.AspNetCore.Mvc;

namespace ProyectoPeliculas.Controllers;

public class PrincipalController : Controller
{
    [HttpGet]
    [Route("")]
    public string Index()
    {
        return "Hola Desde el controlador principal en la ruta'/'";
    }
    [HttpGet]
    [Route("directores")]
    public string Directores()
    {
        return "Hola Desde directores en la ruta'/directores'";
    }
    [HttpGet("mensaje/{nombre}/{apellido}")]
    public string Mensaje(string nombre, string apellido)
    {

        return $"¡Hola como estás {nombre} {apellido}";

    }
    [HttpGet]
    [Route("tabla/{num}/{limite}")]
    public string TablaDeMultiplicar(int num, int limite)
    {
        string TablaCompleta = "";
        for (int i = 1; i <= limite; i++)
        {
            int resultado = i * num;
            TablaCompleta += $"{i} x {num}= {resultado}\n";
        }

        return TablaCompleta;
    }
}