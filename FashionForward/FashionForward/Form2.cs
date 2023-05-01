using FashionForward.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FashionForward.Modelos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace FashionForward
{
    public partial class Form2 : Form
    {
        ProductController productController = new ProductController();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide(); //Oculta el formulario actual (opcional)
            FormController.Form1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog1.Title = "Selecciona una imagen";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pb_imagen.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            cb_talle.Items.Add("XS");
            cb_talle.Items.Add("S");
            cb_talle.Items.Add("M");
            cb_talle.Items.Add("L");
            cb_talle.Items.Add("XL");
            cb_talle.Items.Add("XXL");
            cb_talle.Items.Add("XXXL");

            cb_categoria.Items.Add("Woman");
            cb_categoria.Items.Add("Man");
            cb_categoria.Items.Add("Kids");
            cb_categoria.Items.Add("Teenager");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] imageBytes;
            using (var stream = new MemoryStream())
            {
                pb_imagen.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageBytes = stream.ToArray();
            }

            var talle = cb_talle.SelectedItem;
            var categoria = cb_categoria.SelectedItem;

            Product prod = new Product(int.Parse(txt_id.Text),  txt_nombre.Text, imageBytes, txt_descripcion.Text, int.Parse(txt_stock.Text), double.Parse(txt_id.Text), txt_color.Text, talle.ToString(), categoria.ToString(), true);

            if (productController.crearProducto(prod))
            {
                Trace.WriteLine("Producto Creado con exito");
            }
            else
            {
                Trace.WriteLine("Fallo la creacion del producto");
            }
        }
    }
}
