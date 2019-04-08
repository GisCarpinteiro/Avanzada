using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica4_Graficos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics papel;
            papel = PbPapel.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
            papel.DrawRectangle(lapiz, 10, 10, 100, 30);
            papel.DrawRectangle(lapiz, 120, 10, 100, 30);
        }
    }
}
