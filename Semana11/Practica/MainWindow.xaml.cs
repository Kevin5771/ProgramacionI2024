using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
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

namespace Practica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            InitializeListBox();
            ComboBoxColores.ItemsSource = typeof(Colors).GetProperties();
        }


        public ObservableCollection<string> Items { get; set; } 

        private  void InitializeListBox()
        {
            Items = new ObservableCollection<string>();
            Items.Add("Tareas");
            Items.Add("Proyectos");
            Items.Add("Enlaces");
            Items.Add("Desarrollo");
            Items.Add("Examen");

            listBox.ItemsSource = Items;


        }
        private void MostrarDetalles(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            string nuevoElemento = "Elemento" + random.Next(1000);
            Items.Add(nuevoElemento);

            if (listBox.SelectedItem != null)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Content = $"Información: {listBox.SelectedItem.ToString()}";
                listBox.ToolTip = toolTip;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"La Contraseña es: {PasswordBox.Password}");
        }
    }
}