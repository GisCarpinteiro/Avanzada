using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 form2 = new Form2();

        private void Main_Load(object sender, EventArgs e)
        {
            /*axWindowsMediaPlayer1.URL = @"C:\Users\home\Videos\guasontrailer.mp4";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.uiMode = ("none"); */
            // datos();

        }
        int nasientos, essocio, guardado = 0;
        double subtotal = 0;
        int monito = 0;

        //Cliente monito4, monito3;


        /* void validarnombre(Cliente monitox) {
             if (tbId.Text == monitox.id)
             {
                 btnAsientos.Enabled = true;
                 tbAsientos.Enabled = true;
                 lblNombre.Text = monitox.nombre;
                 essocio = 1;

                 if (monitox.id == "16716") {
                     monito = 3;
                   }

                 if (monitox.id == "16237")
                 {
                     monito = 4;
                 }
             }

             if(tbId.Text != monitox.id)
             {
                 btnAsientos.Enabled = false;
                 tbAsientos.Enabled = false;
                 //MessageBox.Show("No es socio");
                 essocio = 0;
             }

         }*/

        void validar()
        {
            if (tbId.Text == "16716")
            {
                lblNombre.Text = "Gisel Aguirre";
                monito = 3;
                btnAsientos.Enabled = true;
                tbAsientos.Enabled = true;
                essocio = 1;
            }


            if (tbId.Text == "16237")
            {
                lblNombre.Text = "David Orozco";
                monito = 3;
                btnAsientos.Enabled = true;
                tbAsientos.Enabled = true;
                essocio = 1;
            }

        }





        /*   void datos() {
               monito4 = new Cliente("David Antonio", "16237", 0, 0);
               monito3 = new Cliente("Gisel Aguirre", "16716", 0, 0);
               validarnombre(monito4);
               validarnombre(monito3);


           }*/

        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {

            MessageBox.Show("Nasientos" + nasientos);
            if (nasientos <= 2)
            {
                subtotal = nasientos * 70;
                tbSubtotal.Text = Convert.ToString(subtotal);
                tbTotal.Text = Convert.ToString((subtotal * .16) + subtotal);
                tbIva.Text = Convert.ToString(subtotal * .16);

            }

        }

        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        { tbIva.Text = " "; tbSubtotal.Text = " "; tbTotal.Text = " "; }


        private void btnAsientos_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Entro");
            form2.ShowDialog();
            //form2.lblNboletos.Text = Convert.ToString(Convert.ToInt32(nasientos));
            //form2.lblNboletos.Text = Convert.ToString(nasientos);
            MessageBox.Show(tbAsientos.Text);
            //form2.lblNboletos.Text = tbAsientos.Text;
            tbAsientos.Text = "2";

            //datos();
            try
            {
                nasientos = Convert.ToInt32(tbAsientos.Text);
                if (nasientos <= 2)
                    MessageBox.Show("menor");

                else
                {
                    MessageBox.Show("Escoger menos boletos");
                    nasientos = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccionar Boletos");
            }

        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {
            btnAsientos.Enabled = false;
            groupBox1.Enabled = false;
            tbAsientos.Enabled = false;
            // datos();
            if (tbId.Text == "16716")
            {
                lblNombre.Text = "Gisel Aguirre";
                monito = 3;
                groupBox1.Enabled = true;
                btnAsientos.Enabled = true;
                tbAsientos.Enabled = true;
                button1.Enabled = true;
                essocio = 1;
                MessageBox.Show("Bienvenido");
            }


            if (tbId.Text == "16237")
            {
                lblNombre.Text = "David Orozco";
                monito = 4;
                groupBox1.Enabled = true;
                btnAsientos.Enabled = true;
                tbAsientos.Enabled = true;
                button1.Enabled = true;
                essocio = 1;
                MessageBox.Show("Bienvenido");
            }

            /* if (tbId.Text != "16237" || tbId.Text != "16716") {
                 btnAsientos.Enabled = false;
                 groupBox1.Enabled = false;
                 tbAsientos.Enabled = false;
                 lblNombre.Text = " ";*/

            //  }

            /*  if (essocio == 1)
              {
                  btnAsientos.Enabled = true;
                  groupBox1.Enabled = true;
                  tbAsientos.Enabled = true;
                  MessageBox.Show("Bienvenido");

              }
              if(essocio == 0) {
                  btnAsientos.Enabled = false;
                  groupBox1.Enabled = false;
                  tbAsientos.Enabled = false;
                  lblNombre.Text = " ";
                  // MessageBox.Show("No es socio");

                  }*/


        }

        private void button1_Click(object sender, EventArgs e) //GUARDAR
        {
            /*Form2 form2 = new Form2();
            //monito4 = new Cliente("David Antonio", "16237", 0, 0);
            guardado = 1;
            form2.lblbandera.Text = Convert.ToString(Convert.ToInt32(guardado));
            
            if (monito == 3)
            {
                monito3 = new Cliente("Gisel Aguirre", "16716", nasientos, subtotal * .16 + subtotal);
                MessageBox.Show("Nombre, " + monito3.nombre);
                MessageBox.Show("Total, " + monito3.total);

               // nasientos = 0;
               
               // subtotal = 0;
            }

            if (monito == 4) {
                monito4 = new Cliente("David Orozco", "16237", nasientos, subtotal * .16 + subtotal);
                MessageBox.Show("Nombre, " + monito4.nombre);
                MessageBox.Show("Total, " + monito4.total);
            }*/
        }

        private void tbAsientos_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
