namespace ProyectoFinal_Nieves
{
    partial class Ver_ventasCajero
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
            this.cbFiltrar = new System.Windows.Forms.ComboBox();
            this.lblid = new System.Windows.Forms.Label();
            this.tbAv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGanancias = new System.Windows.Forms.Label();
            this.tbGanancia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvV
            // 
            this.dgvV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvV.Location = new System.Drawing.Point(64, 92);
            this.dgvV.Name = "dgvV";
            this.dgvV.Size = new System.Drawing.Size(344, 206);
            this.dgvV.TabIndex = 0;
            // 
            // cbFiltrar
            // 
            this.cbFiltrar.FormattingEnabled = true;
            this.cbFiltrar.Location = new System.Drawing.Point(64, 36);
            this.cbFiltrar.Name = "cbFiltrar";
            this.cbFiltrar.Size = new System.Drawing.Size(121, 21);
            this.cbFiltrar.TabIndex = 1;
            this.cbFiltrar.Text = "Día";
            this.cbFiltrar.SelectedIndexChanged += new System.EventHandler(this.cbFiltrar_SelectedIndexChanged);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(390, 21);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 13);
            this.lblid.TabIndex = 2;
            // 
            // tbAv
            // 
            this.tbAv.Location = new System.Drawing.Point(248, 37);
            this.tbAv.Name = "tbAv";
            this.tbAv.Size = new System.Drawing.Size(41, 20);
            this.tbAv.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Artículos vendidos";
            // 
            // lblGanancias
            // 
            this.lblGanancias.AutoSize = true;
            this.lblGanancias.Location = new System.Drawing.Point(361, 21);
            this.lblGanancias.Name = "lblGanancias";
            this.lblGanancias.Size = new System.Drawing.Size(58, 13);
            this.lblGanancias.TabIndex = 7;
            this.lblGanancias.Text = "Ganancias";
            // 
            // tbGanancia
            // 
            this.tbGanancia.Location = new System.Drawing.Point(352, 37);
            this.tbGanancia.Name = "tbGanancia";
            this.tbGanancia.Size = new System.Drawing.Size(73, 20);
            this.tbGanancia.TabIndex = 6;
            // 
            // Ver_ventasCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 382);
            this.Controls.Add(this.tbAv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGanancias);
            this.Controls.Add(this.tbGanancia);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.cbFiltrar);
            this.Controls.Add(this.dgvV);
            this.Name = "Ver_ventasCajero";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ver_ventasCajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvV;
        private System.Windows.Forms.ComboBox cbFiltrar;
        public System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox tbAv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGanancias;
        private System.Windows.Forms.TextBox tbGanancia;
    }
}