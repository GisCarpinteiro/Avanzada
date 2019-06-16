namespace ProyectoFinal_Nieves
{
    partial class Administrar_Cajero
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
            this.btnEliminarE = new System.Windows.Forms.Button();
            this.btnAgregarE = new System.Windows.Forms.Button();
            this.tbContraE = new System.Windows.Forms.TextBox();
            this.tbIdE = new System.Windows.Forms.TextBox();
            this.tbTelE = new System.Windows.Forms.TextBox();
            this.tbNombreE = new System.Windows.Forms.TextBox();
            this.dgvE = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.btnModificarE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvE)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarE
            // 
            this.btnEliminarE.Location = new System.Drawing.Point(474, 337);
            this.btnEliminarE.Name = "btnEliminarE";
            this.btnEliminarE.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarE.TabIndex = 14;
            this.btnEliminarE.Text = "Eliminar";
            this.btnEliminarE.UseVisualStyleBackColor = true;
            this.btnEliminarE.Click += new System.EventHandler(this.btnEliminarE_Click);
            // 
            // btnAgregarE
            // 
            this.btnAgregarE.Location = new System.Drawing.Point(273, 337);
            this.btnAgregarE.Name = "btnAgregarE";
            this.btnAgregarE.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarE.TabIndex = 13;
            this.btnAgregarE.Text = "Agregar";
            this.btnAgregarE.UseVisualStyleBackColor = true;
            this.btnAgregarE.Click += new System.EventHandler(this.btnAgregarE_Click);
            // 
            // tbContraE
            // 
            this.tbContraE.Location = new System.Drawing.Point(31, 242);
            this.tbContraE.Name = "tbContraE";
            this.tbContraE.Size = new System.Drawing.Size(100, 20);
            this.tbContraE.TabIndex = 12;
            // 
            // tbIdE
            // 
            this.tbIdE.Enabled = false;
            this.tbIdE.Location = new System.Drawing.Point(31, 197);
            this.tbIdE.Name = "tbIdE";
            this.tbIdE.Size = new System.Drawing.Size(100, 20);
            this.tbIdE.TabIndex = 11;
            // 
            // tbTelE
            // 
            this.tbTelE.Location = new System.Drawing.Point(31, 146);
            this.tbTelE.Name = "tbTelE";
            this.tbTelE.Size = new System.Drawing.Size(100, 20);
            this.tbTelE.TabIndex = 10;
            // 
            // tbNombreE
            // 
            this.tbNombreE.Location = new System.Drawing.Point(31, 60);
            this.tbNombreE.Name = "tbNombreE";
            this.tbNombreE.Size = new System.Drawing.Size(100, 20);
            this.tbNombreE.TabIndex = 9;
            // 
            // dgvE
            // 
            this.dgvE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvE.Location = new System.Drawing.Point(193, 41);
            this.dgvE.Name = "dgvE";
            this.dgvE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvE.Size = new System.Drawing.Size(456, 268);
            this.dgvE.TabIndex = 8;
            this.dgvE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvE_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Apellido";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(31, 102);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(100, 20);
            this.tbApellido.TabIndex = 20;
            // 
            // btnModificarE
            // 
            this.btnModificarE.Location = new System.Drawing.Point(372, 336);
            this.btnModificarE.Name = "btnModificarE";
            this.btnModificarE.Size = new System.Drawing.Size(75, 23);
            this.btnModificarE.TabIndex = 22;
            this.btnModificarE.Text = "Modificar";
            this.btnModificarE.UseVisualStyleBackColor = true;
            this.btnModificarE.Click += new System.EventHandler(this.btnModificarE_Click);
            // 
            // Administrar_Cajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 394);
            this.Controls.Add(this.btnModificarE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarE);
            this.Controls.Add(this.btnAgregarE);
            this.Controls.Add(this.tbContraE);
            this.Controls.Add(this.tbIdE);
            this.Controls.Add(this.tbTelE);
            this.Controls.Add(this.tbNombreE);
            this.Controls.Add(this.dgvE);
            this.Name = "Administrar_Cajero";
            this.Text = "Administrar Empleados";
            this.Load += new System.EventHandler(this.Administrar_Cajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminarE;
        private System.Windows.Forms.Button btnAgregarE;
        private System.Windows.Forms.TextBox tbContraE;
        private System.Windows.Forms.TextBox tbIdE;
        private System.Windows.Forms.TextBox tbTelE;
        private System.Windows.Forms.TextBox tbNombreE;
        private System.Windows.Forms.DataGridView dgvE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Button btnModificarE;
    }
}