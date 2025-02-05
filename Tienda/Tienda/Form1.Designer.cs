namespace Tienda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnventa = new Button();
            btntotal = new Button();
            btnvenpro = new Button();
            grbven = new GroupBox();
            btncont = new Button();
            txtape = new TextBox();
            txtnom = new TextBox();
            label2 = new Label();
            label1 = new Label();
            grbcons = new GroupBox();
            btncons = new Button();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            txtcod = new TextBox();
            label9 = new Label();
            grbprod = new GroupBox();
            btnrei = new Button();
            btnfin = new Button();
            txttin = new TextBox();
            txtpap = new TextBox();
            txtgas = new TextBox();
            txtpas = new TextBox();
            txtmec = new TextBox();
            txtcon = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btntin = new Button();
            btnpas = new Button();
            btnpap = new Button();
            btnmec = new Button();
            btngas = new Button();
            btnconf = new Button();
            grbinf = new GroupBox();
            btnnue = new Button();
            btnsalir = new Button();
            lblventa = new Label();
            label19 = new Label();
            lblcant = new Label();
            label18 = new Label();
            lblvalor = new Label();
            label17 = new Label();
            lblnom = new Label();
            label10 = new Label();
            picbprod = new PictureBox();
            grbtotal = new GroupBox();
            btnsal = new Button();
            lbltotal = new Label();
            lbltin = new Label();
            lblpas = new Label();
            lblpap = new Label();
            lblmec = new Label();
            lblgas = new Label();
            lblcon = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            grbven.SuspendLayout();
            grbcons.SuspendLayout();
            grbprod.SuspendLayout();
            grbinf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbprod).BeginInit();
            grbtotal.SuspendLayout();
            SuspendLayout();
            // 
            // btnventa
            // 
            btnventa.Location = new Point(12, 12);
            btnventa.Name = "btnventa";
            btnventa.Size = new Size(124, 23);
            btnventa.TabIndex = 0;
            btnventa.Text = "Venta nueva";
            btnventa.UseVisualStyleBackColor = true;
            btnventa.Click += btnventa_Click;
            // 
            // btntotal
            // 
            btntotal.Location = new Point(12, 70);
            btntotal.Name = "btntotal";
            btntotal.Size = new Size(124, 23);
            btntotal.TabIndex = 1;
            btntotal.Text = "Ventas del día";
            btntotal.UseVisualStyleBackColor = true;
            btntotal.Click += btntotal_Click;
            // 
            // btnvenpro
            // 
            btnvenpro.Location = new Point(12, 41);
            btnvenpro.Name = "btnvenpro";
            btnvenpro.Size = new Size(124, 23);
            btnvenpro.TabIndex = 2;
            btnvenpro.Text = "Ventas por producto";
            btnvenpro.UseVisualStyleBackColor = true;
            btnvenpro.Click += btnvenpro_Click;
            // 
            // grbven
            // 
            grbven.Controls.Add(btncont);
            grbven.Controls.Add(txtape);
            grbven.Controls.Add(txtnom);
            grbven.Controls.Add(label2);
            grbven.Controls.Add(label1);
            grbven.Location = new Point(150, 12);
            grbven.Name = "grbven";
            grbven.Size = new Size(200, 106);
            grbven.TabIndex = 3;
            grbven.TabStop = false;
            grbven.Text = "Venta nueva";
            grbven.Visible = false;
            // 
            // btncont
            // 
            btncont.Location = new Point(63, 74);
            btncont.Name = "btncont";
            btncont.Size = new Size(75, 23);
            btncont.TabIndex = 4;
            btncont.Text = "Continuar";
            btncont.UseVisualStyleBackColor = true;
            btncont.Click += btncont_Click;
            // 
            // txtape
            // 
            txtape.Location = new Point(63, 45);
            txtape.Name = "txtape";
            txtape.Size = new Size(131, 23);
            txtape.TabIndex = 3;
            // 
            // txtnom
            // 
            txtnom.Location = new Point(63, 16);
            txtnom.Name = "txtnom";
            txtnom.Size = new Size(131, 23);
            txtnom.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 49);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // grbcons
            // 
            grbcons.Controls.Add(btncons);
            grbcons.Controls.Add(label16);
            grbcons.Controls.Add(label15);
            grbcons.Controls.Add(label14);
            grbcons.Controls.Add(label13);
            grbcons.Controls.Add(label12);
            grbcons.Controls.Add(label11);
            grbcons.Controls.Add(txtcod);
            grbcons.Controls.Add(label9);
            grbcons.Location = new Point(356, 12);
            grbcons.Name = "grbcons";
            grbcons.Size = new Size(200, 153);
            grbcons.TabIndex = 6;
            grbcons.TabStop = false;
            grbcons.Text = "Consulta";
            grbcons.Visible = false;
            // 
            // btncons
            // 
            btncons.Location = new Point(57, 124);
            btncons.Name = "btncons";
            btncons.Size = new Size(75, 23);
            btncons.TabIndex = 8;
            btncons.Text = "Consultar";
            btncons.UseVisualStyleBackColor = true;
            btncons.Click += btncons_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(115, 97);
            label16.Name = "label16";
            label16.Size = new Size(46, 15);
            label16.TabIndex = 7;
            label16.Text = "6. Tinto";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(115, 72);
            label15.Name = "label15";
            label15.Size = new Size(61, 15);
            label15.TabIndex = 6;
            label15.Text = "5. Pasteles";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(115, 49);
            label14.Name = "label14";
            label14.Size = new Size(57, 15);
            label14.TabIndex = 5;
            label14.Text = "4. Papitas";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(11, 97);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 4;
            label13.Text = "3. Mecato";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 72);
            label12.Name = "label12";
            label12.Size = new Size(62, 15);
            label12.TabIndex = 3;
            label12.Text = "2. Gaseosa";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 49);
            label11.Name = "label11";
            label11.Size = new Size(63, 15);
            label11.TabIndex = 2;
            label11.Text = "1. Confites";
            // 
            // txtcod
            // 
            txtcod.Location = new Point(129, 22);
            txtcod.Name = "txtcod";
            txtcod.Size = new Size(65, 23);
            txtcod.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 26);
            label9.Name = "label9";
            label9.Size = new Size(117, 15);
            label9.TabIndex = 0;
            label9.Text = "Código del producto";
            // 
            // grbprod
            // 
            grbprod.Controls.Add(btnrei);
            grbprod.Controls.Add(btnfin);
            grbprod.Controls.Add(txttin);
            grbprod.Controls.Add(txtpap);
            grbprod.Controls.Add(txtgas);
            grbprod.Controls.Add(txtpas);
            grbprod.Controls.Add(txtmec);
            grbprod.Controls.Add(txtcon);
            grbprod.Controls.Add(label8);
            grbprod.Controls.Add(label7);
            grbprod.Controls.Add(label6);
            grbprod.Controls.Add(label5);
            grbprod.Controls.Add(label4);
            grbprod.Controls.Add(label3);
            grbprod.Controls.Add(btntin);
            grbprod.Controls.Add(btnpas);
            grbprod.Controls.Add(btnpap);
            grbprod.Controls.Add(btnmec);
            grbprod.Controls.Add(btngas);
            grbprod.Controls.Add(btnconf);
            grbprod.Location = new Point(12, 124);
            grbprod.Name = "grbprod";
            grbprod.Size = new Size(271, 316);
            grbprod.TabIndex = 4;
            grbprod.TabStop = false;
            grbprod.Text = "Productos";
            grbprod.Visible = false;
            // 
            // btnrei
            // 
            btnrei.Location = new Point(18, 287);
            btnrei.Name = "btnrei";
            btnrei.Size = new Size(75, 23);
            btnrei.TabIndex = 20;
            btnrei.Text = "Reiniciar";
            btnrei.UseVisualStyleBackColor = true;
            btnrei.Click += btnrei_Click;
            // 
            // btnfin
            // 
            btnfin.Location = new Point(174, 287);
            btnfin.Name = "btnfin";
            btnfin.Size = new Size(75, 23);
            btnfin.TabIndex = 19;
            btnfin.Text = "Finalizar";
            btnfin.UseVisualStyleBackColor = true;
            btnfin.Click += btnfin_Click;
            // 
            // txttin
            // 
            txttin.Enabled = false;
            txttin.Location = new Point(231, 217);
            txttin.Name = "txttin";
            txttin.Size = new Size(34, 23);
            txttin.TabIndex = 17;
            // 
            // txtpap
            // 
            txtpap.Enabled = false;
            txtpap.Location = new Point(231, 128);
            txtpap.Name = "txtpap";
            txtpap.Size = new Size(34, 23);
            txtpap.TabIndex = 16;
            // 
            // txtgas
            // 
            txtgas.Enabled = false;
            txtgas.Location = new Point(231, 39);
            txtgas.Name = "txtgas";
            txtgas.Size = new Size(34, 23);
            txtgas.TabIndex = 15;
            // 
            // txtpas
            // 
            txtpas.Enabled = false;
            txtpas.Location = new Point(94, 217);
            txtpas.Name = "txtpas";
            txtpas.Size = new Size(29, 23);
            txtpas.TabIndex = 14;
            // 
            // txtmec
            // 
            txtmec.Enabled = false;
            txtmec.Location = new Point(94, 128);
            txtmec.Name = "txtmec";
            txtmec.Size = new Size(29, 23);
            txtmec.TabIndex = 13;
            // 
            // txtcon
            // 
            txtcon.Enabled = false;
            txtcon.Location = new Point(94, 39);
            txtcon.Name = "txtcon";
            txtcon.Size = new Size(30, 23);
            txtcon.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(138, 261);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 11;
            label8.Text = "Tinto $500";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 261);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 10;
            label7.Text = "Pasteles $750";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(138, 172);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 9;
            label6.Text = "Papitas $800";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 172);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 8;
            label5.Text = "Mecato $500";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 83);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 7;
            label4.Text = "Gaseosa $1200";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 6;
            label3.Text = "Confites $200";
            // 
            // btntin
            // 
            btntin.BackColor = Color.White;
            btntin.Image = (Image)resources.GetObject("btntin.Image");
            btntin.Location = new Point(138, 197);
            btntin.Name = "btntin";
            btntin.Size = new Size(87, 61);
            btntin.TabIndex = 5;
            btntin.UseVisualStyleBackColor = false;
            btntin.Click += btntin_Click;
            // 
            // btnpas
            // 
            btnpas.BackColor = Color.White;
            btnpas.Image = (Image)resources.GetObject("btnpas.Image");
            btnpas.Location = new Point(6, 197);
            btnpas.Name = "btnpas";
            btnpas.Size = new Size(87, 61);
            btnpas.TabIndex = 4;
            btnpas.UseVisualStyleBackColor = false;
            btnpas.Click += btnpas_Click;
            // 
            // btnpap
            // 
            btnpap.BackColor = Color.White;
            btnpap.Image = (Image)resources.GetObject("btnpap.Image");
            btnpap.Location = new Point(138, 108);
            btnpap.Name = "btnpap";
            btnpap.Size = new Size(87, 61);
            btnpap.TabIndex = 3;
            btnpap.UseVisualStyleBackColor = false;
            btnpap.Click += btnpap_Click;
            // 
            // btnmec
            // 
            btnmec.BackColor = Color.White;
            btnmec.Image = (Image)resources.GetObject("btnmec.Image");
            btnmec.Location = new Point(6, 108);
            btnmec.Name = "btnmec";
            btnmec.Size = new Size(87, 61);
            btnmec.TabIndex = 2;
            btnmec.UseVisualStyleBackColor = false;
            btnmec.Click += btnmec_Click;
            // 
            // btngas
            // 
            btngas.BackColor = Color.White;
            btngas.Image = (Image)resources.GetObject("btngas.Image");
            btngas.Location = new Point(138, 19);
            btngas.Name = "btngas";
            btngas.Size = new Size(87, 61);
            btngas.TabIndex = 1;
            btngas.UseVisualStyleBackColor = false;
            btngas.Click += btngas_Click;
            // 
            // btnconf
            // 
            btnconf.BackColor = SystemColors.Control;
            btnconf.ForeColor = Color.Black;
            btnconf.Image = (Image)resources.GetObject("btnconf.Image");
            btnconf.Location = new Point(6, 19);
            btnconf.Name = "btnconf";
            btnconf.Size = new Size(87, 61);
            btnconf.TabIndex = 0;
            btnconf.UseVisualStyleBackColor = false;
            btnconf.Click += btnconf_Click;
            // 
            // grbinf
            // 
            grbinf.Controls.Add(btnnue);
            grbinf.Controls.Add(btnsalir);
            grbinf.Controls.Add(lblventa);
            grbinf.Controls.Add(label19);
            grbinf.Controls.Add(lblcant);
            grbinf.Controls.Add(label18);
            grbinf.Controls.Add(lblvalor);
            grbinf.Controls.Add(label17);
            grbinf.Controls.Add(lblnom);
            grbinf.Controls.Add(label10);
            grbinf.Controls.Add(picbprod);
            grbinf.Location = new Point(356, 182);
            grbinf.Name = "grbinf";
            grbinf.Size = new Size(207, 271);
            grbinf.TabIndex = 5;
            grbinf.TabStop = false;
            grbinf.Text = "Información del producto";
            grbinf.Visible = false;
            grbinf.Enter += grbinf_Enter;
            // 
            // btnnue
            // 
            btnnue.Location = new Point(125, 235);
            btnnue.Name = "btnnue";
            btnnue.Size = new Size(75, 23);
            btnnue.TabIndex = 18;
            btnnue.Text = "Nueva";
            btnnue.UseVisualStyleBackColor = true;
            btnnue.Click += btnnue_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(11, 235);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 23);
            btnsalir.TabIndex = 17;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += button1_Click;
            // 
            // lblventa
            // 
            lblventa.AutoSize = true;
            lblventa.Location = new Point(112, 205);
            lblventa.Name = "lblventa";
            lblventa.Size = new Size(0, 15);
            lblventa.TabIndex = 16;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 205);
            label19.Name = "label19";
            label19.Size = new Size(63, 15);
            label19.TabIndex = 15;
            label19.Text = "Venta total";
            // 
            // lblcant
            // 
            lblcant.AutoSize = true;
            lblcant.Location = new Point(112, 178);
            lblcant.Name = "lblcant";
            lblcant.Size = new Size(0, 15);
            lblcant.TabIndex = 14;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 178);
            label18.Name = "label18";
            label18.Size = new Size(100, 15);
            label18.TabIndex = 13;
            label18.Text = "Cantidad vendida";
            // 
            // lblvalor
            // 
            lblvalor.AutoSize = true;
            lblvalor.Location = new Point(112, 152);
            lblvalor.Name = "lblvalor";
            lblvalor.Size = new Size(0, 15);
            lblvalor.TabIndex = 12;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 152);
            label17.Name = "label17";
            label17.Size = new Size(33, 15);
            label17.TabIndex = 11;
            label17.Text = "Valor";
            // 
            // lblnom
            // 
            lblnom.AutoSize = true;
            lblnom.Location = new Point(112, 125);
            lblnom.Name = "lblnom";
            lblnom.Size = new Size(0, 15);
            lblnom.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 125);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 9;
            label10.Text = "Nombre:";
            // 
            // picbprod
            // 
            picbprod.Location = new Point(50, 27);
            picbprod.Name = "picbprod";
            picbprod.Size = new Size(107, 84);
            picbprod.SizeMode = PictureBoxSizeMode.Zoom;
            picbprod.TabIndex = 8;
            picbprod.TabStop = false;
            // 
            // grbtotal
            // 
            grbtotal.Controls.Add(btnsal);
            grbtotal.Controls.Add(lbltotal);
            grbtotal.Controls.Add(lbltin);
            grbtotal.Controls.Add(lblpas);
            grbtotal.Controls.Add(lblpap);
            grbtotal.Controls.Add(lblmec);
            grbtotal.Controls.Add(lblgas);
            grbtotal.Controls.Add(lblcon);
            grbtotal.Controls.Add(label26);
            grbtotal.Controls.Add(label25);
            grbtotal.Controls.Add(label24);
            grbtotal.Controls.Add(label23);
            grbtotal.Controls.Add(label22);
            grbtotal.Controls.Add(label21);
            grbtotal.Controls.Add(label20);
            grbtotal.Location = new Point(562, 19);
            grbtotal.Name = "grbtotal";
            grbtotal.Size = new Size(200, 157);
            grbtotal.TabIndex = 7;
            grbtotal.TabStop = false;
            grbtotal.Text = "Ventas totales";
            grbtotal.Visible = false;
            // 
            // btnsal
            // 
            btnsal.Location = new Point(58, 128);
            btnsal.Name = "btnsal";
            btnsal.Size = new Size(75, 23);
            btnsal.TabIndex = 14;
            btnsal.Text = "Salir";
            btnsal.UseVisualStyleBackColor = true;
            btnsal.Click += btnsal_Click;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Location = new Point(100, 109);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(0, 15);
            lbltotal.TabIndex = 13;
            // 
            // lbltin
            // 
            lbltin.AutoSize = true;
            lbltin.Location = new Point(100, 94);
            lbltin.Name = "lbltin";
            lbltin.Size = new Size(0, 15);
            lbltin.TabIndex = 12;
            // 
            // lblpas
            // 
            lblpas.AutoSize = true;
            lblpas.Location = new Point(100, 79);
            lblpas.Name = "lblpas";
            lblpas.Size = new Size(0, 15);
            lblpas.TabIndex = 11;
            // 
            // lblpap
            // 
            lblpap.AutoSize = true;
            lblpap.Location = new Point(100, 64);
            lblpap.Name = "lblpap";
            lblpap.Size = new Size(0, 15);
            lblpap.TabIndex = 10;
            // 
            // lblmec
            // 
            lblmec.AutoSize = true;
            lblmec.Location = new Point(100, 49);
            lblmec.Name = "lblmec";
            lblmec.Size = new Size(0, 15);
            lblmec.TabIndex = 9;
            // 
            // lblgas
            // 
            lblgas.AutoSize = true;
            lblgas.Location = new Point(100, 34);
            lblgas.Name = "lblgas";
            lblgas.Size = new Size(0, 15);
            lblgas.TabIndex = 8;
            // 
            // lblcon
            // 
            lblcon.AutoSize = true;
            lblcon.Location = new Point(100, 19);
            lblcon.Name = "lblcon";
            lblcon.Size = new Size(0, 15);
            lblcon.TabIndex = 7;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(6, 109);
            label26.Name = "label26";
            label26.Size = new Size(69, 15);
            label26.TabIndex = 6;
            label26.Text = "Venta total: ";
            label26.Click += label26_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(6, 94);
            label25.Name = "label25";
            label25.Size = new Size(66, 15);
            label25.TabIndex = 5;
            label25.Text = "Total tinto: ";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(6, 79);
            label24.Name = "label24";
            label24.Size = new Size(83, 15);
            label24.TabIndex = 4;
            label24.Text = "Total pasteles: ";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(6, 64);
            label23.Name = "label23";
            label23.Size = new Size(79, 15);
            label23.TabIndex = 3;
            label23.Text = "Total papitas: ";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(6, 49);
            label22.Name = "label22";
            label22.Size = new Size(81, 15);
            label22.TabIndex = 2;
            label22.Text = "Total mecato: ";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(6, 34);
            label21.Name = "label21";
            label21.Size = new Size(88, 15);
            label21.TabIndex = 1;
            label21.Text = "Total gaseosas: ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 19);
            label20.Name = "label20";
            label20.Size = new Size(85, 15);
            label20.TabIndex = 0;
            label20.Text = "Total Confites: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 460);
            Controls.Add(grbtotal);
            Controls.Add(grbinf);
            Controls.Add(grbcons);
            Controls.Add(grbprod);
            Controls.Add(grbven);
            Controls.Add(btnvenpro);
            Controls.Add(btntotal);
            Controls.Add(btnventa);
            Name = "Form1";
            Text = "Form1";
            grbven.ResumeLayout(false);
            grbven.PerformLayout();
            grbcons.ResumeLayout(false);
            grbcons.PerformLayout();
            grbprod.ResumeLayout(false);
            grbprod.PerformLayout();
            grbinf.ResumeLayout(false);
            grbinf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbprod).EndInit();
            grbtotal.ResumeLayout(false);
            grbtotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnventa;
        private Button btntotal;
        private Button btnvenpro;
        private GroupBox grbven;
        private Button btncont;
        private TextBox txtape;
        private TextBox txtnom;
        private Label label2;
        private Label label1;
        private GroupBox grbprod;
        private Button btntin;
        private Button btnpas;
        private Button btnpap;
        private Button btnmec;
        private Button btngas;
        private Button btnconf;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtpap;
        private TextBox txtgas;
        private TextBox txtpas;
        private TextBox txtmec;
        private TextBox txtcon;
        private TextBox txttin;
        private Button btnfin;
        private Button btnrei;
        private GroupBox grbinf;
        private GroupBox grbcons;
        private Label label9;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox txtcod;
        private PictureBox picbprod;
        private Button btncons;
        private Label lblventa;
        private Label label19;
        private Label lblcant;
        private Label label18;
        private Label lblvalor;
        private Label label17;
        private Label lblnom;
        private Label label10;
        private Button btnnue;
        private Button btnsalir;
        private GroupBox grbtotal;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label26;
        private Button btnsal;
        private Label lbltotal;
        private Label lbltin;
        private Label lblpas;
        private Label lblpap;
        private Label lblmec;
        private Label lblgas;
        private Label lblcon;
    }
}
