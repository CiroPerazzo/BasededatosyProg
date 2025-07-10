using Microsoft.Data.SqlClient;
using Dapper;
namespace BasededatosyProg.Models;
using Newtonsoft.Json;
public class Integrante
{
[JsonProperty]
public int Id { get; set; }
[JsonProperty]
public int DNI { get; set; }
[JsonProperty] 
public string NombreUsuario { get; set; }
[JsonProperty]
public string Apellido { get; set; }
[JsonProperty]
public string Contrasenia { get; set; }
[JsonProperty]
public int Edad { get; set; }
[JsonProperty]
public string Direccion { get; set; }
[JsonProperty] 
public int Telefono { get; set; } 
public Integrante(int id, int dni, string nombreUsuario, string apellido, string contrasenia, int edad, string direccion, int telefono)
{
    this.Id = id;
    this.DNI = dni;
    this.NombreUsuario = nombreUsuario;
    this.Apellido = apellido;
    this.Contrasenia = contrasenia;
    this.Edad = edad;
    this.Direccion = direccion;
    this.Telefono = telefono;
}

}


