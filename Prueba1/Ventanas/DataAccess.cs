﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Datos;
using Dapper;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Ventanas;

namespace Prueba1
{
    public class DataAccess
    {

        private const string ConnectionString = "Server=DELL_G15\\MSSQLSERVER01;Integrated Security=true;Initial Catalog=PEDIDO1";


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
            int result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Clientes (Id, Nombre, Direccion, Telefono, Email) VALUES (@Id, @Nombre, @Direccion, @Telefono, @Email)";

                    result = conn.Execute(query, new
                    {
                        Id = cliente.Id,
                        Nombre = cliente.Nombre,
                        Direccion = cliente.Direccion,
                        Telefono = cliente.Telefono,
                        Email = cliente.Email,
                    });

                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return result;
        }


        public int UpdateCliente(Cliente2 cliente)
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
            return result;

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
            List<Producto> list = new List<Producto>();

            try
            {
                using(SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Productos";

                    list = conn.Query<Producto>(query).ToList();

                    conn.Close();
                }
            }
            catch(SqlException ex) {
                Console.WriteLine(ex.Message);
            }
            return list;

        }

        public int InsertProducto(Producto producto)
        {
            int result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Productos(Id, Nombre, Precio) VALUES(@Id, @Nombre, @Precio)";

                    result = conn.Execute(query, new
                    {
                        Id = producto.Id,
                        Nombre = producto.Nombre,  // Correctly map the Nombre property
                        Precio = producto.Precio,
                    });

                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return result;
        }


        public int UpdateProducto(Producto producto)
        {
            int result = 0;

            try { 
                using(SqlConnection conn = new SqlConnection(ConnectionString))
                {

                    conn.Open();

                    string query = "UPDATE Productos SET Nombre = @Nombre, Precio = @Precio WHERE Id = @Id";


                    result = conn.Execute(query, new
                    {
                        Id = producto.Id,
                        Cliente = producto.Nombre,
                        Precio = producto.Precio,
   
                    });
                    conn.Close();
                }
            }
            catch( SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;  
        }

        public int DeleteProducto(int id)
        {
            int result = 0;
            try
            {
                using(SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Productos WHERE Id = @Id";

                    result = conn.Execute(query, new { Id = id });

                    conn.Close();

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;

        }


        public List<Pedido> GetAllPedidos()

        {
            List<Pedido> list = new List<Pedido>();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM Pedidos";

                    list = conn.Query<Pedido>(query).ToList();

                    conn.Close();
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return list;
        }

        public int InsertPedido(Pedido pedido)
        {
            int result = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Pedidos (ClienteId, Fecha) VALUES (@ClienteId, @Fecha)";

                    result = conn.Execute(query, new
                    {
                        Id = pedido.Id,
                        clienteId = pedido.ClienteId,
                        fecha = pedido.Fecha,
                    });

                    conn.Close();
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;

        }

        public void UpdatePedido(Pedido pedido)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute("UPDATE Pedidos SET ClienteId = @ClienteId, Fecha = @Fecha WHERE Id = @Id", pedido);
            }
        }

        public int DeletePedido(int id)
        {
            int result = 0;

            try
            {
                using(SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string query = "DELETE FROM Pedidos WHERE Id = @Id";

                    result = conn.Execute(query, new { Id = id });

                    conn.Close();
                }
            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        // Operaciones CRUD para detalles de pedidos
        public List<DetallePedido> GetAllDetallesPedidos()
        {
            List<DetallePedido> list = new List<DetallePedido>();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM DetallePedidos";

                    list = conn.Query<DetallePedido>(query).ToList();

                    conn.Close();

                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return list;


        }

        public int InsertDetallePedido(DetallePedido detallePedido)
        {
            int result = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO DetallePedidos (PedidoId, ProductoId, Cantidad) VALUES (@PedidoId, @ProductoId, @Cantidad)";

                    result = conn.Execute(query, new
                    {
                        Id = detallePedido.Id,
                        pedidoId = detallePedido.PedidoId,
                        productoId = detallePedido.ProductoId,
                        cantidad= detallePedido.Cantidad,
                    });

                    conn.Close();

                }
            }
            catch( SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
              return result;
        }

        public void UpdateDetallePedido(DetallePedido detallePedido)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute("UPDATE DetallePedidos SET PedidoId = @PedidoId, ProductoId = @ProductoId, Cantidad = @Cantidad WHERE Id = @Id", detallePedido);
            }
        }

        public int DeleteDetallePedido(int id)
        {
            int result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string query = "DELETE FROM DetallePedidos WHERE Id = @Id";

                    result = conn.Execute(query, new { Id = id });

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}

