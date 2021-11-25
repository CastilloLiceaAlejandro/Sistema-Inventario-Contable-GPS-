
namespace Sistema_Inventario_Contable_GPS
{
    partial class VentanaMovimientosVentas
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
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(15, 165);
            this.buttonBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(117, 46);
            this.buttonBorrar.TabIndex = 33;
            this.buttonBorrar.Text = "Borrar Venta";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(15, 113);
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(117, 46);
            this.buttonModificar.TabIndex = 32;
            this.buttonModificar.Text = "Modificar Venta";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(15, 62);
            this.buttonCrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(117, 46);
            this.buttonCrear.TabIndex = 31;
            this.buttonCrear.Text = "Crear Venta";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(21, 258);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(101, 46);
            this.buttonBuscar.TabIndex = 30;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 231);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 29;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(15, 11);
            this.buttonActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(117, 44);
            this.buttonActualizar.TabIndex = 28;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(139, 11);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(644, 447);
            this.dataGridView.TabIndex = 27;
            // 
            // VentanaMovimientosVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 468);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VentanaMovimientosVentas";
            this.Text = "VentanaMovientosVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}