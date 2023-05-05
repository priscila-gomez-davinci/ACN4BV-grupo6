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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentasForm generarCompra = new VentasForm(); //Crea una instancia del formulario de destino
            generarCompra.Show(); //Muestra el formulario de destino
            this.Hide(); //Oculta el formulario actual (opcional)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductosForm crearProducto = new ProductosForm(); //Crea una instancia del formulario de destino
            crearProducto.Show(); //Muestra el formulario de destino
            this.Hide(); //Oculta el formulario actual (opcional)
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        // Ventas Button
        private void button3_Click(object sender, EventArgs e)
        {
            // ==== OLD WAY
            // VentasForm generarCompra = new VentasForm(); //Crea una instancia del formulario de destino
            // generarCompra.Show(); //Muestra el formulario de destino
            // this.Hide(); //Oculta el formulario actual (opcional)

            // ==== New WAY     
            borderProductos.Visible = false;
            panelProductos.Visible = false;

            borderVentas.Visible = true;
            panelVentas.Visible = true;
        }

        // Productos Button
        private void button4_Click(object sender, EventArgs e)
        {
            // ==== OLD WAY
            // ProductosForm crearProducto = new ProductosForm(); //Crea una instancia del formulario de destino
            // crearProducto.Show(); //Muestra el formulario de destino
            // this.Hide(); //Oculta el formulario actual (opcional)

            // ==== New
            borderVentas.Visible = false;
            panelVentas.Visible = false;

            borderProductos.Visible = true;
            panelProductos.Visible = true;
            
        }
    }
}
