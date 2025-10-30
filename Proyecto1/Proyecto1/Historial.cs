using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            string conexion = "Server=USUARIO-MT692LO;Database=CalculadoraDB;Trusted_Connection=True;";
            string query = "SELECT Id, Numero1, Operador, Numero2, Resultado, Fecha FROM Operaciones ORDER BY Fecha DESC";

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHistorial.DataSource = dt;
            }

            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

