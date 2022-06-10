using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PPAi.Entidades
{
    internal class BE_Acceso_Datos
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataTable tabla = new DataTable();

        private void conenctar()
        {
            conexion.ConnectionString = "Data Source=DESKTOP-H062NAK;Initial Catalog=PPAI2022;Integrated Security=True";
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
        }

        private void desconectar()
        {
            conexion.Close();
        }
        
        public DataTable Ejecutar_Select (string sql)
        {
            conenctar();
            cmd.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            desconectar();
            return tabla;
        }

    }
}
