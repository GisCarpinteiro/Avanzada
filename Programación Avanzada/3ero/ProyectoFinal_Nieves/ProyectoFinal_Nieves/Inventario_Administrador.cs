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
    public partial class Inventario_Administrador : Form
    {
        MySqlConnection conexion;
        public Inventario_Administrador()
        {
            InitializeComponent();
            conexion = new MySqlConnection("datasource = 127.0.0.1; port = 3306; username = root; password =;database = helados");
            mostrarI();
        }
        DataSet ds;
        int g, c, id = 0;
        int  idheladoh=0;
        bool banderaseinsertaron = false;


        void mostrarI()
        {
            try
            {
                conexion.Open();
                MySqlCommand trabajador = new MySqlCommand("select  tipo_helado, precio, cantidad, id_helado from helado where eliminadoh=0", conexion);

                MySqlDataAdapter adapter = new MySqlDataAdapter(trabajador);
                ds = new DataSet();
                adapter.Fill(ds);

                dgvI.DataSource = ds.Tables[0];

                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al mostrar datos");
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            g = dgvI.CurrentRow.Index;
            tbHelado.Text = dgvI[0, g].Value.ToString();
            tbPrecio.Text = dgvI[1, g].Value.ToString();
            numericUpDown1.Value = Convert.ToInt32(dgvI[2, g].Value.ToString());
            tbidhelado.Text = dgvI[3, g].Value.ToString();
           // numericUpDown1.Value = CodgvI[2, 3].Value.ToString;
            c = Convert.ToInt32(dgvI[2, g].Value.ToString());
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < c)
            {
                MessageBox.Show("No puede quitar elementos");
            }
            else {
                id_helado();
                insertarenHelado();
                if (banderaseinsertaron == true)
                    mostrarI();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            obtenerid();
            //////////// Solo dgv /////////////////////////////
            foreach (DataGridViewRow item in this.dgvI.SelectedRows)
            {
                dgvI.Rows.RemoveAt(item.Index);
            }

            ///////////////////////////////////////////////

            try
            {
                conexion.Open();
                MySqlCommand eliminarusuario =
                new MySqlCommand("update helado set eliminadoh=1 where id_helado= " + tbidhelado.Text, conexion);
                if (eliminarusuario.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Se elimino el helado");
               

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

        private void Inventario_Administrador_Load(object sender, EventArgs e)
        {
            id_helado();
            mostrarI();
            
        }

        void insertarenHelado() {
            ///////////////////////////////////INSERTAR INFO HELADOS /////////////////////777
            try
            {
                conexion.Open();
                MySqlCommand insertardatos =
                new MySqlCommand("Insert into helado(id_helado, precio, tipo_helado, cantidad, eliminadoh) values ("+ (id+1) + ",'"+ tbPrecio.Text+ "','" + tbHelado.Text +"'," + numericUpDown1.Value + ", 0)", conexion);

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

                MessageBox.Show("Error al insertar datos");
                MessageBox.Show(ex.Message);
            }

            ///////////////////////////////////////////////////////////////////////////////////////777

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            dgvI[0, g].Value = tbHelado.Text;
            dgvI[1, g].Value = tbPrecio.Text;
            dgvI[2, g].Value = numericUpDown1.Value;
            //////////////////////////////////////////////////////
            try
            {
                conexion.Open();
                MySqlCommand modificarhelado =
                new MySqlCommand("update helado set tipo_helado='" + tbHelado.Text + "', precio= '"+ Convert.ToInt32(tbPrecio.Text) + "', cantidad= '" + numericUpDown1.Value + "' where id_helado= '" + Convert.ToInt32(tbidhelado.Text) + "'", conexion);
                if (modificarhelado.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Se modifico el helado");
                    
                }
                else
                    MessageBox.Show("No se modifico el helado");


                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar1");
                MessageBox.Show(ex.Message);
            }

        }

        void id_helado() {
            try
            {
                conexion.Open();
                MySqlCommand checar = new MySqlCommand("select count(*) from helado ", conexion);

               id  = int.Parse(checar.ExecuteScalar().ToString());

                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar en id helado");
                MessageBox.Show(ex.Message);
            }

        }

        void obtenerid() {
            try
            {
                conexion.Open();
                MySqlCommand idhelado = new MySqlCommand("select id_helado from helado where eliminadoh=0", conexion);
                MySqlDataReader reader;
                reader = idhelado.ExecuteReader();

                while (reader.Read())
                {


                   idheladoh = Convert.ToInt32(reader["id_helado"]);
                    


                }


                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al mostrar datos");
                MessageBox.Show(ex.Message);
            }

        }
        
    }
}
