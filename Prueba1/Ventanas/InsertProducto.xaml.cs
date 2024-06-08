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
    /// Lógica de interacción para InsertProducto.xaml
    /// </summary>
    public partial class InsertProducto : Window
    {
        public InsertProducto()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            Producto producto = new Producto
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Precio = decimal.Parse(txtpre.Text),
            };

            int result = dataAccess.InsertProducto(producto);
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
