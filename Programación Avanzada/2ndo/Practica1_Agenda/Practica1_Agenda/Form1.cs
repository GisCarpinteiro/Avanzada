using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1_Agenda
{
    public partial class Form1 : Form
    {
       //Persona[] monitos = new Persona[6];
        int i = 0, g;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (i > 4)
            {
                MessageBox.Show("Ha excedido");
            }
            else {
                Persona monito1 = new Persona();
                monito1.nombre = TbNombre.Text;
                monito1.telefono = TbTelefono.Text;
                monito1.domicilio = TbDomicilio.Text;
                monito1.id = TbId.Text;
                //monitos[i] = monito1;
                //actualizar();
                dgvDatos.Rows.Add(monito1.nombre, monito1.id, monito1.telefono, monito1.domicilio);
                clearsin();

            }
        }
        void clearsin() {
            TbNombre.Clear();
            TbDomicilio.Clear();
            TbTelefono.Clear();
            TbId.Clear();

        }

        private void actualizar() {
            dgvDatos.DataSource = null;
            //dgvDatos.DataSource = monitos;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvDatos.SelectedRows) {
                dgvDatos.Rows.RemoveAt(item.Index);
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.MultiSelect = false;
            dgvDatos.ColumnCount = 5;
            this.Controls.Add(dgvDatos);
            dgvDatos.Columns[0].HeaderText = "Nombre";
            dgvDatos.Columns[1].HeaderText = "ID";
            dgvDatos.Columns[2].HeaderText = "Telefono";
            dgvDatos.Columns[3].HeaderText = "Domicilio";

            
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            dgvDatos[0, g].Value = TbNombre.Text;
            dgvDatos[1, g].Value = TbId.Text;
            dgvDatos[2, g].Value = TbTelefono.Text;
            dgvDatos[3, g].Value = TbDomicilio.Text;
            
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            g= dgvDatos.CurrentRow.Index;
            TbNombre.Text = dgvDatos[0, g].Value.ToString();
            TbId.Text = dgvDatos[1, g].Value.ToString();
            TbDomicilio.Text = dgvDatos[3, g].Value.ToString();
            TbTelefono.Text = dgvDatos[2, g].Value.ToString();

        
        }
    }
}
