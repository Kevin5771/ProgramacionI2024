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
    /// Lógica de interacción para UpdateWindow.xaml
    /// </summary>
    public partial class UpdateWindow : Window
    {
        public UpdateWindow(int id)
        {
            InitializeComponent();
            DataAccess dataAccess = new DataAccess();
            Ventas alumno = dataAccess.GetById(id);
            txtId.Text = alumno.Id.ToString();
            txtCliente.Text = alumno.Cliente;
            txtidProduct.Text = alumno.Idproducto;
            Cantidad.Text = alumno.cantidad.ToString();
            Precio.Text = alumno.Precio.ToString();
            cbCarreras.ItemsSource = dataAccess.GetProduct();
            cbCarreras.SelectedValue = alumno.Idproducto;

        }

        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            Ventas alumno = new Ventas
            {
                Cliente = txtCliente.Text,
                Idproducto = txtidProduct.Text,
                cantidad = int.Parse(Cantidad.Text),
                Precio = int.Parse(Precio.Text),
                Id = int.Parse(txtId.Text),
                NombreProducto = (cbCarreras.SelectedValue?.ToString() ?? "0")
            };
            int result = dataAccess.Update(alumno);
            if (result > 0)
            {
                MessageBox.Show("Guardado correctamente");
            }

            this.Close();
        }
    }
}
