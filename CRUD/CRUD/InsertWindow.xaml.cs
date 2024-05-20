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

namespace CRUD
{
    /// <summary>
    /// Lógica de interacción para InsertWindow.xaml
    /// </summary>
    public partial class InsertWindow : Window
    {
        public InsertWindow()
        {
            InitializeComponent();
            DataAccess dataAccess = new DataAccess();
            cbCarreras.ItemsSource = dataAccess.GetProduct();
        }

        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            Ventas alumno = new Ventas
            {
                Cliente = txtCliente.Text,
                Idproducto = txtidProduct.Text,
                cantidad = int.Parse( Cantidad.Text),
                Precio = int.Parse(Precio.Text),
                Id = int.Parse(txtId.Text),
                NombreProducto = (cbCarreras.SelectedValue?.ToString() ?? "0")
            };
            int result = dataAccess.Create(alumno);
            if (result > 0)
            {
                MessageBox.Show("Producto guardado correctamente");
            }

            this.Close();
        }
    }
}
