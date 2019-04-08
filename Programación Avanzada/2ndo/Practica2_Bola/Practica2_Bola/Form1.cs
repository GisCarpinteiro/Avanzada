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

        int x = 9, y=10, conta=0; 

        void bajar(int ancho, int alto) {
            Lienzo.DrawEllipse(lapizNegro, x, y, ancho, alto);
            
            x = x + 2;
            y = y + 4;
            conta++;
        }

        

        void subir(int ancho, int alto) {

            Lienzo.DrawEllipse(lapizNegro, x, y, ancho, alto);

            x = x + 2;
            y = y - 4;
            //i++;
            conta++;

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            Lienzo.Clear(Color.WhiteSmoke);
            if (conta > 56  && conta<=102) //51  a 102
            {
                subir(45, 56);
                

            }
            if (conta < 51)
            {
                bajar(45, 56);
                Thread.Sleep(10);
                // conta++;
            }
           if (conta >= 51 && conta <=56 ) {
                
                bajar(56, 45);
                Thread.Sleep(200);

            }
              //  bajar(45, 56);


            listBox1.Items.Add(conta);
            
            //

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Lienzo.Clear(Color.WhiteSmoke);
            if (conta >= 103 && conta <= 154)  //104 a 200
            {
                timer1.Stop();
                bajar(45, 56);
                //conta++;
            }

            
        }


    }
}
