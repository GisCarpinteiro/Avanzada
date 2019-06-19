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
    public partial class Ver_ventasCajero : Form
    {
        MySqlConnection conexion;
        public Ver_ventasCajero()
        {
            InitializeComponent();
            conexion = new MySqlConnection("datasource = 127.0.0.1; port = 3306; username = root; password =;database = helados");

        }

        DataSet ds;

        private void Ver_ventasCajero_Load(object sender, EventArgs e)
        {
            cbFiltrar.Items.Add("Dia");
            cbFiltrar.Items.Add("Todos los días");
            cbFiltrar.Items.Add("Anteriores días");
            filtrodia();
            gananciadías();
            // MessageBox.Show(lblid.Text);
            cantidaddia();
        }

        private void cbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltrar.SelectedIndex == 0)
            {
                filtrodia();
                gananciadías();
                cantidaddia();
            }
            if (cbFiltrar.SelectedIndex == 1)
            {
                filtrotodos();
                gananciatodos();
                cantidadTodos();
            }
            if (cbFiltrar.SelectedIndex == 2)
            {
                anterioresdias();
                gananciaanteriores();
                cantidadanteriores();

            }
        }

        void filtrodia()
        {
            try
            {
                conexion.Open();
                MySqlCommand dia = new MySqlCommand("select cantidad.cantidad, pedido.fecha, pedido.hora, pedido.total from pedido inner join trabajador on trabajador.id_trabajador = pedido.id_trabajador inner join cantidad on cantidad.id_pedido = pedido.id_pedido where pedido.fecha = curdate() and trabajador.id_trabajador= '" + lblid.Text + "'" , conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(dia);
                ds = new DataSet();
                adapter.Fill(ds);
                dgvV.DataSource = ds.Tables[0];
                conexion.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar1");
                MessageBox.Show(ex.Message);
            }

        }
        void filtrotodos()
        {
            try
            {
                conexion.Open();
                MySqlCommand dia = new MySqlCommand("select cantidad.cantidad, pedido.fecha, pedido.hora, pedido.total from pedido inner join trabajador on trabajador.id_trabajador = pedido.id_trabajador inner join cantidad on cantidad.id_pedido = pedido.id_pedido where pedido.fecha <= curdate() and trabajador.id_trabajador= '" + lblid.Text + "'", conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(dia);
                ds = new DataSet();
                adapter.Fill(ds);
                dgvV.DataSource = ds.Tables[0];
                conexion.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar1");
                MessageBox.Show(ex.Message);
            }
        }
        void anterioresdias()
        {
            try
            {
                conexion.Open();
                MySqlCommand dia = new MySqlCommand("select cantidad.cantidad, pedido.fecha, pedido.hora, pedido.total from pedido inner join trabajador on trabajador.id_trabajador = pedido.id_trabajador inner join cantidad on cantidad.id_pedido = pedido.id_pedido where pedido.fecha < curdate() and trabajador.id_trabajador= '" + lblid.Text + "'", conexion);

                MySqlDataAdapter adapter = new MySqlDataAdapter(dia);
                ds = new DataSet();
                adapter.Fill(ds);
                dgvV.DataSource = ds.Tables[0];
                conexion.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar1");
                MessageBox.Show(ex.Message);
            }
        }
        void gananciadías()
        {

            try
            {
                conexion.Open();
                MySqlCommand gdia = new MySqlCommand("select sum(total) from pedido where fecha=curdate() and id_trabajador= '" + lblid.Text + "'", conexion);
                tbGanancia.Text = gdia.ExecuteScalar().ToString();
                conexion.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar1");
                MessageBox.Show(ex.Message);
            }
        }
        void gananciatodos()
        {
            try
            {
                conexion.Open();
                MySqlCommand gdia = new MySqlCommand("select sum(total) from pedido where fecha<=curdate() and id_trabajador= '" + lblid.Text + "'", conexion);
                tbGanancia.Text = gdia.ExecuteScalar().ToString();
                conexion.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar1");
                MessageBox.Show(ex.Message);
            }
        }

        void gananciaanteriores()
        {
            try
            {
                conexion.Open();
                MySqlCommand gdia = new MySqlCommand("select sum(total) from pedido where fecha<curdate() and id_trabajador= '" + lblid.Text + "'", conexion);
                tbGanancia.Text = gdia.ExecuteScalar().ToString();
                conexion.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar1");
                MessageBox.Show(ex.Message);
            }
        }

        void cantidadTodos()
        {
            try
            {
                conexion.Open();
                MySqlCommand gdia = new MySqlCommand("select  sum(cantidad.cantidad) from cantidad inner join pedido on cantidad.id_pedido= pedido.id_pedido where pedido.fecha <= curdate() and pedido.id_trabajador= '" + lblid.Text + "'", conexion);
                tbAv.Text = gdia.ExecuteScalar().ToString();
                conexion.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar1");
                MessageBox.Show(ex.Message);
            }


        }

        void cantidaddia()
        {
            try
            {
                conexion.Open();
                MySqlCommand gdia = new MySqlCommand("select  sum(cantidad.cantidad) from cantidad inner join pedido on cantidad.id_pedido= pedido.id_pedido where pedido.fecha = curdate() and pedido.id_trabajador= '" + lblid.Text + "'", conexion);
                tbAv.Text = gdia.ExecuteScalar().ToString();
                conexion.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar1");
                MessageBox.Show(ex.Message);
            }
        }

        void cantidadanteriores()
        {
            try
            {
                conexion.Open();
                MySqlCommand gdia = new MySqlCommand("select  sum(cantidad.cantidad) from cantidad inner join pedido on cantidad.id_pedido= pedido.id_pedido where pedido.fecha < curdate() and pedido.id_trabajador= '" + lblid.Text + "'", conexion);
                tbAv.Text = gdia.ExecuteScalar().ToString();
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
