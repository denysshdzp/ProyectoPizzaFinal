namespace ProyectoPizzaFinal
{
    partial class frmPagar
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
            label2 = new Label();
            label1 = new Label();
            btnEfectivo = new Button();
            button2 = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 65);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(210, 15);
            label2.Name = "label2";
            label2.Size = new Size(350, 34);
            label2.TabIndex = 2;
            label2.Text = "Seleccione tipo de Pago";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(152, 266);
            label1.Name = "label1";
            label1.Size = new Size(123, 34);
            label1.TabIndex = 1;
            label1.Text = "Efectivo";
            // 
            // btnEfectivo
            // 
            btnEfectivo.BackgroundImage = Properties.Resources.Efectivo;
            btnEfectivo.BackgroundImageLayout = ImageLayout.Stretch;
            btnEfectivo.FlatAppearance.BorderSize = 0;
            btnEfectivo.FlatStyle = FlatStyle.Flat;
            btnEfectivo.Location = new Point(115, 96);
            btnEfectivo.Name = "btnEfectivo";
            btnEfectivo.Size = new Size(212, 157);
            btnEfectivo.TabIndex = 1;
            btnEfectivo.UseVisualStyleBackColor = true;
            btnEfectivo.Click += btnEfectivo_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.tarjeta_de_credito;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(406, 96);
            button2.Name = "button2";
            button2.Size = new Size(208, 157);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(461, 266);
            label3.Name = "label3";
            label3.Size = new Size(105, 34);
            label3.TabIndex = 3;
            label3.Text = "Tarjeta";
            // 
            // frmPagar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 339);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(btnEfectivo);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPagar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPagar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button btnEfectivo;
        private Button button2;
        private Label label3;
    }
}