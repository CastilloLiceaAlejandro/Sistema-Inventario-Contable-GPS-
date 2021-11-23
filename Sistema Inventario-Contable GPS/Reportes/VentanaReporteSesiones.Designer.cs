
namespace Sistema_Inventario_Contable_GPS
{
    partial class VentanaReporteSesiones
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
            this.dataGridViewSesiones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSesiones)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSesiones
            // 
            this.dataGridViewSesiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSesiones.Location = new System.Drawing.Point(12, 11);
            this.dataGridViewSesiones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSesiones.Name = "dataGridViewSesiones";
            this.dataGridViewSesiones.RowHeadersWidth = 51;
            this.dataGridViewSesiones.RowTemplate.Height = 24;
            this.dataGridViewSesiones.Size = new System.Drawing.Size(771, 446);
            this.dataGridViewSesiones.TabIndex = 25;
            this.dataGridViewSesiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // VentanaReporteSesiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 468);
            this.Controls.Add(this.dataGridViewSesiones);
            this.Name = "VentanaReporteSesiones";
            this.Text = "VentanaReporteSesiones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSesiones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewSesiones;
    }
}