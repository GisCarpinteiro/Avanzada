using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Practica2_Bola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics Lienzo;
        Brush color = new System.Drawing.SolidBrush(System.Drawing.Color.Violet);
        Pen lapizNegro = new Pen(Color.Black);
        int i = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            Lienzo = pbLienzo.CreateGraphics();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();

        }

        int x = 9, y = 10, conta = 0;

        void bajar(int ancho, int alto)
        {
            Lienzo.DrawEllipse(lapizNegro, x, y, ancho, alto);
            Lienzo.FillEllipse(color, x, y, ancho, alto);
            x = x + 2;
            y = y + 4;
            conta++;
        }



        void subir(int ancho, int alto)
        {

            Lienzo.DrawEllipse(lapizNegro, x, y, ancho, alto);
            Lienzo.FillEllipse(color, x, y, ancho, alto);
            x = x + 2;
            y = y - 4;
            conta++;

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            x = 9;
            y = 10;
            conta = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            



            if (conta <= 50){  //<50
                Lienzo.Clear(Color.WhiteSmoke);
                bajar(45, 56);
                Thread.Sleep(70); //100 sle
               }



           
            if (conta == 51 /* || conta==52*/){ //conta== 50
                 Lienzo.Clear(Color.WhiteSmoke);
                x = x + 1;
                subir(56, 45);  //bajar
                Thread.Sleep(100); //200 slee
                    }  

                /* if (conta == 53)
                 {
                     Lienzo.Clear(Color.WhiteSmoke);
                     subir(56, 45);
                     Thread.Sleep(200); //200 slee
                 }*/



                listBox1.Items.Add(conta);
            //
            


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (conta > 51 && conta <= 102) //51  a 102
            {
                Lienzo.Clear(Color.WhiteSmoke);
                subir(45, 56);
            }

            if (conta == 103 /* || conta==52*/)
            { //conta== 50
                Lienzo.Clear(Color.WhiteSmoke);
                //x = x + 1;
                bajar(56, 45);  //bajar
                Thread.Sleep(100); //200 slee
            }

            if (conta >= 104 && conta <= 154)  //103  a 154
            {
                Lienzo.Clear(Color.WhiteSmoke);
                timer1.Stop();
                bajar(45, 56);
                Thread.Sleep(70);
                //conta++;
            }

           



        }


    }
}