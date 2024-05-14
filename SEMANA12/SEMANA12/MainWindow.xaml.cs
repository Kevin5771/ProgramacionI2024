using Semana13BD;
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

namespace SEMANA12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataAccess dataAccess = new DataAccess();
            List<Alumno> alumnos = dataAccess.GetAllAdoNet();
            string resultados = "";
            foreach (var item in alumnos)
            {
                resultados += item.Id + " " + item.Nombres + "\n";
            }

            MessageBox.Show(resultados);

            List<Alumno> alumnosConDapper = dataAccess.GetAllDapper();
            string resultadoConDapper = "";
            foreach (var item in alumnosConDapper)
            {
                resultadoConDapper += item.Id + " " + item.Nombres + "\n";
            }

            MessageBox.Show(resultadoConDapper);
        }
    }
}