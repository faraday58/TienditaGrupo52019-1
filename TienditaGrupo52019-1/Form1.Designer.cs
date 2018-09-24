namespace TienditaGrupo52019_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbClavedelproducto = new System.Windows.Forms.TextBox();
            this.txtbPreciounidad = new System.Windows.Forms.TextBox();
            this.txtbAlmacen = new System.Windows.Forms.TextBox();
            this.rdbEfectivo = new System.Windows.Forms.RadioButton();
            this.rdbTarjetacredito = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbResultadoPago = new System.Windows.Forms.Label();
            this.lbResultadoProducto = new System.Windows.Forms.Label();
            this.lbResultadoUnidades = new System.Windows.Forms.Label();
            this.lbResultadoTotal = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbCantidadCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbEfectivo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Clave del Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Precio por Unidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad en almacen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Metodo de pago";
            // 
            // txtbClavedelproducto
            // 
            this.txtbClavedelproducto.Enabled = false;
            this.txtbClavedelproducto.Location = new System.Drawing.Point(348, 60);
            this.txtbClavedelproducto.Name = "txtbClavedelproducto";
            this.txtbClavedelproducto.Size = new System.Drawing.Size(148, 20);
            this.txtbClavedelproducto.TabIndex = 1;
            // 
            // txtbPreciounidad
            // 
            this.txtbPreciounidad.Enabled = false;
            this.txtbPreciounidad.Location = new System.Drawing.Point(35, 140);
            this.txtbPreciounidad.Name = "txtbPreciounidad";
            this.txtbPreciounidad.Size = new System.Drawing.Size(148, 20);
            this.txtbPreciounidad.TabIndex = 1;
            // 
            // txtbAlmacen
            // 
            this.txtbAlmacen.Enabled = false;
            this.txtbAlmacen.Location = new System.Drawing.Point(348, 159);
            this.txtbAlmacen.Name = "txtbAlmacen";
            this.txtbAlmacen.Size = new System.Drawing.Size(148, 20);
            this.txtbAlmacen.TabIndex = 1;
            // 
            // rdbEfectivo
            // 
            this.rdbEfectivo.AutoSize = true;
            this.rdbEfectivo.Location = new System.Drawing.Point(348, 253);
            this.rdbEfectivo.Name = "rdbEfectivo";
            this.rdbEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rdbEfectivo.TabIndex = 2;
            this.rdbEfectivo.TabStop = true;
            this.rdbEfectivo.Text = "Efectivo";
            this.rdbEfectivo.UseVisualStyleBackColor = true;
            this.rdbEfectivo.CheckedChanged += new System.EventHandler(this.rdbEfectivo_CheckedChanged);
            // 
            // rdbTarjetacredito
            // 
            this.rdbTarjetacredito.AutoSize = true;
            this.rdbTarjetacredito.Location = new System.Drawing.Point(348, 230);
            this.rdbTarjetacredito.Name = "rdbTarjetacredito";
            this.rdbTarjetacredito.Size = new System.Drawing.Size(109, 17);
            this.rdbTarjetacredito.TabIndex = 2;
            this.rdbTarjetacredito.TabStop = true;
            this.rdbTarjetacredito.Text = "Tarjeta de Credito";
            this.rdbTarjetacredito.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Datos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Metodo de pago:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Producto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Unidades";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Total";
            // 
            // lbResultadoPago
            // 
            this.lbResultadoPago.AutoSize = true;
            this.lbResultadoPago.Location = new System.Drawing.Point(200, 326);
            this.lbResultadoPago.Name = "lbResultadoPago";
            this.lbResultadoPago.Size = new System.Drawing.Size(61, 13);
            this.lbResultadoPago.TabIndex = 0;
            this.lbResultadoPago.Text = "Resultado1";
            // 
            // lbResultadoProducto
            // 
            this.lbResultadoProducto.AutoSize = true;
            this.lbResultadoProducto.Location = new System.Drawing.Point(200, 351);
            this.lbResultadoProducto.Name = "lbResultadoProducto";
            this.lbResultadoProducto.Size = new System.Drawing.Size(61, 13);
            this.lbResultadoProducto.TabIndex = 0;
            this.lbResultadoProducto.Text = "Resultado2";
            // 
            // lbResultadoUnidades
            // 
            this.lbResultadoUnidades.AutoSize = true;
            this.lbResultadoUnidades.Location = new System.Drawing.Point(200, 375);
            this.lbResultadoUnidades.Name = "lbResultadoUnidades";
            this.lbResultadoUnidades.Size = new System.Drawing.Size(61, 13);
            this.lbResultadoUnidades.TabIndex = 0;
            this.lbResultadoUnidades.Text = "Resultado3";
            // 
            // lbResultadoTotal
            // 
            this.lbResultadoTotal.AutoSize = true;
            this.lbResultadoTotal.Location = new System.Drawing.Point(200, 400);
            this.lbResultadoTotal.Name = "lbResultadoTotal";
            this.lbResultadoTotal.Size = new System.Drawing.Size(61, 13);
            this.lbResultadoTotal.TabIndex = 0;
            this.lbResultadoTotal.Text = "Resultado4";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(398, 302);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(159, 62);
            this.btnPagar.TabIndex = 3;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(35, 59);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(148, 21);
            this.cmbProducto.TabIndex = 4;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_Efectivo);
            this.cmbProducto.SelectionChangeCommitted += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cantidad  que requiere";
            // 
            // txtbCantidadCliente
            // 
            this.txtbCantidadCliente.Location = new System.Drawing.Point(35, 230);
            this.txtbCantidadCliente.Name = "txtbCantidadCliente";
            this.txtbCantidadCliente.Size = new System.Drawing.Size(148, 20);
            this.txtbCantidadCliente.TabIndex = 6;
            this.txtbCantidadCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbCantidadCliente_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbClavedelproducto);
            this.groupBox1.Controls.Add(this.txtbEfectivo);
            this.groupBox1.Controls.Add(this.txtbAlmacen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rdbEfectivo);
            this.groupBox1.Controls.Add(this.rdbTarjetacredito);
            this.groupBox1.Controls.Add(this.txtbCantidadCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtbPreciounidad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbProducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(61, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 269);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elige Producto";
            // 
            // txtbEfectivo
            // 
            this.txtbEfectivo.Location = new System.Drawing.Point(479, 249);
            this.txtbEfectivo.Name = "txtbEfectivo";
            this.txtbEfectivo.Size = new System.Drawing.Size(148, 20);
            this.txtbEfectivo.TabIndex = 1;
            this.txtbEfectivo.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(61, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 136);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TienditaGrupo52019_1.Properties.Resources.Escudo_Ingenieria;
            this.pictureBox1.Location = new System.Drawing.Point(694, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbResultadoTotal);
            this.Controls.Add(this.lbResultadoUnidades);
            this.Controls.Add(this.lbResultadoProducto);
            this.Controls.Add(this.lbResultadoPago);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbClavedelproducto;
        private System.Windows.Forms.TextBox txtbPreciounidad;
        private System.Windows.Forms.TextBox txtbAlmacen;
        private System.Windows.Forms.RadioButton rdbEfectivo;
        private System.Windows.Forms.RadioButton rdbTarjetacredito;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbResultadoPago;
        private System.Windows.Forms.Label lbResultadoProducto;
        private System.Windows.Forms.Label lbResultadoUnidades;
        private System.Windows.Forms.Label lbResultadoTotal;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbCantidadCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProv;
        private System.Windows.Forms.TextBox txtbEfectivo;
    }
}

