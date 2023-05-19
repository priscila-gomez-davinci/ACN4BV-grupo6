﻿using FashionForward.Controladores;
using FashionForward.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionForward
{
    public partial class MainForm : Form
    {
        ProductController productController = new ProductController();
        List<Product> products;
        public MainForm()
        {
            InitializeComponent();
            showProducts();
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

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog1.Title = "Selecciona una imagen";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pb_imagen.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
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
  
        private void showProducts()
        {

            products = ProductController.getAll();
            dg_products.Rows.Clear();
            foreach (Product prod in products)
            {
                int rowIndex = dg_products.Rows.Add();

                dg_products.Rows[rowIndex].Cells[0].Value = prod.id.ToString();
                dg_products.Rows[rowIndex].Cells[1].Value = prod.name.ToString();
                dg_products.Rows[rowIndex].Cells[2].Value = prod.stock.ToString();
                dg_products.Rows[rowIndex].Cells[3].Value = prod.price.ToString();
                dg_products.Rows[rowIndex].Cells[4].Value = prod.color.ToString();
                dg_products.Rows[rowIndex].Cells[5].Value = prod.size.ToString();
                dg_products.Rows[rowIndex].Cells[6].Value = prod.category.ToString();


                dg_products.Rows[rowIndex].Cells[7].Value = new DataGridViewButtonCell();

            }
        }


        private void btn_agregar_Click(object sender, EventArgs e)
        {
            byte[] imageBytes;
            using (var stream = new MemoryStream())
            {
                pb_imagen.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageBytes = stream.ToArray();
            }

            var talle = cb_talle.SelectedItem;
            var categoria = cb_categoria.SelectedItem;

            Product prod = new Product(int.Parse(txt_id.Text), txt_nombre.Text, imageBytes, txt_descripcion.Text, int.Parse(txt_stock.Text), decimal.Parse(txt_id.Text), txt_color.Text, talle.ToString(), categoria.ToString(), true);

            if (productController.crearProducto(prod))
            {
                Trace.WriteLine("Producto Creado con exito");
                showProducts();
            }
            else
            {
                Trace.WriteLine("Fallo la creacion del producto");
            }
            
        }

        private void dg_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int id = int.Parse(dg_products.Rows[e.RowIndex].Cells[0].Value.ToString());
                ProductController.deleteProduct(id);
                showProducts();
            }
        }
    }
}
