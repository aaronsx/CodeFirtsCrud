using AplicacionWebCodeFirsBiblioteca.Models;
using DAL;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AplicacionWebCodeFirsBiblioteca.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Contexto contexto;

        public HomeController(Contexto contexto)
        {


            Usuarios usuarios = new Usuarios("858", "253257", 2);
            Insert insert = new Insert();
            //Accesos accesos =new Accesos("EM","Un empleado normal");
            //insert.AddAcceso(accesos, contexto);
            //insert.AddUsuario(usuarios, contexto);
            Select select = new Select();
            Usuarios usu =select.BuscarUsuario(usuarios, contexto);
            //Console.WriteLine(usu.dni_usuario);
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}