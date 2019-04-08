namespace Ejemplo2_Division
{
    partial class Form1
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
            this.Tbvalor = new System.Windows.Forms.TextBox();
            this.Tbvaloruno = new System.Windows.Forms.TextBox();
            this.Tbreal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tbvalor
            // 
            this.Tbvalor.Location = new System.Drawing.Point(58, 77);
            this.Tbvalor.Name = "Tbvalor";
            this.Tbvalor.Size = new System.Drawing.Size(100, 20);
            this.Tbvalor.TabIndex = 0;
            // 
            // Tbvaloruno
            // 
            this.Tbvaloruno.Location = new System.Drawing.Point(218, 77);
            this.Tbvaloruno.Name = "Tbvaloruno";
            this.Tbvaloruno.Size = new System.Drawing.Size(100, 20);
            this.Tbvaloruno.TabIndex = 1;
            // 
            // Tbreal
            // 
            this.Tbreal.Location = new System.Drawing.Point(136, 146);
            this.Tbreal.Name = "Tbreal";
            this.Tbreal.Size = new System.Drawing.Size(100, 20);
            this.Tbreal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(175, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "÷";
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(146, 238);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 4;
            this.BtnOk.Text = "Aceptar";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 313);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tbreal);
            this.Controls.Add(this.Tbvaloruno);
            this.Controls.Add(this.Tbvalor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbvalor;
        private System.Windows.Forms.TextBox Tbvaloruno;
        private System.Windows.Forms.TextBox Tbreal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOk;
    }
}

