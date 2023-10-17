using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoPeliculas.Controllers;

public class PrincipalController : Controller
{
    private static List<string> ListaDirectores = new List<string> { "Martin Scorses", "Quentin Tarantino", "Billy Wilder", "James Cameron" };
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
        ViewBag.listaDirectores = ListaDirectores;
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
    [HttpGet]
    [Route("procesa/directores")]
    public RedirectResult ProcesaDirectores()
    {
        Console.WriteLine("Procesando Directores");
        return Redirect("/directores");
    }
    [HttpGet]
    [Route("/formulario/director")]
    public IActionResult FormularioDirector()
    {
        return View("FormularioDirector");
    }
    [HttpPost]
    [Route("nuevo/director")]
    public RedirectToActionResult AgregaDirector(string NombreCompleto)
    {
        ListaDirectores.Add(NombreCompleto);
        return RedirectToAction("directores");
    }
    [HttpGet]
    [Route("api/directores")]
    public JsonResult APIDirectores()
    {
        return Json(ListaDirectores);
    }
}