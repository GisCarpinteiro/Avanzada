using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bdprueba
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;
        SqlDataReader reader; //leer datos

        public Form1()
        {
            InitializeComponent();
            conexion = new SqlConnection("Persist Security Info=False;User ID=root;Initial Catalog=bdprueba;Data Source=127.0.0.1");
            conexion.Open();
            SqlCommand sql = new SqlCommand("", conexion);
            dataGridView1.DataSource = sql.ExecuteReader(); //ejecutar
            reader = sql.ExecuteReader(); //si la consulta esta bien
           //reader.GetSqlDouble(); //Obtener como ese tipo dato

        }
    }
}
