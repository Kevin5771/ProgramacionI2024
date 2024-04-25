using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ComboBoxColores.ItemsSource = typeof(Colors).GetProperties();
        }

        private void cbtodos_Checked(object sender, RoutedEventArgs e)
        {
            if (cbtodos.IsChecked == true)
            {
                Cbopcion1.IsChecked = true;
                Cbopcion2.IsChecked = true;
                Cbopcion3.IsChecked = true;
            }
            else if (cbtodos.IsChecked == false)
            {
                Cbopcion1.IsChecked = false;
                Cbopcion2.IsChecked = false;
                Cbopcion3.IsChecked = false;
            }
            else
            {
                Cbopcion1.IsChecked = false;
                Cbopcion2.IsChecked = false;
                Cbopcion3.IsChecked = false;
            }
        }

        private void cbOpcion_Checked(object sender, RoutedEventArgs e)
        {
            if (Cbopcion1.IsChecked == true && Cbopcion2.IsChecked == true && Cbopcion3.IsChecked == true)
            {
                cbtodos.IsChecked = true;
            }
            else if (Cbopcion1.IsChecked == false && Cbopcion2.IsChecked == false && Cbopcion3.IsChecked == false)
            {
                cbtodos.IsChecked = false;
            }
            else
            {
                cbtodos.IsChecked = null;
            }
        }
    }
    

}
