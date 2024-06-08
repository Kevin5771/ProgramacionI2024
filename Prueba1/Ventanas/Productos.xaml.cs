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
    /// Lógica de interacción para Productos.xaml
    /// </summary>
    public partial class Productos : Window
    {
        public Productos()
        {
            InitializeComponent();
            recoverData();  
        }

        private void recoverData()
        {
            DataAccess dataAccess = new DataAccess();
            List<Producto> Dapper = dataAccess.GetAllProductos();
            myDataGrid.ItemsSource = Dapper;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InsertProducto insertWindow = new InsertProducto();
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
            int id = ((Producto)myDataGrid.SelectedItem).Id;
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
