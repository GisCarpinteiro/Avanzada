using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoFinal_Nieves
{
    public partial class CajeroPrincipal : Form

    {
        MySqlConnection conexion;

        public CajeroPrincipal()
        {
            InitializeComponent();
            conexion = new MySqlConnection("datasource = 127.0.0.1; port = 3306; username = root; password =;database = helados");

        }

        string t_helado;
        int n_thelado;

        private void CajeroPrincipal_Load(object sender, EventArgs e)
        {
            //InicioSesion InicioSesion = new InicioSesion();
            timer1.Start();
            //cb_tipohelado.Items.Add("Hola");
            //cb_tipohelado.Items.Add("soy");
            //cb_tipohelado.Items.Add("gis");

           /* try
            {
                conexion.Open();

                MySqlCommand queryn_thelado = new MySqlCommand("select count(*) from helado", conexion);
                MySqlDataReader reader1;
                reader1 = queryn_thelado.ExecuteReader();

                while (reader.Read())
                {
                    n_thelado = Convert.ToInt32(queryn_thelado.ExecuteScalar());

                }
               // reader.Close();

               
                conexion.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar");
                MessageBox.Show(ex.Message);

            }*/

            try {
                conexion.Open();
                MySqlCommand querythelado = new MySqlCommand("select tipo_helado from helado", conexion);
                MySqlDataReader reader;
                reader = querythelado.ExecuteReader();

                while (reader.Read())
                {
                    
                   // for (int i = 0; i < 3; i++)
                   // {
                        t_helado = Convert.ToString(reader["tipo_helado"]);
                        cb_tipohelado.Items.Add(t_helado);
                   // }

                }

                conexion.Close();
            } catch (Exception ex) {

                MessageBox.Show("Error al conectar1");
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("G");
        }
    }
}
