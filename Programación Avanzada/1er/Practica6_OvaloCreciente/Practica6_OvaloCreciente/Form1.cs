using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica6_OvaloCreciente
{
 
    public partial class Form1 : Form
         
    {
        int x, y;
        public void crear(int x, int y)
        {
            Brush Brochamorada = new System.Drawing.SolidBrush(System.Drawing.Color.Violet);
            Graphics papel1;
            papel1 = PbN1.CreateGraphics();
            papel1.Clear(Color.WhiteSmoke);
            Pen lapizAzul = new Pen(Color.Aqua);
            papel1.DrawEllipse(lapizAzul, 40, 55, x, y);
            papel1.FillEllipse(Brochamorada, new Rectangle(40, 55, x, y));
        }
       

            
        public Form1()
        {
            InitializeComponent();
           
        }

        private void SbVertical_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void SbHorizontal_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void SbVertical_ValueChanged(object sender, EventArgs e)
        {
            y = SbVertical.Value;
            crear(x, y);
        }

        private void SbHorizontal_ValueChanged(object sender, EventArgs e)
        {
            x = SbHorizontal.Value;
            crear(x, y);
        }

        
        }
    }

