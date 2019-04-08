namespace Practica5_Figuras
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
            this.btDibujar = new System.Windows.Forms.Button();
            this.PbN4 = new System.Windows.Forms.PictureBox();
            this.PbN2 = new System.Windows.Forms.PictureBox();
            this.PbN3 = new System.Windows.Forms.PictureBox();
            this.PbNombre = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbN4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbN2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbN3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // PbN1
            // 
            this.PbN1.Location = new System.Drawing.Point(27, 54);
            this.PbN1.Name = "PbN1";
            this.PbN1.Size = new System.Drawing.Size(127, 97);
            this.PbN1.TabIndex = 0;
            this.PbN1.TabStop = false;
            // 
            // btDibujar
            // 
            this.btDibujar.Location = new System.Drawing.Point(105, 12);
            this.btDibujar.Name = "btDibujar";
            this.btDibujar.Size = new System.Drawing.Size(75, 23);
            this.btDibujar.TabIndex = 1;
            this.btDibujar.Text = "Dibujar";
            this.btDibujar.UseVisualStyleBackColor = true;
            this.btDibujar.Click += new System.EventHandler(this.btDibujar_Click);
            // 
            // PbN4
            // 
            this.PbN4.Location = new System.Drawing.Point(318, 54);
            this.PbN4.Name = "PbN4";
            this.PbN4.Size = new System.Drawing.Size(297, 303);
            this.PbN4.TabIndex = 2;
            this.PbN4.TabStop = false;
            // 
            // PbN2
            // 
            this.PbN2.Location = new System.Drawing.Point(160, 54);
            this.PbN2.Name = "PbN2";
            this.PbN2.Size = new System.Drawing.Size(123, 68);
            this.PbN2.TabIndex = 3;
            this.PbN2.TabStop = false;
            // 
            // PbN3
            // 
            this.PbN3.Location = new System.Drawing.Point(160, 128);
            this.PbN3.Name = "PbN3";
            this.PbN3.Size = new System.Drawing.Size(123, 68);
            this.PbN3.TabIndex = 4;
            this.PbN3.TabStop = false;
            // 
            // PbNombre
            // 
            this.PbNombre.Location = new System.Drawing.Point(27, 157);
            this.PbNombre.Name = "PbNombre";
            this.PbNombre.Size = new System.Drawing.Size(123, 50);
            this.PbNombre.TabIndex = 5;
            this.PbNombre.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 468);
            this.Controls.Add(this.PbNombre);
            this.Controls.Add(this.PbN3);
            this.Controls.Add(this.PbN2);
            this.Controls.Add(this.PbN4);
            this.Controls.Add(this.btDibujar);
            this.Controls.Add(this.PbN1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbN4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbN2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbN3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNombre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbN1;
        private System.Windows.Forms.Button btDibujar;
        private System.Windows.Forms.PictureBox PbN4;
        private System.Windows.Forms.PictureBox PbN2;
        private System.Windows.Forms.PictureBox PbN3;
        private System.Windows.Forms.PictureBox PbNombre;
    }
}

