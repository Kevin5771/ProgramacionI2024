using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using System.Windows;
using System.Windows.Media.Media3D;

namespace CRUD
{
    public class DataAccess
    {

        public const string CONECTION_CADENA_SQL = "Server=DELL_G15\\MSSQLSERVER01;Integrated Security=true;Initial Catalog=VentasDB";

        public List<Ventas> GetAllDapper() {
        
            List<Ventas> ventas = new List<Ventas>();
            try
            {
                using (SqlConnection conn = new SqlConnection(CONECTION_CADENA_SQL))
                {

                    conn.Open();

                    string query = "SELECT v.id, v.cliente, v.idproducto ,p.product AS NombreProducto, v.cantidad, v.precio FROM Ventas1 v JOIN Product p ON v.idproducto = p.id";

                    ventas = conn.Query<Ventas>(query).ToList();

                    conn.Close();
                }
 

                    }
            catch (SqlException ex) {

                Console.WriteLine(ex.Message);

            }
            return ventas;

        }

        public int Create(Ventas ventas)
        {
            int result = 0;

            try
            {
                SqlConnection conn = new SqlConnection(CONECTION_CADENA_SQL);
                conn.Open();

                string query = @"INSERT INTO Ventas1 (id, cliente,idproducto, cantidad, precio)
                                    VALUES(@id,@cliente, @idproduct, @cantidad, @precio)";


                result = conn.Execute(query, new
                {

                    id = ventas.Id,
                    cliente = ventas.Cliente,
                    idproduct = ventas.Idproducto,
                    Cantidad = ventas.cantidad,
                    precio = ventas.Precio,

                });

                conn.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            return result;


        }

        public Ventas GetById(int idventas)
        {
            Ventas ventas = new Ventas();

            try { 

            SqlConnection conn = new SqlConnection(CONECTION_CADENA_SQL);
                conn.Open();
                string query = "SELECT id,cliente, idproducto, cantidad, precio FROM Ventas1 WHERE id=@id";
                ventas = conn.QuerySingle<Ventas>(query, new { id = idventas});
                conn.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ventas;

        }

        public int Update(Ventas ventas)
        {
            int result = 0;

            try
            {
                SqlConnection conn = new SqlConnection(CONECTION_CADENA_SQL);
                conn.Open();
                string query = @"UPDATE Ventas1 SET cliente=@cliente, idproducto=@idproduct, cantidad=@Cantidad, precio=@precio WHERE id= @id1";

                //Para guardar, actualizar o eliminar se usa execute.
                result = conn.Execute(query, new
                {
                    id1 = ventas.Id,
                    cliente= ventas.Cliente,
                    idproduct = ventas.Idproducto,
                    Cantidad = ventas.cantidad,
                    precio = ventas.Precio
                       });
                conn.Close();
            } catch (SqlException ex) {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        public int Delete(int id) {

            int result = 0;

            try
            {
                SqlConnection conn = new SqlConnection(CONECTION_CADENA_SQL); conn.Open();
                string query = @"DELETE FROM Ventas1 WHERE id= @id";

                result = conn.Execute(query, new { Id = id });

                conn.Close();
            } catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;

        }

        public List<Producto> GetProduct() {

            List<Producto> product = new List<Producto>();

            try
            {
                SqlConnection conn = new SqlConnection(CONECTION_CADENA_SQL);
                conn.Open();
                string query = "SELECT id,product";
                product = conn.Query<Producto>(query).ToList();
                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }

            return product;


        }
    }
}
