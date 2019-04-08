namespace Practica10_FormulaGeneral
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
            this.TbB = new System.Windows.Forms.TextBox();
            this.TbA = new System.Windows.Forms.TextBox();
            this.TbC = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.LblRes1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbB
            // 
            this.TbB.Location = new System.Drawing.Point(28, 95);
            this.TbB.Name = "TbB";
            this.TbB.Size = new System.Drawing.Size(67, 20);
            this.TbB.TabIndex = 0;
            // 
            // TbA
            // 
            this.TbA.Location = new System.Drawing.Point(28, 58);
            this.TbA.Name = "TbA";
            this.TbA.Size = new System.Drawing.Size(67, 20);
            this.TbA.TabIndex = 1;
            // 
            // TbC
            // 
            this.TbC.Location = new System.Drawing.Point(28, 132);
            this.TbC.Name = "TbC";
            this.TbC.Size = new System.Drawing.Size(67, 20);
            this.TbC.TabIndex = 2;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(153, 21);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 3;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // LblRes1
            // 
            this.LblRes1.AutoSize = true;
            this.LblRes1.Location = new System.Drawing.Point(182, 121);
            this.LblRes1.Name = "LblRes1";
            this.LblRes1.Size = new System.Drawing.Size(0, 13);
            this.LblRes1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "X1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblRes1);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TbC);
            this.Controls.Add(this.TbA);
            this.Controls.Add(this.TbB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbB;
        private System.Windows.Forms.TextBox TbA;
        private System.Windows.Forms.TextBox TbC;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label LblRes1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

