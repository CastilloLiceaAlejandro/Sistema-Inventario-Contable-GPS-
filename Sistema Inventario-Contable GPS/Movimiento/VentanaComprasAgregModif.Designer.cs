﻿namespace Sistema_Inventario_Contable_GPS
{
    partial class VentanaComprasAgregModif
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
            this.txtprod = new System.Windows.Forms.TextBox();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.lblprod = new System.Windows.Forms.Label();
            this.lblcost = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.rtxtOb = new System.Windows.Forms.RichTextBox();
            this.lblOb = new System.Windows.Forms.Label();
            this.txtfactura = new System.Windows.Forms.TextBox();
            this.lblfactura = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txttt = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblsubt = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtprod
            // 
            this.txtprod.Location = new System.Drawing.Point(100, 38);
            this.txtprod.Name = "txtprod";
            this.txtprod.Size = new System.Drawing.Size(152, 20);
            this.txtprod.TabIndex = 69;
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(100, 64);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(152, 20);
            this.txtcant.TabIndex = 68;
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(100, 90);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(152, 20);
            this.txtcost.TabIndex = 67;
            // 
            // lblprod
            // 
            this.lblprod.AutoSize = true;
            this.lblprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblprod.Location = new System.Drawing.Point(9, 38);
            this.lblprod.Name = "lblprod";
            this.lblprod.Size = new System.Drawing.Size(72, 17);
            this.lblprod.TabIndex = 66;
            this.lblprod.Text = "Productos";
            // 
            // lblcost
            // 
            this.lblcost.AutoSize = true;
            this.lblcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblcost.Location = new System.Drawing.Point(11, 90);
            this.lblcost.Name = "lblcost";
            this.lblcost.Size = new System.Drawing.Size(44, 17);
            this.lblcost.TabIndex = 65;
            this.lblcost.Text = "Costo";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblCant.Location = new System.Drawing.Point(9, 64);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(64, 17);
            this.lblCant.TabIndex = 64;
            this.lblCant.Text = "Cantidad";
            // 
            // rtxtOb
            // 
            this.rtxtOb.Location = new System.Drawing.Point(284, 65);
            this.rtxtOb.Name = "rtxtOb";
            this.rtxtOb.Size = new System.Drawing.Size(211, 123);
            this.rtxtOb.TabIndex = 63;
            this.rtxtOb.Text = "";
            // 
            // lblOb
            // 
            this.lblOb.AutoSize = true;
            this.lblOb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblOb.Location = new System.Drawing.Point(281, 45);
            this.lblOb.Name = "lblOb";
            this.lblOb.Size = new System.Drawing.Size(103, 17);
            this.lblOb.TabIndex = 62;
            this.lblOb.Text = "Observaciones";
            // 
            // txtfactura
            // 
            this.txtfactura.Enabled = false;
            this.txtfactura.Location = new System.Drawing.Point(343, 11);
            this.txtfactura.Name = "txtfactura";
            this.txtfactura.Size = new System.Drawing.Size(152, 20);
            this.txtfactura.TabIndex = 61;
            // 
            // lblfactura
            // 
            this.lblfactura.AutoSize = true;
            this.lblfactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblfactura.Location = new System.Drawing.Point(281, 12);
            this.lblfactura.Name = "lblfactura";
            this.lblfactura.Size = new System.Drawing.Size(56, 17);
            this.lblfactura.TabIndex = 60;
            this.lblfactura.Text = "Factura";
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(284, 214);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 59;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(142, 214);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 58;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txttt
            // 
            this.txttt.Location = new System.Drawing.Point(100, 168);
            this.txttt.Name = "txttt";
            this.txttt.Size = new System.Drawing.Size(152, 20);
            this.txttt.TabIndex = 57;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbltotal.Location = new System.Drawing.Point(9, 171);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(40, 17);
            this.lbltotal.TabIndex = 56;
            this.lbltotal.Text = "Total";
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(100, 142);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(152, 20);
            this.txtIVA.TabIndex = 55;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(100, 116);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(152, 20);
            this.txtsubtotal.TabIndex = 54;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(100, 12);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(152, 20);
            this.txtfecha.TabIndex = 53;
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblIva.Location = new System.Drawing.Point(9, 142);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(29, 17);
            this.lblIva.TabIndex = 52;
            this.lblIva.Text = "IVA";
            // 
            // lblsubt
            // 
            this.lblsubt.AutoSize = true;
            this.lblsubt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblsubt.Location = new System.Drawing.Point(9, 116);
            this.lblsubt.Name = "lblsubt";
            this.lblsubt.Size = new System.Drawing.Size(60, 17);
            this.lblsubt.TabIndex = 51;
            this.lblsubt.Text = "Subtotal";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblFecha.Location = new System.Drawing.Point(8, 12);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 17);
            this.lblFecha.TabIndex = 50;
            this.lblFecha.Text = "Fecha";
            // 
            // VentanaComprasAgregModif
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(507, 248);
            this.Controls.Add(this.txtprod);
            this.Controls.Add(this.txtcant);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.lblprod);
            this.Controls.Add(this.lblcost);
            this.Controls.Add(this.lblCant);
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
            this.Name = "VentanaComprasAgregModif";
            this.Text = "VentanaModificarCuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtprod;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.Label lblprod;
        private System.Windows.Forms.Label lblcost;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.RichTextBox rtxtOb;
        private System.Windows.Forms.Label lblOb;
        private System.Windows.Forms.TextBox txtfactura;
        private System.Windows.Forms.Label lblfactura;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txttt;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblsubt;
        private System.Windows.Forms.Label lblFecha;
    }
}