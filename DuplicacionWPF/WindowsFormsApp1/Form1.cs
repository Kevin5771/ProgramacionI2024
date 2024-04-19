using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
            textBox1.Text = "Elemento 1";

            
            button1.Text = "Elemento 2";


            label1.Text = "Elemento 4";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // Cambiar el tamaño de la fuente cuando el mouse entra en el Button
            button1.Font = new System.Drawing.Font(button1.Font.FontFamily, 30);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

            button1.Font = new System.Drawing.Font(button1.Font.FontFamily, 8.25F);
        }
    }
}
