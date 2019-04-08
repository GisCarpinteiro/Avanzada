using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int checar = 0, vlabel, linea = 0, v, bandera=0, ContarBandera=1;
        int intento=1;
        string texti;
        private void button1_Click(object sender, EventArgs e)
        {

            texti = intento.ToString();
            LblIntento.Text = texti;
            

            if (bandera == 0)
            {
                ContarBandera = ContarBandera + 1;

            }

            if (intento >= 5 && ContarBandera >= 5)
            {

                LblPerder.BackColor = Color.Aqua;
                BtnApostar.Enabled = false;
            }
            intento++;
            Random r = new Random();
            int aleatorio = r.Next(3000, 7000);

            timer1.Start();
            Recorrer.Start();
            timer1.Interval = aleatorio;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Recorrer.Stop();
            BtnBorrar.Enabled=true;
            ganaste();
            

        }

        void ganaste(){
            
            // MessageBox.Show("ggg" + i);
            if (checar == 21)
            {
                if (i == 1 || i == 2 || i == 3 || i == 4 || i == 5 || i == 6)
                {
                    LblGanar.BackColor = Color.Aqua;
                    bandera = 1;
                }
                
            }
            

            if (checar == 57)
            {
                if (i == 7 || i == 8 || i == 9 || i == 10 || i == 11 || i == 12)
                {
                    LblGanar.BackColor = Color.Aqua;
                    bandera = 1;

                }
                
            }
            

            if (checar == 93)
            {
                if (i == 13 || i == 14 || i == 15 || i == 16 || i == 17 || i == 18)
                {
                    LblGanar.BackColor = Color.Aqua;
                    bandera = 1;
                }
               
            }
            

            if (checar == 129)
            {
                if (i == 19 || i == 20 || i == 21 || i == 22 || i == 23 || i == 24)
                {
                    LblGanar.BackColor = Color.Aqua;
                    bandera = 1;
                }
                
            }
            

            if (checar == 165)
            {
                if (i == 25 || i == 26 || i == 27 || i == 28 || i == 29 || i == 30)
                {
                    LblGanar.BackColor = Color.Aqua;
                    bandera = 1;
                }
               
            }
            

            if (checar == 201)
            {
                if (i == 31 || i == 32 || i == 33 || i == 34 || i == 35 || i == 36)
                {
                    LblGanar.BackColor = Color.Aqua;
                    bandera = 1;
                }
                
            }

            

            /////////////////////////////// columnas////////////////////7
            //MessageBox.Show("ggg" + checar);
            if (checar == 96)
            {
                if (i == 1 || i == 7 || i == 13 || i == 19 || i == 25 || i == 31)
                {
                    LblGanar.BackColor = Color.Aqua;
                    bandera = 1;
                }
                
            }
            

            if (checar == 102)
            {
                if (i == 2 || i == 8 || i == 14 || i == 20 || i == 26 || i == 32)
                {
                    LblGanar.BackColor = Color.Aqua;
                    bandera = 1;
                }
                
            }
            

            if (checar == 108)
            {
                if (i == 3 || i == 9 || i == 15 || i == 21 || i == 27 || i == 33)
                {
                    LblGanar.BackColor = Color.Aqua;
                    bandera = 1;
                }
                
            }
         

            if (checar == 114)
            {
                if (i == 4 || i == 10 || i == 16 || i == 22 || i == 28 || i == 34)
                {
                    LblGanar.BackColor = Color.Aqua;
                    bandera = 1;
                }
               
            }
            

            if (checar == 120)
            {
                if (i == 5 || i == 11 || i == 17 || i == 23 || i == 29 || i == 35)
                {
                    LblGanar.BackColor = Color.Aqua;
                    bandera = 1;
                }
               
            }

            if (checar == 126)
            {
                if (i == 6 || i == 12 || i == 18 || i == 24 || i == 30 || i == 36)
                {
                    LblGanar.BackColor = Color.Aqua;
                    bandera = 1;
                }
               
            }

            if (checar == 111)
            {
                if (i == 1 || i == 8 || i == 15 || i == 22 || i == 29 || i == 36)
                {
                    LblGanar.BackColor = Color.Aqua;
                    bandera = 1;
                }
                

                if (i == 6 || i == 11 || i == 16 || i == 21 || i == 26 || i == 31)
                {
                    LblGanar.BackColor = Color.Aqua;
                    bandera = 1;
                }
                
            }

           
        }

        

        int i=0;
        private void Recorrer_Tick(object sender, EventArgs e)
        {
            LblGanar.BackColor = Color.WhiteSmoke;
            Label[] con = new Label[40];
            con[0] = label1;
            con[1] = label2;
            con[2] = label3;
            con[3] = label4;
            con[4] = label5;
            con[5] = label6;
            con[6] = label7;
            con[7] = label8;
            con[8] = label9;
            con[9] = label10;
            con[10] = label11;
            con[11] = label12;
            con[12] = label13;
            con[13] = label14;
            con[14] = label15;
            con[15] = label16;
            con[16] = label17;
            con[17] = label18;
            con[18] = label19;
            con[19] = label20;
            con[20] = label21;
            con[21] = label22;
            con[22] = label23;
            con[23] = label24;
            con[24] = label25;
            con[25] = label26;
            con[26] = label27;
            con[27] = label28;
            con[28] = label29;
            con[29] = label30;
            con[30] = label31;
            con[31] = label32;
            con[32] = label33;
            con[33] = label34;
            con[34] = label35;
            con[35] = label36;
            con[36] = label42;

            if (i == 36)
            {
                i = 0;
                label36.BackColor = Color.BlueViolet;

            }

            if (i == 0)
            {

                con[35].BackColor = Color.WhiteSmoke;
                con[i].BackColor = Color.BlueViolet;
                con[34].BackColor = Color.WhiteSmoke;
                
            }
            else
            {
                con[i - 1].BackColor = Color.WhiteSmoke;
                con[i].BackColor = Color.BlueViolet;

            }

            //n = i;
            i++;
            BtnBorrar.Enabled = false;
    
}
        

        private void label1_Click(object sender, EventArgs e)
        {
            if (linea<=6)
            {
                v = 1;
                linea = linea + v;
                label1.ForeColor = Color.Chocolate;
                vlabel = 1;
                checar = checar + vlabel;
                evaluar();
                
            }

            
        }
        private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //BtnApostar.Enabled = false;
            // label1.ForeColor = Color.Black;
            //linea = linea-1;
            
        }
        private void label2_Click(object sender, EventArgs e)
        {
               
            if (linea <= 6)
            {
                v = 1;
                linea = linea + v;
                label2.ForeColor = Color.Chocolate;
                vlabel = 2;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
                
            if (linea <= 6)
            {
                v = 1;
                linea = linea + v;
                label3.ForeColor = Color.Chocolate;
                vlabel = 3;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
            if (linea <= 6)
            {
                v = 1;
                linea = linea + v;
                label4.ForeColor = Color.Chocolate;
                vlabel = 4;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
            if (linea <= 6)
            {
                v = 1;
                linea = linea + v;
                label5.ForeColor = Color.Chocolate;
                vlabel = 5;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
            if (linea <= 6)
            {
                v = 1;
                linea = linea + v;
                label6.ForeColor = Color.Chocolate;
                vlabel = 6;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
            if (linea <= 6)
            {
                v = 1;
                linea = linea + v;
                label7.ForeColor = Color.Chocolate;
                vlabel = 7;
                checar = checar + vlabel;
                evaluar();
            }

            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
            if (linea <= 6)
            {
                v = 1;
                linea = linea + v;
                label8.ForeColor = Color.Chocolate;
                vlabel = 8;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label9.ForeColor = Color.Chocolate;
                vlabel = 9;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label10.ForeColor = Color.Chocolate;
                vlabel = 10;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label11.ForeColor = Color.Chocolate;
                vlabel = 11;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label12.ForeColor = Color.Chocolate;
                vlabel = 12;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label13.ForeColor = Color.Chocolate;
                vlabel = 13;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label14.ForeColor = Color.Chocolate;
                vlabel = 14;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label15.ForeColor = Color.Chocolate;
                vlabel = 15;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label16.ForeColor = Color.Chocolate;
                vlabel = 16;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label17.ForeColor = Color.Chocolate;
                vlabel = 17;
                checar = checar + vlabel;
                evaluar();
            }
        }


        private void label18_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label18.ForeColor = Color.Chocolate;
                vlabel = 18;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label19.ForeColor = Color.Chocolate;
                vlabel = 19;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label20.ForeColor = Color.Chocolate;
                vlabel = 20;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label21.ForeColor = Color.Chocolate;
                vlabel = 21;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label22.ForeColor = Color.Chocolate;
                vlabel = 22;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label23.ForeColor = Color.Chocolate;
                vlabel = 23;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label24.ForeColor = Color.Chocolate;
                vlabel = 24;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label25.ForeColor = Color.Chocolate;
                vlabel = 25;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label26.ForeColor = Color.Chocolate;
                vlabel = 26;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label27.ForeColor = Color.Chocolate;
                vlabel = 27;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label28_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label28.ForeColor = Color.Chocolate;
                vlabel = 28;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label29_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label29.ForeColor = Color.Chocolate;
                vlabel = 29;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label30_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label30.ForeColor = Color.Chocolate;
                vlabel = 30;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label31_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label31.ForeColor = Color.Chocolate;
                vlabel = 31;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label32_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label32.ForeColor = Color.Chocolate;
                vlabel = 32;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label33_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label33.ForeColor = Color.Chocolate;
                vlabel = 33;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label34_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label34.ForeColor = Color.Chocolate;
                vlabel = 34;
                checar = checar + vlabel;
                evaluar();
            }
        }

        

        private void label35_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label35.ForeColor = Color.Chocolate;
                vlabel = 35;
                checar = checar + vlabel;
                evaluar();
            }
        }

        private void label36_Click(object sender, EventArgs e)
        {
            v = 1;
            linea = linea + v;
            if (linea <= 6)
            {
                label36.ForeColor = Color.Chocolate;
                vlabel = 36;
                checar = checar + vlabel;
                evaluar();
            }

        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            
            linea = 0;
            checar = 0;
            BtnApostar.Enabled = false;
            intento = 1;
            LblPerder.BackColor = Color.WhiteSmoke;
            LblGanar.BackColor = Color.WhiteSmoke;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
            label9.ForeColor = Color.Black;
            label10.ForeColor = Color.Black;
            label11.ForeColor = Color.Black;
            label12.ForeColor = Color.Black;
            label13.ForeColor = Color.Black;
            label14.ForeColor = Color.Black;
            label15.ForeColor = Color.Black;
            label16.ForeColor = Color.Black;
            label17.ForeColor = Color.Black;
            label18.ForeColor = Color.Black;
            label19.ForeColor = Color.Black;
            label20.ForeColor = Color.Black;
            label21.ForeColor = Color.Black;
            label22.ForeColor = Color.Black;
            label23.ForeColor = Color.Black;
            label24.ForeColor = Color.Black;
            label25.ForeColor = Color.Black;
            label26.ForeColor = Color.Black;
            label27.ForeColor = Color.Black;
            label28.ForeColor = Color.Black;
            label29.ForeColor = Color.Black;
            label30.ForeColor = Color.Black;
            label31.ForeColor = Color.Black;
            label32.ForeColor = Color.Black;
            label33.ForeColor = Color.Black;
            label34.ForeColor = Color.Black;
            label35.ForeColor = Color.Black;
            label36.ForeColor = Color.Black;
            

        }

        void evaluar() {
            
            

                if (linea == 6)
               {
                if (checar == 21 || checar == 57 || checar == 93 || checar == 129 || checar == 165 ||
                checar == 201 || checar == 96 || checar == 102 || checar == 108 || checar == 114 || checar == 120 || checar == 126 || checar == 111)
                {
                    BtnApostar.Enabled = true;
                    string schecar;
                   // schecar = checar.ToString();
                    //MessageBox.Show(schecar);
                }
                else
                    MessageBox.Show("No se inserto bien filas o columnas");
            }

        }
    }
}
