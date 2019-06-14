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
        int g, c, id=0;
        bool banderaseinsertaron = false;
        void mostrarI()
        {
            try
            {
                conexion.Open();
                MySqlCommand trabajador = new MySqlCommand("select tipo_helado, precio, cantidad from helado where eliminadoh=0", conexion);

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

        }

        private void Inventario_Administrador_Load(object sender, EventArgs e)
        {
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

          
        
    }
}
