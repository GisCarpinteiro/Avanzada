namespace Practica4_Graficos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PbPapel = new System.Windows.Forms.PictureBox();
            this.BtDibujar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbPapel)).BeginInit();
            this.SuspendLayout();
            // 
            // PbPapel
            // 
            this.PbPapel.Location = new System.Drawing.Point(22, 34);
            this.PbPapel.Name = "PbPapel";
            this.PbPapel.Size = new System.Drawing.Size(239, 203);
            this.PbPapel.TabIndex = 0;
            this.PbPapel.TabStop = false;
            // 
            // BtDibujar
            // 
            this.BtDibujar.Location = new System.Drawing.Point(99, 5);
            this.BtDibujar.Name = "BtDibujar";
            this.BtDibujar.Size = new System.Drawing.Size(75, 23);
            this.BtDibujar.TabIndex = 1;
            this.BtDibujar.Text = "Dibujar";
            this.BtDibujar.UseVisualStyleBackColor = true;
            this.BtDibujar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.BtDibujar);
            this.Controls.Add(this.PbPapel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbPapel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbPapel;
        private System.Windows.Forms.Button BtDibujar;
    }
}

