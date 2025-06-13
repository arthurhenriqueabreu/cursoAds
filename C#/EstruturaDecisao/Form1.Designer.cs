namespace EstruturaDecisao
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
            txtLado1 = new TextBox();
            lblLado1 = new Label();
            lblLado2 = new Label();
            txtLado2 = new TextBox();
            lblLado3 = new Label();
            txtLado3 = new TextBox();
            btnVerificar = new Button();
            lblResultado = new Label();
            lblResultadoOutput = new Label();
            SuspendLayout();
            // 
            // txtLado1
            // 
            txtLado1.Font = new Font("Segoe UI", 15F);
            txtLado1.Location = new Point(151, 46);
            txtLado1.Name = "txtLado1";
            txtLado1.Size = new Size(104, 34);
            txtLado1.TabIndex = 0;
            // 
            // lblLado1
            // 
            lblLado1.AutoSize = true;
            lblLado1.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLado1.Location = new Point(57, 50);
            lblLado1.Name = "lblLado1";
            lblLado1.Size = new Size(73, 30);
            lblLado1.TabIndex = 1;
            lblLado1.Text = "Lado 1";
            // 
            // lblLado2
            // 
            lblLado2.AutoSize = true;
            lblLado2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLado2.Location = new Point(57, 105);
            lblLado2.Name = "lblLado2";
            lblLado2.Size = new Size(73, 30);
            lblLado2.TabIndex = 3;
            lblLado2.Text = "Lado 2";
            lblLado2.Click += label1_Click;
            // 
            // txtLado2
            // 
            txtLado2.Font = new Font("Segoe UI", 15F);
            txtLado2.Location = new Point(151, 101);
            txtLado2.Name = "txtLado2";
            txtLado2.Size = new Size(104, 34);
            txtLado2.TabIndex = 2;
            // 
            // lblLado3
            // 
            lblLado3.AutoSize = true;
            lblLado3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLado3.Location = new Point(57, 166);
            lblLado3.Name = "lblLado3";
            lblLado3.Size = new Size(73, 30);
            lblLado3.TabIndex = 5;
            lblLado3.Text = "Lado 3";
            // 
            // txtLado3
            // 
            txtLado3.Font = new Font("Segoe UI", 15F);
            txtLado3.Location = new Point(151, 162);
            txtLado3.Name = "txtLado3";
            txtLado3.Size = new Size(104, 34);
            txtLado3.TabIndex = 4;
            // 
            // btnVerificar
            // 
            btnVerificar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerificar.Location = new Point(118, 222);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(137, 46);
            btnVerificar.TabIndex = 6;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(57, 281);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(105, 30);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado:";
            // 
            // lblResultadoOutput
            // 
            lblResultadoOutput.AutoSize = true;
            lblResultadoOutput.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultadoOutput.Location = new Point(168, 281);
            lblResultadoOutput.Name = "lblResultadoOutput";
            lblResultadoOutput.Size = new Size(99, 30);
            lblResultadoOutput.TabIndex = 8;
            lblResultadoOutput.Text = "Resultado";
            lblResultadoOutput.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 338);
            Controls.Add(lblResultadoOutput);
            Controls.Add(lblResultado);
            Controls.Add(btnVerificar);
            Controls.Add(lblLado3);
            Controls.Add(txtLado3);
            Controls.Add(lblLado2);
            Controls.Add(txtLado2);
            Controls.Add(lblLado1);
            Controls.Add(txtLado1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLado1;
        private Label lblLado1;
        private Label lblLado2;
        private TextBox txtLado2;
        private Label lblLado3;
        private TextBox txtLado3;
        private Button btnVerificar;
        private Label lblResultado;
        private Label lblResultadoOutput;
    }
}
