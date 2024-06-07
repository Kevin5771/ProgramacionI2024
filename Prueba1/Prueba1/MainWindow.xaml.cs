
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CRUD
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
 
        }

    }

}