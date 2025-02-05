namespace arkanoid
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabla = new System.Windows.Forms.Button();
            this.bola = new System.Windows.Forms.Button();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tabla
            // 
            this.tabla.BackColor = System.Drawing.Color.Yellow;
            this.tabla.Enabled = false;
            this.tabla.Location = new System.Drawing.Point(98, 227);
            this.tabla.Name = "tabla";
            this.tabla.Size = new System.Drawing.Size(80, 23);
            this.tabla.TabIndex = 0;
            this.tabla.Text = "tabla";
            this.tabla.UseVisualStyleBackColor = false;
            this.tabla.LocationChanged += new System.EventHandler(this.tabla_LocationChanged);
            // 
            // bola
            // 
            this.bola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bola.Enabled = false;
            this.bola.Location = new System.Drawing.Point(133, 84);
            this.bola.Name = "bola";
            this.bola.Size = new System.Drawing.Size(13, 15);
            this.bola.TabIndex = 2;
            this.bola.UseVisualStyleBackColor = false;
            // 
            // txtposition
            // 
            this.txtposition.Location = new System.Drawing.Point(12, 1);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(260, 20);
            this.txtposition.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtposition);
            this.Controls.Add(this.bola);
            this.Controls.Add(this.tabla);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "arkanoid";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tabla;
        private System.Windows.Forms.Button bola;
        private System.Windows.Forms.TextBox txtposition;
        private System.Windows.Forms.Timer timer;
    }
}

