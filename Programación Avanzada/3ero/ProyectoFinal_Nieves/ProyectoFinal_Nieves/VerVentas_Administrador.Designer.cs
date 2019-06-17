namespace ProyectoFinal_Nieves
{
    partial class VerVentas_Administrador
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
            this.dgvV = new System.Windows.Forms.DataGridView();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.tbGanancia = new System.Windows.Forms.TextBox();
            this.lblGanancias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvV
            // 
            this.dgvV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvV.Location = new System.Drawing.Point(47, 64);
            this.dgvV.Name = "dgvV";
            this.dgvV.Size = new System.Drawing.Size(430, 206);
            this.dgvV.TabIndex = 0;
            // 
            // cbFiltro
            // 
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(47, 25);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cbFiltro.TabIndex = 1;
            this.cbFiltro.Text = "Día";
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // tbGanancia
            // 
            this.tbGanancia.Location = new System.Drawing.Point(377, 296);
            this.tbGanancia.Name = "tbGanancia";
            this.tbGanancia.Size = new System.Drawing.Size(100, 20);
            this.tbGanancia.TabIndex = 2;
            // 
            // lblGanancias
            // 
            this.lblGanancias.AutoSize = true;
            this.lblGanancias.Location = new System.Drawing.Point(295, 296);
            this.lblGanancias.Name = "lblGanancias";
            this.lblGanancias.Size = new System.Drawing.Size(58, 13);
            this.lblGanancias.TabIndex = 3;
            this.lblGanancias.Text = "Ganancias";
            // 
            // VerVentas_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 357);
            this.Controls.Add(this.lblGanancias);
            this.Controls.Add(this.tbGanancia);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.dgvV);
            this.Name = "VerVentas_Administrador";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.VerVentas_Administrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvV;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.TextBox tbGanancia;
        private System.Windows.Forms.Label lblGanancias;
    }
}