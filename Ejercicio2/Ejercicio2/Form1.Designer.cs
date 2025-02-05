namespace Ejercicio2
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
            btncarta = new Button();
            btnpedido = new Button();
            button3 = new Button();
            grbcarta = new GroupBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            grbpedido = new GroupBox();
            dtgped = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Gaseosa = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            btnfin = new Button();
            btnañad = new Button();
            cmbgas = new ComboBox();
            lblgas = new Label();
            pctproped = new PictureBox();
            lblproped = new Label();
            txtcod = new TextBox();
            label24 = new Label();
            grbpago = new GroupBox();
            btnpago = new Button();
            txtdev = new TextBox();
            txtpago = new TextBox();
            txttotal = new TextBox();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            grbventas = new GroupBox();
            lbltotven = new Label();
            label21 = new Label();
            dtgventas = new DataGridView();
            Producto1 = new DataGridViewTextBoxColumn();
            Total_Venta = new DataGridViewTextBoxColumn();
            Valor_Venta = new DataGridViewTextBoxColumn();
            label22 = new Label();
            grbcarta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grbpedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgped).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctproped).BeginInit();
            grbpago.SuspendLayout();
            grbventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgventas).BeginInit();
            SuspendLayout();
            // 
            // btncarta
            // 
            btncarta.BackColor = Color.White;
            btncarta.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btncarta.ForeColor = Color.Black;
            btncarta.Location = new Point(12, 36);
            btncarta.Name = "btncarta";
            btncarta.Size = new Size(120, 23);
            btncarta.TabIndex = 0;
            btncarta.Text = "Ver carta";
            btncarta.UseVisualStyleBackColor = false;
            btncarta.Click += btncarta_Click;
            // 
            // btnpedido
            // 
            btnpedido.BackColor = Color.White;
            btnpedido.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnpedido.ForeColor = Color.Black;
            btnpedido.Location = new Point(12, 65);
            btnpedido.Name = "btnpedido";
            btnpedido.Size = new Size(120, 26);
            btnpedido.TabIndex = 1;
            btnpedido.Text = "Nuevo pedido";
            btnpedido.UseVisualStyleBackColor = false;
            btnpedido.Click += btnpedido_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Enabled = false;
            button3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(12, 98);
            button3.Name = "button3";
            button3.Size = new Size(120, 25);
            button3.TabIndex = 2;
            button3.Text = "Ventas del día";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // grbcarta
            // 
            grbcarta.BackColor = Color.White;
            grbcarta.Controls.Add(label16);
            grbcarta.Controls.Add(label15);
            grbcarta.Controls.Add(label14);
            grbcarta.Controls.Add(label13);
            grbcarta.Controls.Add(label12);
            grbcarta.Controls.Add(label11);
            grbcarta.Controls.Add(label10);
            grbcarta.Controls.Add(label9);
            grbcarta.Controls.Add(label8);
            grbcarta.Controls.Add(label7);
            grbcarta.Controls.Add(label6);
            grbcarta.Controls.Add(label5);
            grbcarta.Controls.Add(label4);
            grbcarta.Controls.Add(label3);
            grbcarta.Controls.Add(label2);
            grbcarta.Controls.Add(label1);
            grbcarta.Controls.Add(pictureBox8);
            grbcarta.Controls.Add(pictureBox7);
            grbcarta.Controls.Add(pictureBox6);
            grbcarta.Controls.Add(pictureBox5);
            grbcarta.Controls.Add(pictureBox4);
            grbcarta.Controls.Add(pictureBox3);
            grbcarta.Controls.Add(pictureBox2);
            grbcarta.Controls.Add(pictureBox1);
            grbcarta.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grbcarta.Location = new Point(208, 73);
            grbcarta.Name = "grbcarta";
            grbcarta.Size = new Size(439, 504);
            grbcarta.TabIndex = 3;
            grbcarta.TabStop = false;
            grbcarta.Text = "Carta";
            grbcarta.Visible = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(371, 463);
            label16.Name = "label16";
            label16.Size = new Size(61, 19);
            label16.TabIndex = 23;
            label16.Text = "$25.000";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(371, 351);
            label15.Name = "label15";
            label15.Size = new Size(61, 19);
            label15.TabIndex = 22;
            label15.Text = "$15.500";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(371, 239);
            label14.Name = "label14";
            label14.Size = new Size(61, 19);
            label14.TabIndex = 21;
            label14.Text = "$20.000";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(371, 116);
            label13.Name = "label13";
            label13.Size = new Size(61, 19);
            label13.TabIndex = 20;
            label13.Text = "$15.000";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(148, 463);
            label12.Name = "label12";
            label12.Size = new Size(53, 19);
            label12.TabIndex = 19;
            label12.Text = "$7.000";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(148, 351);
            label11.Name = "label11";
            label11.Size = new Size(61, 19);
            label11.TabIndex = 18;
            label11.Text = "$12.000";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(148, 239);
            label10.Name = "label10";
            label10.Size = new Size(61, 19);
            label10.TabIndex = 17;
            label10.Text = "$17.000";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(148, 116);
            label9.Name = "label9";
            label9.Size = new Size(61, 19);
            label9.TabIndex = 16;
            label9.Text = "$12.000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(233, 463);
            label8.Name = "label8";
            label8.Size = new Size(92, 19);
            label8.TabIndex = 15;
            label8.Text = "0711. Picada";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(236, 351);
            label7.Name = "label7";
            label7.Size = new Size(89, 19);
            label7.TabIndex = 14;
            label7.Text = "0511. Chuzo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(233, 239);
            label6.Name = "label6";
            label6.Size = new Size(141, 19);
            label6.TabIndex = 13;
            label6.Text = "0311. Hamburguesa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(233, 114);
            label5.Name = "label5";
            label5.Size = new Size(85, 19);
            label5.TabIndex = 12;
            label5.Text = "0211. Perro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 463);
            label4.Name = "label4";
            label4.Size = new Size(87, 19);
            label4.TabIndex = 11;
            label4.Text = "0611. Tacos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 351);
            label3.Name = "label3";
            label3.Size = new Size(99, 19);
            label3.TabIndex = 10;
            label3.Text = "0411. Chorizo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 239);
            label2.Name = "label2";
            label2.Size = new Size(86, 19);
            label2.TabIndex = 9;
            label2.Text = "0212. Perra";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 116);
            label1.Name = "label1";
            label1.Size = new Size(119, 19);
            label1.TabIndex = 8;
            label1.Text = "0111. Salchipapa";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.picada;
            pictureBox8.Location = new Point(233, 369);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(185, 91);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 7;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.chuzo_de_pollo;
            pictureBox7.Location = new Point(233, 257);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(185, 91);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.hamburguesa;
            pictureBox6.Location = new Point(233, 145);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(185, 91);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.perro;
            pictureBox5.Location = new Point(233, 20);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(185, 91);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.tacos;
            pictureBox4.Location = new Point(23, 369);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(186, 91);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.chorizo;
            pictureBox3.Location = new Point(23, 257);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(186, 91);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.perra;
            pictureBox2.Location = new Point(23, 145);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 91);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.salchipapa;
            pictureBox1.Location = new Point(23, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // grbpedido
            // 
            grbpedido.BackColor = Color.White;
            grbpedido.Controls.Add(dtgped);
            grbpedido.Controls.Add(btnfin);
            grbpedido.Controls.Add(btnañad);
            grbpedido.Controls.Add(cmbgas);
            grbpedido.Controls.Add(lblgas);
            grbpedido.Controls.Add(pctproped);
            grbpedido.Controls.Add(lblproped);
            grbpedido.Controls.Add(txtcod);
            grbpedido.Controls.Add(label24);
            grbpedido.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grbpedido.Location = new Point(208, 67);
            grbpedido.Name = "grbpedido";
            grbpedido.Size = new Size(443, 504);
            grbpedido.TabIndex = 4;
            grbpedido.TabStop = false;
            grbpedido.Text = "Pedido";
            grbpedido.Visible = false;
            // 
            // dtgped
            // 
            dtgped.BackgroundColor = Color.White;
            dtgped.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgped.Columns.AddRange(new DataGridViewColumn[] { Producto, Gaseosa, Subtotal });
            dtgped.GridColor = Color.White;
            dtgped.Location = new Point(23, 354);
            dtgped.Name = "dtgped";
            dtgped.RowTemplate.Height = 25;
            dtgped.Size = new Size(395, 150);
            dtgped.TabIndex = 8;
            dtgped.Visible = false;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // Gaseosa
            // 
            Gaseosa.HeaderText = "Gaseosa";
            Gaseosa.Name = "Gaseosa";
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            // 
            // btnfin
            // 
            btnfin.Location = new Point(250, 314);
            btnfin.Name = "btnfin";
            btnfin.Size = new Size(107, 23);
            btnfin.TabIndex = 7;
            btnfin.Text = "Finalizar";
            btnfin.UseVisualStyleBackColor = true;
            btnfin.Visible = false;
            btnfin.Click += btnfin_Click;
            // 
            // btnañad
            // 
            btnañad.Location = new Point(67, 314);
            btnañad.Name = "btnañad";
            btnañad.Size = new Size(104, 23);
            btnañad.TabIndex = 6;
            btnañad.Text = "Añadir";
            btnañad.UseVisualStyleBackColor = true;
            btnañad.Visible = false;
            btnañad.Click += btnañad_Click;
            // 
            // cmbgas
            // 
            cmbgas.FormattingEnabled = true;
            cmbgas.Items.AddRange(new object[] { "Si", "No" });
            cmbgas.Location = new Point(285, 255);
            cmbgas.Name = "cmbgas";
            cmbgas.Size = new Size(121, 27);
            cmbgas.TabIndex = 5;
            cmbgas.Visible = false;
            // 
            // lblgas
            // 
            lblgas.AutoSize = true;
            lblgas.Location = new Point(23, 258);
            lblgas.Name = "lblgas";
            lblgas.Size = new Size(256, 19);
            lblgas.TabIndex = 4;
            lblgas.Text = "¿Desea agregar gaseosa por $4.000?";
            lblgas.Visible = false;
            // 
            // pctproped
            // 
            pctproped.Location = new Point(130, 74);
            pctproped.Name = "pctproped";
            pctproped.Size = new Size(188, 144);
            pctproped.SizeMode = PictureBoxSizeMode.StretchImage;
            pctproped.TabIndex = 3;
            pctproped.TabStop = false;
            pctproped.Visible = false;
            // 
            // lblproped
            // 
            lblproped.AutoSize = true;
            lblproped.Location = new Point(200, 220);
            lblproped.Name = "lblproped";
            lblproped.Size = new Size(0, 19);
            lblproped.TabIndex = 2;
            lblproped.Visible = false;
            // 
            // txtcod
            // 
            txtcod.Location = new Point(275, 25);
            txtcod.Name = "txtcod";
            txtcod.Size = new Size(82, 26);
            txtcod.TabIndex = 1;
            txtcod.KeyDown += textBox1_KeyDown;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(83, 28);
            label24.Name = "label24";
            label24.Size = new Size(142, 19);
            label24.TabIndex = 0;
            label24.Text = "Código del producto";
            // 
            // grbpago
            // 
            grbpago.BackColor = Color.White;
            grbpago.Controls.Add(btnpago);
            grbpago.Controls.Add(txtdev);
            grbpago.Controls.Add(txtpago);
            grbpago.Controls.Add(txttotal);
            grbpago.Controls.Add(label20);
            grbpago.Controls.Add(label19);
            grbpago.Controls.Add(label18);
            grbpago.Controls.Add(label17);
            grbpago.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grbpago.Location = new Point(208, 65);
            grbpago.Name = "grbpago";
            grbpago.Size = new Size(443, 198);
            grbpago.TabIndex = 9;
            grbpago.TabStop = false;
            grbpago.Text = "Pago";
            grbpago.Visible = false;
            // 
            // btnpago
            // 
            btnpago.Location = new Point(167, 155);
            btnpago.Name = "btnpago";
            btnpago.Size = new Size(124, 28);
            btnpago.TabIndex = 7;
            btnpago.Text = "Hacer pedido";
            btnpago.UseVisualStyleBackColor = true;
            btnpago.Click += btnpago_Click;
            // 
            // txtdev
            // 
            txtdev.Enabled = false;
            txtdev.Location = new Point(179, 113);
            txtdev.Name = "txtdev";
            txtdev.Size = new Size(100, 26);
            txtdev.TabIndex = 6;
            // 
            // txtpago
            // 
            txtpago.Location = new Point(179, 71);
            txtpago.Name = "txtpago";
            txtpago.Size = new Size(100, 26);
            txtpago.TabIndex = 5;
            // 
            // txttotal
            // 
            txttotal.Enabled = false;
            txttotal.Location = new Point(179, 29);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(100, 26);
            txttotal.TabIndex = 4;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(56, 116);
            label20.Name = "label20";
            label20.Size = new Size(75, 19);
            label20.TabIndex = 3;
            label20.Text = "Devuelta:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(56, 74);
            label19.Name = "label19";
            label19.Size = new Size(102, 19);
            label19.TabIndex = 2;
            label19.Text = "Valor pagado:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(56, 60);
            label18.Name = "label18";
            label18.Size = new Size(0, 19);
            label18.TabIndex = 1;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(56, 32);
            label17.Name = "label17";
            label17.Size = new Size(97, 19);
            label17.TabIndex = 0;
            label17.Text = "Total a pagar";
            // 
            // grbventas
            // 
            grbventas.BackColor = Color.White;
            grbventas.Controls.Add(lbltotven);
            grbventas.Controls.Add(label21);
            grbventas.Controls.Add(dtgventas);
            grbventas.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grbventas.Location = new Point(208, 56);
            grbventas.Name = "grbventas";
            grbventas.Size = new Size(443, 424);
            grbventas.TabIndex = 8;
            grbventas.TabStop = false;
            grbventas.Text = "Ventas del día";
            grbventas.Visible = false;
            // 
            // lbltotven
            // 
            lbltotven.AutoSize = true;
            lbltotven.Location = new Point(275, 351);
            lbltotven.Name = "lbltotven";
            lbltotven.Size = new Size(0, 19);
            lbltotven.TabIndex = 2;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(70, 351);
            label21.Name = "label21";
            label21.Size = new Size(101, 19);
            label21.TabIndex = 1;
            label21.Text = "Total Vendido";
            // 
            // dtgventas
            // 
            dtgventas.BackgroundColor = Color.White;
            dtgventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgventas.Columns.AddRange(new DataGridViewColumn[] { Producto1, Total_Venta, Valor_Venta });
            dtgventas.GridColor = Color.White;
            dtgventas.Location = new Point(23, 29);
            dtgventas.Name = "dtgventas";
            dtgventas.RowTemplate.Height = 25;
            dtgventas.Size = new Size(395, 308);
            dtgventas.TabIndex = 0;
            // 
            // Producto1
            // 
            Producto1.HeaderText = "Producto";
            Producto1.Name = "Producto1";
            // 
            // Total_Venta
            // 
            Total_Venta.HeaderText = "Total_Venta";
            Total_Venta.Name = "Total_Venta";
            // 
            // Valor_Venta
            // 
            Valor_Venta.HeaderText = "Valor_Venta";
            Valor_Venta.Name = "Valor_Venta";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(231, 9);
            label22.Name = "label22";
            label22.Size = new Size(282, 30);
            label22.TabIndex = 10;
            label22.Text = "Comidas rápidas DM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(676, 589);
            Controls.Add(label22);
            Controls.Add(grbventas);
            Controls.Add(grbpago);
            Controls.Add(grbpedido);
            Controls.Add(grbcarta);
            Controls.Add(button3);
            Controls.Add(btnpedido);
            Controls.Add(btncarta);
            Name = "Form1";
            Text = "Form1";
            grbcarta.ResumeLayout(false);
            grbcarta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grbpedido.ResumeLayout(false);
            grbpedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgped).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctproped).EndInit();
            grbpago.ResumeLayout(false);
            grbpago.PerformLayout();
            grbventas.ResumeLayout(false);
            grbventas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgventas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncarta;
        private Button btnpedido;
        private Button button3;
        private GroupBox grbcarta;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private GroupBox grbpedido;
        private Label label24;
        private TextBox txtcod;
        private PictureBox pctproped;
        private Label lblproped;
        private Label lblgas;
        private ComboBox cmbgas;
        private Button btnfin;
        private Button btnañad;
        private DataGridView dtgped;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Gaseosa;
        private DataGridViewTextBoxColumn Subtotal;
        private GroupBox grbpago;
        private Label label18;
        private Label label17;
        private TextBox txtdev;
        private TextBox txtpago;
        private TextBox txttotal;
        private Label label20;
        private Label label19;
        private Button btnpago;
        private GroupBox grbventas;
        private DataGridView dtgventas;
        private DataGridViewTextBoxColumn Producto1;
        private DataGridViewTextBoxColumn Total_Venta;
        private DataGridViewTextBoxColumn Valor_Venta;
        private Label lbltotven;
        private Label label21;
        private Label label22;
    }
}
