namespace Practica8_Cuadros
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
            this.BtnDibujar = new System.Windows.Forms.Button();
            this.PbUno = new System.Windows.Forms.PictureBox();
            this.PbDos = new System.Windows.Forms.PictureBox();
            this.PbTres = new System.Windows.Forms.PictureBox();
            this.PbCuatro = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblDos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCuatro)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDibujar
            // 
            this.BtnDibujar.Location = new System.Drawing.Point(254, 60);
            this.BtnDibujar.Name = "BtnDibujar";
            this.BtnDibujar.Size = new System.Drawing.Size(75, 23);
            this.BtnDibujar.TabIndex = 0;
            this.BtnDibujar.Text = "Dibujar";
            this.BtnDibujar.UseVisualStyleBackColor = true;
            this.BtnDibujar.Click += new System.EventHandler(this.BtnDibujar_Click);
            // 
            // PbUno
            // 
            this.PbUno.Location = new System.Drawing.Point(55, 100);
            this.PbUno.Name = "PbUno";
            this.PbUno.Size = new System.Drawing.Size(133, 114);
            this.PbUno.TabIndex = 1;
            this.PbUno.TabStop = false;
            // 
            // PbDos
            // 
            this.PbDos.Location = new System.Drawing.Point(241, 100);
            this.PbDos.Name = "PbDos";
            this.PbDos.Size = new System.Drawing.Size(186, 160);
            this.PbDos.TabIndex = 2;
            this.PbDos.TabStop = false;
            // 
            // PbTres
            // 
            this.PbTres.Location = new System.Drawing.Point(406, 278);
            this.PbTres.Name = "PbTres";
            this.PbTres.Size = new System.Drawing.Size(134, 117);
            this.PbTres.TabIndex = 3;
            this.PbTres.TabStop = false;
            // 
            // PbCuatro
            // 
            this.PbCuatro.Location = new System.Drawing.Point(124, 338);
            this.PbCuatro.Name = "PbCuatro";
            this.PbCuatro.Size = new System.Drawing.Size(64, 57);
            this.PbCuatro.TabIndex = 4;
            this.PbCuatro.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // LblDos
            // 
            this.LblDos.AutoSize = true;
            this.LblDos.Location = new System.Drawing.Point(10, 33);
            this.LblDos.Name = "LblDos";
            this.LblDos.Size = new System.Drawing.Size(0, 13);
            this.LblDos.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 419);
            this.Controls.Add(this.LblDos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PbCuatro);
            this.Controls.Add(this.PbTres);
            this.Controls.Add(this.PbDos);
            this.Controls.Add(this.PbUno);
            this.Controls.Add(this.BtnDibujar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCuatro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDibujar;
        private System.Windows.Forms.PictureBox PbUno;
        private System.Windows.Forms.PictureBox PbDos;
        private System.Windows.Forms.PictureBox PbTres;
        private System.Windows.Forms.PictureBox PbCuatro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDos;
    }
}

