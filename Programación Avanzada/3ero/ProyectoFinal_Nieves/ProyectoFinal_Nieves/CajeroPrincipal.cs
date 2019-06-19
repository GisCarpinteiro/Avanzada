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
        string idt;
        int idhelado=0;
        int idpedido, idcantidad;
        int cuenta = 0, d;
        DataSet ds;

        
       // int id_cajero;

        private void CajeroPrincipal_Load(object sender, EventArgs e)
        {
           
            timer1.Start();
            mostrarhelados();
            mostrarnombre();
            /*dgvPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedido.MultiSelect = false;
            dgvPedido.ColumnCount = 3;
            this.Controls.Add(dgvPedido);
            dgvPedido.Columns[0].HeaderText = "Cantidad";
            dgvPedido.Columns[1].HeaderText = "Tipo Helado";
            dgvPedido.Columns[2].HeaderText = "Precio";*/
            idt = lbl_id.Text;
            sacarIdpedido();
            mostrarDatos();
            sacaridcantidad();


            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("G");
            
        }

        void mostrarhelados() {
            try
            {
                conexion.Open();
                MySqlCommand querythelado = new MySqlCommand("select tipo_helado from helado where eliminadoh=0", conexion);
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
            sacaridhelado();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
           

            try
            {
                conexion.Open();
                MySqlCommand insertardatos =
                new MySqlCommand("delete from cantidad  where id_cantidad= '" + idcantidad + "'", conexion);

                if (insertardatos.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Se eliminaron datos");


                }
                else
                    MessageBox.Show("No se eliminaron datos");


                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar eliminar");
                MessageBox.Show(ex.Message);
            }

            
            mostrarDatos();
            

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Visible = false;
            MessageBox.Show("Sesión cerrada");
            InicioSesion InicioSesion = new InicioSesion();
            InicioSesion.Show();
        }

        private void lblVentas_Click(object sender, EventArgs e)
        {
            Ver_ventasCajero Ver_ventasCajero = new Ver_ventasCajero();
            Ver_ventasCajero.Show();
    
            Ver_ventasCajero.lblid.Text = idt;
            //MessageBox.Show("ver ventas" + Ver_ventasCajero.lblid.Text);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //cantidad = Convert.ToDouble(nuCantidad.Value);
            //helado = Convert.ToString(cb_tipohelado);
            //sacarprecio();
            //cuenta= cuenta+1;
            sacaridcantidad();
            //idcantidad = idcantidad + 1;
            idcantidad++;
            sacaridhelado();
            insertarcantidad();
            mostrarDatos();
            


        }


        private void rbT_CheckedChanged(object sender, EventArgs e)
        {
            if (rbT.Checked == true)
            {
                lblT.Visible = true;
                tbTarjeta.Visible = true;
                lbltxt.Visible = true;

            }
        }

        private void rbE_CheckedChanged(object sender, EventArgs e)
        {
            if (rbE.Checked == true)
            {
                lblT.Visible = false;
                tbTarjeta.Visible = false;
                lbltxt.Visible = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("filas"+ dgvPedido.CurrentRow.Index);
            pedido();

        }


        private void tbnuevo_Click(object sender, EventArgs e)
        {
            nuevopedido();
            mostrarDatos();
        }

        void sacarIdpedido() {
            try
            {
                conexion.Open();
                MySqlCommand id = new MySqlCommand("select count(*) from pedido", conexion);
                idpedido = Convert.ToInt32(id.ExecuteScalar().ToString());
                //tbGanancia.Text = gdia.ExecuteScalar().ToString();
                conexion.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar1");
                MessageBox.Show(ex.Message);
            }

        }

        void sacaridcantidad() {
            try
            {
                conexion.Open();
                MySqlCommand id = new MySqlCommand("select count(*) from cantidad", conexion);
                idcantidad = Convert.ToInt32(id.ExecuteScalar().ToString());
                //tbGanancia.Text = gdia.ExecuteScalar().ToString();
                //cidcantidad = idcantidad;
                conexion.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar1");
                MessageBox.Show(ex.Message);
            }

            
        }
      /*  void insertarenCantidad() {

            //sacaridcantidad();
            
            try
            {
                conexion.Open();
                MySqlCommand insertardatos =
                new MySqlCommand("insert into cantidad(cantidad, id_pedido, id_helado, id_cantidad) values ('" + nuCantidad.Value + "', '"+ idpedido + "', '" + idhelado + "', '" + idcantidad + "')", conexion);

                if (insertardatos.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Se insertaron datos");
                    

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
        } */

        void pedido()
        {
            
            try
            {
                conexion.Open();
                MySqlCommand insertardatos =
                new MySqlCommand("insert into pedido(fecha, hora, subtotal, total, id_trabajador, id_pedido) values (curdate(), time(now()),'" + TbSubtotal.Text + "', '" + TbTotal.Text + "', '" + lbl_id.Text + "', '" + idpedido + "')", conexion);

                if (insertardatos.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Se insertaron datos");


                }
                else
                    MessageBox.Show("No se insertaron datos");


                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar insertar");
                MessageBox.Show(ex.Message);
            }

            

        }

        private void tbTarjeta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cuenta = Convert.ToInt32(tbTarjeta.Text);

                if (tbTarjeta.Text == "")
                    lblT.Text = "No";
                if (cuenta <= 3000 && cuenta >= 0)
                    lblT.Text = "Mastercard";
                if (cuenta > 3000 && cuenta <= 7000)
                    lblT.Text = "Visa";
                if (cuenta > 7000)
                    lblT.Text = "Amex";
            }
            catch (Exception) {
                // MessageBox.Show("");
                lblT.Text = "No";
            }
        }

        void nuevopedido()
        {
            idpedido = idpedido + 1;
            try
            {
                conexion.Open();
                MySqlCommand insertardatos =
                new MySqlCommand("insert into pedido(fecha, hora, subtotal, total, id_trabajador, id_pedido) values (curdate(), time(now()), 0, 0,'"+ lbl_id.Text + "', '" + idpedido + "')", conexion);

                if (insertardatos.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Nuevo pedido");


                }
                else
                    MessageBox.Show("No se insertaron datos");


                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar insertar");
                MessageBox.Show(ex.Message);
            }

            

        }

        void mostrarDatos() {
            //btn agregar y nuevo
            try
            {
                conexion.Open();
                MySqlCommand trabajador = new MySqlCommand("select cantidad.cantidad, helado.tipo_helado, helado.precio from cantidad inner join helado on cantidad.id_helado = helado.id_helado where cantidad.cantidad > 0 and cantidad.id_pedido = '" + idpedido + "'", conexion);

                MySqlDataAdapter adapter = new MySqlDataAdapter(trabajador);
                ds = new DataSet();
                adapter.Fill(ds);

                dgvPedido.DataSource = ds.Tables[0];

                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar1");
                MessageBox.Show(ex.Message);
            }


        }

       void sacaridhelado() {
            try
            {
                conexion.Open();
                MySqlCommand querythelado = new MySqlCommand("select id_helado from helado where tipo_helado= '" + cb_tipohelado.SelectedItem + "'", conexion);
                MySqlDataReader reader;
                reader = querythelado.ExecuteReader();

                while (reader.Read())
                {

                    idhelado = Convert.ToInt32(reader["id_helado"]);

                }

                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al sacar helado");
                MessageBox.Show(ex.Message);
            }

        }

        void insertarcantidad() {


            try
            {
                conexion.Open();
                MySqlCommand insertardatos =
                new MySqlCommand("insert cantidad(cantidad, id_pedido, id_helado, id_cantidad) values ('" + nuCantidad.Value + "', '" + idpedido + "', '" + idhelado + "', '" + idcantidad  + "')", conexion);

                if (insertardatos.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Se agregaron datos");


                }
                else
                    MessageBox.Show("No se insertaron datos");


                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar insertar");
                MessageBox.Show(ex.Message);
            }

        }

        void descuento() {
            try
            {
                conexion.Open();
                MySqlCommand id = new MySqlCommand("select sum(cantidad) from cantidad where id_pedido='" + idpedido + "'", conexion);
                d = Convert.ToInt32(id.ExecuteScalar().ToString());
                conexion.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar descuento");
                MessageBox.Show(ex.Message);
            }
        }

        void descuentar() {
            descuento();
            if (d > 5) { }
             if (d > 10) { }
            
  
        }
    }
}
