namespace ProyectoPizzaFinal
{
    partial class frmAdminIngredienteExtra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminIngredienteExtra));
            panel2 = new Panel();
            btnRegresar = new Button();
            btnCerrar = new Button();
            label7 = new Label();
            dataGridViewIngredienteExtra = new DataGridView();
            label6 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            txtDescripcion = new TextBox();
            label5 = new Label();
            txtIdIngrediente = new TextBox();
            label4 = new Label();
            txtPrecio = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            label8 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngredienteExtra).BeginInit();
            SuspendLayout();
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
            panel2.TabIndex = 78;
            // 
            // btnRegresar
            // 
            btnRegresar.BackgroundImage = (Image)resources.GetObject("btnRegresar.BackgroundImage");
            btnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Location = new Point(801, 5);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(28, 31);
            btnRegresar.TabIndex = 80;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(847, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(28, 31);
            btnCerrar.TabIndex = 79;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(350, 9);
            label7.Name = "label7";
            label7.Size = new Size(211, 28);
            label7.TabIndex = 3;
            label7.Text = "Ingrediente extra";
            // 
            // dataGridViewIngredienteExtra
            // 
            dataGridViewIngredienteExtra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIngredienteExtra.Location = new Point(7, 324);
            dataGridViewIngredienteExtra.Name = "dataGridViewIngredienteExtra";
            dataGridViewIngredienteExtra.RowHeadersWidth = 62;
            dataGridViewIngredienteExtra.Size = new Size(860, 225);
            dataGridViewIngredienteExtra.TabIndex = 77;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(361, 33);
            label6.Name = "label6";
            label6.Size = new Size(0, 34);
            label6.TabIndex = 76;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.BackColor = Color.FromArgb(224, 224, 224);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(732, 102);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(143, 47);
            btnEliminar.TabIndex = 75;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModificar.BackColor = Color.FromArgb(224, 224, 224);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(732, 164);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(143, 47);
            btnModificar.TabIndex = 74;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.BackColor = Color.FromArgb(224, 224, 224);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(732, 227);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(143, 47);
            btnAgregar.TabIndex = 73;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcion.Location = new Point(320, 205);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(295, 81);
            txtDescripcion.TabIndex = 72;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(196, 205);
            label5.Name = "label5";
            label5.Size = new Size(121, 22);
            label5.TabIndex = 71;
            label5.Text = "Descripción:";
            // 
            // txtIdIngrediente
            // 
            txtIdIngrediente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIdIngrediente.Location = new Point(367, 82);
            txtIdIngrediente.Name = "txtIdIngrediente";
            txtIdIngrediente.Size = new Size(295, 31);
            txtIdIngrediente.TabIndex = 70;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(196, 87);
            label4.Name = "label4";
            label4.Size = new Size(140, 22);
            label4.TabIndex = 69;
            label4.Text = "ID Ingrediente:";
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrecio.Location = new Point(273, 159);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(295, 31);
            txtPrecio.TabIndex = 68;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(196, 164);
            label3.Name = "label3";
            label3.Size = new Size(71, 22);
            label3.TabIndex = 67;
            label3.Text = "Precio:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(289, 118);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(295, 31);
            txtNombre.TabIndex = 66;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(196, 127);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 65;
            label2.Text = "Nombre:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(350, 33);
            label8.Name = "label8";
            label8.Size = new Size(0, 22);
            label8.TabIndex = 64;
            // 
            // frmAdminIngredienteExtra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(884, 566);
            Controls.Add(panel2);
            Controls.Add(dataGridViewIngredienteExtra);
            Controls.Add(label6);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtDescripcion);
            Controls.Add(label5);
            Controls.Add(txtIdIngrediente);
            Controls.Add(label4);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdminIngredienteExtra";
            Text = "frmAdminIngredienteExtra";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngredienteExtra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label7;
        private DataGridView dataGridViewIngredienteExtra;
        private Label label6;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private TextBox txtDescripcion;
        private Label label5;
        private TextBox txtIdIngrediente;
        private Label label4;
        private TextBox txtPrecio;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private Label label8;
        private Button btnCerrar;
        private Button btnRegresar;
    }
}