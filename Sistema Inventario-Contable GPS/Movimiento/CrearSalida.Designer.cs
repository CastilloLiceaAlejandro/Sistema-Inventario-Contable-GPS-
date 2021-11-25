namespace Sistema_Inventario_Contable_GPS
{
    partial class VentanaCrearSalida
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtfe = new System.Windows.Forms.TextBox();
            this.txtfo = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblFolio = new System.Windows.Forms.Label();
            this.lblfe = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblobser = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(246, 108);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(150, 108);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtfe
            // 
            this.txtfe.Location = new System.Drawing.Point(88, 38);
            this.txtfe.Name = "txtfe";
            this.txtfe.Size = new System.Drawing.Size(100, 20);
            this.txtfe.TabIndex = 15;
            // 
            // txtfo
            // 
            this.txtfo.Enabled = false;
            this.txtfo.Location = new System.Drawing.Point(88, 64);
            this.txtfo.Name = "txtfo";
            this.txtfo.Size = new System.Drawing.Size(100, 20);
            this.txtfo.TabIndex = 14;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(88, 12);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 13;
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblFolio.Location = new System.Drawing.Point(14, 67);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(38, 17);
            this.lblFolio.TabIndex = 12;
            this.lblFolio.Text = "Folio";
            // 
            // lblfe
            // 
            this.lblfe.AutoSize = true;
            this.lblfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblfe.Location = new System.Drawing.Point(14, 41);
            this.lblfe.Name = "lblfe";
            this.lblfe.Size = new System.Drawing.Size(47, 17);
            this.lblfe.TabIndex = 11;
            this.lblfe.Text = "Fecha";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblId.Location = new System.Drawing.Point(14, 12);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 17);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "Id";
            // 
            // lblobser
            // 
            this.lblobser.AutoSize = true;
            this.lblobser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblobser.Location = new System.Drawing.Point(218, 15);
            this.lblobser.Name = "lblobser";
            this.lblobser.Size = new System.Drawing.Size(103, 17);
            this.lblobser.TabIndex = 18;
            this.lblobser.Text = "Observaciones";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(221, 35);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(246, 49);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // VentanaCrearSalida
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(491, 146);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblobser);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtfe);
            this.Controls.Add(this.txtfo);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.lblfe);
            this.Controls.Add(this.lblId);
            this.Name = "VentanaCrearSalida";
            this.Text = "VentanaCrearSalida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtfe;
        private System.Windows.Forms.TextBox txtfo;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label lblfe;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblobser;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}