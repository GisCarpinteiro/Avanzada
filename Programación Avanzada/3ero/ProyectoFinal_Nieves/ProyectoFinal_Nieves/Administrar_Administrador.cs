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
    public partial class Administrar_Administrador : Form
    {
        MySqlConnection conexion;

        public Administrar_Administrador()
        {
            InitializeComponent();
            conexion = new MySqlConnection("datasource = 127.0.0.1; port = 3306; username = root; password =;database = helados");

        }

        DataSet ds;
        int g, contarid, eliminado;
        bool banderaseinsertaron = false;

        private void dgvE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            g = dgvE.CurrentRow.Index;
            tbNombreE.Text = dgvE[0, g].Value.ToString();
            tbApellido.Text = dgvE[1, g].Value.ToString();
            tbTelE.Text = dgvE[2, g].Value.ToString();
            tbContraE.Text = dgvE[4, g].Value.ToString();
            tbIdE.Text = dgvE[3, g].Value.ToString();
        }

        private void btnEliminarE_Click(object sender, EventArgs e)
        {
            //////////// Solo dgv /////////////////////////////
            foreach (DataGridViewRow item in this.dgvE.SelectedRows)
            {
                dgvE.Rows.RemoveAt(item.Index);
            }

            ///////////////////////////////////////////////

            try
            {
                conexion.Open();
                MySqlCommand eliminarusuario =
                new MySqlCommand("update trabajador set eliminado=1 where id_trabajador=" + tbIdE.Text, conexion);
                if (eliminarusuario.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Se elimino el usuario");
                    //banderaseinsertaron = true;

                }
                else
                    MessageBox.Show("No se insertaron datos");


                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar1");
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarE_Click(object sender, EventArgs e)
        {
            checarid();
            if (contarid == 0)
            {
                AgregarE();
                mostrarE();
            }
            else
                MessageBox.Show("Error id existente");
            if (banderaseinsertaron == true)
            {
                tbNombreE.Clear();
                tbApellido.Clear();
                tbContraE.Clear();
                tbIdE.Clear();
                tbTelE.Clear();
            }
        }

        private void Administrar_Administrador_Load(object sender, EventArgs e)
        {
            dgvE.MultiSelect = false;
            mostrarE();

        }

        void mostrarE()
        {
            try
            {
                conexion.Open();
                MySqlCommand trabajador = new MySqlCommand("select nombre, apellido, telefono, id_trabajador, contrasena from trabajador where id_puesto=1 and eliminado=0", conexion);

                MySqlDataAdapter adapter = new MySqlDataAdapter(trabajador);
                ds = new DataSet();
                adapter.Fill(ds);

                dgvE.DataSource = ds.Tables[0];

                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar1");
                MessageBox.Show(ex.Message);
            }

        }

        void AgregarE()
        {
            try
            {
                conexion.Open();
                MySqlCommand insertardatos =
                new MySqlCommand("Insert into trabajador (nombre, apellido, telefono, contrasena, id_trabajador, id_puesto, eliminado) values  ('" + tbNombreE.Text + "', '" + tbApellido.Text + "', '" + tbTelE.Text + "', '" + tbContraE.Text + "', " + Convert.ToInt32(tbIdE.Text) + ", 1, 0)", conexion);

                if (insertardatos.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Se insertaron datos");
                    banderaseinsertaron = true;

                }
                else
                    MessageBox.Show("No se insertaron datos");


                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar1");
                MessageBox.Show(ex.Message);
            }


        }

        void checareliminado()
        {
            try
            {
                conexion.Open();
                MySqlCommand checar = new MySqlCommand("select eliminado from trabajador where id_trabajador=" + tbIdE.Text, conexion);
                MySqlDataReader reader;
                reader = checar.ExecuteReader();

                while (reader.Read())
                {
                    eliminado = Convert.ToInt32(reader["eliminado"]);


                }

                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar1");
                MessageBox.Show(ex.Message);
            }

        }

        void checarid()
        {
            try
            {
                conexion.Open();
                MySqlCommand checar = new MySqlCommand("select count(*) from trabajador where id_trabajador= " + Convert.ToInt32(tbIdE.Text), conexion);
                //MySqlDataReader reader;
                //reader = checar.ExecuteReader();

                // while (reader.Read())
                //{

                contarid = int.Parse(checar.ExecuteScalar().ToString());


                //}

                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar1");
                MessageBox.Show(ex.Message);
            }

        }


    }
}
