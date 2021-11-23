namespace Sistema_Inventario_Contable_GPS
{
    partial class VentanaCompraMateriaPrima
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblsubt = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txttt = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblfactura = new System.Windows.Forms.Label();
            this.txtfactura = new System.Windows.Forms.TextBox();
            this.lblOb = new System.Windows.Forms.Label();
            this.rtxtOb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblFecha.Location = new System.Drawing.Point(11, 24);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 17);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // lblsubt
            // 
            this.lblsubt.AutoSize = true;
            this.lblsubt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblsubt.Location = new System.Drawing.Point(12, 64);
            this.lblsubt.Name = "lblsubt";
            this.lblsubt.Size = new System.Drawing.Size(60, 17);
            this.lblsubt.TabIndex = 1;
            this.lblsubt.Text = "Subtotal";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblIva.Location = new System.Drawing.Point(12, 107);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(29, 17);
            this.lblIva.TabIndex = 3;
            this.lblIva.Text = "IVA";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(103, 59);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(152, 20);
            this.txtsubtotal.TabIndex = 9;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(103, 24);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(152, 20);
            this.txtfecha.TabIndex = 8;
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(103, 107);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(152, 20);
            this.txtIVA.TabIndex = 11;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbltotal.Location = new System.Drawing.Point(12, 150);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(40, 17);
            this.lbltotal.TabIndex = 15;
            this.lbltotal.Text = "Total";
            // 
            // txttt
            // 
            this.txttt.Location = new System.Drawing.Point(103, 147);
            this.txttt.Name = "txttt";
            this.txttt.Size = new System.Drawing.Size(152, 20);
            this.txttt.TabIndex = 16;
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(287, 202);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(145, 202);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblfactura
            // 
            this.lblfactura.AutoSize = true;
            this.lblfactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblfactura.Location = new System.Drawing.Point(284, 24);
            this.lblfactura.Name = "lblfactura";
            this.lblfactura.Size = new System.Drawing.Size(56, 17);
            this.lblfactura.TabIndex = 19;
            this.lblfactura.Text = "Factura";
            // 
            // txtfactura
            // 
            this.txtfactura.Location = new System.Drawing.Point(346, 24);
            this.txtfactura.Name = "txtfactura";
            this.txtfactura.Size = new System.Drawing.Size(152, 20);
            this.txtfactura.TabIndex = 20;
            // 
            // lblOb
            // 
            this.lblOb.AutoSize = true;
            this.lblOb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblOb.Location = new System.Drawing.Point(284, 59);
            this.lblOb.Name = "lblOb";
            this.lblOb.Size = new System.Drawing.Size(103, 17);
            this.lblOb.TabIndex = 21;
            this.lblOb.Text = "Observaciones";
            // 
            // rtxtOb
            // 
            this.rtxtOb.Location = new System.Drawing.Point(287, 79);
            this.rtxtOb.Name = "rtxtOb";
            this.rtxtOb.Size = new System.Drawing.Size(211, 88);
            this.rtxtOb.TabIndex = 23;
            this.rtxtOb.Text = "";
            // 
            // VentanaCompraMateriaPrima
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(526, 250);
            this.Controls.Add(this.rtxtOb);
            this.Controls.Add(this.lblOb);
            this.Controls.Add(this.txtfactura);
            this.Controls.Add(this.lblfactura);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txttt);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.lblsubt);
            this.Controls.Add(this.lblFecha);
            this.Name = "VentanaCompraMateriaPrima";
            this.Text = "VentanaCompraMateriaPrima";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblsubt;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txttt;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblfactura;
        private System.Windows.Forms.TextBox txtfactura;
        private System.Windows.Forms.Label lblOb;
        private System.Windows.Forms.RichTextBox rtxtOb;
    }
}