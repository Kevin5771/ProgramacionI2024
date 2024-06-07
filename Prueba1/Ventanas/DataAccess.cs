using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Datos;
using Dapper;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace Prueba1
{
    public class DataAccess
    {

        private const string ConnectionString = "Server=DELL_G15\\MSSQLSERVER01;Integrated Security=true;Initial Catalog=PEDIDO";


        public List<InformacionDestacada> GetInformacionDestacada()
        {
            List<InformacionDestacada> list = new List<InformacionDestacada>();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = @"SELECT p.Id AS PedidoId,
                                    c.Nombre AS ClienteNombre,
                                    pr.Nombre AS ProductoNombre,
                                    dp.Cantidad,
                                    pr.Precio AS PrecioUnitario,
                                    p.Fecha AS FechaPedido
                             FROM Pedidos p
                             JOIN Clientes c ON p.ClienteId = c.Id
                             JOIN DetallePedidos dp ON p.Id = dp.PedidoId
                             JOIN Productos pr ON dp.ProductoId = pr.Id";

                    list = conn.Query<InformacionDestacada>(query).ToList();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return list;
        }
        public int Delete(int id)
        {

            int result = 0;
            int result1 = 0; 

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString); conn.Open();

                string query = "DELETE FROM DetallePedidos WHERE PedidoId = @Id";

                result = conn.Execute(query, new { Id = id });

                string deletePedidosQuery = "DELETE FROM Pedidos WHERE Id = @Id";
                result1 = conn.Execute(deletePedidosQuery, new { Id = id });

                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
            return result1;

        }

        //Para Clientes
        public List<Cliente2> GetAllClientes()
        {
            List<Cliente2> list = new List<Cliente2>();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = " SELECT * FROM Clientes";

                    list = conn.Query<Cliente2>(query).ToList();

                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return list;

        }

        public int InsertCliente(Cliente2 cliente)
        {
            int result= 0;
            try
            {
                using (SqlConnection conn= new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Clientes (Nombre, Direccion, Telefono, Email) VALUES (@Nombre, @Direccion, @Telefono, @Email)";

                    result = conn.Execute(query, new
                    {
                        id1 = cliente.Id,
                        cliente = cliente.Nombre,
                        idproduct = cliente.Direccion,
                        Cantidad = cliente.Telefono,
                        precio = cliente.Email,
                    });

                    conn.Close() ;
                }
            }catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;

        }

        public void UpdateCliente(Cliente2 cliente)
        {
            int result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {

                    conn.Open();

                    string query = "UPDATE Clientes SET Nombre = @Nombre, Direccion = @Direccion, Telefono = @Telefono, Email = @Email WHERE Id = @Id";

                    result = conn.Execute(query, new
                    {
                        id1 = cliente.Id,
                        cliente = cliente.Nombre,
                        idproduct = cliente.Direccion,
                        Cantidad = cliente.Telefono,
                        precio = cliente.Email,
                    });
                    conn.Close();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public int DeleteCliente(int id)
        {
            int result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Clientes WHERE Id = @Id";

                    result = conn.Execute(query, new { Id = id });

                    conn.Close();

                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;

        }

        // Operaciones CRUD para productos
        public List<Producto> GetAllProductos()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                return connection.Query<Producto>("SELECT * FROM Productos").AsList();
            }
        }

        public void InsertProducto(Producto producto)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute("INSERT INTO Productos (Nombre, Precio) VALUES (@Nombre, @Precio)", producto);
            }
        }

        public void UpdateProducto(Producto producto)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute("UPDATE Productos SET Nombre = @Nombre, Precio = @Precio WHERE Id = @Id", producto);
            }
        }

        public void DeleteProducto(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute("DELETE FROM Productos WHERE Id = @Id", new { Id = id });
            }
        }


        public List<Pedido> GetAllPedidos()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                return connection.Query<Pedido>("SELECT * FROM Pedidos").AsList();
            }
        }

        public void InsertPedido(Pedido pedido)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute("INSERT INTO Pedidos (ClienteId, Fecha) VALUES (@ClienteId, @Fecha)", pedido);
            }
        }

        public void UpdatePedido(Pedido pedido)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute("UPDATE Pedidos SET ClienteId = @ClienteId, Fecha = @Fecha WHERE Id = @Id", pedido);
            }
        }

        public void DeletePedido(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute("DELETE FROM Pedidos WHERE Id = @Id", new { Id = id });
            }
        }

        // Operaciones CRUD para detalles de pedidos
        public List<DetallePedido> GetAllDetallesPedidos()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                return connection.Query<DetallePedido>("SELECT * FROM DetallePedidos").AsList();
            }
        }

        public void InsertDetallePedido(DetallePedido detallePedido)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute("INSERT INTO DetallePedidos (PedidoId, ProductoId, Cantidad) VALUES (@PedidoId, @ProductoId, @Cantidad)", detallePedido);
            }
        }

        public void UpdateDetallePedido(DetallePedido detallePedido)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute("UPDATE DetallePedidos SET PedidoId = @PedidoId, ProductoId = @ProductoId, Cantidad = @Cantidad WHERE Id = @Id", detallePedido);
            }
        }

        public void DeleteDetallePedido(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute("DELETE FROM DetallePedidos WHERE Id = @Id", new { Id = id });
            }
        }
    }
}

