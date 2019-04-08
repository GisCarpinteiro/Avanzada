using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica8_Cuadros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cuadrar(Pen pen, Graphics papel, int x, int y) {
            papel.DrawRectangle(pen, 10, 10, x, y);
        }

        private void BtnDibujar_Click(object sender, EventArgs e)
        {
            label1.Text = "La compañia mundial de cajas de cartón tiene un logotipo que consiste en 3 cuadrados uno dentro del otro.";
            LblDos.Text = "Los responsables de la empresa desean utilizar el logotipo dentro de un cuadro de imagen";
            Graphics papel1, papel2, papel3, papel4;
            Pen Lapiznegro = new Pen(Color.Black);
            papel1 = PbUno.CreateGraphics();
            papel2 = PbDos.CreateGraphics();
            papel3 = PbTres.CreateGraphics();
            papel4 = PbCuatro.CreateGraphics();

            cuadrar(Lapiznegro, papel1, 90, 90);
            cuadrar(Lapiznegro, papel1, 70, 70);
            cuadrar(Lapiznegro, papel1, 60, 60);
            
            cuadrar(Lapiznegro, papel2, 100, 100);
            cuadrar(Lapiznegro, papel2, 120, 120);
            cuadrar(Lapiznegro, papel2, 130, 130);
            
            cuadrar(Lapiznegro, papel3, 50, 50);
            cuadrar(Lapiznegro, papel3, 40, 40);
            cuadrar(Lapiznegro, papel3, 20, 20);

            cuadrar(Lapiznegro, papel4, 40, 40);
            cuadrar(Lapiznegro, papel4, 25, 25);
            cuadrar(Lapiznegro, papel4, 10, 10);
        }
    }
}
