using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

using SEMANA12;

namespace Semana13BD
{
    public class DataAccess
    {
       // public const string CONNECTION_STRING = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Marco\\Documents\\UMG\\Progra12024\\Semana13BD\\Semana13BD\\Escuela.mdf;Integrated Security=True";

        public const string CADENA_SQL_SERVER = "Server=DELL_G15\\MSSQLSERVER01;Integrated Security=true;Initial Catalog=ALUMNO";
        //ADO.NET
        public List<Alumno> GetAllAdoNet()
        {
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = "SELECT id, nombres, apellidos, carnet, telefono FROM Alumno";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Alumno a = new Alumno
                    {
                        Id = reader.GetInt32(0),
                        Nombres = reader.GetString(1),
                        Apellidos = reader.GetString(2),
                        Carnet = reader.GetString(3),
                        Telefono = reader.GetString(4)
                    };
                    alumnos.Add(a);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return alumnos;
        }

        public List<Alumno> GetAllDapper()
        {
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = "SELECT id, nombres, apellidos, carnet, telefono FROM Alumno";
                alumnos = conn.Query<Alumno>(query).ToList();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return alumnos;
        }

        public Alumno Create (Alumno alumno)
        {
            int result =0;
            try {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = "INSERT INTO Alumno";

                conn.Execute(query,new {});
                conn.Close();  
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //return result;
        }
    }
}