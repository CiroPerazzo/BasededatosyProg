using Microsoft.AspNetCore.Mvc;
using BasededatosyProg.Models;
using Microsoft.AspNetCore.Http;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string usuario, string contraseña)
    {
        Integrante integrante = BD.Login(usuario, contraseña);
        if (integrante != null)
        {
            HttpContext.Session.SetString("usuario", Objeto.ObjectToString(integrante));
            return RedirectToAction("Perfil");
        }
        ViewBag.Mensaje = "Usuario o contraseña incorrectos.";
        Console.WriteLine(integrante != null ? "Login exitoso" : "Login fallido");
        return View();
    }

    public IActionResult Perfil()
    {

        if (HttpContext.Session.GetString("usuario") == null) return RedirectToAction("Login");

        Integrante integrante = Objeto.StringToObject<Integrante>(HttpContext.Session.GetString("usuario"));
        return View(integrante);
    }
}

