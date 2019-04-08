namespace Practica9_ValordeCuadros
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbX1 = new System.Windows.Forms.TextBox();
            this.TbX2 = new System.Windows.Forms.TextBox();
            this.TbX3 = new System.Windows.Forms.TextBox();
            this.TbY1 = new System.Windows.Forms.TextBox();
            this.TbY2 = new System.Windows.Forms.TextBox();
            this.TbY3 = new System.Windows.Forms.TextBox();
            this.BtDibujar = new System.Windows.Forms.Button();
            this.PbUno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbUno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y";
            // 
            // TbX1
            // 
            this.TbX1.Location = new System.Drawing.Point(22, 63);
            this.TbX1.Name = "TbX1";
            this.TbX1.Size = new System.Drawing.Size(100, 20);
            this.TbX1.TabIndex = 8;
            // 
            // TbX2
            // 
            this.TbX2.Location = new System.Drawing.Point(22, 99);
            this.TbX2.Name = "TbX2";
            this.TbX2.Size = new System.Drawing.Size(100, 20);
            this.TbX2.TabIndex = 9;
            // 
            // TbX3
            // 
            this.TbX3.Location = new System.Drawing.Point(22, 137);
            this.TbX3.Name = "TbX3";
            this.TbX3.Size = new System.Drawing.Size(100, 20);
            this.TbX3.TabIndex = 10;
            // 
            // TbY1
            // 
            this.TbY1.Location = new System.Drawing.Point(149, 63);
            this.TbY1.Name = "TbY1";
            this.TbY1.Size = new System.Drawing.Size(100, 20);
            this.TbY1.TabIndex = 11;
            // 
            // TbY2
            // 
            this.TbY2.Location = new System.Drawing.Point(149, 99);
            this.TbY2.Name = "TbY2";
            this.TbY2.Size = new System.Drawing.Size(100, 20);
            this.TbY2.TabIndex = 12;
            // 
            // TbY3
            // 
            this.TbY3.Location = new System.Drawing.Point(149, 137);
            this.TbY3.Name = "TbY3";
            this.TbY3.Size = new System.Drawing.Size(100, 20);
            this.TbY3.TabIndex = 13;
            // 
            // BtDibujar
            // 
            this.BtDibujar.Location = new System.Drawing.Point(342, 63);
            this.BtDibujar.Name = "BtDibujar";
            this.BtDibujar.Size = new System.Drawing.Size(75, 23);
            this.BtDibujar.TabIndex = 14;
            this.BtDibujar.Text = "Dibujar";
            this.BtDibujar.UseVisualStyleBackColor = true;
            this.BtDibujar.Click += new System.EventHandler(this.BtDibujar_Click);
            // 
            // PbUno
            // 
            this.PbUno.Location = new System.Drawing.Point(276, 137);
            this.PbUno.Name = "PbUno";
            this.PbUno.Size = new System.Drawing.Size(223, 213);
            this.PbUno.TabIndex = 15;
            this.PbUno.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 388);
            this.Controls.Add(this.PbUno);
            this.Controls.Add(this.BtDibujar);
            this.Controls.Add(this.TbY3);
            this.Controls.Add(this.TbY2);
            this.Controls.Add(this.TbY1);
            this.Controls.Add(this.TbX3);
            this.Controls.Add(this.TbX2);
            this.Controls.Add(this.TbX1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbUno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbX1;
        private System.Windows.Forms.TextBox TbX2;
        private System.Windows.Forms.TextBox TbX3;
        private System.Windows.Forms.TextBox TbY1;
        private System.Windows.Forms.TextBox TbY2;
        private System.Windows.Forms.TextBox TbY3;
        private System.Windows.Forms.Button BtDibujar;
        private System.Windows.Forms.PictureBox PbUno;
    }
}

