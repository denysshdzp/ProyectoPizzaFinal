namespace ProyectoPizzaFinal
{
    partial class frmAdminPromociones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminPromociones));
            panel2 = new Panel();
            btnRegresar = new Button();
            btnCerrar = new Button();
            label7 = new Label();
            dataGridViewPromociones = new DataGridView();
            label6 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            txtCantidad = new TextBox();
            label5 = new Label();
            txtIdPromocion = new TextBox();
            label4 = new Label();
            txtCodigo = new TextBox();
            label3 = new Label();
            txtDescripcion = new TextBox();
            label2 = new Label();
            label8 = new Label();
            label1 = new Label();
            label9 = new Label();
            dtFechaInicio = new DateTimePicker();
            dtFechaFin = new DateTimePicker();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPromociones).BeginInit();
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
            panel2.TabIndex = 63;
            // 
            // btnRegresar
            // 
            btnRegresar.BackgroundImage = (Image)resources.GetObject("btnRegresar.BackgroundImage");
            btnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Location = new Point(801, 3);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(28, 31);
            btnRegresar.TabIndex = 70;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(844, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(28, 31);
            btnCerrar.TabIndex = 69;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(389, 9);
            label7.Name = "label7";
            label7.Size = new Size(162, 28);
            label7.TabIndex = 3;
            label7.Text = "Promociones";
            // 
            // dataGridViewPromociones
            // 
            dataGridViewPromociones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPromociones.Location = new Point(12, 387);
            dataGridViewPromociones.Name = "dataGridViewPromociones";
            dataGridViewPromociones.RowHeadersWidth = 62;
            dataGridViewPromociones.Size = new Size(860, 172);
            dataGridViewPromociones.TabIndex = 62;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(366, 43);
            label6.Name = "label6";
            label6.Size = new Size(0, 34);
            label6.TabIndex = 61;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.BackColor = Color.FromArgb(224, 224, 224);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(715, 112);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(143, 47);
            btnEliminar.TabIndex = 60;
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
            btnModificar.Location = new Point(715, 174);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(143, 47);
            btnModificar.TabIndex = 59;
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
            btnAgregar.Location = new Point(715, 237);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(143, 47);
            btnAgregar.TabIndex = 58;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += button1_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCantidad.Location = new Point(294, 215);
            txtCantidad.Multiline = true;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(273, 33);
            txtCantidad.TabIndex = 57;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(201, 215);
            label5.Name = "label5";
            label5.Size = new Size(97, 22);
            label5.TabIndex = 56;
            label5.Text = "Cantidad:";
            // 
            // txtIdPromocion
            // 
            txtIdPromocion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIdPromocion.Location = new Point(341, 92);
            txtIdPromocion.Name = "txtIdPromocion";
            txtIdPromocion.Size = new Size(273, 31);
            txtIdPromocion.TabIndex = 55;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(201, 97);
            label4.Name = "label4";
            label4.Size = new Size(134, 22);
            label4.TabIndex = 54;
            label4.Text = "ID Promoción:";
            // 
            // txtCodigo
            // 
            txtCodigo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCodigo.Location = new Point(278, 169);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(273, 31);
            txtCodigo.TabIndex = 53;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(201, 174);
            label3.Name = "label3";
            label3.Size = new Size(81, 22);
            label3.TabIndex = 52;
            label3.Text = "Código:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcion.Location = new Point(328, 132);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(273, 31);
            txtDescripcion.TabIndex = 51;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(201, 137);
            label2.Name = "label2";
            label2.Size = new Size(121, 22);
            label2.TabIndex = 50;
            label2.Text = "Descripción:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(355, 43);
            label8.Name = "label8";
            label8.Size = new Size(0, 22);
            label8.TabIndex = 49;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(201, 300);
            label1.Name = "label1";
            label1.Size = new Size(100, 22);
            label1.TabIndex = 66;
            label1.Text = "Fecha Fin:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(201, 259);
            label9.Name = "label9";
            label9.Size = new Size(124, 22);
            label9.TabIndex = 64;
            label9.Text = "Fecha Inicio:";
            // 
            // dtFechaInicio
            // 
            dtFechaInicio.Location = new Point(331, 254);
            dtFechaInicio.Name = "dtFechaInicio";
            dtFechaInicio.Size = new Size(300, 31);
            dtFechaInicio.TabIndex = 67;
            // 
            // dtFechaFin
            // 
            dtFechaFin.Location = new Point(307, 293);
            dtFechaFin.Name = "dtFechaFin";
            dtFechaFin.Size = new Size(300, 31);
            dtFechaFin.TabIndex = 68;
            // 
            // frmAdminPromociones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(884, 566);
            Controls.Add(dtFechaFin);
            Controls.Add(dtFechaInicio);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(panel2);
            Controls.Add(dataGridViewPromociones);
            Controls.Add(label6);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtCantidad);
            Controls.Add(label5);
            Controls.Add(txtIdPromocion);
            Controls.Add(label4);
            Controls.Add(txtCodigo);
            Controls.Add(label3);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdminPromociones";
            Text = "AdminPromociones";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPromociones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label7;
        private DataGridView dataGridViewPromociones;
        private Label label6;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private TextBox txtCantidad;
        private Label label5;
        private TextBox txtIdPromocion;
        private Label label4;
        private TextBox txtCodigo;
        private Label label3;
        private TextBox txtDescripcion;
        private Label label2;
        private Label label8;
        private Label label1;
        private Label label9;
        private DateTimePicker dtFechaInicio;
        private DateTimePicker dtFechaFin;
        private Button btnCerrar;
        private Button btnRegresar;
    }
}