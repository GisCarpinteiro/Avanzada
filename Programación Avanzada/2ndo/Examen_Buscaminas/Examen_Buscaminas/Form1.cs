using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Buscaminas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Facil formulariof = new Facil();
        Dificil formulariod = new Dificil();
       

        private void facilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulariof.ShowDialog();
        }

        private void dificilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulariod.ShowDialog();
        }
    }
}
