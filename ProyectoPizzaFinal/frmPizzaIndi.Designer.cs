namespace ProyectoPizzaFinal
{
    partial class frmPizzaIndi
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
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            textBox1 = new TextBox();
            btnIniciar = new Button();
            button2 = new Button();
            label5 = new Label();
            comboBox3 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(312, 24);
            label1.Name = "label1";
            label1.Size = new Size(348, 51);
            label1.TabIndex = 1;
            label1.Text = "Pizza Individual";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(327, 104);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 2;
            label2.Text = "Tamaño:";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(458, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(215, 33);
            comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(270, 157);
            label3.Name = "label3";
            label3.Size = new Size(170, 28);
            label3.TabIndex = 4;
            label3.Text = "Especialidad:";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(458, 152);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(215, 33);
            comboBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(290, 220);
            label4.Name = "label4";
            label4.Size = new Size(150, 56);
            label4.TabIndex = 6;
            label4.Text = "Comentario\r\nAdicional:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(446, 220);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 75);
            textBox1.TabIndex = 7;
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
            btnIniciar.Location = new Point(525, 469);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(230, 51);
            btnIniciar.TabIndex = 8;
            btnIniciar.Text = "Agregar al Pedido";
            btnIniciar.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = Color.Tan;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(290, 469);
            button2.Name = "button2";
            button2.Size = new Size(169, 51);
            button2.TabIndex = 10;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(241, 338);
            label5.Name = "label5";
            label5.Size = new Size(225, 28);
            label5.TabIndex = 11;
            label5.Text = "Ingrediente extra: ";
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(458, 333);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(215, 33);
            comboBox3.TabIndex = 12;
            // 
            // frmPizzaIndi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1020, 631);
            Controls.Add(comboBox3);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(btnIniciar);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPizzaIndi";
            Text = "frmPizzaIndi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private TextBox textBox1;
        private Button btnIniciar;
        private Button button2;
        private Label label5;
        private ComboBox comboBox3;
    }
}