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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Juego> list = new List<Juego>(); 
            list.Add(new Juego() { Eq1 = "Barcelona", Eq2="Paris Saint-Germain", puntaje1= 1, puntaje2=2, Progreso=85});
            list.Add(new Juego() { Eq1 = "Real Madrid", Eq2 = "Bayern Munich", puntaje1 = 1, puntaje2 = 2, Progreso = 65 });
            list.Add(new Juego() { Eq1 = "BVB Dourmound", Eq2 = "As Roma", puntaje1 = 1, puntaje2 = 2, Progreso = 75 });
            list.Add(new Juego() { Eq1 = "Manchester United", Eq2 = "Arsenal", puntaje1 = 1, puntaje2 = 2, Progreso = 45 });


            LbJuego.ItemsSource= list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LbJuego.SelectedItem != null)
            {
                Juego juegoSeleccionado = LbJuego.SelectedItem as Juego;
                MessageBox.Show("Juego Seleccionado: " + juegoSeleccionado.Eq1 + " " +
                    juegoSeleccionado.puntaje1 + " " + juegoSeleccionado.Eq2 + " " +
                    juegoSeleccionado.puntaje2);
            }
        }



    }
}