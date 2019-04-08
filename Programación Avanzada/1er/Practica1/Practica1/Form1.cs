using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void lblMateria_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblMateria.Text = "Programación Avanzada";
            lblMateria.Font = new Font("IrisUPC", 22, FontStyle.Bold);
            lblMateria.BackColor = System.Drawing.Color.LightBlue;
            lblNombre.Text = "Gisel Carpinteiro Aguirre";
            lblNombre.Font = new Font("Iskoola Pota", 19, FontStyle.Bold);
            lblNombre.BackColor = System.Drawing.Color.MediumPurple;
            lblRegistro.Text = "16100716";
            lblRegistro.Font = new Font("Lucida Sans Typewriter", 16, FontStyle.Bold);
            lblRegistro.BackColor = System.Drawing.Color.DeepSkyBlue;
            lblGrupo.Text = "7A";
            lblGrupo.Font = new Font("Snap ITC", 12, FontStyle.Bold);
            lblGrupo.BackColor = System.Drawing.Color.ForestGreen;
            DateTime.Now.ToString("h:mm:ss tt");
            lblHora.Text= DateTime.Now.ToString("h:mm:ss tt");
            lblHora.Font = new Font("Iskoola Pota", 19, FontStyle.Bold);
            lblHora.BackColor = System.Drawing.Color.Pink;
            System.DateTime.Now.ToString("dd.mm.yyyy");
            lblFecha.Text= System.DateTime.Now.ToString("dd.mm.yyyy");
            lblFecha.Font = new Font("Iskoola Pota", 19, FontStyle.Bold);
            lblFecha.BackColor = System.Drawing.Color.Pink;
            this.AutoSize = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.DateTime.Now.ToString("dd.mm.yyyy");
            lblFecha.Text = System.DateTime.Now.ToString("dd.mm.yyyy");

            DateTime.Now.ToString("h:mm:ss tt");
            lblHora.Text = DateTime.Now.ToString("h:mm:ss tt");
        }
    }
}
