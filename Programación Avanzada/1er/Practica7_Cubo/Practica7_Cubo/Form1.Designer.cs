namespace Practica7_Cubo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnArriba = new System.Windows.Forms.Button();
            this.BtnAbajo = new System.Windows.Forms.Button();
            this.BtnIzquierda = new System.Windows.Forms.Button();
            this.BtnDerecha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(170, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 281);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            
            // 
            // BtnArriba
            // 
            this.BtnArriba.Location = new System.Drawing.Point(39, 71);
            this.BtnArriba.Name = "BtnArriba";
            this.BtnArriba.Size = new System.Drawing.Size(49, 23);
            this.BtnArriba.TabIndex = 1;
            this.BtnArriba.Text = "Arriba";
            this.BtnArriba.UseVisualStyleBackColor = true;
            // 
            // BtnAbajo
            // 
            this.BtnAbajo.Location = new System.Drawing.Point(37, 125);
            this.BtnAbajo.Name = "BtnAbajo";
            this.BtnAbajo.Size = new System.Drawing.Size(51, 23);
            this.BtnAbajo.TabIndex = 2;
            this.BtnAbajo.Text = "Abajo";
            this.BtnAbajo.UseVisualStyleBackColor = true;
            // 
            // BtnIzquierda
            // 
            this.BtnIzquierda.Location = new System.Drawing.Point(12, 100);
            this.BtnIzquierda.Name = "BtnIzquierda";
            this.BtnIzquierda.Size = new System.Drawing.Size(53, 23);
            this.BtnIzquierda.TabIndex = 3;
            this.BtnIzquierda.Text = "Izquierda";
            this.BtnIzquierda.UseVisualStyleBackColor = true;
            // 
            // BtnDerecha
            // 
            this.BtnDerecha.Location = new System.Drawing.Point(87, 99);
            this.BtnDerecha.Name = "BtnDerecha";
            this.BtnDerecha.Size = new System.Drawing.Size(55, 23);
            this.BtnDerecha.TabIndex = 4;
            this.BtnDerecha.Text = "Derecha";
            this.BtnDerecha.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 387);
            this.Controls.Add(this.BtnDerecha);
            this.Controls.Add(this.BtnIzquierda);
            this.Controls.Add(this.BtnAbajo);
            this.Controls.Add(this.BtnArriba);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnArriba;
        private System.Windows.Forms.Button BtnAbajo;
        private System.Windows.Forms.Button BtnIzquierda;
        private System.Windows.Forms.Button BtnDerecha;
    }
}

