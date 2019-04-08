using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2_Division
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double valor = 0, valoruno=0, real=0;
        string total;
        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {

                valor = Convert.ToDouble(Tbvalor.Text);
                valoruno = Convert.ToDouble(Tbvaloruno.Text);
                real = valor / valoruno;
                total = Convert.ToString(real);
                Tbreal.Text = total;

            }
            catch (DivideByZeroException exception)
            {
                
                MessageBox.Show("gmm");
            }

          // catch (StringFormat exception)
          //  {
           //    MessageBox.Show("errror");
           //  }





        }
    }
}
