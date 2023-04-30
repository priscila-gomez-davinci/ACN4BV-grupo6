using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionForward
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 atras = new Form1(); //Crea una instancia del formulario de destino
            atras.Show(); //Muestra el formulario de destino
            this.Hide(); //Oculta el formulario actual (opcional)
        }
    }
}
