namespace WinFormsBarCode
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
            txtCodigo = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnGerarCodigoBarras = new Button();
            label2 = new Label();
            txtDecode = new TextBox();
            btnDecode = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(84, 25);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(259, 23);
            txtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 28);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Código:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(84, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 50);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnGerarCodigoBarras
            // 
            btnGerarCodigoBarras.Location = new Point(357, 28);
            btnGerarCodigoBarras.Name = "btnGerarCodigoBarras";
            btnGerarCodigoBarras.Size = new Size(144, 23);
            btnGerarCodigoBarras.TabIndex = 3;
            btnGerarCodigoBarras.Text = "Gerar Código de Barras";
            btnGerarCodigoBarras.UseVisualStyleBackColor = true;
            btnGerarCodigoBarras.Click += btnGerarCodigoBarras_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 161);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "Decode";
            // 
            // txtDecode
            // 
            txtDecode.Location = new Point(93, 161);
            txtDecode.Name = "txtDecode";
            txtDecode.Size = new Size(250, 23);
            txtDecode.TabIndex = 5;
            // 
            // btnDecode
            // 
            btnDecode.Location = new Point(366, 164);
            btnDecode.Name = "btnDecode";
            btnDecode.Size = new Size(135, 23);
            btnDecode.TabIndex = 6;
            btnDecode.Text = "Decodificar";
            btnDecode.UseVisualStyleBackColor = true;
            btnDecode.Click += btnDecode_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 236);
            Controls.Add(btnDecode);
            Controls.Add(txtDecode);
            Controls.Add(label2);
            Controls.Add(btnGerarCodigoBarras);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtCodigo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnGerarCodigoBarras;
        private Label label2;
        private TextBox txtDecode;
        private Button btnDecode;
    }
}
