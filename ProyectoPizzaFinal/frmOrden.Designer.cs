namespace ProyectoPizzaFinal
{
    partial class frmOrden
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
            dataGridView1 = new DataGridView();
            btnIniciar = new Button();
            button1 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 33);
            label1.Name = "label1";
            label1.Size = new Size(343, 34);
            label1.TabIndex = 23;
            label1.Text = "¿Tu pedido es correcto?";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(92, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(321, 284);
            dataGridView1.TabIndex = 24;
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
            btnIniciar.Location = new Point(227, 449);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(282, 69);
            btnIniciar.TabIndex = 27;
            btnIniciar.Text = "SI\r\nProceder al pago\r\n";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
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
            button1.Location = new Point(23, 449);
            button1.Name = "button1";
            button1.Size = new Size(178, 69);
            button1.TabIndex = 28;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnIniciar);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 570);
            panel1.TabIndex = 29;
            // 
            // frmOrden
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(552, 605);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmOrden";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmOrden";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btnIniciar;
        private Button button1;
        private Panel panel1;
    }
}