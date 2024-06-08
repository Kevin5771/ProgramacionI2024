using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using DATOS;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FINAL
{
    /// <summary>
    /// Lógica de interacción para Producto.xaml
    /// </summary>
    public partial class Producto : Window
    {
        public Producto()
        {
            InitializeComponent();
            recoverData();
        }

        private void recoverData()
        {
            DataAccess dataAccess = new DataAccess();
            List<D_Producto> Dapper = dataAccess.GetAllProductos();
            myDataGrid.ItemsSource = Dapper;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Insertproducto insertWindow = new Insertproducto();
            insertWindow.Show();
            insertWindow.Closed += Window_Closed;
        }
        private void Window_Closed(object? sender, EventArgs e)
        {
            recoverData();
        }
        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = ((D_Producto)myDataGrid.SelectedItem).Id;
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Estas seguro que deseas eliminar el registro?", "Confirmacion de borrado", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                DataAccess dataAccess = new DataAccess();
                dataAccess.DeleteProducto(id);
                MessageBox.Show("El registro ha sido eliminado");
                recoverData();

            }
        }
    }
}
