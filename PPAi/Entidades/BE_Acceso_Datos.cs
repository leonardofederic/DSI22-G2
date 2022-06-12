using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace prueba1.Clases
{
    internal class BE_Acceso_Datos
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
       

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
        public DataTable Ejecutar_Select(string sql)
        {
            conenctar();
            cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            desconectar();
            return tabla;
        }
        
    }
}
