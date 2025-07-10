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

        public List<Integrante> LevantarIntegrante()
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Integrante";
                return connection.Query<Integrante>(query).ToList();
            }
        }

        public static List<Integrante> LevantarIntegrantesPorNombre(string nombre)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string storedProcedure = "TraerIntegrantesPorNombre";
                return connection.Query<Integrante>(
                    storedProcedure,
                    new { Letra = nombre },
                    commandType: System.Data.CommandType.StoredProcedure
                ).ToList();
            }
        }

     public static Integrante Login(string usuario, string contraseña)
{
    using (SqlConnection connection = new SqlConnection(_connectionString))
    {
        string query = @"SELECT * FROM Integrante 
                         WHERE (NombreUsuario = @Usuario OR Email = @Usuario) AND Contraseña = @Contraseña";
        return connection.QueryFirstOrDefault<Integrante>(query, new { Usuario = usuario, Contraseña = contraseña });
    }
}

    }
}
