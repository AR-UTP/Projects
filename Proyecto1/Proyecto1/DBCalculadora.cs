using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Proyecto1
{
    internal class DBCalculadora
    {
        public void GuardarOperacion(double num1, string operador, double? num2, string resultado)
        {
            string conexion = "Server=USUARIO-MT692LO;Database=CalculadoraDB;Trusted_Connection=True;";
            string query = "INSERT INTO Operaciones (Numero1, Operador, Numero2, Resultado) VALUES (@n1, @op, @n2, @res)";

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@n1", num1);
                    cmd.Parameters.AddWithValue("@op", operador);
                    cmd.Parameters.AddWithValue("@n2", (object)num2 ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@res", resultado);
                    cmd.ExecuteNonQuery();
                }
            }


        }

    }
}
