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

namespace Parcial2
{
    /// <summary>
    /// Lógica de interacción para AgendaAvanzada.xaml
    /// </summary>
    public partial class AgendaAvanzada : Window
    {

            private List<Tarea> listaTareas = new List<Tarea>();

            public DateTime FechaSeleccionada { get; set; } = DateTime.Now;

            public AgendaAvanzada()
            {
                InitializeComponent();
            }

            private void BtnAgregar_Click(object sender, RoutedEventArgs e)
            {
                var nuevaTarea = new Tarea
                {
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Fecha = FechaSeleccionada
                };
                listaTareas.Add(nuevaTarea);
                ActualizarListBox();
            }


            private void BtnEliminar_Click(object sender, RoutedEventArgs e)
            {
                if (listBoxTareas.SelectedItem is Tarea tareaSeleccionada)
                {
                    listaTareas.Remove(tareaSeleccionada);
                    ActualizarListBox();
                }
            }

            private void ActualizarListBox()
            {
                listBoxTareas.ItemsSource = null;
                listBoxTareas.ItemsSource = listaTareas;
            }

            private void MostrarDetalles_Click(object sender, RoutedEventArgs e)
            {
                if (listBoxTareas.SelectedItem is Tarea tareaSeleccionada)
                {
                    MessageBox.Show($"Detalles de la tarea:\n\nNombre: {tareaSeleccionada.Nombre}\nDescripción: {tareaSeleccionada.Descripcion}\nFecha: {tareaSeleccionada.Fecha}");
                }
            }

            private void MarcarComoCompletada_Click(object sender, RoutedEventArgs e)
            {
                if (listBoxTareas.SelectedItem is Tarea tareaSeleccionada)
                {
                    tareaSeleccionada.Completada = true;
                    ActualizarListBox();
                }
            }

            private void AsignarResponsable_Click(object sender, RoutedEventArgs e)
            {
                if (listBoxTareas.SelectedItem is Tarea tareaSeleccionada)
                {
                    ActualizarListBox();
                }
            }



    }

}


