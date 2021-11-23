
namespace Sistema_Inventario_Contable_GPS
{
    partial class VentanaReporteAlmacen
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
            this.dataGridViewEntradas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewSalidas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalidas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEntradas
            // 
            this.dataGridViewEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntradas.Location = new System.Drawing.Point(12, 34);
            this.dataGridViewEntradas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewEntradas.Name = "dataGridViewEntradas";
            this.dataGridViewEntradas.RowHeadersWidth = 51;
            this.dataGridViewEntradas.RowTemplate.Height = 24;
            this.dataGridViewEntradas.Size = new System.Drawing.Size(375, 423);
            this.dataGridViewEntradas.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 37;
            // 
            // dataGridViewSalidas
            // 
            this.dataGridViewSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalidas.Location = new System.Drawing.Point(408, 34);
            this.dataGridViewSalidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSalidas.Name = "dataGridViewSalidas";
            this.dataGridViewSalidas.RowHeadersWidth = 51;
            this.dataGridViewSalidas.RowTemplate.Height = 24;
            this.dataGridViewSalidas.Size = new System.Drawing.Size(375, 423);
            this.dataGridViewSalidas.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Entradas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Salidas";
            // 
            // VentanaReporteAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 468);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSalidas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewEntradas);
            this.Name = "VentanaReporteAlmacen";
            this.Text = "VentanaReporteAlmacen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewEntradas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewSalidas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}