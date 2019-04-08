namespace Practica6_OvaloCreciente
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
            this.PbN1 = new System.Windows.Forms.PictureBox();
            this.SbHorizontal = new System.Windows.Forms.HScrollBar();
            this.SbVertical = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.PbN1)).BeginInit();
            this.SuspendLayout();
            // 
            // PbN1
            // 
            this.PbN1.Location = new System.Drawing.Point(43, 12);
            this.PbN1.Name = "PbN1";
            this.PbN1.Size = new System.Drawing.Size(255, 255);
            this.PbN1.TabIndex = 0;
            this.PbN1.TabStop = false;
            // 
            // SbHorizontal
            // 
            this.SbHorizontal.Location = new System.Drawing.Point(89, 270);
            this.SbHorizontal.Maximum = 200;
            this.SbHorizontal.Name = "SbHorizontal";
            this.SbHorizontal.Size = new System.Drawing.Size(148, 25);
            this.SbHorizontal.TabIndex = 1;
            this.SbHorizontal.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SbHorizontal_Scroll);
            this.SbHorizontal.ValueChanged += new System.EventHandler(this.SbHorizontal_ValueChanged);
            // 
            // SbVertical
            // 
            this.SbVertical.Location = new System.Drawing.Point(10, 56);
            this.SbVertical.Maximum = 200;
            this.SbVertical.Name = "SbVertical";
            this.SbVertical.Size = new System.Drawing.Size(20, 132);
            this.SbVertical.TabIndex = 2;
            this.SbVertical.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SbVertical_Scroll);
            this.SbVertical.ValueChanged += new System.EventHandler(this.SbVertical_ValueChanged);
            this.SbVertical.EnabledChanged += new System.EventHandler(this.SbVertical_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 304);
            this.Controls.Add(this.SbVertical);
            this.Controls.Add(this.SbHorizontal);
            this.Controls.Add(this.PbN1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbN1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbN1;
        private System.Windows.Forms.HScrollBar SbHorizontal;
        private System.Windows.Forms.VScrollBar SbVertical;
    }
}

