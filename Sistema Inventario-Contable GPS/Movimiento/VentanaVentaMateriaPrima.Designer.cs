
namespace Sistema_Inventario_Contable_GPS
{
    partial class VentanaVentaMateriaPrima
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
            this.txtprec = new System.Windows.Forms.TextBox();
            this.lblprod = new System.Windows.Forms.Label();
            this.lblcost = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.rtxtOb = new System.Windows.Forms.RichTextBox();
            this.lblOb = new System.Windows.Forms.Label();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textidVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtprod
            // 
            this.txtprod.Location = new System.Drawing.Point(152, 89);
            this.txtprod.Margin = new System.Windows.Forms.Padding(4);
            this.txtprod.Name = "txtprod";
            this.txtprod.Size = new System.Drawing.Size(201, 22);
            this.txtprod.TabIndex = 69;
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(152, 121);
            this.txtcant.Margin = new System.Windows.Forms.Padding(4);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(201, 22);
            this.txtcant.TabIndex = 68;
            // 
            // txtprec
            // 
            this.txtprec.Location = new System.Drawing.Point(152, 153);
            this.txtprec.Margin = new System.Windows.Forms.Padding(4);
            this.txtprec.Name = "txtprec";
            this.txtprec.Size = new System.Drawing.Size(201, 22);
            this.txtprec.TabIndex = 67;
            // 
            // lblprod
            // 
            this.lblprod.AutoSize = true;
            this.lblprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblprod.Location = new System.Drawing.Point(30, 89);
            this.lblprod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprod.Name = "lblprod";
            this.lblprod.Size = new System.Drawing.Size(76, 20);
            this.lblprod.TabIndex = 66;
            this.lblprod.Text = "Producto";
            // 
            // lblcost
            // 
            this.lblcost.AutoSize = true;
            this.lblcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblcost.Location = new System.Drawing.Point(33, 153);
            this.lblcost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcost.Name = "lblcost";
            this.lblcost.Size = new System.Drawing.Size(57, 20);
            this.lblcost.TabIndex = 65;
            this.lblcost.Text = "Precio";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblCant.Location = new System.Drawing.Point(30, 121);
            this.lblCant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(75, 20);
            this.lblCant.TabIndex = 64;
            this.lblCant.Text = "Cantidad";
            // 
            // rtxtOb
            // 
            this.rtxtOb.Location = new System.Drawing.Point(394, 51);
            this.rtxtOb.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtOb.Name = "rtxtOb";
            this.rtxtOb.Size = new System.Drawing.Size(280, 191);
            this.rtxtOb.TabIndex = 63;
            this.rtxtOb.Text = "";
            // 
            // lblOb
            // 
            this.lblOb.AutoSize = true;
            this.lblOb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblOb.Location = new System.Drawing.Point(390, 27);
            this.lblOb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOb.Name = "lblOb";
            this.lblOb.Size = new System.Drawing.Size(121, 20);
            this.lblOb.TabIndex = 62;
            this.lblOb.Text = "Observaciones";
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(394, 276);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 59;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(205, 276);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 58;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txttt
            // 
            this.txttt.Location = new System.Drawing.Point(152, 249);
            this.txttt.Margin = new System.Windows.Forms.Padding(4);
            this.txttt.Name = "txttt";
            this.txttt.Size = new System.Drawing.Size(201, 22);
            this.txttt.TabIndex = 57;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbltotal.Location = new System.Drawing.Point(30, 253);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(46, 20);
            this.lbltotal.TabIndex = 56;
            this.lbltotal.Text = "Total";
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(152, 217);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(4);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(201, 22);
            this.txtIVA.TabIndex = 55;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(152, 185);
            this.txtsubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(201, 22);
            this.txtsubtotal.TabIndex = 54;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(152, 57);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(201, 22);
            this.txtfecha.TabIndex = 53;
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblIva.Location = new System.Drawing.Point(30, 217);
            this.lblIva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(35, 20);
            this.lblIva.TabIndex = 52;
            this.lblIva.Text = "IVA";
            // 
            // lblsubt
            // 
            this.lblsubt.AutoSize = true;
            this.lblsubt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblsubt.Location = new System.Drawing.Point(30, 185);
            this.lblsubt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsubt.Name = "lblsubt";
            this.lblsubt.Size = new System.Drawing.Size(70, 20);
            this.lblsubt.TabIndex = 51;
            this.lblsubt.Text = "Subtotal";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblFecha.Location = new System.Drawing.Point(29, 57);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(55, 20);
            this.lblFecha.TabIndex = 50;
            this.lblFecha.Text = "Fecha";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(687, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(421, 306);
            this.dataGridView1.TabIndex = 70;
            // 
            // textidVenta
            // 
            this.textidVenta.Location = new System.Drawing.Point(152, 27);
            this.textidVenta.Margin = new System.Windows.Forms.Padding(4);
            this.textidVenta.Name = "textidVenta";
            this.textidVenta.Size = new System.Drawing.Size(201, 22);
            this.textidVenta.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "Venta";
            // 
            // VentanaVentaMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 331);
            this.Controls.Add(this.textidVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtprod);
            this.Controls.Add(this.txtcant);
            this.Controls.Add(this.txtprec);
            this.Controls.Add(this.lblprod);
            this.Controls.Add(this.lblcost);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.rtxtOb);
            this.Controls.Add(this.lblOb);
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
            this.Name = "VentanaVentaMateriaPrima";
            this.Text = "VentanaVentaMateriaPrima";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtprod;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.TextBox txtprec;
        private System.Windows.Forms.Label lblprod;
        private System.Windows.Forms.Label lblcost;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.RichTextBox rtxtOb;
        private System.Windows.Forms.Label lblOb;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textidVenta;
        private System.Windows.Forms.Label label1;
    }
}