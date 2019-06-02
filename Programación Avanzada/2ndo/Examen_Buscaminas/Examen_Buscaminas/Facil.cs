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
    public partial class Facil : Form
    {
        public Facil()
        {
            InitializeComponent();
        }
        

        Button[,] botones = new Button[6, 6];
        //int fila=0, columna = 0;

        bool bandera = false;
        int numeroR1 = 0, numeroR2 = 0;
        Casilla c = new Casilla();

        private void Facil_Load(object sender, EventArgs e)
        {
            botones[0, 0] = btn1;
            botones[0, 1] = btn2;
            botones[0, 2] = btn3;
            botones[0, 3] = btn4;
            botones[0, 4] = btn5;
            botones[0, 5] = btn6;
            botones[1, 0] = btn7;
            botones[1, 1] = btn8;
            botones[1, 2] = btn9;
            botones[1, 3] = btn10;
            botones[1, 4] = btn11;
            botones[1, 5] = btn12;
            botones[2, 0] = btn13;
            botones[2, 1] = btn14;
            botones[2, 2] = btn15;
            botones[2, 3] = btn16;
            botones[2, 4] = btn17;
            botones[2, 5] = btn18;
            botones[3, 0] = btn19;
            botones[3, 1] = btn20;
            botones[3, 2] = btn21;
            botones[3, 3] = btn22;
            botones[3, 4] = btn23;
            botones[3, 5] = btn24;
            botones[4, 0] = btn25;
            botones[4, 1] = btn26;
            botones[4, 2] = btn27;
            botones[4, 3] = btn28;
            botones[4, 4] = btn29;
            botones[4, 5] = btn30;
            botones[5, 0] = btn31;
            botones[5, 1] = btn32;
            botones[5, 2] = btn33;
            botones[5, 3] = btn34;
            botones[5, 4] = btn35;
            botones[5, 5] = btn36;

            
            c.HayBomba = false;
            btn1.ForeColor = Color.White;
            btn1.BackColor = Color.Blue;
            btn2.ForeColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.ForeColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.ForeColor = Color.White;
            btn4.BackColor = Color.White;
            btn5.ForeColor = Color.White;
            btn5.BackColor = Color.White;
            btn6.ForeColor = Color.White;
            btn6.BackColor = Color.White;
            btn7.ForeColor = Color.White;
            btn7.BackColor = Color.White;
            btn8.ForeColor = Color.White;
            btn8.BackColor = Color.White;
            btn9.ForeColor = Color.White;
            btn9.BackColor = Color.White;
            btn10.ForeColor = Color.White;
            btn10.BackColor = Color.White;
            btn11.ForeColor = Color.White; 
            btn11.BackColor = Color.White;
            btn12.ForeColor = Color.White;
            btn12.BackColor = Color.White;
            btn13.ForeColor = Color.White;
            btn13.BackColor = Color.Blue;
            btn14.ForeColor = Color.White;
            btn14.BackColor = Color.White;
            btn15.ForeColor = Color.White;
            btn15.BackColor = Color.White;
            btn16.ForeColor = Color.White;
            btn16.BackColor = Color.White;
            btn17.ForeColor = Color.White;
            btn17.BackColor = Color.White;
            btn18.ForeColor = Color.White;
            btn18.BackColor = Color.White;
            btn19.ForeColor = Color.White;
            btn19.BackColor = Color.White;
            btn20.ForeColor = Color.White;
            btn20.BackColor = Color.White;
            btn21.ForeColor = Color.White;
            btn21.BackColor = Color.White;
            btn22.ForeColor = Color.White;
            btn22.BackColor = Color.White;
            btn23.ForeColor = Color.White;
            btn23.BackColor = Color.White;
            btn24.ForeColor = Color.White;
            btn24.BackColor = Color.White;
            btn25.ForeColor = Color.White;
            btn25.BackColor = Color.White;
            btn26.ForeColor = Color.White;
            btn26.BackColor = Color.White;
            btn27.ForeColor = Color.White;
            btn27.BackColor = Color.White;
            btn28.ForeColor = Color.White;
            btn29.ForeColor = Color.White;
            btn29.BackColor = Color.White;
            btn30.ForeColor = Color.White;
            btn30.BackColor = Color.White;
            btn31.ForeColor = Color.White;
            btn31.BackColor = Color.White;
            btn32.ForeColor = Color.White;
            btn32.BackColor = Color.White;
            btn33.ForeColor = Color.White;
            btn33.BackColor = Color.White;
            btn34.ForeColor = Color.White;
            btn34.BackColor = Color.White;
            btn35.ForeColor = Color.White;
            btn35.BackColor = Color.White;
            btn36.ForeColor = Color.White;
            btn36.BackColor = Color.White;
            colocarbuscamina();
        }

        void mandarbuscamina(Button botonx) {
            botonx.Text = "*";
            c.HayBomba = true;
            
        }

        void checarclic(Button botonx, int f, int c)
        {
            botonx.ForeColor = Color.Black;
            switch (MouseButtons)
            {
                case MouseButtons.Left:
                    MessageBox.Show("izquierda");
                    break;
                case MouseButtons.Right:

                    if (botonx.Text == "*")
                    {
                        MessageBox.Show("Aqui hay una mina");
                    }
                    else
                    {
                        
                        esnumero(f, c);
                        
                    }
                    break;
            }
        }



        private void btn1_MouseDown(object sender, MouseEventArgs e)
        {
            
            checarclic(btn1, 0, 0);
        }

        private void btn2_MouseDown(object sender, MouseEventArgs e)
        {
            
            checarclic(btn2, 0, 1);
        }

       

        private void btn3_MouseDown(object sender, MouseEventArgs e)
        {
            
            checarclic(btn3, 0, 2);
        }



        

        private void btn4_MouseDown(object sender, MouseEventArgs e)
        {
            
            checarclic(btn4, 0, 3);
        }

        private void btn5_MouseDown(object sender, MouseEventArgs e)
        {
           
            checarclic(btn5, 0, 4);
        }

        private void btn6_MouseDown(object sender, MouseEventArgs e)
        {
           
            checarclic(btn6, 0, 5);
        }

        private void btn7_MouseDown(object sender, MouseEventArgs e)
        {
            checarclic(btn7, 1, 0);
        }

        private void btn8_MouseDown(object sender, MouseEventArgs e)
        {
            checarclic(btn8, 1, 1);
        }

        private void btn9_MouseDown(object sender, MouseEventArgs e)
        {
           
            checarclic(btn9, 1, 2);
        }

        private void btn10_MouseDown(object sender, MouseEventArgs e)
        {
            
            checarclic(btn10, 1, 3);
            
        }

        private void btn11_MouseDown(object sender, MouseEventArgs e)
        {
            
            checarclic(btn11, 1, 4);
        }

        private void btn12_MouseDown(object sender, MouseEventArgs e)
        {
            checarclic(btn12, 1, 5);
        }

        private void btn13_Click(object sender, EventArgs e)
        { }

        private void btn14_MouseDown(object sender, MouseEventArgs e)
        {
            
            checarclic(btn14, 2, 1);
        }

        private void btn15_MouseDown(object sender, MouseEventArgs e)
        {
            
            checarclic(btn15, 2, 2);
        }

        private void btn16_MouseDown(object sender, MouseEventArgs e)
        {
            
            checarclic(btn16, 2, 3);
        }

        private void btn17_MouseDown(object sender, MouseEventArgs e)
        {
           
            checarclic(btn17, 2, 4);
        }

        private void btn18_MouseDown(object sender, MouseEventArgs e)
        {
            checarclic(btn18, 2, 5);
        }

        int num, num1;
        private void colocarbuscamina(){
            Random random1 = new Random();
            Random random2 = new Random();
            numeroR1 = random1.Next(1, 36);
            numeroR2 = random2.Next(1, 36);
            Random RandomMinas = new Random();
            
           

            switch (numeroR1)
            {
                case 1: mandarbuscamina(btn1); break;
                case 2: mandarbuscamina(btn2); break;
                case 3: mandarbuscamina(btn3); break;
                case 4: mandarbuscamina(btn4); break;
                case 5: mandarbuscamina(btn5); break;
                case 6: mandarbuscamina(btn6); break;
                case 7: mandarbuscamina(btn7); break;
                case 8: mandarbuscamina(btn8); break;
                case 9: mandarbuscamina(btn9); break;
                case 10: mandarbuscamina(btn10); break; 
                case 11: mandarbuscamina(btn11); break;
                case 12: mandarbuscamina(btn12); break;
                case 13: mandarbuscamina(btn13); break;
                case 14: mandarbuscamina(btn14); break;
                case 15: mandarbuscamina(btn15); break;
                case 16: mandarbuscamina(btn16); break;
                case 17: mandarbuscamina(btn17); break;
                case 18: mandarbuscamina(btn18); break;
                case 19: mandarbuscamina(btn19); break;
                case 20: mandarbuscamina(btn20); break;
                case 21: mandarbuscamina(btn21); break;
                case 22: mandarbuscamina(btn22); break;
                case 23: mandarbuscamina(btn23); break;
                case 24: mandarbuscamina(btn24); break;
                case 25: mandarbuscamina(btn25); break;
                case 26: mandarbuscamina(btn26); break;
                case 27: mandarbuscamina(btn27); break;
                case 28: mandarbuscamina(btn28); break;
                case 29: mandarbuscamina(btn29); break;
                case 30: mandarbuscamina(btn30); break;
                case 31: mandarbuscamina(btn31); break;
                case 32: mandarbuscamina(btn32); break;
                case 33: mandarbuscamina(btn33); break;
                case 34: mandarbuscamina(btn34); break;
                case 35: mandarbuscamina(btn35); break;
                case 36: mandarbuscamina(btn36); break;
                }
            switch (numeroR2)
            {
                case 1: mandarbuscamina(btn1); break;
                case 2: mandarbuscamina(btn2); break;
                case 3: mandarbuscamina(btn3); break;
                case 4: mandarbuscamina(btn4); break;
                case 5: mandarbuscamina(btn5); break;
                case 6: mandarbuscamina(btn6); break;
                case 7: mandarbuscamina(btn7); break;
                case 8: mandarbuscamina(btn8); break;
                case 9: mandarbuscamina(btn9); break;
                case 10: mandarbuscamina(btn10); break;
                case 11: mandarbuscamina(btn11); break;
                case 12: mandarbuscamina(btn12); break;
                case 13: mandarbuscamina(btn13); break;
                case 14: mandarbuscamina(btn14); break;
                case 15: mandarbuscamina(btn15); break;
                case 16: mandarbuscamina(btn16); break;
                case 17: mandarbuscamina(btn17); break;
                case 18: mandarbuscamina(btn18); break;
                case 19: mandarbuscamina(btn19); break;
                case 20: mandarbuscamina(btn20); break;
                case 21: mandarbuscamina(btn21); break;
                case 22: mandarbuscamina(btn22); break;
                case 23: mandarbuscamina(btn23); break;
                case 24: mandarbuscamina(btn24); break;
                case 25: mandarbuscamina(btn25); break;
                case 26: mandarbuscamina(btn26); break;
                case 27: mandarbuscamina(btn27); break;
                case 28: mandarbuscamina(btn28); break;
                case 29: mandarbuscamina(btn29); break;
                case 30: mandarbuscamina(btn30); break;
                case 31: mandarbuscamina(btn31); break;
                case 32: mandarbuscamina(btn32); break;
                case 33: mandarbuscamina(btn33); break;
                case 34: mandarbuscamina(btn34); break;
                case 35: mandarbuscamina(btn35); break;
                case 36: mandarbuscamina(btn36); break;


            }

        }
        int checarfila = 0, checarcolumna=0;
        int contador=0; //Buscamina
        int cuentao = 0;
        
        int realfila, realcolumna = 0;

        private void btn20_MouseDown(object sender, MouseEventArgs e)
        {
            checarclic(btn20, 3, 1);
        }

        private void btn21_MouseDown(object sender, MouseEventArgs e)
        {
            checarclic(btn21, 3, 2);
        }

        private void btn22_MouseDown(object sender, MouseEventArgs e)
        {
            checarclic(btn22, 3, 3);
        }

        private void btn23_MouseDown(object sender, MouseEventArgs e)
        {
            checarclic(btn23, 3, 4);
        }

        private void btn24_MouseDown(object sender, MouseEventArgs e)
        {
            checarclic(btn24, 3, 5);
        }

        private void btn25_MouseDown(object sender, MouseEventArgs e)
        {
            checarclic(btn25, 4, 0);
        }

        private void btn26_MouseDown(object sender, MouseEventArgs e)
        {
            checarclic(btn26, 4, 1);
        }

        private void btn27_MouseDown(object sender, MouseEventArgs e)
        {
            checarclic(btn27, 4, 2);
        }

        private void btn28_MouseDown(object sender, MouseEventArgs e)
        {
            checarclic(btn28, 4, 3);
        }

        private void btn29_MouseDown(object sender, MouseEventArgs e)
        {
            checarclic(btn29, 4, 4);
        }

        private void btn30_MouseDown(object sender, MouseEventArgs e)
        {
            checarclic(btn30, 4, 5);
        }

        private void btn31_MouseDown(object sender, MouseEventArgs e)
        {
            checarclic(btn31, 5, 0);
        }

        private void btn32_MouseDown(object sender, MouseEventArgs e)
        {
            checarclic(btn32, 5, 1);
        }

        private void btn33_MouseDown(object sender, MouseEventArgs e)
        {
            checarclic(btn33, 5, 2);
        }

        private void btn34_MouseDown(object sender, MouseEventArgs e)
        {
            checarclic(btn34, 5, 3);
        }

        private void btn35_MouseDown(object sender, MouseEventArgs e)
        {
            checarclic(btn35, 5, 4);
        }

        private void btn36_MouseDown(object sender, MouseEventArgs e)
        {
            checarclic(btn36, 5, 5);
        }

        private void btn19_MouseDown(object sender, MouseEventArgs e)
        {
            checarclic(btn19, 3, 0);
        }

        private void btn13_MouseDown(object sender, MouseEventArgs e)
        {
            checarclic(btn13, 2, 0);
        }

        string contadorletra;


        void esnumero(int fila, int columna) { //esto es mi lugar 
            realfila = fila;
            realcolumna = columna;
            
                MessageBox.Show("Soy un limite");
            
            if (fila == 0 && columna == 0) {
                if (botones[fila + 1, columna].Text == "*")
                    contador++;
                fila = realfila;
                columna = realcolumna;
                if (botones[fila, columna + 1].Text == "*")
                    contador++;
                fila = realfila;
                columna = realcolumna;
                if (botones[fila + 1, columna + 1].Text == "*")
                    contador++;
                }
                
                if (fila == 1 && columna == 0) 
                    bordeizquierda(fila, columna);
                if(fila==2 && columna ==0 )
                bordeizquierda(fila, columna);






            if ( columna > 0) {
                        //recuerda colocar como abajo
                        if (botones[fila, columna - 1].Text == "*")
                        {
                            contador++;
                        }
                        fila = realfila;
                        columna = realcolumna;
                        if (botones[fila, columna + 1].Text == "*")
                        {
                            contador++;
                        }
                        fila = realfila;
                        columna = realcolumna;

                        if (botones[fila - 1, columna].Text == "*")
                        {
                        MessageBox.Show("Entre");
                            contador++;
                        }

                        fila = realfila;
                        columna = realcolumna;
                        if (botones[fila - 1, columna - 1].Text == "*")
                        {
                            contador++;
                        }
                        fila = realfila;
                        columna = realcolumna;
                        if (botones[fila - 1, columna + 1].Text == "*")
                        {
                            contador++;
                        }
                        fila = realfila;
                        columna = realcolumna;
                        if (botones[fila + 1, columna].Text == "*")
                        {
                            contador++;
                        }
                        fila = realfila;
                        columna = realcolumna;
                        if (botones[fila + 1, columna - 1].Text == "*")
                        {
                            contador++;
                        }
                        fila = realfila;
                        columna = realcolumna;
                        if (botones[fila + 1, columna + 1].Text == "*")
                        {
                            contador++;
                        }
                        //botones[realfila, realcolumna].Text = Convert.ToString(contador);
                        //contador = 0;
                    } //checar no limite
                

            
            botones[realfila, realcolumna].Text = Convert.ToString(contador);
            contador = 0;
        }

        void limiteizquierdo(int fila, int columna) {
            fila = realfila;
            columna = realcolumna;



            /////////////////////////////////////7

            if (botones[fila - 1, columna + 1].Text == "*")
            {
                contador++;
            }
            fila = realfila;
            columna = realcolumna;

            if (botones[fila - 1, columna].Text == "*")
            {
                contador++;
            }
            fila = realfila;
            columna = realcolumna;
            if (botones[fila, columna + 1].Text == "*")
            {
                contador++;
            }
            fila = realfila;
            columna = realcolumna;
            if (botones[fila + 1, columna].Text == "*")
            {
                contador++;
            }
            fila = realfila;
            columna = realcolumna;
            if (botones[fila + 1, columna + 1].Text == "*")
            {
                contador++;
            }

        }

        void bordeizquierda(int fila, int columna) {
            fila = realfila;
            columna = realcolumna;
            if (botones[fila + 1, columna].Text == "*")
                contador++;
            fila = realfila;
            columna = realcolumna;
            if (botones[fila, columna + 1].Text == "*")
                contador++;
            fila = realfila;
            columna = realcolumna;
            if (botones[fila + 1, columna + 1].Text == "*")
                contador++;
            fila = realfila;
            columna = realcolumna;
            if (botones[fila + 1, columna + 1].Text == "*")
                contador++;
            fila = realfila;
            columna = realcolumna;
            if (botones[fila - 1, columna].Text == "*")
                contador++;
            fila = realfila;
            columna = realcolumna;
            if (botones[fila - 1, columna++].Text == "*")
                contador++;

        }
        
    }
}
