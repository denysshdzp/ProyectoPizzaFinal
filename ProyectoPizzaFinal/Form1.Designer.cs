namespace ProyectoPizzaFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblLogin = new Label();
            lblUsuario = new Label();
            lblContra = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnIniciar = new Button();
            linRecuperarContraseña = new LinkLabel();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Pizza_Fondo_Negro;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 435);
            panel1.TabIndex = 0;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = SystemColors.ButtonFace;
            lblLogin.Location = new Point(450, 46);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(256, 38);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "INICIAR SESIÓN";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = SystemColors.ButtonFace;
            lblUsuario.Location = new Point(404, 133);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(122, 34);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario:";
            // 
            // lblContra
            // 
            lblContra.AutoSize = true;
            lblContra.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContra.ForeColor = SystemColors.ButtonFace;
            lblContra.Location = new Point(346, 199);
            lblContra.Name = "lblContra";
            lblContra.Size = new Size(180, 34);
            lblContra.TabIndex = 3;
            lblContra.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(524, 135);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(258, 31);
            txtUsuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(524, 199);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(258, 31);
            txtContraseña.TabIndex = 5;
            // 
            // btnIniciar
            // 
            btnIniciar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            btnIniciar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnIniciar.ForeColor = SystemColors.ButtonFace;
            btnIniciar.Location = new Point(450, 288);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(282, 51);
            btnIniciar.TabIndex = 6;
            btnIniciar.Text = "Iniciar Sesión";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // linRecuperarContraseña
            // 
            linRecuperarContraseña.AutoSize = true;
            linRecuperarContraseña.LinkColor = Color.White;
            linRecuperarContraseña.Location = new Point(511, 356);
            linRecuperarContraseña.Name = "linRecuperarContraseña";
            linRecuperarContraseña.Size = new Size(0, 25);
            linRecuperarContraseña.TabIndex = 7;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(767, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(28, 31);
            btnCerrar.TabIndex = 8;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Form1
            // 
            AcceptButton = btnIniciar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            CancelButton = btnCerrar;
            ClientSize = new Size(820, 435);
            Controls.Add(btnCerrar);
            Controls.Add(linRecuperarContraseña);
            Controls.Add(btnIniciar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblContra);
            Controls.Add(lblUsuario);
            Controls.Add(lblLogin);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblLogin;
        private Label lblUsuario;
        private Label lblContra;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnIniciar;
        private LinkLabel linRecuperarContraseña;
        private Button btnCerrar;
    }
}
