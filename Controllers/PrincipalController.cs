using Microsoft.AspNetCore.Mvc;

namespace ProyectoPeliculas.Controllers;

public class PrincipalController : Controller
{
    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
        string titulo = "Hola desde ASP y el servidor!!!";
        string subTitulo = "Bienvenidos a la primera vista";
        ViewBag.Titulo = titulo;
        ViewBag.SubTitulo = subTitulo;
        return View("index");
    }
    [HttpGet]
    [Route("directores")]
    public IActionResult Directores()
    {
        string[] listaDirectores = { "Martin Scorses", "Quentin Tarantino", "Billy Wilder", "James Cameron" };
        ViewBag.ListaDirectores = listaDirectores;
        return View("directores");
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