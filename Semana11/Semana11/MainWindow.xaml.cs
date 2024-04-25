


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

namespace Semana11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Suma suma = new Suma();
            this.DataContext = suma;

        }

        private void textbox_LostFocus (object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Haz Salido del Texbox");
        }
    }
}