using Microsoft.AspNetCore.Mvc;
using BasededatosyProg.Models;
using Microsoft.AspNetCore.Http;

public class LoginController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View(); // Muestra el formulario de login
    }

    [HttpPost]
    public IActionResult Index(string email, string password)
    {
        var user = BD.Login(email, password);
        if (user != null)
        {
            // Guardamos en sesión el usuario serializado
            HttpContext.Session.SetString("usuario", Objeto.ObjectToString(user));
            return RedirectToAction("Perfil", "Login");
        }
        ViewBag.Error = "Credenciales incorrectas";
        return View();
    }

    public IActionResult Perfil()
    {
        var userString = HttpContext.Session.GetString("usuario");
        if (string.IsNullOrEmpty(userString)) return RedirectToAction("Index");
        
        var user = Objeto.StringToObject<Integrante>(userString);
        return View(user);
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }
}
