using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1_Areacuadrado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int valor = 0, bandera = 0, valoruno=0, real=0;
        

        private void BtnAceptar_Click(object sender, EventArgs e)
        {




            try
            {
                if (bandera == 0)
                {
                    valor = Convert.ToInt32(TbValor.Text);
                    bandera = 1;
                }
                else
                {
                    valoruno = Convert.ToInt32(TbValor.Text);
                    bandera = 0;
                    real = valor * valoruno;
                    MessageBox.Show("Resultado" + real);
                }

               

            }
            catch (Exception exception) {

                MessageBox.Show("Error al ingresar");

            }

        }
    }
}
