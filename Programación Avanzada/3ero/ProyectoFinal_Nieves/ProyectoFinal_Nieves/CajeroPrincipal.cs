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
    public partial class CajeroPrincipal : Form
    {
        public CajeroPrincipal()
        {
            InitializeComponent();
        }

        private void CajeroPrincipal_Load(object sender, EventArgs e)
        {
            InicioSesion InicioSesion = new InicioSesion();
            InicioSesion.Close();
        }
    }
}
