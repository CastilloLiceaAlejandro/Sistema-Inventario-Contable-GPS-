
namespace Sistema_Inventario_Contable_GPS
{
    partial class VentanaReporteMovimientos
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
            this.dataGridViewCompras = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewVentas = new System.Windows.Forms.DataGridView();
            this.dataGridViewEntradas = new System.Windows.Forms.DataGridView();
            this.dataGridViewSalidas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalidas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCompras
            // 
            this.dataGridViewCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompras.Location = new System.Drawing.Point(12, 28);
            this.dataGridViewCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCompras.Name = "dataGridViewCompras";
            this.dataGridViewCompras.RowHeadersWidth = 51;
            this.dataGridViewCompras.RowTemplate.Height = 24;
            this.dataGridViewCompras.Size = new System.Drawing.Size(742, 249);
            this.dataGridViewCompras.TabIndex = 6;
            this.dataGridViewCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1050, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ventas";
            // 
            // dataGridViewVentas
            // 
            this.dataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVentas.Location = new System.Drawing.Point(760, 28);
            this.dataGridViewVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewVentas.Name = "dataGridViewVentas";
            this.dataGridViewVentas.RowHeadersWidth = 51;
            this.dataGridViewVentas.RowTemplate.Height = 24;
            this.dataGridViewVentas.Size = new System.Drawing.Size(612, 249);
            this.dataGridViewVentas.TabIndex = 25;
            this.dataGridViewVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVentas_CellContentClick);
            // 
            // dataGridViewEntradas
            // 
            this.dataGridViewEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntradas.Location = new System.Drawing.Point(111, 328);
            this.dataGridViewEntradas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewEntradas.Name = "dataGridViewEntradas";
            this.dataGridViewEntradas.RowHeadersWidth = 51;
            this.dataGridViewEntradas.RowTemplate.Height = 24;
            this.dataGridViewEntradas.Size = new System.Drawing.Size(482, 249);
            this.dataGridViewEntradas.TabIndex = 26;
            this.dataGridViewEntradas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEntradas_CellContentClick);
            // 
            // dataGridViewSalidas
            // 
            this.dataGridViewSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalidas.Location = new System.Drawing.Point(807, 328);
            this.dataGridViewSalidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSalidas.Name = "dataGridViewSalidas";
            this.dataGridViewSalidas.RowHeadersWidth = 51;
            this.dataGridViewSalidas.RowTemplate.Height = 24;
            this.dataGridViewSalidas.Size = new System.Drawing.Size(474, 249);
            this.dataGridViewSalidas.TabIndex = 27;
            this.dataGridViewSalidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSalidas_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Compras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Entradas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1050, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Salidas";
            // 
            // VentanaReporteMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 597);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSalidas);
            this.Controls.Add(this.dataGridViewEntradas);
            this.Controls.Add(this.dataGridViewVentas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewCompras);
            this.Name = "VentanaReporteMovimientos";
            this.Text = "VentanaReporteMovimientos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCompras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewVentas;
        private System.Windows.Forms.DataGridView dataGridViewEntradas;
        private System.Windows.Forms.DataGridView dataGridViewSalidas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}