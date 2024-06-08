using DATOS;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FINAL
{
    /// <summary>
    /// Lógica de interacción para UpdateCliente.xaml
    /// </summary>
    /// 

    public partial class UpdateCliente : Window
    {
        private int idAlumno;
        public UpdateCliente()
        {
            InitializeComponent();
            this.idAlumno = idAlumno;
            DataAccess dataAccess = new DataAccess();
            D_Cliente alumno = dataAccess.GetById(idAlumno);
            txtId.Text = alumno.Id.ToString();
            txtCliente.Text = alumno.Nombre;
            txtDireccion.Text = alumno.Direccion;
            txtTelefono.Text= alumno.Telefono;
             txtEmail.Text= alumno.Email;

        }

        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            D_Cliente cliente = new D_Cliente
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtCliente.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,

            };
            int result = dataAccess.InsertCliente(cliente);
            if (result > 0)
            {
                MessageBox.Show("Cliente guardado correctamente");
            }
            else
            {
                MessageBox.Show("Hubo un problema al guardar el cliente");
            }


            this.Close();
        }
    }
}
