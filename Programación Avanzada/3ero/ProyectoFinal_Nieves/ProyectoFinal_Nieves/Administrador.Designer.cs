namespace ProyectoFinal_Nieves
{
    partial class Administrador
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
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.BtnHelados = new System.Windows.Forms.Button();
            this.BtnVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(72, 27);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(140, 106);
            this.btnEmpleados.TabIndex = 0;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Location = new System.Drawing.Point(248, 27);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(141, 106);
            this.btnAdministrador.TabIndex = 1;
            this.btnAdministrador.Text = "Administradores";
            this.btnAdministrador.UseVisualStyleBackColor = true;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // BtnHelados
            // 
            this.BtnHelados.Location = new System.Drawing.Point(72, 161);
            this.BtnHelados.Name = "BtnHelados";
            this.BtnHelados.Size = new System.Drawing.Size(140, 106);
            this.BtnHelados.TabIndex = 2;
            this.BtnHelados.Text = "Inventario";
            this.BtnHelados.UseVisualStyleBackColor = true;
            this.BtnHelados.Click += new System.EventHandler(this.BtnHelados_Click);
            // 
            // BtnVentas
            // 
            this.BtnVentas.Location = new System.Drawing.Point(249, 161);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(140, 106);
            this.BtnVentas.TabIndex = 3;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.UseVisualStyleBackColor = true;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 305);
            this.Controls.Add(this.BtnVentas);
            this.Controls.Add(this.BtnHelados);
            this.Controls.Add(this.btnAdministrador);
            this.Controls.Add(this.btnEmpleados);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Button BtnHelados;
        private System.Windows.Forms.Button BtnVentas;
    }
}