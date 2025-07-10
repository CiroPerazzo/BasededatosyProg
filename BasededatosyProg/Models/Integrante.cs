using Microsoft.Data.SqlClient;
using Dapper;
namespace BasededatosyProg.Models;
using Newtonsoft.Json;
public class Integrante
{
[JsonProperty]
public int Id { get; set; }
[JsonProperty] 
public string NombreUsuario { get; set; }
[JsonProperty]
public string Contraseña { get; set; }
[JsonProperty]
public int Edad { get; set; }
[JsonProperty] 
public int Telefono { get; set; } 
[JsonProperty]
public string Apellido { get; set; }
[JsonProperty]
public int DNI { get; set; }






public Integrante(int id, int dni, string nombreUsuario, string apellido, string contraseña, int edad, int telefono)
{
this.Id = id;
this.NombreUsuario = nombreUsuario;
this.Contraseña = contraseña;
this.Edad = edad;
this.Telefono = telefono;
this.Apellido = apellido;
this.DNI = dni;
}

}


