namespace Proyecto
{
    partial class Venta
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            dtgProDis = new DataGridView();
            txtCantidad = new TextBox();
            txtProdu = new TextBox();
            txtPrecioP = new TextBox();
            txtFactura = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnVenta = new Button();
            label3 = new Label();
            dtgFactura = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnRegresar = new Button();
            txtCliente = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lbltotal = new Label();
            button2 = new Button();
            label11 = new Label();
            label12 = new Label();
            lblVentas = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgProDis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgFactura).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(9, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(102, 49);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 5;
            label2.Text = "Ventas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(102, 9);
            label1.Name = "label1";
            label1.Size = new Size(225, 40);
            label1.TabIndex = 4;
            label1.Text = "SMART SHOP";
            // 
            // dtgProDis
            // 
            dtgProDis.AllowUserToAddRows = false;
            dtgProDis.AllowUserToDeleteRows = false;
            dtgProDis.BackgroundColor = Color.FromArgb(192, 255, 192);
            dtgProDis.BorderStyle = BorderStyle.Fixed3D;
            dtgProDis.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtgProDis.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgProDis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgProDis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProDis.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgProDis.DefaultCellStyle = dataGridViewCellStyle2;
            dtgProDis.GridColor = Color.FromArgb(192, 255, 192);
            dtgProDis.Location = new Point(328, 78);
            dtgProDis.MultiSelect = false;
            dtgProDis.Name = "dtgProDis";
            dtgProDis.ReadOnly = true;
            dtgProDis.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgProDis.RowHeadersVisible = false;
            dtgProDis.RowTemplate.Height = 25;
            dtgProDis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProDis.Size = new Size(402, 246);
            dtgProDis.TabIndex = 28;
            dtgProDis.CellContentClick += dtgProDis_CellContentClick;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.FromArgb(192, 255, 192);
            txtCantidad.Cursor = Cursors.IBeam;
            txtCantidad.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCantidad.Location = new Point(130, 271);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(173, 24);
            txtCantidad.TabIndex = 36;
            // 
            // txtProdu
            // 
            txtProdu.BackColor = Color.FromArgb(192, 255, 192);
            txtProdu.Cursor = Cursors.IBeam;
            txtProdu.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtProdu.Location = new Point(130, 189);
            txtProdu.Name = "txtProdu";
            txtProdu.Size = new Size(173, 24);
            txtProdu.TabIndex = 35;
            // 
            // txtPrecioP
            // 
            txtPrecioP.BackColor = Color.FromArgb(192, 255, 192);
            txtPrecioP.Cursor = Cursors.IBeam;
            txtPrecioP.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrecioP.Location = new Point(130, 228);
            txtPrecioP.Name = "txtPrecioP";
            txtPrecioP.Size = new Size(173, 24);
            txtPrecioP.TabIndex = 34;
            // 
            // txtFactura
            // 
            txtFactura.BackColor = Color.FromArgb(192, 255, 192);
            txtFactura.Cursor = Cursors.IBeam;
            txtFactura.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtFactura.Location = new Point(130, 111);
            txtFactura.Name = "txtFactura";
            txtFactura.Size = new Size(173, 24);
            txtFactura.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(7, 271);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 32;
            label7.Text = "Cantidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(7, 189);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 31;
            label6.Text = "Producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(7, 232);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 30;
            label5.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(7, 111);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 29;
            label4.Text = "N° factura";
            // 
            // btnVenta
            // 
            btnVenta.BackColor = Color.Green;
            btnVenta.Cursor = Cursors.Hand;
            btnVenta.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            btnVenta.FlatStyle = FlatStyle.Flat;
            btnVenta.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVenta.ForeColor = Color.White;
            btnVenta.Location = new Point(12, 301);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(224, 37);
            btnVenta.TabIndex = 37;
            btnVenta.Text = "Agregar a factura";
            btnVenta.UseVisualStyleBackColor = false;
            btnVenta.Click += btnVenta_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(412, 49);
            label3.Name = "label3";
            label3.Size = new Size(253, 20);
            label3.TabIndex = 38;
            label3.Text = "Productos en inventario";
            // 
            // dtgFactura
            // 
            dtgFactura.AllowUserToAddRows = false;
            dtgFactura.AllowUserToDeleteRows = false;
            dtgFactura.BackgroundColor = Color.FromArgb(192, 255, 192);
            dtgFactura.BorderStyle = BorderStyle.Fixed3D;
            dtgFactura.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtgFactura.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgFactura.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dtgFactura.Cursor = Cursors.Hand;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle4.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dtgFactura.DefaultCellStyle = dataGridViewCellStyle4;
            dtgFactura.GridColor = Color.FromArgb(192, 255, 192);
            dtgFactura.Location = new Point(9, 368);
            dtgFactura.MultiSelect = false;
            dtgFactura.Name = "dtgFactura";
            dtgFactura.ReadOnly = true;
            dtgFactura.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgFactura.RowHeadersVisible = false;
            dtgFactura.RowTemplate.Height = 25;
            dtgFactura.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgFactura.Size = new Size(538, 144);
            dtgFactura.TabIndex = 39;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Producto";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Precio";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Cantidad";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Valor Total";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 135;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.Green;
            btnRegresar.Cursor = Cursors.Hand;
            btnRegresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(12, 521);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(121, 33);
            btnRegresar.TabIndex = 40;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += button1_Click;
            // 
            // txtCliente
            // 
            txtCliente.BackColor = Color.FromArgb(192, 255, 192);
            txtCliente.Cursor = Cursors.IBeam;
            txtCliente.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCliente.Location = new Point(130, 149);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(173, 24);
            txtCliente.TabIndex = 42;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(7, 149);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 41;
            label8.Text = "Cliente";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(139, 341);
            label9.Name = "label9";
            label9.Size = new Size(226, 20);
            label9.TabIndex = 43;
            label9.Text = "Productos del cliente";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(572, 402);
            label10.Name = "label10";
            label10.Size = new Size(141, 20);
            label10.TabIndex = 44;
            label10.Text = "Total a pagar";
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbltotal.Location = new Point(595, 446);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(25, 27);
            lbltotal.TabIndex = 45;
            lbltotal.Text = "0";
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(271, 521);
            button2.Name = "button2";
            button2.Size = new Size(256, 33);
            button2.TabIndex = 46;
            button2.Text = "Ingresar venta";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(572, 446);
            label11.Name = "label11";
            label11.Size = new Size(23, 27);
            label11.TabIndex = 47;
            label11.Text = "$";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(501, 9);
            label12.Name = "label12";
            label12.Size = new Size(164, 20);
            label12.TabIndex = 48;
            label12.Text = "Ventas actuales";
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblVentas.Location = new Point(671, 3);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(25, 27);
            lblVentas.TabIndex = 49;
            lblVentas.Text = "0";
            // 
            // Venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(737, 566);
            Controls.Add(lblVentas);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(button2);
            Controls.Add(lbltotal);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtCliente);
            Controls.Add(label8);
            Controls.Add(btnRegresar);
            Controls.Add(dtgFactura);
            Controls.Add(label3);
            Controls.Add(btnVenta);
            Controls.Add(txtCantidad);
            Controls.Add(txtProdu);
            Controls.Add(txtPrecioP);
            Controls.Add(txtFactura);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtgProDis);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Venta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venta";
            Load += Venta_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgProDis).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgFactura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private DataGridView dtgProDis;
        private TextBox txtCantidad;
        private TextBox txtProdu;
        private TextBox txtPrecioP;
        private TextBox txtFactura;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnVenta;
        private Label label3;
        private DataGridView dtgFactura;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnRegresar;
        private TextBox txtCliente;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lbltotal;
        private Button button2;
        private Label label11;
        private Label label12;
        private Label lblVentas;
    }
}