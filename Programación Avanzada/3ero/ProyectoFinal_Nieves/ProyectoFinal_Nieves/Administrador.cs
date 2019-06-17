using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Nieves
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Visible = false;
            Administrar_Cajero Administrar_Cajero = new Administrar_Cajero();
            Administrar_Cajero.Show();
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
           // Visible = false;
            VerVentas_Administrador VerVentas_Administrador = new VerVentas_Administrador();
            VerVentas_Administrador.Show();
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            Administrar_Administrador Administrar_Administrador = new Administrar_Administrador();
            Administrar_Administrador.Show();
        }

        private void BtnHelados_Click(object sender, EventArgs e)
        {
            Inventario_Administrador Inventario_Administrador = new Inventario_Administrador();
            Inventario_Administrador.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Visible = false;
            MessageBox.Show("Sesión cerrada");
            InicioSesion InicioSesion = new InicioSesion();
            InicioSesion.Show();
            
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("G");
        }
    }
}
