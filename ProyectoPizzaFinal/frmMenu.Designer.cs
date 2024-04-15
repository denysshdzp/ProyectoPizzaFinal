namespace ProyectoPizzaFinal
{
    partial class frmMenu
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
            panel1 = new Panel();
            panel11 = new Panel();
            btnAdministrar = new Button();
            panel10 = new Panel();
            btnInforme = new Button();
            btnPromociones = new Button();
            panel9 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel7 = new Panel();
            panel6 = new Panel();
            btnComplemento = new Button();
            panel5 = new Panel();
            panel4 = new Panel();
            panel8 = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnPizza = new Button();
            pictureBox1 = new PictureBox();
            btnCerrarSesion = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            btnCancelarOrden = new Button();
            btnPagar = new Button();
            dataGridView1 = new DataGridView();
            lblOrden = new Label();
            pContenido = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(btnAdministrar);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(btnInforme);
            panel1.Controls.Add(btnPromociones);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(btnComplemento);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnPizza);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 738);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(128, 255, 128);
            panel11.Location = new Point(0, 513);
            panel11.Name = "panel11";
            panel11.Size = new Size(10, 64);
            panel11.TabIndex = 9;
            // 
            // btnAdministrar
            // 
            btnAdministrar.FlatAppearance.BorderSize = 0;
            btnAdministrar.FlatStyle = FlatStyle.Flat;
            btnAdministrar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdministrar.ForeColor = SystemColors.ButtonFace;
            btnAdministrar.Location = new Point(9, 513);
            btnAdministrar.Name = "btnAdministrar";
            btnAdministrar.Size = new Size(229, 64);
            btnAdministrar.TabIndex = 12;
            btnAdministrar.Text = "Administrar";
            btnAdministrar.UseVisualStyleBackColor = true;
            btnAdministrar.Click += btnAdministrar_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(128, 255, 128);
            panel10.Location = new Point(0, 443);
            panel10.Name = "panel10";
            panel10.Size = new Size(10, 64);
            panel10.TabIndex = 8;
            // 
            // btnInforme
            // 
            btnInforme.FlatAppearance.BorderSize = 0;
            btnInforme.FlatStyle = FlatStyle.Flat;
            btnInforme.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInforme.ForeColor = SystemColors.ButtonFace;
            btnInforme.Location = new Point(10, 443);
            btnInforme.Name = "btnInforme";
            btnInforme.Size = new Size(229, 64);
            btnInforme.TabIndex = 11;
            btnInforme.Text = "Informe de Venta";
            btnInforme.UseVisualStyleBackColor = true;
            btnInforme.Click += button3_Click_1;
            // 
            // btnPromociones
            // 
            btnPromociones.FlatAppearance.BorderSize = 0;
            btnPromociones.FlatStyle = FlatStyle.Flat;
            btnPromociones.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPromociones.ForeColor = SystemColors.ButtonFace;
            btnPromociones.Location = new Point(10, 367);
            btnPromociones.Name = "btnPromociones";
            btnPromociones.Size = new Size(226, 64);
            btnPromociones.TabIndex = 10;
            btnPromociones.Text = "Promociones";
            btnPromociones.UseVisualStyleBackColor = true;
            btnPromociones.Click += btnPromociones_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(128, 255, 128);
            panel9.Location = new Point(1, 367);
            panel9.Name = "panel9";
            panel9.Size = new Size(10, 64);
            panel9.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(73, 628);
            label2.Name = "label2";
            label2.Size = new Size(75, 22);
            label2.TabIndex = 9;
            label2.Text = "Usuario";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.BackgroundImage = Properties.Resources.USUARIO;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(82, 547);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 67);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(128, 255, 128);
            panel7.Location = new Point(0, 297);
            panel7.Name = "panel7";
            panel7.Size = new Size(10, 64);
            panel7.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(128, 255, 128);
            panel6.Location = new Point(1, 185);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 47);
            panel6.TabIndex = 5;
            // 
            // btnComplemento
            // 
            btnComplemento.FlatAppearance.BorderSize = 0;
            btnComplemento.FlatStyle = FlatStyle.Flat;
            btnComplemento.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComplemento.ForeColor = SystemColors.ButtonFace;
            btnComplemento.Location = new Point(11, 185);
            btnComplemento.Name = "btnComplemento";
            btnComplemento.Size = new Size(225, 46);
            btnComplemento.TabIndex = 4;
            btnComplemento.Text = "Complementos";
            btnComplemento.UseVisualStyleBackColor = true;
            btnComplemento.Click += btnComplemento_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(128, 255, 128);
            panel5.Location = new Point(1, 133);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 47);
            panel5.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(128, 255, 128);
            panel4.Controls.Add(panel8);
            panel4.Location = new Point(1, 238);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 47);
            panel4.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.Location = new Point(9, 42);
            panel8.Name = "panel8";
            panel8.Size = new Size(226, 81);
            panel8.TabIndex = 7;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(11, 294);
            button2.Name = "button2";
            button2.Size = new Size(227, 64);
            button2.TabIndex = 6;
            button2.Text = "Pedidos Pendientes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(14, 134);
            button1.Name = "button1";
            button1.Size = new Size(227, 46);
            button1.TabIndex = 5;
            button1.Text = "Combos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnPizza
            // 
            btnPizza.FlatAppearance.BorderSize = 0;
            btnPizza.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            btnPizza.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btnPizza.FlatStyle = FlatStyle.Flat;
            btnPizza.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPizza.ForeColor = SystemColors.ButtonFace;
            btnPizza.Location = new Point(10, 237);
            btnPizza.Name = "btnPizza";
            btnPizza.Size = new Size(231, 46);
            btnPizza.TabIndex = 3;
            btnPizza.Text = "Pizzas";
            btnPizza.UseVisualStyleBackColor = true;
            btnPizza.Click += btnPizza_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(62, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 108);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = SystemColors.ButtonHighlight;
            btnCerrarSesion.Location = new Point(38, 664);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(147, 48);
            btnCerrarSesion.TabIndex = 0;
            btnCerrarSesion.Text = "Cerrar Sesion.";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(239, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(816, 39);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(413, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 3;
            label1.Text = "Menú";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(255, 255, 192);
            panel3.Controls.Add(btnCancelarOrden);
            panel3.Controls.Add(btnPagar);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(lblOrden);
            panel3.Location = new Point(239, 524);
            panel3.Name = "panel3";
            panel3.Size = new Size(816, 214);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // btnCancelarOrden
            // 
            btnCancelarOrden.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelarOrden.BackColor = Color.Red;
            btnCancelarOrden.FlatStyle = FlatStyle.Flat;
            btnCancelarOrden.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarOrden.ForeColor = Color.Black;
            btnCancelarOrden.Location = new Point(180, 166);
            btnCancelarOrden.Name = "btnCancelarOrden";
            btnCancelarOrden.Size = new Size(208, 37);
            btnCancelarOrden.TabIndex = 3;
            btnCancelarOrden.Text = "Cancelar Orden";
            btnCancelarOrden.UseVisualStyleBackColor = false;
            btnCancelarOrden.Click += btnCancelarOrden_Click;
            // 
            // btnPagar
            // 
            btnPagar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPagar.BackColor = Color.Lime;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagar.ForeColor = Color.Black;
            btnPagar.Location = new Point(498, 166);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(174, 37);
            btnPagar.TabIndex = 2;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.AntiqueWhite;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(728, 112);
            dataGridView1.TabIndex = 1;
            // 
            // lblOrden
            // 
            lblOrden.Anchor = AnchorStyles.Bottom;
            lblOrden.AutoSize = true;
            lblOrden.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrden.Location = new Point(378, 19);
            lblOrden.Name = "lblOrden";
            lblOrden.Size = new Size(85, 26);
            lblOrden.TabIndex = 0;
            lblOrden.Text = "Orden:";
            // 
            // pContenido
            // 
            pContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pContenido.Location = new Point(239, 39);
            pContenido.Name = "pContenido";
            pContenido.Size = new Size(816, 501);
            pContenido.TabIndex = 3;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 738);
            Controls.Add(pContenido);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMenu";
            Text = "frmMenu";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnCerrarSesion;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label lblOrden;
        private Button btnPizza;
        private Panel panel5;
        private Panel panel4;
        private Button button2;
        private Button button1;
        private Button btnComplemento;
        private Panel panel7;
        private Panel panel6;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnPagar;
        private Button btnCancelarOrden;
        private Panel panel8;
        private Panel pContenido;
        private Label label2;
        private PictureBox pictureBox2;
        private Button btnPromociones;
        private Panel panel9;
        private Button btnInforme;
        private Panel panel10;
        private Panel panel11;
        private Button btnAdministrar;
    }
}