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
    public partial class InicioSesion : Form
    {
        MySqlConnection conexion;
        public InicioSesion()
        {
            InitializeComponent();
            conexion = new MySqlConnection("datasource = 127.0.0.1; port = 3306; username = root; password =;database = helados");

        }
        string contrasenabd, contrasena;
        int idbd, id, puesto;
        bool bandera_entroid=false, banderabienvenido=false;

        private void BtnAceptarinicio_Click(object sender, EventArgs e)
        {

            id = Convert.ToInt32(TbId.Text);
            contrasena = TbContraseña.Text;

            try
            {

                conexion.Open();

                MySqlCommand query = new MySqlCommand("select id_trabajador from trabajador where id_trabajador= " + id, conexion);
                MySqlDataReader reader;
                reader = query.ExecuteReader();

                if (reader.Read())
                {
                    //MessageBox.Show("La id se encuentra en la bd");
                    idbd = Convert.ToInt32(reader["id_trabajador"]);
                    bandera_entroid = true;
                    
                }
                
                else
                    MessageBox.Show("La id no se encontro");

                reader.Close();
                conexion.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar");
                MessageBox.Show(ex.Message);

            }


          
            try
            {
                conexion.Open();


                if (bandera_entroid == true)
                {
                    MySqlCommand querycontrasena = new MySqlCommand("select contrasena from trabajador where id_trabajador= " +id,conexion);
                    MySqlDataReader reader = querycontrasena.ExecuteReader();
                    

                    if (reader.HasRows)
                    {
                        while(reader.Read())
                            contrasenabd = Convert.ToString(reader["contrasena"]);
                        if (contrasena == contrasenabd)
                        {
                            //MessageBox.Show("Bienvenido");
                            bandera_entroid = false;
                            banderabienvenido = true;
                        }

                        else
                            MessageBox.Show("Contraseña incorrecta");

                    }

                    reader.Close();

                    if (banderabienvenido == true)
                    { 
                        MySqlCommand querypuesto = new MySqlCommand("select id_puesto from trabajador where id_trabajador=" + id, conexion);
                        reader = querypuesto.ExecuteReader();
                        while (reader.Read()) {
                            puesto = Convert.ToInt32(reader["id_puesto"]);
                            if (puesto == 2){
                                MessageBox.Show("Bienvenido Cajero");
                                CajeroPrincipal CajeroPrincipal = new CajeroPrincipal();
                                CajeroPrincipal.Show();
                               
                                
                               
                            }
                            else{
                                MessageBox.Show("Bienvenido Dueño");
                                //Form Formulario = New Form();
                                //Formulario.Show();
                            }
                        }

                    }

                }


                conexion.Close();


            }
            catch (Exception ex) {
                MessageBox.Show("Error al checar la contraseña");
                MessageBox.Show(ex.Message);

            }
        }


        private void InicioSesion_Load(object sender, EventArgs e)
        {
          

        }
    }
}