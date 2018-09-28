namespace TienditaGrupo52019_1
{
    partial class FormTarjeta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.lbprueba = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.mtbNumeroTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.mtbCvv = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbVencimiento = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPago = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalPagar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(76, 32);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(0, 13);
            this.lblTotalPagar.TabIndex = 0;
            // 
            // lbprueba
            // 
            this.lbprueba.AutoSize = true;
            this.lbprueba.Location = new System.Drawing.Point(355, 35);
            this.lbprueba.Name = "lbprueba";
            this.lbprueba.Size = new System.Drawing.Size(82, 13);
            this.lbprueba.TabIndex = 0;
            this.lbprueba.Text = "Total a pagar: $";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pago con Tarjeta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Número Tarjeta";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(240, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "CVV";
            // 
            // mtbNumeroTarjeta
            // 
            this.mtbNumeroTarjeta.Location = new System.Drawing.Point(52, 120);
            this.mtbNumeroTarjeta.Mask = "0000 - 0000 - 0000 - 0000";
            this.mtbNumeroTarjeta.Name = "mtbNumeroTarjeta";
            this.mtbNumeroTarjeta.Size = new System.Drawing.Size(138, 20);
            this.mtbNumeroTarjeta.TabIndex = 3;
            // 
            // mtbCvv
            // 
            this.mtbCvv.Location = new System.Drawing.Point(233, 119);
            this.mtbCvv.Mask = "000";
            this.mtbCvv.Name = "mtbCvv";
            this.mtbCvv.Size = new System.Drawing.Size(49, 20);
            this.mtbCvv.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fecha de Vencimiento (mes / año)";
            // 
            // mtbVencimiento
            // 
            this.mtbVencimiento.Location = new System.Drawing.Point(444, 120);
            this.mtbVencimiento.Mask = "00 / 00";
            this.mtbVencimiento.Name = "mtbVencimiento";
            this.mtbVencimiento.Size = new System.Drawing.Size(57, 20);
            this.mtbVencimiento.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TienditaGrupo52019_1.Properties.Resources.LogoPayPal;
            this.pictureBox1.Location = new System.Drawing.Point(334, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnPago
            // 
            this.btnPago.Location = new System.Drawing.Point(52, 164);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(230, 57);
            this.btnPago.TabIndex = 6;
            this.btnPago.Text = "Finalizar Transacción";
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // FormTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 293);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.lbprueba);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtbVencimiento);
            this.Controls.Add(this.mtbCvv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtbNumeroTarjeta);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTarjeta";
            this.Text = "FormTarjeta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lbprueba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox mtbNumeroTarjeta;
        private System.Windows.Forms.MaskedTextBox mtbCvv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbVencimiento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPago;
    }
}