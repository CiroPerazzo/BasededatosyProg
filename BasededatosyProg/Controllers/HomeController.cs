using Microsoft.AspNetCore.Mvc;
using BasededatosyProg.Models;
using Microsoft.AspNetCore.Http;

public class HomeController : Controller
{
    public IActionResult Login()
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
        return View();
    }

    public IActionResult Perfil()
    {
        var data = HttpContext.Session.GetString("usuario");
        if (data == null) return RedirectToAction("Login");

        Integrante integrante = Objeto.StringToObject<Integrante>(data);
        return View(integrante);
    }
}

