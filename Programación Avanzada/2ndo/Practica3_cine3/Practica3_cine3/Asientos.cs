using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3_cine3
{
    public partial class Asientos : Form
    {
        public Asientos()
        {
            InitializeComponent();
            
        }
        //Estado de asientos
        bool[,] eAsientos = new bool[6, 6];

        public int contador = 0, numero;
        int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0, c8 = 0, c9 = 0, c10 = 0;
        int c11 = 0, c12 = 0, c13 = 0, c14 = 0, c15 = 0, c16 = 0, c17 = 0, c18 = 0, c19 = 0, c20 = 0;
        int c21 = 0, c22 = 0, c23 = 0, c24 = 0, c25 = 0, c26 = 0, c27 = 0, c28 = 0, c29 = 0, c30 = 0;
        int c31 = 0, c32 = 0, c33 = 0, c34 = 0, c35 = 0, c36 = 0;


        private void btnlisto_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Asientos_Load(object sender, EventArgs e)
        {
            numero = Convert.ToInt32(lblNboletos.Text);
            for(int f=0; f<6; f++)
            {
                for(int c=0; c<6; c++)
                {
                    //significa que están diposnibles
                    eAsientos[f,c] = true;
                }
            }
            
        }

        //

        void checar(Button botonx, int f, int c)
        {
            if ( contador < numero ) //contador <=2

            //if ((contador < numero) && contador < 2 && contador >= 0) //contador <=2
            {
                eAsientos[f, c] = false;
                contador = contador + 1;
                    botonx.BackgroundImage = (System.Drawing.Image)(Properties.Resources.asientoazul1);
                    //MessageBox.Show("Asientos " + contador);                
            }
            

        }

        void deshabilitar(Button botonx, int f, int c)
        {
            if(eAsientos[f, c] == false)
            {
                eAsientos[f, c] = true;

                contador = contador - 1;
                botonx.BackgroundImage = (System.Drawing.Image)(Properties.Resources.asientorojo1);
            }
        }


        private void btnA1_Click(object sender, EventArgs e)
        {
            //if (contador<numero)
                c1++;
            if (c1 == 1)
            {
                checar(btnA1,0,0);

            }

            if (c1 == 2)
            {
                deshabilitar(btnA1,0,0);
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
           // if (contador < numero)
                c2++;
            if (c2 == 1)
            {
                checar(btnA2,0,1);

            }

            if (c2 == 2)
            {
                deshabilitar(btnA2, 0, 1);
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
            //if (contador < numero)
                c3++;
            if (c3 == 1)
            {
                checar(btnA3, 0, 2);

            }

            if (c3 == 2)
            {
                deshabilitar(btnA3, 0, 2);
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
           // if (contador < numero)
                c4++;
            if (c4 == 1)
            {
                checar(btnA4, 0, 3);

            }

            if (c4 == 2)
            {
                deshabilitar(btnA4, 0, 3);
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
            //if (contador < numero)
                c5++;
            if (c5 == 1)
            {
                checar(btnA5, 0, 4);

            }

            if (c5 == 2)
            {
                deshabilitar(btnA5, 0, 4);
                c5 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnA6_Click(object sender, EventArgs e)
        {
           // if (contador < numero)
                c6++;
            if (c6 == 1)
            {
                checar(btnA6, 0, 5);

            }

            if (c6 == 2)
            {
                deshabilitar(btnA6, 0, 5);
                c6 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            c7++;
            if (c7 == 1)
            {
                checar(btnB1, 1, 0);

            }

            if (c7 == 2)
            {
                deshabilitar(btnB1, 1, 0);
                c7 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            c8++;
            if (c8 == 1)
            {
                checar(btnB2, 1, 1);

            }

            if (c8 == 2)
            {
                deshabilitar(btnB2, 1, 1);
                c8 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            c9++;
            if (c9 == 1)
            {
                checar(btnB3, 1, 2);

            }

            if (c9 == 2)
            {
                deshabilitar(btnB3, 1, 2);
                c9 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            c10++;
            if (c10 == 1)
            {
                checar(btnB4, 1, 3);

            }

            if (c10 == 2)
            {
                deshabilitar(btnB4, 1, 3);
                c10 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            c11++;
            if (c11 == 1)
            {
                checar(btnB5, 1, 4);

            }

            if (c11 == 2)
            {
                deshabilitar(btnB5, 1, 4);
                c11 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnB6_Click(object sender, EventArgs e)
        {
            c12++;
            if (c12 == 1)
            {
                checar(btnB6, 1, 5);

            }

            if (c12 == 2)
            {
                deshabilitar(btnB6, 1, 5);
                c12 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            c13++;
            if (c13 == 1)
            {
                checar(btnC1, 2, 0);

            }

            if (c13 == 2)
            {
                deshabilitar(btnC1, 2, 0);
                c13 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            c14++;
            if (c14 == 1)
            {
                checar(btnC2, 2, 1);

            }

            if (c14 == 2)
            {
                deshabilitar(btnC2, 2, 1);
                c14 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            c15++;
            if (c15 == 1)
            {
                checar(btnC3, 2, 2);

            }

            if (c15 == 2)
            {
                deshabilitar(btnC3, 2, 2);
                c15 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            c16++;
            if (c16 == 1)
            {
                checar(btnC4, 2, 3);

            }

            if (c16 == 2)
            {
                deshabilitar(btnC4, 2, 3);
                c16 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            c17++;
            if (c17 == 1)
            {
                checar(btnC5, 2, 4);

            }

            if (c17 == 2)
            {
                deshabilitar(btnC5, 2, 4);
                c17 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnC6_Click(object sender, EventArgs e)
        {
            c18++;
            if (c18 == 1)
            {
                checar(btnC6, 2, 5);

            }

            if (c18 == 2)
            {
                deshabilitar(btnC6, 2, 5);
                c18 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            c19++;
            if (c19 == 1)
            {
                checar(btnD1, 3, 0);

            }

            if (c19 == 2)
            {
                deshabilitar(btnD1, 3, 0);
                c19 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            c20++;
            if (c20 == 1)
            {
                checar(btnD2, 3, 1);

            }

            if (c20 == 2)
            {
                deshabilitar(btnD2, 3, 1);
                c20 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnD3_Click(object sender, EventArgs e)
        {
            c21++;
            if (c21 == 1)
            {
                checar(btnD3, 3, 2);

            }

            if (c21 == 2)
            {
                deshabilitar(btnD3, 3, 2);
                c21 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            c22++;
            if (c22 == 1)
            {
                checar(btnD4, 3, 3);

            }

            if (c22 == 2)
            {
                deshabilitar(btnD4, 3, 3);
                c22 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnD5_Click(object sender, EventArgs e)
        {
            c23++;
            if (c23 == 1)
            {
                checar(btnD5, 3, 4);

            }

            if (c23 == 2)
            {
                deshabilitar(btnD5, 3, 4);
                c23 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnD6_Click(object sender, EventArgs e)
        {
            c24++;
            if (c24 == 1)
            {
                checar(btnD6, 3, 5);

            }

            if (c24 == 2)
            {
                deshabilitar(btnD6, 3, 5);
                c24 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            c25++;
            if (c25 == 1)
            {
                checar(btnE1, 4, 0);

            }

            if (c25 == 2)
            {
                deshabilitar(btnE1, 4, 0);
                c25 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnE2_Click(object sender, EventArgs e)
        {
            c26++;
            if (c26 == 1)
            {
                checar(btnE2, 4, 1);

            }

            if (c26 == 2)
            {
                deshabilitar(btnE2, 4, 1);
                c26 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            c27++;
            if (c27 == 1)
            {
                checar(btnE3, 4, 2);

            }

            if (c27 == 2)
            {
                deshabilitar(btnE3, 4, 2);
                c27 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            c28++;
            if (c28 == 1)
            {
                checar(btnE4, 4, 3);

            }

            if (c28 == 2)
            {
                deshabilitar(btnE4, 4, 3);
                c28 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnE5_Click(object sender, EventArgs e)
        {
            c29++;
            if (c29 == 1)
            {
                checar(btnE5, 4, 4);

            }

            if (c29 == 2)
            {
                deshabilitar(btnE5, 4, 4);
                c29 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnE6_Click(object sender, EventArgs e)
        {
            c30++;
            if (c30 == 1)
            {
                checar(btnE6, 4, 5);

            }

            if (c30 == 2)
            {
                deshabilitar(btnE6, 4, 5);
                c30 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnF1_Click(object sender, EventArgs e)
        {
            c31++;
            if (c31 == 1)
            {
                checar(btnF1, 5, 0);

            }

            if (c31 == 2)
            {
                deshabilitar(btnF1, 5, 0);
                c31 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            c32++;
            if (c32 == 1)
            {
                checar(btnF2, 5, 1);

            }

            if (c32 == 2)
            {
                deshabilitar(btnF2, 5, 1);
                c32 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnF3_Click(object sender, EventArgs e)
        {
            c33++;
            if (c33 == 1)
            {
                checar(btnF3, 5, 2);

            }

            if (c33 == 2)
            {
                deshabilitar(btnF3, 5, 2);
                c33 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnF4_Click(object sender, EventArgs e)
        {
            c34++;
            if (c34 == 1)
            {
                checar(btnF4, 5, 3);

            }

            if (c34 == 2)
            {
                deshabilitar(btnF4, 5, 3);
                c34 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            c35++;
            if (c35 == 1)
            {
                checar(btnF5, 5, 4);

            }

            if (c35 == 2)
            {
                deshabilitar(btnF5, 5, 4);
                c35 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }

        private void btnF6_Click(object sender, EventArgs e)
        {
            c36++;
            if (c36 == 1)
            {
                checar(btnF6, 5, 5);

            }

            if (c36 == 2)
            {
                deshabilitar(btnF6, 5, 5);
                c36 = 0;
            }

            if (contador == numero)
            {
                btnlisto.Enabled = true;
            }
            else
                btnlisto.Enabled = false;
        }


    }
}
