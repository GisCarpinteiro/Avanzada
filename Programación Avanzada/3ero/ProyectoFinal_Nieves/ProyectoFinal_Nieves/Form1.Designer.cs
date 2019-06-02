namespace ProyectoFinal_Nieves
{
    partial class InicioSesion
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
            this.TbId = new System.Windows.Forms.TextBox();
            this.TbContraseña = new System.Windows.Forms.TextBox();
            this.BtnAceptarinicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbId
            // 
            this.TbId.Location = new System.Drawing.Point(129, 68);
            this.TbId.Name = "TbId";
            this.TbId.Size = new System.Drawing.Size(117, 20);
            this.TbId.TabIndex = 0;
            this.TbId.Text = "1";
            // 
            // TbContraseña
            // 
            this.TbContraseña.Location = new System.Drawing.Point(129, 123);
            this.TbContraseña.Name = "TbContraseña";
            this.TbContraseña.Size = new System.Drawing.Size(117, 20);
            this.TbContraseña.TabIndex = 1;
            this.TbContraseña.Text = "giselbonit";
            // 
            // BtnAceptarinicio
            // 
            this.BtnAceptarinicio.Location = new System.Drawing.Point(155, 170);
            this.BtnAceptarinicio.Name = "BtnAceptarinicio";
            this.BtnAceptarinicio.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptarinicio.TabIndex = 2;
            this.BtnAceptarinicio.Text = "Aceptar";
            this.BtnAceptarinicio.UseVisualStyleBackColor = true;
            this.BtnAceptarinicio.Click += new System.EventHandler(this.BtnAceptarinicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CONTRASEÑA";
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_Nieves.Properties.Resources.fondohelado2;
            this.ClientSize = new System.Drawing.Size(373, 240);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAceptarinicio);
            this.Controls.Add(this.TbContraseña);
            this.Controls.Add(this.TbId);
            this.Name = "InicioSesion";
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbId;
        private System.Windows.Forms.TextBox TbContraseña;
        private System.Windows.Forms.Button BtnAceptarinicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

