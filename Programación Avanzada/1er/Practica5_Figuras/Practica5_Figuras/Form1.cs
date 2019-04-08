using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5_Figuras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btDibujar_Click(object sender, EventArgs e)
        {
            Graphics papel1;
            //PbN1.BackColor = Color.Blue;
            papel1 = PbN1.CreateGraphics();
            Pen lapizNegro = new Pen(Color.Black);
            Pen lapizRojo = new Pen(Color.Red);
            Pen lapizAzul = new Pen(Color.BlueViolet);
            Brush Brochamorada = new System.Drawing.SolidBrush(System.Drawing.Color.Violet);
            papel1.DrawRectangle(lapizNegro, 10, 10, 100, 30);
            
            papel1.DrawLine(lapizNegro, 9, 10, 110, 40);

            Graphics papel2;
            papel2 = PbN2.CreateGraphics();
            papel2.DrawEllipse(lapizNegro, 9, 10, 80, 45);
            papel2.DrawRectangle(lapizAzul, 9, 10, 80, 45);


            Graphics papel3;
            papel3 = PbN3.CreateGraphics();
            papel3.DrawEllipse(lapizNegro, 9, 10, 80, 45);
            papel3.FillEllipse(Brochamorada, new Rectangle(9, 10, 80, 45));

            
            Graphics papel4;
            papel4 = PbN4.CreateGraphics();
          
            int c = 80;
            int x, y;
            
            for (int i = 0; i < 160; i++)
            {
                x = 5 + (int)(Math.Cos(i) * 80);
                y = 5 + (int)(Math.Sin(i) * 80);
                papel4.DrawEllipse(lapizNegro, x + c, y + c, 80, 80);


            }

            Graphics papel5;
            papel5 = PbNombre.CreateGraphics();
            string drawString = "GISEL";
            System.Drawing.Font drawFont = new System.Drawing.Font("Algerian", 18);
           // System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            papel5.DrawString(drawString, drawFont, Brochamorada, 10, 10, drawFormat);

        }
    }
}
