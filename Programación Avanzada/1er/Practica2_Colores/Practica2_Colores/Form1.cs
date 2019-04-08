using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2_Colores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        private void label1_Click(object sender, EventArgs e)
        {
            int r, g, b;
            r = SbN1.Value;
            g = SbN2.Value;
            b = SbN3.Value;
            label1.ForeColor = System.Drawing.Color.FromArgb(250, 244, 227);
            label1.Text = "  RGB    " + r.ToString() +", " + g.ToString() + ", " + b.ToString();
            label1.BackColor = System.Drawing.Color.FromArgb(r, g, b);
        }
    }
}
