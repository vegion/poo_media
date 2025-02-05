namespace Actividad1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtnom = new TextBox();
            txtdoc = new TextBox();
            txthe = new TextBox();
            txths = new TextBox();
            txtht = new TextBox();
            cmbpuesto = new ComboBox();
            dtgsalario = new DataGridView();
            Documento = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Puesto = new DataGridViewTextBoxColumn();
            Hora_Ent = new DataGridViewTextBoxColumn();
            Hora_Sal = new DataGridViewTextBoxColumn();
            Horas_Trab = new DataGridViewTextBoxColumn();
            Salario_Dia = new DataGridViewTextBoxColumn();
            btnreg = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgsalario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 19);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(85, 19);
            label2.TabIndex = 1;
            label2.Text = "Documento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 87);
            label3.Name = "label3";
            label3.Size = new Size(125, 19);
            label3.TabIndex = 2;
            label3.Text = "Puesto de trabajo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 132);
            label4.Name = "label4";
            label4.Size = new Size(98, 19);
            label4.TabIndex = 3;
            label4.Text = "Hora entrada";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 181);
            label5.Name = "label5";
            label5.Size = new Size(86, 19);
            label5.TabIndex = 4;
            label5.Text = "Hora salida";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 223);
            label6.Name = "label6";
            label6.Size = new Size(124, 19);
            label6.TabIndex = 5;
            label6.Text = "Horas trabajadas";
            // 
            // txtnom
            // 
            txtnom.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtnom.Location = new Point(143, 6);
            txtnom.Name = "txtnom";
            txtnom.Size = new Size(172, 26);
            txtnom.TabIndex = 6;
            // 
            // txtdoc
            // 
            txtdoc.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtdoc.Location = new Point(143, 44);
            txtdoc.Name = "txtdoc";
            txtdoc.Size = new Size(172, 26);
            txtdoc.TabIndex = 7;
            // 
            // txthe
            // 
            txthe.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txthe.Location = new Point(143, 129);
            txthe.Name = "txthe";
            txthe.Size = new Size(172, 26);
            txthe.TabIndex = 8;
            // 
            // txths
            // 
            txths.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txths.Location = new Point(143, 178);
            txths.Name = "txths";
            txths.Size = new Size(172, 26);
            txths.TabIndex = 9;
            // 
            // txtht
            // 
            txtht.Enabled = false;
            txtht.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtht.Location = new Point(143, 220);
            txtht.Name = "txtht";
            txtht.Size = new Size(172, 26);
            txtht.TabIndex = 10;
            // 
            // cmbpuesto
            // 
            cmbpuesto.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbpuesto.FormattingEnabled = true;
            cmbpuesto.Items.AddRange(new object[] { "Director", "Coordinador", "Auxiliar", "Operario", "Logistica" });
            cmbpuesto.Location = new Point(143, 84);
            cmbpuesto.Name = "cmbpuesto";
            cmbpuesto.Size = new Size(172, 27);
            cmbpuesto.TabIndex = 11;
            // 
            // dtgsalario
            // 
            dtgsalario.BackgroundColor = Color.White;
            dtgsalario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgsalario.Columns.AddRange(new DataGridViewColumn[] { Documento, Nombre, Puesto, Hora_Ent, Hora_Sal, Horas_Trab, Salario_Dia });
            dtgsalario.Location = new Point(12, 252);
            dtgsalario.Name = "dtgsalario";
            dtgsalario.RowTemplate.Height = 25;
            dtgsalario.Size = new Size(776, 186);
            dtgsalario.TabIndex = 12;
            dtgsalario.CellContentClick += dtgsalario_CellContentClick;
            // 
            // Documento
            // 
            Documento.HeaderText = "Documento";
            Documento.Name = "Documento";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Puesto
            // 
            Puesto.HeaderText = "Puesto";
            Puesto.Name = "Puesto";
            // 
            // Hora_Ent
            // 
            Hora_Ent.HeaderText = "Hora_Ent";
            Hora_Ent.Name = "Hora_Ent";
            // 
            // Hora_Sal
            // 
            Hora_Sal.HeaderText = "Hora_Sal";
            Hora_Sal.Name = "Hora_Sal";
            // 
            // Horas_Trab
            // 
            Horas_Trab.HeaderText = "Horas_Trab";
            Horas_Trab.Name = "Horas_Trab";
            // 
            // Salario_Dia
            // 
            Salario_Dia.HeaderText = "Salario_Dia";
            Salario_Dia.Name = "Salario_Dia";
            // 
            // btnreg
            // 
            btnreg.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnreg.Location = new Point(522, 75);
            btnreg.Name = "btnreg";
            btnreg.Size = new Size(88, 36);
            btnreg.TabIndex = 13;
            btnreg.Text = "Registrar";
            btnreg.UseVisualStyleBackColor = true;
            btnreg.Click += btnreg_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(321, 132);
            label7.Name = "label7";
            label7.Size = new Size(105, 19);
            label7.TabIndex = 14;
            label7.Text = "hh:mm:ss 24 h";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(321, 181);
            label8.Name = "label8";
            label8.Size = new Size(105, 19);
            label8.TabIndex = 15;
            label8.Text = "hh:mm:ss 24 h";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(361, 22);
            label9.Name = "label9";
            label9.Size = new Size(427, 30);
            label9.TabIndex = 16;
            label9.Text = "Registro de horas trabajadas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnreg);
            Controls.Add(dtgsalario);
            Controls.Add(cmbpuesto);
            Controls.Add(txtht);
            Controls.Add(txths);
            Controls.Add(txthe);
            Controls.Add(txtdoc);
            Controls.Add(txtnom);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgsalario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtnom;
        private TextBox txtdoc;
        private TextBox txthe;
        private TextBox txths;
        private TextBox txtht;
        private ComboBox cmbpuesto;
        private DataGridView dtgsalario;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Puesto;
        private DataGridViewTextBoxColumn Hora_Ent;
        private DataGridViewTextBoxColumn Hora_Sal;
        private DataGridViewTextBoxColumn Horas_Trab;
        private DataGridViewTextBoxColumn Salario_Dia;
        private Button btnreg;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
