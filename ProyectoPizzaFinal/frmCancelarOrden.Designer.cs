namespace ProyectoPizzaFinal
{
    partial class frmCancelarOrden
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
            label1 = new Label();
            btnIniciar = new Button();
            button1 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(16, 34);
            label1.Name = "label1";
            label1.Size = new Size(556, 28);
            label1.TabIndex = 0;
            label1.Text = "¿Estas seguro que quieres cancelar el pedido?";
            // 
            // btnIniciar
            // 
            btnIniciar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnIniciar.BackColor = Color.FromArgb(128, 255, 128);
            btnIniciar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            btnIniciar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnIniciar.ForeColor = SystemColors.ActiveCaptionText;
            btnIniciar.Location = new Point(321, 146);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(235, 52);
            btnIniciar.TabIndex = 28;
            btnIniciar.Text = "SI";
            btnIniciar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(72, 146);
            button1.Name = "button1";
            button1.Size = new Size(230, 52);
            button1.TabIndex = 29;
            button1.Text = "NO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnIniciar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(21, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(611, 225);
            panel1.TabIndex = 30;
            // 
            // frmCancelarOrden
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(653, 249);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCancelarOrden";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCancelarOrden";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnIniciar;
        private Button button1;
        private Panel panel1;
    }
}