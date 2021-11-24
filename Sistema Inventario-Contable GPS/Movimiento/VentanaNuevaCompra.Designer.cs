
namespace Sistema_Inventario_Contable_GPS
{
    partial class VentanaNuevaCompra
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btninsertar = new System.Windows.Forms.Button();
            this.txtfactura = new System.Windows.Forms.TextBox();
            this.btnfactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(578, 343);
            this.dataGridView1.TabIndex = 6;
            // 
            // btninsertar
            // 
            this.btninsertar.Enabled = false;
            this.btninsertar.Location = new System.Drawing.Point(330, 5);
            this.btninsertar.Margin = new System.Windows.Forms.Padding(2);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(157, 21);
            this.btninsertar.TabIndex = 11;
            this.btninsertar.Text = "Agregar nueva materia prima";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtfactura
            // 
            this.txtfactura.Location = new System.Drawing.Point(12, 5);
            this.txtfactura.Name = "txtfactura";
            this.txtfactura.Size = new System.Drawing.Size(179, 20);
            this.txtfactura.TabIndex = 12;
            // 
            // btnfactura
            // 
            this.btnfactura.Location = new System.Drawing.Point(197, 4);
            this.btnfactura.Name = "btnfactura";
            this.btnfactura.Size = new System.Drawing.Size(128, 23);
            this.btnfactura.TabIndex = 13;
            this.btnfactura.Text = "Factura";
            this.btnfactura.UseVisualStyleBackColor = true;
            this.btnfactura.Click += new System.EventHandler(this.btnfactura_Click);
            // 
            // VentanaNuevaCompra
            // 
            this.AcceptButton = this.btninsertar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 380);
            this.Controls.Add(this.btnfactura);
            this.Controls.Add(this.txtfactura);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VentanaNuevaCompra";
            this.Text = "VentanaNuevaCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.TextBox txtfactura;
        private System.Windows.Forms.Button btnfactura;
    }
}