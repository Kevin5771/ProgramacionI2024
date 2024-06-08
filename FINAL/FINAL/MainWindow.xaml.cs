using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using DATOS;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FINAL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            recoverData();  
        }

        private void recoverData()
        {

            DataAccess dataAccess = new DataAccess();
            List<InformacionDestacada> Dapper = dataAccess.GetInformacionDestacada();
            myDataGrid.ItemsSource = Dapper;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cliente insertWindow = new Cliente();
            insertWindow.Show();
            insertWindow.Closed += Window_Closed;
        }

        private void Window_Closed(object? sender, EventArgs e)
        {
            recoverData();
        }


        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = ((InformacionDestacada)myDataGrid.SelectedItem).PedidoId;
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Estas seguro que deseas eliminar el registro?", "Confirmacion de borrado", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                DataAccess dataAccess = new DataAccess();
                dataAccess.Delete(id);
                MessageBox.Show("El registro ha sido eliminado");
                recoverData();

            }
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Producto insertWindow = new Producto();
            insertWindow.Show();
            insertWindow.Closed += Window_Closed;

        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Pedidos insertWindow = new Pedidos();
            insertWindow.Show();
            insertWindow.Closed += Window_Closed;
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {

        }
    }
}