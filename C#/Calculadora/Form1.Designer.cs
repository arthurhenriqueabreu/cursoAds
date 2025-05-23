namespace Calculadora
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
            txtCalculadora = new Label();
            lblNum1 = new Label();
            lblNum2 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            btnSomar = new Button();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // txtCalculadora
            // 
            txtCalculadora.AutoSize = true;
            txtCalculadora.Font = new Font("Segoe UI", 29F, FontStyle.Bold);
            txtCalculadora.Location = new Point(66, 23);
            txtCalculadora.Name = "txtCalculadora";
            txtCalculadora.Size = new Size(238, 52);
            txtCalculadora.TabIndex = 0;
            txtCalculadora.Text = "Calculadora";
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Segoe UI", 20F);
            lblNum1.Location = new Point(79, 93);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(216, 37);
            lblNum1.TabIndex = 1;
            lblNum1.Text = "Primeiro número";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Font = new Font("Segoe UI", 20F);
            lblNum2.Location = new Point(81, 221);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(222, 37);
            lblNum2.TabIndex = 2;
            lblNum2.Text = "Segundo número";
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Segoe UI", 20F);
            txtNum1.Location = new Point(130, 146);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(122, 43);
            txtNum1.TabIndex = 3;
            txtNum1.TextChanged += txtNum1_TextChanged;
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Segoe UI", 20F);
            txtNum2.Location = new Point(130, 297);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(122, 43);
            txtNum2.TabIndex = 4;
            // 
            // btnSomar
            // 
            btnSomar.Font = new Font("Segoe UI", 20F);
            btnSomar.Location = new Point(110, 357);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(161, 67);
            btnSomar.TabIndex = 5;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 20F);
            txtResultado.Location = new Point(130, 447);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(122, 43);
            txtResultado.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 515);
            Controls.Add(txtResultado);
            Controls.Add(btnSomar);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Controls.Add(txtCalculadora);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtCalculadora;
        private Label lblNum1;
        private Label lblNum2;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button btnSomar;
        private TextBox txtResultado;
    }
}
