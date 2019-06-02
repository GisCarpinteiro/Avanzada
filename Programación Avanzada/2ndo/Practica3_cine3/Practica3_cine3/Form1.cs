using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3_cine3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //
        Asientos fasiento = new Asientos();

        Cliente monito1 = new Cliente("Gisel Aguirre", "16716", 2);
        Cliente monito2 = new Cliente("David Orozco", "16237", 2);
        Cliente monito3 = new Cliente("Ximena Carpinteiro", "16719", 2);
        Cliente monito4 = new Cliente("Mayra Carpinteiro", "16777", 2);
        Cliente monito5 = new Cliente("Jorge Davalos", "16075", 2);
        Cliente monito6 = new Cliente("Gustavo Davalos", "16076", 2);
        Cliente monito7 = new Cliente("Issac Zuñiga", "16339", 2);
        Cliente monito8 = new Cliente("Esteban Quintero", "16266", 2);
        Cliente monito9 = new Cliente("Luz Garcia", "16717", 2);
        Cliente monito10 = new Cliente("Hernesto Valverde", "16718", 2);

        int[] contadorAsientosSocios = new int[10];
        
        int monito = 0, nasientos;
        bool bandera;
        double subtotal=0;
        int nAsientosAux;

        int cuantos=0;
        //
       

        private void tbId_TextChanged(object sender, EventArgs e)
        {
            btnAsientos.Enabled = false;
            groupBox1.Enabled = false;
            tbAsientos.Enabled = false;
            // datos();
            bool socioReconocido = false;

            if (tbId.Text == "16716")
            {
                lblNombre.Text = monito1.nombre;
                nAsientosAux = monito1.nasientos;
                socioReconocido = true;              
            }

            if (tbId.Text == "16237")
            {
                lblNombre.Text = monito2.nombre;
                socioReconocido = true;
                nAsientosAux = monito2.nasientos;

            }

            if (tbId.Text == "16719")
            {
                lblNombre.Text = monito3.nombre;
                socioReconocido = true;
                nAsientosAux = monito3.nasientos;

            }

            if (tbId.Text == "16777")
            {
                lblNombre.Text = monito4.nombre;
                socioReconocido = true;
                nAsientosAux = monito4.nasientos;

            }

            if (tbId.Text == "16075")
            {
                lblNombre.Text = monito5.nombre;
                socioReconocido = true;
                nAsientosAux = monito5.nasientos;

            }

            if (tbId.Text == "16076")
            {
                lblNombre.Text = monito6.nombre;
                socioReconocido = true;
                nAsientosAux = monito6.nasientos;

            }

            if (tbId.Text == "16339")
            {
                lblNombre.Text = monito7.nombre;
                socioReconocido = true;
                nAsientosAux = monito7.nasientos;

            }

            if (tbId.Text == "16266")
            {
                lblNombre.Text = monito8.nombre;
                socioReconocido = true;
                nAsientosAux = monito8.nasientos;

            }

            if (tbId.Text == "16717")
            {
                lblNombre.Text = monito9.nombre;
                socioReconocido = true;
                nAsientosAux = monito9.nasientos;

            }

            if (tbId.Text == "16718")
            {
                lblNombre.Text = monito10.nombre;
                socioReconocido = true;
                nAsientosAux = monito10.nasientos;

            }

            if (socioReconocido)
            {
                groupBox1.Enabled = true;
                btnAsientos.Enabled = true;
                tbAsientos.Enabled = true;
                button1.Enabled = true;

                MessageBox.Show("Bienvenido");
            }
        }

        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Nasientos" + nasientos);
            if (nasientos <= 2)
            {
                subtotal = nasientos * 70;
                tbSubtotal.Text = Convert.ToString(subtotal);
                tbTotal.Text = Convert.ToString((subtotal * .16) + subtotal);
                tbIva.Text = Convert.ToString(subtotal * .16);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           axWindowsMediaPlayer1.URL = @"C:\Users\home\Videos\guasontrailer.mp4";
           axWindowsMediaPlayer1.settings.setMode("loop", true);
           axWindowsMediaPlayer1.uiMode = ("none"); 
        }

        //botón guardar
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guardado");
            //Numero de acientos del usuario que ingresó menos el de la txtbox.
            nAsientosAux -= nasientos;

            switch (tbId.Text)
            {
                case "16716":
                    monito1.nasientos = nAsientosAux;
                    break;
                case "16237":
                    monito2.nasientos = nAsientosAux;
                    break;
                case "16729":
                    monito3.nasientos = nAsientosAux;
                    break;
                case "16777":
                    monito4.nasientos = nAsientosAux;
                    break;
                case "167075":
                    monito5.nasientos = nAsientosAux;
                    break;
                case "16076":
                    monito6.nasientos = nAsientosAux;
                    break;
                case "16339":
                    monito7.nasientos = nAsientosAux;
                    break;
                case "16266":
                    monito8.nasientos = nAsientosAux;
                    break;
                case "16717":
                    monito9.nasientos = nAsientosAux;
                    break;
                case "16718":
                    monito10.nasientos = nAsientosAux;
                    break;
            }

            bandera = true;        
            
        }

        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        { tbIva.Text = " "; tbSubtotal.Text = " "; tbTotal.Text = " ";}


        private void btnAsientos_Click(object sender, EventArgs e)
        {

            /*//MessageBox.Show("numero asientos" + nasientos);
            int resta = nAsientosAux - Convert.ToInt32(tbAsientos.Text);

            nasientos = Convert.ToInt32(tbAsientos.Text);
            fasiento.lblNboletos.Text = tbAsientos.Text;
            MessageBox.Show("" + nAsientosAux + "-" + Convert.ToInt32(tbAsientos.Text));

            if (resta >= 0) {

                fasiento.contador = 0;
                fasiento.ShowDialog();
            }

            else if (nasientos >= 3)
            {
                MessageBox.Show("Escoger menos boletos");
                nasientos = 0;
            }

            else if (nasientos <= 0)
            {
                MessageBox.Show("Escoger más boletos");
            }

            else
            {
                if (nAsientosAux > 0)
                {
                    //MessageBox.Show("aun sobra");
                    tbAsientos.Text = Convert.ToString(resta*-1);
                }
                else
                    MessageBox.Show("Ya no hay boletos para "+lblNombre.Text);
            } */

            if (bandera)
            {
                tbAsientos.Text = Convert.ToString(cuantos);
                fasiento.contador = 0;

                bandera = false;
            }

            fasiento.lblNboletos.Text = tbAsientos.Text;
            //MessageBox.Show("numero asientos" + nasientos);

            nasientos = Convert.ToInt32(tbAsientos.Text);

            if (nAsientosAux == 0 || cuantos + nasientos > 2)
            {
                MessageBox.Show("Ya no puede adquirir más boletos");

            }
            else
            {

                if (nasientos <= 2 && nasientos > 0)
                    fasiento.ShowDialog();
            }



            if (nasientos >= 3)
            {
                MessageBox.Show("Escoger menos boletos");
                nasientos = 0;
            }

            if (nasientos <= 0)
            {
                MessageBox.Show("Escoger boletos");
            }

        }
    }
}
