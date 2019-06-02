using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cine;

namespace Cine
{
    public partial class Form2 : Form
    {
        public Form2()
        {    /*  if (guardado == 1 && c4>=1)
            {
                MessageBox.Show("Ya se guardo");
                btnA4.BackgroundImage = (System.Drawing.Image)(Properties.Resources.asientomorado);
            }*/
        }
        int numero = 0, guardado;

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("test");
            numero = Convert.ToInt32(lblNboletos.Text); ///Numero tiene label
            //  guardado = Convert.ToInt32(lblbandera.Text);

        }
        int contador = 0;
        private void btnlisto_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Close();
            // main.ShowDialog();
        }
        int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0, c8 = 0, c9 = 0, c10 = 0;

        private void btnA6_Click(object sender, EventArgs e)
        {
            c6++;
            if (c6 == 1)
            {
                checar(btnA6);

            }

            if (c6 == 2)
            {
                deshabilitar(btnA6);
                c6 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            c1++;
            if (c1 == 1)
            {
                checar(btnA1);

            }

            if (c1 == 2)
            {
                deshabilitar(btnA1);
                c1 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            c2++;
            if (c2 == 1)
            {
                checar(btnA2);

            }

            if (c2 == 2)
            {
                deshabilitar(btnA2);
                c2 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            c3++;
            if (c3 == 1)
            {
                checar(btnA3);

            }

            if (c3 == 2)
            {
                deshabilitar(btnA3);
                c3 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnA4_Click(object sender, EventArgs e)
        {

            c4++;
            if (c4 == 1)
            {
                checar(btnA4);


            }

            if (c4 == 2)
            {
                deshabilitar(btnA4);
                c4 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;

        }

        private void btnA5_Click(object sender, EventArgs e)
        {



            c5++;
            if (c5 == 1)
            {
                checar(btnA5);

            }

            if (c5 == 2)
            {
                deshabilitar(btnA5);
                c5 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }



        void checar(Button botonx)
        {
            if (contador < numero && contador <= 2 && contador >= 0)
            {

                contador = contador + 1;
                botonx.BackgroundImage = (System.Drawing.Image)(Properties.Resources.asientoazul1);


                MessageBox.Show("Asientos " + contador);
                //MessageBox.Show("Numero" + numero);

            }

        }

        void deshabilitar(Button botonx)
        {

            if (contador >= 0)
            {
                botonx.BackgroundImage = (System.Drawing.Image)(Properties.Resources.asientorojo1);
                contador = contador - 1;
            }
            MessageBox.Show("Asientos " + contador);
        }

    }
}
