using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica12_Casino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int valor, n, c;
        
        string variable;
        private void BtnJugar_Click(object sender, EventArgs e)
        {
            
            variable =TbNumero.Text;
           // valor = Int32.Parse(variable);
            Random r = new Random();
            int aleatorio = r.Next(1000, 7000);

            timer1.Start();
            Tcambiar.Start();
            timer1.Interval = aleatorio;

          
            
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            c = 0;
            Tcambiar.Stop();

             variable = TbNumero.Text;
                valor = Convert.ToInt32(variable);
            if (valor == n + 1)
            {
               
                c = 1;
            }

            else
            {
                
                c = 0;
            }

            timer1.Enabled = false;
            timer1.Stop();
            evaluar();

        }

        void evaluar()
        {
        
            if (c == 1)
                MessageBox.Show("Ganaste");
            else
                MessageBox.Show("JAJA");
        }

        /// ///////////////////////////////////////////////////////////77
        int i = 0;

        
        private void Tcambiar_Tick(object sender, EventArgs e)
        {

           
            Label[] con = new Label[34];
            con[0] = Lbl1;
            con[1] = Lbl2;
            con[2] = Lbl3;
            con[3] = Lbl4;
            con[4] = Lbl5;
            con[5] = Lbl6;
            con[6] = Lbl7;
            con[7] = Lbl8;
            con[8] = Lbl9;
            con[9] = Lbl10;
            con[10] = Lbl11;
            con[11] = Lbl12;
            con[12] = Lbl13;
            con[13] = Lbl14;
            con[14] = Lbl15;
            con[15] = Lbl16;
            con[16] = Lbl17;
            con[17] = Lbl18;
            con[18] = Lbl19;
            con[19] = Lbl20;
            con[20] = Lbl21;
            con[21] = Lbl22;
            con[22] = Lbl23;
            con[23] = Lbl24;
            con[24] = Lbl25;
            con[25] = Lbl26;
            con[26] = Lbl27;
            con[27] = Lbl28;
            con[28] = Lbl29;
            con[29] = Lbl30;
            con[30] = Lbl31;
            con[31] = Lbl32;

            
            if (i == 32)
            {
                i = 0;
               
            }

            if (i == 0)
            {

                con[i].BackColor = Color.BlueViolet;
                con[31].BackColor = Color.WhiteSmoke;
            }
            else
            {
                con[i - 1].BackColor = Color.WhiteSmoke;
                con[i].BackColor = Color.BlueViolet;

            }

            n = i;
            i++;


            
          
           
                
        }


    }
}
