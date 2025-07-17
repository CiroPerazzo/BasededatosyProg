using Microsoft.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace BasededatosyProg.Models
{
    public class BD
    {  
        private static string _connectionString = @"Server=localhost;
        DataBase=Integrantes;Integrated Security=True;TrustServerCertificate=True;";

        public static Integrante Login(string usuario, string contraseña)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"SELECT * FROM Integrante WHERE NombreUsuario = @pUsuario AND Contraseña = @pContraseña";
                return connection.QueryFirstOrDefault<Integrante>(
                    query,
                    new { pUsuario = usuario, pContraseña = contraseña }
                );
            }
        }
        public List<Integrante> LevantarIntegrante()
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Integrante";
                return connection.Query<Integrante>(query).ToList();
            }
        }
    }
}
