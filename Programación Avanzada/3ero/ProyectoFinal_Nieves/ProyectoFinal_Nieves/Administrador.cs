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
            Inventario_Administrador Inventario_Administrador = new Inventario_Administrador();
            Inventario_Administrador.Show();
        }
    }
}
