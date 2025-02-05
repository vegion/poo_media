namespace Proyecto
{
    partial class Equipos
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipos));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtId = new TextBox();
            txtMarca = new TextBox();
            txtMod = new TextBox();
            txtCamP = new TextBox();
            txtCamF = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            cmbMemIn = new ComboBox();
            cmbMemRam = new ComboBox();
            dtgProd = new DataGridView();
            btnlimpiar = new Button();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgProd).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(105, 19);
            label1.Name = "label1";
            label1.Size = new Size(225, 40);
            label1.TabIndex = 1;
            label1.Text = "SMART SHOP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(105, 59);
            label2.Name = "label2";
            label2.Size = new Size(242, 20);
            label2.TabIndex = 2;
            label2.Text = "Administrar productos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(177, 97);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 4;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(54, 147);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 5;
            label4.Text = "Marca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(247, 147);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 6;
            label5.Text = "Modelo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(7, 210);
            label6.Name = "label6";
            label6.Size = new Size(178, 20);
            label6.TabIndex = 7;
            label6.Text = "Camara Principal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(215, 210);
            label7.Name = "label7";
            label7.Size = new Size(163, 20);
            label7.TabIndex = 8;
            label7.Text = "Camara Frontal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 280);
            label8.Name = "label8";
            label8.Size = new Size(173, 20);
            label8.TabIndex = 9;
            label8.Text = "Memoria interna";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(231, 280);
            label9.Name = "label9";
            label9.Size = new Size(137, 20);
            label9.TabIndex = 10;
            label9.Text = "Memoria RAM";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(54, 341);
            label10.Name = "label10";
            label10.Size = new Size(74, 20);
            label10.TabIndex = 11;
            label10.Text = "Precio";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(263, 341);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 12;
            label11.Text = "Stock";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(192, 255, 192);
            txtId.Cursor = Cursors.IBeam;
            txtId.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtId.Location = new Point(139, 120);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 24);
            txtId.TabIndex = 13;
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.FromArgb(192, 255, 192);
            txtMarca.Cursor = Cursors.IBeam;
            txtMarca.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtMarca.Location = new Point(12, 170);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(173, 24);
            txtMarca.TabIndex = 14;
            // 
            // txtMod
            // 
            txtMod.BackColor = Color.FromArgb(192, 255, 192);
            txtMod.Cursor = Cursors.IBeam;
            txtMod.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtMod.Location = new Point(205, 170);
            txtMod.Name = "txtMod";
            txtMod.Size = new Size(173, 24);
            txtMod.TabIndex = 15;
            // 
            // txtCamP
            // 
            txtCamP.BackColor = Color.FromArgb(192, 255, 192);
            txtCamP.Cursor = Cursors.IBeam;
            txtCamP.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCamP.Location = new Point(12, 233);
            txtCamP.Name = "txtCamP";
            txtCamP.Size = new Size(173, 24);
            txtCamP.TabIndex = 16;
            // 
            // txtCamF
            // 
            txtCamF.BackColor = Color.FromArgb(192, 255, 192);
            txtCamF.Cursor = Cursors.IBeam;
            txtCamF.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCamF.Location = new Point(205, 233);
            txtCamF.Name = "txtCamF";
            txtCamF.Size = new Size(173, 24);
            txtCamF.TabIndex = 17;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(192, 255, 192);
            txtPrecio.Cursor = Cursors.IBeam;
            txtPrecio.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrecio.Location = new Point(7, 364);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(173, 24);
            txtPrecio.TabIndex = 20;
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.FromArgb(192, 255, 192);
            txtStock.Cursor = Cursors.IBeam;
            txtStock.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtStock.Location = new Point(205, 364);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(173, 24);
            txtStock.TabIndex = 21;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Green;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(7, 426);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 37);
            btnAgregar.TabIndex = 22;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Green;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(125, 426);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(128, 37);
            btnActualizar.TabIndex = 23;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Green;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(259, 426);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 37);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cmbMemIn
            // 
            cmbMemIn.BackColor = Color.FromArgb(192, 255, 192);
            cmbMemIn.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cmbMemIn.FormattingEnabled = true;
            cmbMemIn.Items.AddRange(new object[] { "32 GB", "64 GB", "128 GB", "256 GB", "512 GB", "1 TB" });
            cmbMemIn.Location = new Point(12, 303);
            cmbMemIn.Name = "cmbMemIn";
            cmbMemIn.Size = new Size(173, 25);
            cmbMemIn.TabIndex = 25;
            // 
            // cmbMemRam
            // 
            cmbMemRam.BackColor = Color.FromArgb(192, 255, 192);
            cmbMemRam.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cmbMemRam.FormattingEnabled = true;
            cmbMemRam.Items.AddRange(new object[] { "2 GB", "4 GB", "6 GB", "8 GB", "12 GB", "16 GB" });
            cmbMemRam.Location = new Point(205, 303);
            cmbMemRam.Name = "cmbMemRam";
            cmbMemRam.Size = new Size(173, 25);
            cmbMemRam.TabIndex = 26;
            // 
            // dtgProd
            // 
            dtgProd.AllowUserToAddRows = false;
            dtgProd.AllowUserToDeleteRows = false;
            dtgProd.BackgroundColor = Color.FromArgb(192, 255, 192);
            dtgProd.BorderStyle = BorderStyle.Fixed3D;
            dtgProd.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtgProd.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProd.Cursor = Cursors.Hand;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle4.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dtgProd.DefaultCellStyle = dataGridViewCellStyle4;
            dtgProd.GridColor = Color.FromArgb(192, 255, 192);
            dtgProd.Location = new Point(395, 12);
            dtgProd.Name = "dtgProd";
            dtgProd.ReadOnly = true;
            dtgProd.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgProd.RowHeadersVisible = false;
            dtgProd.RowTemplate.Height = 25;
            dtgProd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProd.Size = new Size(838, 526);
            dtgProd.TabIndex = 27;
            dtgProd.CellContentClick += dtgProd_CellContentClick;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = Color.Green;
            btnlimpiar.Cursor = Cursors.Hand;
            btnlimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            btnlimpiar.FlatStyle = FlatStyle.Flat;
            btnlimpiar.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnlimpiar.ForeColor = Color.White;
            btnlimpiar.Location = new Point(55, 479);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(130, 37);
            btnlimpiar.TabIndex = 28;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.Green;
            btnRegresar.Cursor = Cursors.Hand;
            btnRegresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(200, 479);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(130, 37);
            btnRegresar.TabIndex = 29;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += button1_Click;
            // 
            // Equipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1237, 550);
            Controls.Add(btnRegresar);
            Controls.Add(btnlimpiar);
            Controls.Add(dtgProd);
            Controls.Add(cmbMemRam);
            Controls.Add(cmbMemIn);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtCamF);
            Controls.Add(txtCamP);
            Controls.Add(txtMod);
            Controls.Add(txtMarca);
            Controls.Add(txtId);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Equipos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Equipos";
            Load += Equipos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgProd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtId;
        private TextBox txtMarca;
        private TextBox txtMod;
        private TextBox txtCamP;
        private TextBox txtCamF;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private ComboBox cmbMemIn;
        private ComboBox cmbMemRam;
        private DataGridView dtgProd;
        private Button btnlimpiar;
        private Button btnRegresar;
    }
}