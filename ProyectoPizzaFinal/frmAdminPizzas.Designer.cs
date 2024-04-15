namespace ProyectoPizzaFinal
{
    partial class frmAdminPizzas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminPizzas));
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            txtIdPizza = new TextBox();
            label5 = new Label();
            txtDescripcion = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            label6 = new Label();
            dataGridViewPizzas = new DataGridView();
            panel2 = new Panel();
            btnRegresar = new Button();
            btnCerrar = new Button();
            label7 = new Label();
            label8 = new Label();
            cmbTamaño = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPizzas).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(355, 22);
            label1.Name = "label1";
            label1.Size = new Size(0, 22);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(201, 116);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(294, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(273, 31);
            txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(201, 153);
            label3.Name = "label3";
            label3.Size = new Size(71, 22);
            label3.TabIndex = 3;
            label3.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrecio.Location = new Point(278, 148);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(273, 31);
            txtPrecio.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(201, 76);
            label4.Name = "label4";
            label4.Size = new Size(80, 22);
            label4.TabIndex = 5;
            label4.Text = "ID Pizza:";
            // 
            // txtIdPizza
            // 
            txtIdPizza.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIdPizza.Location = new Point(325, 71);
            txtIdPizza.Name = "txtIdPizza";
            txtIdPizza.Size = new Size(273, 31);
            txtIdPizza.TabIndex = 6;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(201, 194);
            label5.Name = "label5";
            label5.Size = new Size(121, 22);
            label5.TabIndex = 7;
            label5.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcion.Location = new Point(325, 194);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(273, 81);
            txtDescripcion.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.BackColor = Color.FromArgb(224, 224, 224);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(715, 216);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(143, 47);
            btnAgregar.TabIndex = 27;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModificar.BackColor = Color.FromArgb(224, 224, 224);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(715, 153);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(143, 47);
            btnModificar.TabIndex = 28;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.BackColor = Color.FromArgb(224, 224, 224);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(715, 91);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(143, 47);
            btnEliminar.TabIndex = 29;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(366, 22);
            label6.Name = "label6";
            label6.Size = new Size(0, 34);
            label6.TabIndex = 30;
            // 
            // dataGridViewPizzas
            // 
            dataGridViewPizzas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPizzas.Location = new Point(12, 389);
            dataGridViewPizzas.Name = "dataGridViewPizzas";
            dataGridViewPizzas.RowHeadersWidth = 62;
            dataGridViewPizzas.Size = new Size(860, 149);
            dataGridViewPizzas.TabIndex = 31;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(btnRegresar);
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(884, 39);
            panel2.TabIndex = 32;
            // 
            // btnRegresar
            // 
            btnRegresar.BackgroundImage = (Image)resources.GetObject("btnRegresar.BackgroundImage");
            btnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Location = new Point(797, 5);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(28, 31);
            btnRegresar.TabIndex = 36;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(844, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(28, 31);
            btnCerrar.TabIndex = 35;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(417, 9);
            label7.Name = "label7";
            label7.Size = new Size(80, 28);
            label7.TabIndex = 3;
            label7.Text = "Pizzas";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(210, 296);
            label8.Name = "label8";
            label8.Size = new Size(87, 22);
            label8.TabIndex = 33;
            label8.Text = "Tamaño:";
            // 
            // cmbTamaño
            // 
            cmbTamaño.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbTamaño.FormattingEnabled = true;
            cmbTamaño.Location = new Point(303, 291);
            cmbTamaño.Name = "cmbTamaño";
            cmbTamaño.Size = new Size(215, 33);
            cmbTamaño.TabIndex = 34;
            // 
            // frmAdminPizzas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(884, 566);
            Controls.Add(cmbTamaño);
            Controls.Add(label8);
            Controls.Add(panel2);
            Controls.Add(dataGridViewPizzas);
            Controls.Add(label6);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtDescripcion);
            Controls.Add(label5);
            Controls.Add(txtIdPizza);
            Controls.Add(label4);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdminPizzas";
            Text = "frmAgregarMenuCombo";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPizzas).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtPrecio;
        private Label label4;
        private TextBox txtIdPizza;
        private Label label5;
        private TextBox txtDescripcion;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label label6;
        private DataGridView dataGridViewPizzas;
        private Panel panel2;
        private Label label7;
        private Label label8;
        private ComboBox cmbTamaño;
        private Button btnCerrar;
        private Button btnRegresar;
    }
}