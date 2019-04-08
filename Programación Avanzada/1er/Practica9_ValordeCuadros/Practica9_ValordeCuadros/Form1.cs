using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica9_ValordeCuadros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Dibujar(Graphics papel, Pen lapiz, int x, int y) {
            papel.DrawRectangle(lapiz, 100, 100, x, y);
            papel.DrawRectangle(lapiz, 50, 50, x, y);
            papel.DrawRectangle(lapiz, 10, 10, x, y);

            

        }

        private void BtDibujar_Click(object sender, EventArgs e)
        {
            
            if (TbX1.Text == "" || TbX2.Text == "" || TbX3.Text=="") {
                MessageBox.Show("Falto completar");
                return;
            }

            if (TbY1.Text == "" || TbY2.Text == "" || TbY3.Text == "")
            {
                MessageBox.Show("Falto completar");
                
                    return;
            }

           
                int x1, y1, x2, y2, x3, y3;
                x1 = Int32.Parse(TbX1.Text);
                y1 = Int32.Parse(TbY1.Text);
                x2 = Int32.Parse(TbX2.Text);
                y2 = Int32.Parse(TbY2.Text);
                x3 = Int32.Parse(TbX3.Text);
                y3 = Int32.Parse(TbY3.Text);

            Graphics Papel;
            Papel = PbUno.CreateGraphics();
            Pen Lapiz = new Pen(Color.Violet);
            Dibujar(Papel, Lapiz, x1, y1);
            Dibujar(Papel, Lapiz, x2, y2);
                Dibujar(Papel, Lapiz, x3, y3);
            //Papel.Clear(Color.WhiteSmoke);

        }
    }
}
