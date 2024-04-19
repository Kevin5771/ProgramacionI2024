using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicacionWPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configurar el texto del TextBox
            textBox1.Text = "Hola Mundo, Esta es Una Prueba en Windows Forms";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Haz Hecho Click en Button1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Haz Hecho Click en Button2");
        }
    }
}
