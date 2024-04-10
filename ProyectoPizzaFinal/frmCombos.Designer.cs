namespace ProyectoPizzaFinal
{
    partial class frmCombos
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
            button2 = new Button();
            btnIniciar = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
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
            button2.Location = new Point(182, 309);
            button2.Name = "button2";
            button2.Size = new Size(169, 51);
            button2.TabIndex = 28;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;
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
            btnIniciar.Location = new Point(368, 309);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(282, 51);
            btnIniciar.TabIndex = 26;
            btnIniciar.Text = "Agregar al Pedido";
            btnIniciar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(318, 164);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 111);
            textBox1.TabIndex = 25;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(162, 164);
            label4.Name = "label4";
            label4.Size = new Size(150, 56);
            label4.TabIndex = 24;
            label4.Text = "Comentario\r\nAdicional:";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(318, 101);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(169, 33);
            comboBox2.TabIndex = 23;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(204, 106);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 22;
            label3.Text = "Combo:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 24);
            label1.Name = "label1";
            label1.Size = new Size(201, 51);
            label1.TabIndex = 21;
            label1.Text = "Combos";
            // 
            // frmCombos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(843, 496);
            Controls.Add(button2);
            Controls.Add(btnIniciar);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCombos";
            Text = "frmCombos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button btnIniciar;
        private TextBox textBox1;
        private Label label4;
        private ComboBox comboBox2;
        private Label label3;
        private Label label1;
    }
}