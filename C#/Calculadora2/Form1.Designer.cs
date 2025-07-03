namespace Calculadora2
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
            components = new System.ComponentModel.Container();
            btnDivision = new Button();
            btnMultiplication = new Button();
            btnAdittion = new Button();
            btnSubtraction = new Button();
            btnNum9 = new Button();
            btnNum8 = new Button();
            btnNum7 = new Button();
            btnNum6 = new Button();
            btnNum5 = new Button();
            btnNum4 = new Button();
            btnNum3 = new Button();
            btnNum2 = new Button();
            btnNum1 = new Button();
            btnNum0 = new Button();
            btnDelete = new Button();
            btnEnter = new Button();
            btnBackspace = new Button();
            lblResultado = new Label();
            btnVirgula = new Button();
            btnRaizQuadrada = new Button();
            btnPotencia = new Button();
            btnInverter = new Button();
            btnOpcoes = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            calculadoraDeTemperaturaToolStripMenuItem = new ToolStripMenuItem();
            calculadoraDeIMCToolStripMenuItem = new ToolStripMenuItem();
            porcentagemToolStripMenuItem = new ToolStripMenuItem();
            temperaturaToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDivision
            // 
            btnDivision.BackColor = Color.FromArgb(224, 224, 224);
            btnDivision.FlatAppearance.BorderSize = 0;
            btnDivision.FlatStyle = FlatStyle.Flat;
            btnDivision.Font = new Font("Microsoft Sans Serif", 24F);
            btnDivision.ForeColor = Color.White;
            btnDivision.Location = new Point(201, 213);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(94, 43);
            btnDivision.TabIndex = 1;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.BackColor = Color.FromArgb(224, 224, 224);
            btnMultiplication.FlatAppearance.BorderSize = 0;
            btnMultiplication.FlatStyle = FlatStyle.Flat;
            btnMultiplication.Font = new Font("Microsoft Sans Serif", 24F);
            btnMultiplication.ForeColor = Color.White;
            btnMultiplication.Location = new Point(105, 213);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(90, 43);
            btnMultiplication.TabIndex = 2;
            btnMultiplication.Text = "X";
            btnMultiplication.UseVisualStyleBackColor = false;
            btnMultiplication.Click += btnMultiplication_Click;
            // 
            // btnAdittion
            // 
            btnAdittion.BackColor = Color.FromArgb(224, 224, 224);
            btnAdittion.FlatAppearance.BorderSize = 0;
            btnAdittion.FlatStyle = FlatStyle.Flat;
            btnAdittion.Font = new Font("Microsoft Sans Serif", 24F);
            btnAdittion.ForeColor = Color.White;
            btnAdittion.Location = new Point(230, 323);
            btnAdittion.Name = "btnAdittion";
            btnAdittion.Size = new Size(65, 65);
            btnAdittion.TabIndex = 3;
            btnAdittion.Text = "+";
            btnAdittion.UseVisualStyleBackColor = false;
            btnAdittion.Click += btnAdittion_Click;
            // 
            // btnSubtraction
            // 
            btnSubtraction.BackColor = Color.FromArgb(224, 224, 224);
            btnSubtraction.FlatAppearance.BorderSize = 0;
            btnSubtraction.FlatStyle = FlatStyle.Flat;
            btnSubtraction.Font = new Font("Microsoft Sans Serif", 24F);
            btnSubtraction.ForeColor = Color.White;
            btnSubtraction.Location = new Point(230, 262);
            btnSubtraction.Name = "btnSubtraction";
            btnSubtraction.Size = new Size(65, 55);
            btnSubtraction.TabIndex = 4;
            btnSubtraction.Text = "-";
            btnSubtraction.UseVisualStyleBackColor = false;
            btnSubtraction.Click += btnSubtraction_Click;
            // 
            // btnNum9
            // 
            btnNum9.BackColor = Color.FromArgb(224, 224, 224);
            btnNum9.FlatAppearance.BorderSize = 0;
            btnNum9.FlatStyle = FlatStyle.Flat;
            btnNum9.Font = new Font("Microsoft Sans Serif", 24F);
            btnNum9.ForeColor = Color.White;
            btnNum9.Location = new Point(159, 262);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new Size(65, 55);
            btnNum9.TabIndex = 9;
            btnNum9.Text = "9";
            btnNum9.UseVisualStyleBackColor = false;
            btnNum9.Click += btnNum9_Click;
            // 
            // btnNum8
            // 
            btnNum8.BackColor = Color.FromArgb(224, 224, 224);
            btnNum8.FlatAppearance.BorderSize = 0;
            btnNum8.FlatStyle = FlatStyle.Flat;
            btnNum8.Font = new Font("Microsoft Sans Serif", 24F);
            btnNum8.ForeColor = Color.White;
            btnNum8.Location = new Point(88, 262);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new Size(65, 55);
            btnNum8.TabIndex = 6;
            btnNum8.Text = "8";
            btnNum8.UseVisualStyleBackColor = false;
            btnNum8.Click += btnNum8_Click;
            // 
            // btnNum7
            // 
            btnNum7.BackColor = Color.FromArgb(224, 224, 224);
            btnNum7.FlatAppearance.BorderSize = 0;
            btnNum7.FlatStyle = FlatStyle.Flat;
            btnNum7.Font = new Font("Microsoft Sans Serif", 24F);
            btnNum7.ForeColor = Color.White;
            btnNum7.Location = new Point(17, 262);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new Size(65, 55);
            btnNum7.TabIndex = 5;
            btnNum7.Text = "7";
            btnNum7.UseVisualStyleBackColor = false;
            btnNum7.Click += btnNum7_Click;
            // 
            // btnNum6
            // 
            btnNum6.BackColor = Color.FromArgb(224, 224, 224);
            btnNum6.FlatAppearance.BorderSize = 0;
            btnNum6.FlatStyle = FlatStyle.Flat;
            btnNum6.Font = new Font("Microsoft Sans Serif", 24F);
            btnNum6.ForeColor = Color.White;
            btnNum6.Location = new Point(159, 323);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new Size(65, 65);
            btnNum6.TabIndex = 10;
            btnNum6.Text = "6";
            btnNum6.UseVisualStyleBackColor = false;
            btnNum6.Click += btnNum6_Click;
            // 
            // btnNum5
            // 
            btnNum5.BackColor = Color.FromArgb(224, 224, 224);
            btnNum5.FlatAppearance.BorderSize = 0;
            btnNum5.FlatStyle = FlatStyle.Flat;
            btnNum5.Font = new Font("Microsoft Sans Serif", 24F);
            btnNum5.ForeColor = Color.White;
            btnNum5.Location = new Point(88, 323);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new Size(65, 65);
            btnNum5.TabIndex = 9;
            btnNum5.Text = "5";
            btnNum5.UseVisualStyleBackColor = false;
            btnNum5.Click += btnNum5_Click;
            // 
            // btnNum4
            // 
            btnNum4.BackColor = Color.FromArgb(224, 224, 224);
            btnNum4.FlatAppearance.BorderSize = 0;
            btnNum4.FlatStyle = FlatStyle.Flat;
            btnNum4.Font = new Font("Microsoft Sans Serif", 24F);
            btnNum4.ForeColor = Color.White;
            btnNum4.Location = new Point(17, 323);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(65, 65);
            btnNum4.TabIndex = 8;
            btnNum4.Text = "4";
            btnNum4.UseVisualStyleBackColor = false;
            btnNum4.Click += btnNum4_Click;
            // 
            // btnNum3
            // 
            btnNum3.BackColor = Color.FromArgb(224, 224, 224);
            btnNum3.FlatAppearance.BorderSize = 0;
            btnNum3.FlatStyle = FlatStyle.Flat;
            btnNum3.Font = new Font("Microsoft Sans Serif", 24F);
            btnNum3.ForeColor = Color.White;
            btnNum3.Location = new Point(159, 394);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new Size(65, 65);
            btnNum3.TabIndex = 13;
            btnNum3.Text = "3";
            btnNum3.UseVisualStyleBackColor = false;
            btnNum3.Click += btnNum3_Click;
            // 
            // btnNum2
            // 
            btnNum2.BackColor = Color.FromArgb(224, 224, 224);
            btnNum2.FlatAppearance.BorderSize = 0;
            btnNum2.FlatStyle = FlatStyle.Flat;
            btnNum2.Font = new Font("Microsoft Sans Serif", 24F);
            btnNum2.ForeColor = Color.White;
            btnNum2.Location = new Point(88, 394);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(65, 65);
            btnNum2.TabIndex = 12;
            btnNum2.Text = "2";
            btnNum2.UseVisualStyleBackColor = false;
            btnNum2.Click += btnNum2_Click;
            // 
            // btnNum1
            // 
            btnNum1.BackColor = Color.FromArgb(224, 224, 224);
            btnNum1.FlatAppearance.BorderSize = 0;
            btnNum1.FlatStyle = FlatStyle.Flat;
            btnNum1.Font = new Font("Microsoft Sans Serif", 24F);
            btnNum1.ForeColor = Color.White;
            btnNum1.Location = new Point(17, 394);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(65, 65);
            btnNum1.TabIndex = 11;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = false;
            btnNum1.Click += btnNum1_Click;
            // 
            // btnNum0
            // 
            btnNum0.BackColor = Color.FromArgb(224, 224, 224);
            btnNum0.FlatAppearance.BorderSize = 0;
            btnNum0.FlatStyle = FlatStyle.Flat;
            btnNum0.Font = new Font("Microsoft Sans Serif", 24F);
            btnNum0.ForeColor = Color.White;
            btnNum0.Location = new Point(88, 465);
            btnNum0.Name = "btnNum0";
            btnNum0.Size = new Size(65, 65);
            btnNum0.TabIndex = 14;
            btnNum0.Text = "0";
            btnNum0.UseVisualStyleBackColor = false;
            btnNum0.Click += btnNum0_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(224, 224, 224);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Microsoft Sans Serif", 24F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(17, 465);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(65, 65);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "C";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.FromArgb(224, 224, 224);
            btnEnter.BackgroundImageLayout = ImageLayout.None;
            btnEnter.FlatAppearance.BorderSize = 0;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Font = new Font("Microsoft Sans Serif", 24F);
            btnEnter.ForeColor = Color.White;
            btnEnter.Location = new Point(230, 394);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(65, 136);
            btnEnter.TabIndex = 16;
            btnEnter.Text = "=";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.BackColor = Color.FromArgb(224, 224, 224);
            btnBackspace.FlatAppearance.BorderSize = 0;
            btnBackspace.FlatStyle = FlatStyle.Flat;
            btnBackspace.Font = new Font("Microsoft Sans Serif", 24F);
            btnBackspace.ForeColor = Color.White;
            btnBackspace.Location = new Point(17, 213);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(82, 43);
            btnBackspace.TabIndex = 17;
            btnBackspace.Text = "⌫";
            btnBackspace.UseVisualStyleBackColor = false;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // lblResultado
            // 
            lblResultado.Anchor = AnchorStyles.Right;
            lblResultado.Font = new Font("Segoe UI", 40F);
            lblResultado.ImageAlign = ContentAlignment.MiddleRight;
            lblResultado.Location = new Point(32, 69);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(264, 72);
            lblResultado.TabIndex = 18;
            lblResultado.Text = "Resultado";
            lblResultado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.FromArgb(224, 224, 224);
            btnVirgula.FlatAppearance.BorderSize = 0;
            btnVirgula.FlatStyle = FlatStyle.Flat;
            btnVirgula.Font = new Font("Microsoft Sans Serif", 24F);
            btnVirgula.ForeColor = Color.White;
            btnVirgula.Location = new Point(159, 465);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(65, 65);
            btnVirgula.TabIndex = 20;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnRaizQuadrada
            // 
            btnRaizQuadrada.BackColor = Color.FromArgb(224, 224, 224);
            btnRaizQuadrada.FlatAppearance.BorderSize = 0;
            btnRaizQuadrada.FlatStyle = FlatStyle.Flat;
            btnRaizQuadrada.Font = new Font("Microsoft Sans Serif", 24F);
            btnRaizQuadrada.ForeColor = Color.White;
            btnRaizQuadrada.Location = new Point(17, 172);
            btnRaizQuadrada.Name = "btnRaizQuadrada";
            btnRaizQuadrada.Size = new Size(82, 34);
            btnRaizQuadrada.TabIndex = 22;
            btnRaizQuadrada.Text = "√";
            btnRaizQuadrada.UseVisualStyleBackColor = false;
            btnRaizQuadrada.Click += btnRaizQuadrada_Click;
            // 
            // btnPotencia
            // 
            btnPotencia.BackColor = Color.FromArgb(224, 224, 224);
            btnPotencia.FlatAppearance.BorderSize = 0;
            btnPotencia.FlatStyle = FlatStyle.Flat;
            btnPotencia.Font = new Font("Microsoft Sans Serif", 24F);
            btnPotencia.ForeColor = Color.White;
            btnPotencia.Location = new Point(105, 173);
            btnPotencia.Name = "btnPotencia";
            btnPotencia.Size = new Size(90, 34);
            btnPotencia.TabIndex = 23;
            btnPotencia.Text = "^";
            btnPotencia.UseVisualStyleBackColor = false;
            btnPotencia.Click += btnPotencia_Click;
            // 
            // btnInverter
            // 
            btnInverter.BackColor = Color.FromArgb(224, 224, 224);
            btnInverter.FlatAppearance.BorderSize = 0;
            btnInverter.FlatStyle = FlatStyle.Flat;
            btnInverter.Font = new Font("Microsoft Sans Serif", 19F);
            btnInverter.ForeColor = Color.White;
            btnInverter.Location = new Point(201, 174);
            btnInverter.Name = "btnInverter";
            btnInverter.Size = new Size(94, 34);
            btnInverter.TabIndex = 24;
            btnInverter.Text = "+/-";
            btnInverter.UseVisualStyleBackColor = false;
            btnInverter.Click += btnInverter_Click;
            // 
            // btnOpcoes
            // 
            btnOpcoes.BackColor = Color.FromArgb(224, 224, 224);
            btnOpcoes.ContextMenuStrip = contextMenuStrip1;
            btnOpcoes.FlatAppearance.BorderSize = 0;
            btnOpcoes.FlatStyle = FlatStyle.Flat;
            btnOpcoes.Font = new Font("Microsoft Sans Serif", 24F);
            btnOpcoes.ForeColor = Color.White;
            btnOpcoes.Location = new Point(12, 12);
            btnOpcoes.Name = "btnOpcoes";
            btnOpcoes.Size = new Size(65, 53);
            btnOpcoes.TabIndex = 25;
            btnOpcoes.Text = "☰";
            btnOpcoes.UseVisualStyleBackColor = false;
            btnOpcoes.Click += btnOpcoes_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { calculadoraDeTemperaturaToolStripMenuItem, calculadoraDeIMCToolStripMenuItem, porcentagemToolStripMenuItem, temperaturaToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(146, 92);
            // 
            // calculadoraDeTemperaturaToolStripMenuItem
            // 
            calculadoraDeTemperaturaToolStripMenuItem.Name = "calculadoraDeTemperaturaToolStripMenuItem";
            calculadoraDeTemperaturaToolStripMenuItem.Size = new Size(145, 22);
            calculadoraDeTemperaturaToolStripMenuItem.Text = "Padrão";
            calculadoraDeTemperaturaToolStripMenuItem.Click += calculadoraDeTemperaturaToolStripMenuItem_Click;
            // 
            // calculadoraDeIMCToolStripMenuItem
            // 
            calculadoraDeIMCToolStripMenuItem.Name = "calculadoraDeIMCToolStripMenuItem";
            calculadoraDeIMCToolStripMenuItem.Size = new Size(145, 22);
            calculadoraDeIMCToolStripMenuItem.Text = "IMC";
            // 
            // porcentagemToolStripMenuItem
            // 
            porcentagemToolStripMenuItem.Name = "porcentagemToolStripMenuItem";
            porcentagemToolStripMenuItem.Size = new Size(145, 22);
            porcentagemToolStripMenuItem.Text = "Porcentagem";
            // 
            // temperaturaToolStripMenuItem
            // 
            temperaturaToolStripMenuItem.Name = "temperaturaToolStripMenuItem";
            temperaturaToolStripMenuItem.Size = new Size(145, 22);
            temperaturaToolStripMenuItem.Text = "Temperatura";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(308, 546);
            Controls.Add(btnOpcoes);
            Controls.Add(btnInverter);
            Controls.Add(btnPotencia);
            Controls.Add(btnRaizQuadrada);
            Controls.Add(btnVirgula);
            Controls.Add(lblResultado);
            Controls.Add(btnBackspace);
            Controls.Add(btnEnter);
            Controls.Add(btnDelete);
            Controls.Add(btnNum0);
            Controls.Add(btnNum3);
            Controls.Add(btnNum2);
            Controls.Add(btnNum1);
            Controls.Add(btnNum6);
            Controls.Add(btnNum5);
            Controls.Add(btnNum4);
            Controls.Add(btnNum9);
            Controls.Add(btnNum8);
            Controls.Add(btnNum7);
            Controls.Add(btnSubtraction);
            Controls.Add(btnAdittion);
            Controls.Add(btnMultiplication);
            Controls.Add(btnDivision);
            Name = "Form1";
            Opacity = 0.95D;
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnDivision;
        private Button btnMultiplication;
        private Button btnAdittion;
        private Button btnSubtraction;
        private Button btnNum9;
        private Button btnNum8;
        private Button btnNum7;
        private Button btnNum6;
        private Button btnNum5;
        private Button btnNum4;
        private Button btnNum3;
        private Button btnNum2;
        private Button btnNum1;
        private Button btnNum0;
        private Button btnDelete;
        private Button btnEnter;
        private Button btnBackspace;
        private Label lblResultado;
        private Button btnVirgula;
        private Button btnRaizQuadrada;
        private Button btnPotencia;
        private Button btnInverter;
        private Button btnOpcoes;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem calculadoraDeTemperaturaToolStripMenuItem;
        private ToolStripMenuItem calculadoraDeIMCToolStripMenuItem;
        private ToolStripMenuItem porcentagemToolStripMenuItem;
        private ToolStripMenuItem temperaturaToolStripMenuItem;
    }
}
