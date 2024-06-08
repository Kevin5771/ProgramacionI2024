using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DATOS;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FINAL
{
    /// <summary>
    /// Lógica de interacción para Insertproducto.xaml
    /// </summary>
    public partial class Insertproducto : Window
    {
        public Insertproducto()
        {
            InitializeComponent();
        }
        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            D_Producto producto = new D_Producto
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Precio = decimal.Parse(txtpre.Text),
                Existencia = int.Parse(txtExistencia.Text),
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
