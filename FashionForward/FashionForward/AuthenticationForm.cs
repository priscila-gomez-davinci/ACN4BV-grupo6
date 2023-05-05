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
    public partial class AuthenticationForm : Form
    {
        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        // Go to Login
        private void button2_Click_2(object sender, EventArgs e)
        {
            panelSignIn.Visible = false;
            panelLogIn.Visible = true;
        }

        // Login Button
        // TODO: Complete this function validating the data with the DB
        private void button1_Click(object sender, EventArgs e)
        {
            // Make validation with the DB
            if (usernameTextBoxLogIn.Text == "Test" && passwordTextBoxLogIn.Text == "Test")
            {
                new MainForm().Show();
                this.Hide();
            } else
            {
                MessageBox.Show("La contraseña ingresada es incorrecta. Por favor, inténtalo de nuevo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Go to Sign In
        private void button2_Click(object sender, EventArgs e)
        {
            panelLogIn.Visible = false;
            panelSignIn.Visible = true;
        }

        // Sign In Button
        // TODO: Complete this function adding the data with the DB
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (passwordTextBoxSignIn.Text == passwordTextBoxConfirmSignIn.Text)
            {
                // Create User in the DB
                // String username = usernameTextBoxSignIn.Text 
                // String password = encryptPassword()
                // Save in the DB
                new MainForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("La contraseñas no coinciden. Por favor, inténtalo de nuevo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void usernameTextBoxSignIn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
