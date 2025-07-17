using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BasededatosyProg.Models;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using Dapper;

namespace BasededatosyProg.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [HttpPost]
        public IActionResult Login(string nombreUsuario, string contraseña)
        {
            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contraseña))
            {
                ViewBag.error = "Por favor, complete todos los campos.";
                return View("Index");
            }

            Integrante i = BD.Login(nombreUsuario, contraseña);

            if (i == null)
            {
                ViewBag.error = "Usuario o contraseña incorrectos.";
                return View("Index");
            }

            ViewBag.nombreUsuario = i.NombreUsuario;
            ViewBag.DNI = i.DNI;
            ViewBag.apellido = i.Apellido;
            ViewBag.telefono = i.Telefono;
            ViewBag.edad = i.Edad;
            return View("Perfil");
        }

        
    }
}
