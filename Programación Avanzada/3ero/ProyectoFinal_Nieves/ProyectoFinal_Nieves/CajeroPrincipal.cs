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

        string t_helado, helado;
        double precioHelado, cantidad; //double

        
       // int id_cajero;

        private void CajeroPrincipal_Load(object sender, EventArgs e)
        {
           
            timer1.Start();
            mostrarhelados();
            mostrarnombre();
            dgvPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedido.MultiSelect = false;
            dgvPedido.ColumnCount = 3;
            this.Controls.Add(dgvPedido);
            dgvPedido.Columns[0].HeaderText = "Cantidad";
            dgvPedido.Columns[1].HeaderText = "Tipo Helado";
            dgvPedido.Columns[2].HeaderText = "Precio";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("G");
            
        }

        void mostrarhelados() {
            try
            {
                conexion.Open();
                MySqlCommand querythelado = new MySqlCommand("select tipo_helado from helado", conexion);
                MySqlDataReader reader;
                reader = querythelado.ExecuteReader();

                while (reader.Read())
                {


                    t_helado = Convert.ToString(reader["tipo_helado"]);
                    cb_tipohelado.Items.Add(t_helado);


                }

                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar1");
                MessageBox.Show(ex.Message);
            }
        }

        void mostrarnombre() {

            try
            {
                conexion.Open();
                MySqlCommand querythelado = new MySqlCommand("select nombre, apellido from trabajador where id_trabajador="+ lbl_id.Text, conexion);
                MySqlDataReader reader;
                reader = querythelado.ExecuteReader();

                while (reader.Read())
                {

                    lblNombrecajero.Text = Convert.ToString(reader["nombre"]) + " "+ Convert.ToString(reader["apellido"]);

                }

                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar1");
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_tipohelado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mostrarhelados();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //////////// Solo dgv /////////////////////////////
            try
            {
                foreach (DataGridViewRow item in this.dgvPedido.SelectedRows)
                {
                    dgvPedido.Rows.RemoveAt(item.Index);
                }
            }
            catch (Exception) {
                MessageBox.Show("Error, se elimino un campo vacio");

            }
            ///////////////////////////////////////////////
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Visible = false;
            MessageBox.Show("Sesión cerrada");
            InicioSesion InicioSesion = new InicioSesion();
            InicioSesion.Show();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            cantidad = Convert.ToDouble(nuCantidad.Value);

            helado = Convert.ToString(cb_tipohelado);
            sacarprecio();
            dgvPedido.Rows.Add(nuCantidad.Value, cb_tipohelado.SelectedItem, (precioHelado * cantidad));
        }

       void sacarprecio() {
            try
            {
                conexion.Open();
                MySqlCommand querythelado = new MySqlCommand("select precio from helado where tipo_helado= '" + cb_tipohelado.SelectedItem + "'", conexion);
                MySqlDataReader reader;
                reader = querythelado.ExecuteReader();

                while (reader.Read())
                {

                    precioHelado = Convert.ToDouble(reader["precio"]) ;

                }

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
