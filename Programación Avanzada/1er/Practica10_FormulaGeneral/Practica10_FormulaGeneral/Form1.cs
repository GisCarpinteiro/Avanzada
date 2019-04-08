using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Practica10_FormulaGeneral
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double a, b, c, resultado, res, p, res1, res2;
            string Uno, Dos, Tres;
            string r, r1;
             if (TbA.Text == "" || TbB.Text == "" || TbC.Text == "") {
                MessageBox.Show("Completar los datos");
                 return;
             }
         
            Uno = TbA.Text;
            a = Convert.ToDouble(Uno);
            Dos = TbB.Text;
            b = Convert.ToDouble(Dos);
            Tres = TbC.Text;
            c = Convert.ToDouble(Tres);
            resultado = (b * b);
            p = 4 * a * c;
            resultado = resultado - p;
            res = Math.Sqrt(resultado); //raiz cuadrada
            res1 = (-b + res) / (2 * a);
            res2 = (-b - res) / (2 * a);
            

          //  label1.Text = "2";


            r=res1.ToString();
            r1 = res2.ToString();
            LblRes1.Text = r;
            label1.Text = r1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
