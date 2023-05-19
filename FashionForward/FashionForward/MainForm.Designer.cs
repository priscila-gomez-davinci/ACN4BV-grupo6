namespace FashionForward
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.buttonVentas = new System.Windows.Forms.Button();
            this.borderVentas = new System.Windows.Forms.Panel();
            this.buttonProductos = new System.Windows.Forms.Button();
            this.borderProductos = new System.Windows.Forms.Panel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.dg_products = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Talle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.cb_talle = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pb_imagen = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelVentas = new System.Windows.Forms.Panel();
            this.btn_editar = new System.Windows.Forms.Button();
            this.panelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.panelProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavbar
            // 
            this.panelNavbar.BackColor = System.Drawing.Color.Black;
            this.panelNavbar.Controls.Add(this.buttonVentas);
            this.panelNavbar.Controls.Add(this.borderVentas);
            this.panelNavbar.Controls.Add(this.buttonProductos);
            this.panelNavbar.Controls.Add(this.borderProductos);
            this.panelNavbar.Controls.Add(this.labelUsername);
            this.panelNavbar.Controls.Add(this.pictureBoxUser);
            this.panelNavbar.Location = new System.Drawing.Point(0, 0);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(942, 40);
            this.panelNavbar.TabIndex = 4;
            // 
            // buttonVentas
            // 
            this.buttonVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVentas.FlatAppearance.BorderSize = 0;
            this.buttonVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVentas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVentas.ForeColor = System.Drawing.Color.White;
            this.buttonVentas.Location = new System.Drawing.Point(13, 9);
            this.buttonVentas.Name = "buttonVentas";
            this.buttonVentas.Size = new System.Drawing.Size(75, 20);
            this.buttonVentas.TabIndex = 5;
            this.buttonVentas.Text = "Ventas";
            this.buttonVentas.UseVisualStyleBackColor = true;
            this.buttonVentas.Click += new System.EventHandler(this.button3_Click);
            // 
            // borderVentas
            // 
            this.borderVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(174)))), ((int)(((byte)(17)))));
            this.borderVentas.ForeColor = System.Drawing.Color.White;
            this.borderVentas.Location = new System.Drawing.Point(31, 29);
            this.borderVentas.Name = "borderVentas";
            this.borderVentas.Size = new System.Drawing.Size(40, 3);
            this.borderVentas.TabIndex = 39;
            this.borderVentas.Visible = false;
            // 
            // buttonProductos
            // 
            this.buttonProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProductos.FlatAppearance.BorderSize = 0;
            this.buttonProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProductos.ForeColor = System.Drawing.Color.White;
            this.buttonProductos.Location = new System.Drawing.Point(94, 9);
            this.buttonProductos.Name = "buttonProductos";
            this.buttonProductos.Size = new System.Drawing.Size(75, 20);
            this.buttonProductos.TabIndex = 6;
            this.buttonProductos.Text = "Productos";
            this.buttonProductos.UseVisualStyleBackColor = true;
            this.buttonProductos.Click += new System.EventHandler(this.button4_Click);
            // 
            // borderProductos
            // 
            this.borderProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(174)))), ((int)(((byte)(17)))));
            this.borderProductos.ForeColor = System.Drawing.Color.White;
            this.borderProductos.Location = new System.Drawing.Point(104, 29);
            this.borderProductos.Name = "borderProductos";
            this.borderProductos.Size = new System.Drawing.Size(56, 3);
            this.borderProductos.TabIndex = 38;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(840, 14);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(59, 15);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "Test User";
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackgroundImage = global::FashionForward.Properties.Resources.user_profile_white_32px1;
            this.pictureBoxUser.Location = new System.Drawing.Point(902, 5);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxUser.TabIndex = 5;
            this.pictureBoxUser.TabStop = false;
            // 
            // panelProductos
            // 
            this.panelProductos.Controls.Add(this.btn_editar);
            this.panelProductos.Controls.Add(this.dg_products);
            this.panelProductos.Controls.Add(this.txt_id);
            this.panelProductos.Controls.Add(this.label9);
            this.panelProductos.Controls.Add(this.btn_agregar);
            this.panelProductos.Controls.Add(this.txt_color);
            this.panelProductos.Controls.Add(this.txt_nombre);
            this.panelProductos.Controls.Add(this.txt_stock);
            this.panelProductos.Controls.Add(this.txt_descripcion);
            this.panelProductos.Controls.Add(this.cb_categoria);
            this.panelProductos.Controls.Add(this.cb_talle);
            this.panelProductos.Controls.Add(this.label8);
            this.panelProductos.Controls.Add(this.pb_imagen);
            this.panelProductos.Controls.Add(this.label7);
            this.panelProductos.Controls.Add(this.label6);
            this.panelProductos.Controls.Add(this.label5);
            this.panelProductos.Controls.Add(this.label4);
            this.panelProductos.Controls.Add(this.label3);
            this.panelProductos.Controls.Add(this.label2);
            this.panelProductos.Controls.Add(this.txt_precio);
            this.panelProductos.Controls.Add(this.label1);
            this.panelProductos.Location = new System.Drawing.Point(0, 38);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(942, 418);
            this.panelProductos.TabIndex = 5;
            // 
            // dg_products
            // 
            this.dg_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.Stock,
            this.Precio,
            this.Color,
            this.Talle,
            this.Categoria,
            this.Acciones,
            this.Editar});
            this.dg_products.Location = new System.Drawing.Point(3, 234);
            this.dg_products.Name = "dg_products";
            this.dg_products.Size = new System.Drawing.Size(939, 150);
            this.dg_products.TabIndex = 39;
            this.dg_products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_products_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            // 
            // Talle
            // 
            this.Talle.HeaderText = "Talle";
            this.Talle.Name = "Talle";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // Acciones
            // 
            this.Acciones.HeaderText = "Eliminar";
            this.Acciones.Name = "Acciones";
            this.Acciones.Text = "Eliminar";
            // 
            // Editar
            // 
            this.Editar.DataPropertyName = "Editar";
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(150, 21);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(121, 20);
            this.txt_id.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Id";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(301, 183);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(126, 30);
            this.btn_agregar.TabIndex = 36;
            this.btn_agregar.Text = "Agregar producto";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_color
            // 
            this.txt_color.Location = new System.Drawing.Point(457, 67);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(121, 20);
            this.txt_color.TabIndex = 34;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(150, 51);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(121, 20);
            this.txt_nombre.TabIndex = 33;
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(150, 131);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(121, 20);
            this.txt_stock.TabIndex = 32;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(149, 83);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(121, 20);
            this.txt_descripcion.TabIndex = 31;
            // 
            // cb_categoria
            // 
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Location = new System.Drawing.Point(457, 145);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(121, 21);
            this.cb_categoria.TabIndex = 30;
            // 
            // cb_talle
            // 
            this.cb_talle.FormattingEnabled = true;
            this.cb_talle.Location = new System.Drawing.Point(457, 101);
            this.cb_talle.Name = "cb_talle";
            this.cb_talle.Size = new System.Drawing.Size(121, 21);
            this.cb_talle.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(674, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Imagen";
            // 
            // pb_imagen
            // 
            this.pb_imagen.Location = new System.Drawing.Point(651, 40);
            this.pb_imagen.Name = "pb_imagen";
            this.pb_imagen.Size = new System.Drawing.Size(100, 145);
            this.pb_imagen.TabIndex = 27;
            this.pb_imagen.TabStop = false;
            this.pb_imagen.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Categoría";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Talle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 29);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Descripción";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(457, 29);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(121, 20);
            this.txt_precio.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre";
            // 
            // panelVentas
            // 
            this.panelVentas.Enabled = false;
            this.panelVentas.Location = new System.Drawing.Point(0, 41);
            this.panelVentas.Name = "panelVentas";
            this.panelVentas.Size = new System.Drawing.Size(942, 415);
            this.panelVentas.TabIndex = 37;
            this.panelVentas.Visible = false;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(301, 183);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(131, 29);
            this.btn_editar.TabIndex = 40;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 459);
            this.Controls.Add(this.panelNavbar);
            this.Controls.Add(this.panelVentas);
            this.Controls.Add(this.panelProductos);
            this.Name = "MainForm";
            this.Text = "Fashion Forward";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelNavbar.ResumeLayout(false);
            this.panelNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.panelProductos.ResumeLayout(false);
            this.panelProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Button buttonProductos;
        private System.Windows.Forms.Button buttonVentas;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panelProductos;
        private System.Windows.Forms.Panel borderProductos;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.ComboBox cb_talle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pb_imagen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel borderVentas;
        private System.Windows.Forms.Panel panelVentas;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dg_products;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Talle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewButtonColumn Acciones;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.Button btn_editar;
    }
}

