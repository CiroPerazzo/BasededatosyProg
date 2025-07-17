using Microsoft.Data.SqlClient;
using Dapper;
namespace BasededatosyProg.Models;
using Newtonsoft.Json;
public class Integrante
{
    public int Id { get; set; }
    public string NombreUsuario { get; set; }
    public string Contraseña { get; set; }
    public int Edad { get; set; }
    public int Telefono { get; set; }
    public string Apellido { get; set; }
    public int DNI { get; set; }

    // 🔧 Este constructor vacío es lo que Dapper necesita
    public Integrante() { }
}


