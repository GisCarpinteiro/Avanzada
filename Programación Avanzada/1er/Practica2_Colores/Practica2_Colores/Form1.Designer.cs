namespace Practica2_Colores
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
            this.SbN1 = new System.Windows.Forms.HScrollBar();
            this.SbN2 = new System.Windows.Forms.HScrollBar();
            this.SbN3 = new System.Windows.Forms.HScrollBar();
            this.lblRgb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SbN1
            // 
            this.SbN1.Location = new System.Drawing.Point(120, 86);
            this.SbN1.Name = "SbN1";
            this.SbN1.Size = new System.Drawing.Size(190, 36);
            this.SbN1.TabIndex = 0;
            // 
            // SbN2
            // 
            this.SbN2.Location = new System.Drawing.Point(120, 168);
            this.SbN2.Name = "SbN2";
            this.SbN2.Size = new System.Drawing.Size(190, 35);
            this.SbN2.TabIndex = 1;
            // 
            // SbN3
            // 
            this.SbN3.Location = new System.Drawing.Point(120, 249);
            this.SbN3.Name = "SbN3";
            this.SbN3.Size = new System.Drawing.Size(190, 35);
            this.SbN3.TabIndex = 2;
            // 
            // lblRgb
            // 
            this.lblRgb.AutoSize = true;
            this.lblRgb.Location = new System.Drawing.Point(193, 43);
            this.lblRgb.Name = "lblRgb";
            this.lblRgb.Size = new System.Drawing.Size(0, 13);
            this.lblRgb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 37);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(408, 378);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRgb);
            this.Controls.Add(this.SbN3);
            this.Controls.Add(this.SbN2);
            this.Controls.Add(this.SbN1);
            this.Name = "Form1";
            this.Text = "Colores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar SbN1;
        private System.Windows.Forms.HScrollBar SbN2;
        private System.Windows.Forms.HScrollBar SbN3;
        private System.Windows.Forms.Label lblRgb;
        private System.Windows.Forms.Label label1;
    }
}

