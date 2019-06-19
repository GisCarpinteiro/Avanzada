namespace ProyectoFinal_Nieves
{
    partial class CajeroPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.lblNombrecajero = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.nuCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cb_tipohelado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.TbSubtotal = new System.Windows.Forms.TextBox();
            this.TbDescuento = new System.Windows.Forms.TextBox();
            this.TbTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.lblVentas = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_id = new System.Windows.Forms.Label();
            this.rbT = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbE = new System.Windows.Forms.RadioButton();
            this.tbTarjeta = new System.Windows.Forms.TextBox();
            this.lbltxt = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tbnuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuCantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombrecajero
            // 
            this.lblNombrecajero.AutoSize = true;
            this.lblNombrecajero.Location = new System.Drawing.Point(125, 56);
            this.lblNombrecajero.Name = "lblNombrecajero";
            this.lblNombrecajero.Size = new System.Drawing.Size(44, 13);
            this.lblNombrecajero.TabIndex = 0;
            this.lblNombrecajero.Text = "Nombre";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(12, 56);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(96, 13);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre del cajero:";
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(256, 38);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(240, 150);
            this.dgvPedido.TabIndex = 2;
            // 
            // nuCantidad
            // 
            this.nuCantidad.Location = new System.Drawing.Point(33, 119);
            this.nuCantidad.Name = "nuCantidad";
            this.nuCantidad.Size = new System.Drawing.Size(33, 20);
            this.nuCantidad.TabIndex = 3;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(240, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 13);
            this.lblHora.TabIndex = 5;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(166, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            // 
            // cb_tipohelado
            // 
            this.cb_tipohelado.FormattingEnabled = true;
            this.cb_tipohelado.Location = new System.Drawing.Point(107, 118);
            this.cb_tipohelado.Name = "cb_tipohelado";
            this.cb_tipohelado.Size = new System.Drawing.Size(121, 21);
            this.cb_tipohelado.TabIndex = 7;
            this.cb_tipohelado.SelectedIndexChanged += new System.EventHandler(this.cb_tipohelado_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo de helado";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(195, 364);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // TbSubtotal
            // 
            this.TbSubtotal.Location = new System.Drawing.Point(349, 278);
            this.TbSubtotal.Name = "TbSubtotal";
            this.TbSubtotal.Size = new System.Drawing.Size(100, 20);
            this.TbSubtotal.TabIndex = 12;
            // 
            // TbDescuento
            // 
            this.TbDescuento.Location = new System.Drawing.Point(349, 304);
            this.TbDescuento.Name = "TbDescuento";
            this.TbDescuento.Size = new System.Drawing.Size(100, 20);
            this.TbDescuento.TabIndex = 13;
            // 
            // TbTotal
            // 
            this.TbTotal.Location = new System.Drawing.Point(349, 330);
            this.TbTotal.Name = "TbTotal";
            this.TbTotal.Size = new System.Drawing.Size(100, 20);
            this.TbTotal.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Subtotal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Descuento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(80, 209);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 18;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(80, 256);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 20;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Location = new System.Drawing.Point(438, 191);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(58, 13);
            this.lblVentas.TabIndex = 21;
            this.lblVentas.Text = "Ver ventas";
            this.lblVentas.Click += new System.EventHandler(this.lblVentas_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(12, 8);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(15, 13);
            this.lbl_id.TabIndex = 22;
            this.lbl_id.Text = "id";
            // 
            // rbT
            // 
            this.rbT.AutoSize = true;
            this.rbT.Location = new System.Drawing.Point(6, 18);
            this.rbT.Name = "rbT";
            this.rbT.Size = new System.Drawing.Size(58, 17);
            this.rbT.TabIndex = 23;
            this.rbT.TabStop = true;
            this.rbT.Text = "Tarjeta";
            this.rbT.UseVisualStyleBackColor = true;
            this.rbT.CheckedChanged += new System.EventHandler(this.rbT_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbE);
            this.groupBox1.Controls.Add(this.rbT);
            this.groupBox1.Location = new System.Drawing.Point(296, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 41);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metodo pago";
            // 
            // rbE
            // 
            this.rbE.AutoSize = true;
            this.rbE.Location = new System.Drawing.Point(104, 18);
            this.rbE.Name = "rbE";
            this.rbE.Size = new System.Drawing.Size(64, 17);
            this.rbE.TabIndex = 24;
            this.rbE.TabStop = true;
            this.rbE.Text = "Efectivo";
            this.rbE.UseVisualStyleBackColor = true;
            this.rbE.CheckedChanged += new System.EventHandler(this.rbE_CheckedChanged);
            // 
            // tbTarjeta
            // 
            this.tbTarjeta.Location = new System.Drawing.Point(349, 254);
            this.tbTarjeta.Name = "tbTarjeta";
            this.tbTarjeta.Size = new System.Drawing.Size(100, 20);
            this.tbTarjeta.TabIndex = 25;
            this.tbTarjeta.Visible = false;
            this.tbTarjeta.TextChanged += new System.EventHandler(this.tbTarjeta_TextChanged);
            // 
            // lbltxt
            // 
            this.lbltxt.AutoSize = true;
            this.lbltxt.Location = new System.Drawing.Point(293, 257);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(40, 13);
            this.lbltxt.TabIndex = 26;
            this.lbltxt.Text = "Tarjeta";
            this.lbltxt.Visible = false;
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(455, 261);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(28, 13);
            this.lblT.TabIndex = 27;
            this.lblT.Text = "Tipo";
            this.lblT.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::ProyectoFinal_Nieves.Properties.Resources.cerrasesion1;
            this.btnCerrar.Location = new System.Drawing.Point(493, 364);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 33);
            this.btnCerrar.TabIndex = 28;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tbnuevo
            // 
            this.tbnuevo.Location = new System.Drawing.Point(494, 8);
            this.tbnuevo.Name = "tbnuevo";
            this.tbnuevo.Size = new System.Drawing.Size(33, 23);
            this.tbnuevo.TabIndex = 29;
            this.tbnuevo.Text = "+";
            this.tbnuevo.UseVisualStyleBackColor = true;
            this.tbnuevo.Click += new System.EventHandler(this.tbnuevo_Click);
            // 
            // CajeroPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(538, 400);
            this.Controls.Add(this.tbnuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lbltxt);
            this.Controls.Add(this.tbTarjeta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbTotal);
            this.Controls.Add(this.TbDescuento);
            this.Controls.Add(this.TbSubtotal);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_tipohelado);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.nuCantidad);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblNombrecajero);
            this.Name = "CajeroPrincipal";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.CajeroPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuCantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombrecajero;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.NumericUpDown nuCantidad;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cb_tipohelado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox TbSubtotal;
        private System.Windows.Forms.TextBox TbDescuento;
        private System.Windows.Forms.TextBox TbTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.RadioButton rbT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbE;
        private System.Windows.Forms.TextBox tbTarjeta;
        private System.Windows.Forms.Label lbltxt;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button tbnuevo;
    }
}