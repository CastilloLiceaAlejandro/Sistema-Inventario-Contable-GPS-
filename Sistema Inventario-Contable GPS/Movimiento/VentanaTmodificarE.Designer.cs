namespace Sistema_Inventario_Contable_GPS
{
    partial class VentanaTmodificarE
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
            this.txtfac = new System.Windows.Forms.TextBox();
            this.btnmod = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfac
            // 
            this.txtfac.Location = new System.Drawing.Point(12, 11);
            this.txtfac.Name = "txtfac";
            this.txtfac.Size = new System.Drawing.Size(161, 20);
            this.txtfac.TabIndex = 17;
            // 
            // btnmod
            // 
            this.btnmod.Location = new System.Drawing.Point(178, 10);
            this.btnmod.Margin = new System.Windows.Forms.Padding(2);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(157, 21);
            this.btnmod.TabIndex = 16;
            this.btnmod.Text = "Modificar Entrada";
            this.btnmod.UseVisualStyleBackColor = true;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 35);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(578, 343);
            this.dataGridView1.TabIndex = 15;
            // 
            // VentanaTmodificarE
            // 
            this.AcceptButton = this.btnmod;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 386);
            this.Controls.Add(this.txtfac);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VentanaTmodificarE";
            this.Text = "VentanaTmodificarE";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfac;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}