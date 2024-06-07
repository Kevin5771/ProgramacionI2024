using Datos;
using Prueba1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ventanas
{
    /// <summary>
    /// Lógica de interacción para Cliente.xaml
    /// </summary>
    public partial class Cliente : Window
    {
        public Cliente()
        {
            InitializeComponent();
            DataAccess dataAccess = new DataAccess();
        }

        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            Cliente2 cliente = new Cliente2
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtCliente.Text,
                Direccion= txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,

            };
            int result = dataAccess.InsertCliente(cliente);
            if (result > 0)
            {
                MessageBox.Show("Cliente guardado correctamente");
            }
            else
            {
                MessageBox.Show("Hubo un problema al guardar el cliente");
            }


            this.Close();
        }
    }
}
