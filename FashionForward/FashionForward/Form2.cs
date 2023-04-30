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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 atras = new Form1(); //Crea una instancia del formulario de destino
            atras.Show(); //Muestra el formulario de destino
            this.Hide(); //Oculta el formulario actual (opcional)
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog1.Title = "Selecciona una imagen";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            comboBox1.Items.Add("XS");
            comboBox1.Items.Add("S");
            comboBox1.Items.Add("M");
            comboBox1.Items.Add("L");
            comboBox1.Items.Add("XL");
            comboBox1.Items.Add("XXL");
            comboBox1.Items.Add("XXXL");

            comboBox2.Items.Add("Woman");
            comboBox2.Items.Add("Man");
            comboBox2.Items.Add("Kids");
            comboBox2.Items.Add("Teenager");
        }
    }
}
