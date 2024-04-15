namespace ProyectoPizzaFinal
{
    partial class frmAdminCombos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminCombos));
            label1 = new Label();
            panel2 = new Panel();
            btnRegresar = new Button();
            btnCerrar = new Button();
            label7 = new Label();
            dataGridViewCombos = new DataGridView();
            label6 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            txtDescripcion = new TextBox();
            label5 = new Label();
            txtIdCombo = new TextBox();
            label4 = new Label();
            txtPrecio = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            label8 = new Label();
            cmbTamaño = new ComboBox();
            label9 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCombos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(319, -22);
            label1.Name = "label1";
            label1.Size = new Size(0, 22);
            label1.TabIndex = 33;
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
            panel2.TabIndex = 48;
            // 
            // btnRegresar
            // 
            btnRegresar.BackgroundImage = (Image)resources.GetObject("btnRegresar.BackgroundImage");
            btnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Location = new Point(799, 6);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(28, 31);
            btnRegresar.TabIndex = 52;
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
            btnCerrar.TabIndex = 51;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(427, 9);
            label7.Name = "label7";
            label7.Size = new Size(111, 28);
            label7.TabIndex = 3;
            label7.Text = "Combos";
            // 
            // dataGridViewCombos
            // 
            dataGridViewCombos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCombos.Location = new Point(12, 399);
            dataGridViewCombos.Name = "dataGridViewCombos";
            dataGridViewCombos.RowHeadersWidth = 62;
            dataGridViewCombos.Size = new Size(860, 153);
            dataGridViewCombos.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(366, 36);
            label6.Name = "label6";
            label6.Size = new Size(0, 34);
            label6.TabIndex = 46;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.BackColor = Color.FromArgb(224, 224, 224);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(715, 105);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(143, 47);
            btnEliminar.TabIndex = 45;
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
            btnModificar.Location = new Point(715, 167);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(143, 47);
            btnModificar.TabIndex = 44;
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
            btnAgregar.Location = new Point(715, 230);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(143, 47);
            btnAgregar.TabIndex = 43;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcion.Location = new Point(325, 208);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(273, 81);
            txtDescripcion.TabIndex = 42;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(201, 208);
            label5.Name = "label5";
            label5.Size = new Size(121, 22);
            label5.TabIndex = 41;
            label5.Text = "Descripción:";
            // 
            // txtIdCombo
            // 
            txtIdCombo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIdCombo.Location = new Point(325, 85);
            txtIdCombo.Name = "txtIdCombo";
            txtIdCombo.Size = new Size(273, 31);
            txtIdCombo.TabIndex = 40;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(201, 90);
            label4.Name = "label4";
            label4.Size = new Size(105, 22);
            label4.TabIndex = 39;
            label4.Text = "ID Combo:";
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrecio.Location = new Point(278, 162);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(273, 31);
            txtPrecio.TabIndex = 38;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(201, 167);
            label3.Name = "label3";
            label3.Size = new Size(71, 22);
            label3.TabIndex = 37;
            label3.Text = "Precio:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(294, 121);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(273, 31);
            txtNombre.TabIndex = 36;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(201, 130);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 35;
            label2.Text = "Nombre:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(355, 36);
            label8.Name = "label8";
            label8.Size = new Size(0, 22);
            label8.TabIndex = 34;
            // 
            // cmbTamaño
            // 
            cmbTamaño.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbTamaño.FormattingEnabled = true;
            cmbTamaño.Location = new Point(294, 304);
            cmbTamaño.Name = "cmbTamaño";
            cmbTamaño.Size = new Size(215, 33);
            cmbTamaño.TabIndex = 50;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(201, 315);
            label9.Name = "label9";
            label9.Size = new Size(87, 22);
            label9.TabIndex = 49;
            label9.Text = "Tamaño:";
            // 
            // frmAdminCombos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(884, 566);
            Controls.Add(cmbTamaño);
            Controls.Add(label9);
            Controls.Add(panel2);
            Controls.Add(dataGridViewCombos);
            Controls.Add(label6);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtDescripcion);
            Controls.Add(label5);
            Controls.Add(txtIdCombo);
            Controls.Add(label4);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdminCombos";
            Text = "frmAdminCombos";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCombos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel2;
        private Label label7;
        private DataGridView dataGridViewCombos;
        private Label label6;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private TextBox txtDescripcion;
        private Label label5;
        private TextBox txtIdCombo;
        private Label label4;
        private TextBox txtPrecio;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private Label label8;
        private ComboBox cmbTamaño;
        private Label label9;
        private Button btnCerrar;
        private Button btnRegresar;
    }
}