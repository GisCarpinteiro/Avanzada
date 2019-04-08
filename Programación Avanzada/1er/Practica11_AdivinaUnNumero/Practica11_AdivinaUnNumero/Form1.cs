using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica11_AdivinaUnNumero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void realizar() {
            int n, bandera, intento;
            string g, intento1;
            string n1;
            int v;
            n1 = TbNumero.Text;
            v=Int32.Parse(n1);
            Random numero = new Random();
            bandera = 0;
            intento = 0;


            for (int i = 0; i <= 100; i++)
            {

                    n = numero.Next(1, 100);

                LbValores.Items.Add("Valor " + i + "  ->  " + n);

                if (n == v)
                {
                    bandera = 1;
                    intento = i;
                    break;
                }

            }
            if (bandera == 1)
                    MessageBox.Show("Se encontró el numero");
                else
                {
                    intento = 103;
                    MessageBox.Show("No se encontró el numero");
                }
                intento1 = intento.ToString();
                if (intento == 103)
                {
                    LblGanar.Text = "x";
                }
                else
                    LblGanar.Text = intento1;
            
           
        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            realizar();
            BtnCalcular.Enabled = false;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {


            LbValores.Items.Clear();
            BtnCalcular.Enabled = true;
            
        }
    }
}
