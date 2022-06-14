using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAi.Entidades;




namespace PPAi.Entidades
{
    public class Usuario
    {
        public Usuario()
        {

        }

        private int cod_usuario;
        private string clave;
        private string usuario;
        private int legajoCientifi;
        private string habilitado;

        public int LegajoCientifi
        {
            get => legajoCientifi;
            set => legajoCientifi = value;
        }
        public int Cod_usuario
        {
            get => cod_usuario;
            set => cod_usuario = value;
        }
        public string Clave
        {
            get => clave;
            set => clave = value;
        }
        public string USuario
        {
            get => usuario;
            set => usuario = value;
        }
        public string Habilitado
        {
            get => habilitado;
            set => habilitado = value;
        }

        public static Usuario obtenerPersonalCientífico(int id_usu)
        {
            //String cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaDB"];
            string cadenaConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=PPAi;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Usuario u = new Usuario();
            try
            {

                SqlCommand comando = new SqlCommand();
                String consulta = "SELECT * FROM Usuario where cod_usuario like @cod_usuario";
                comando.Parameters.AddWithValue("@cod_usuario", id_usu);
                comando.CommandType = CommandType.Text;
                comando.CommandText = consulta;
                cn.Open();
                comando.Connection = cn;
                SqlDataReader dr = comando.ExecuteReader();
                if (dr != null & dr.Read())
                {
                    u.cod_usuario = int.Parse(dr["cod_usuario"].ToString());
                    u.usuario = dr["usuario"].ToString();
                    u.habilitado = dr["habilitado"].ToString();
                    u.clave = dr["clave"].ToString();
                    u.legajoCientifi = int.Parse(dr["legajoCientifi"].ToString());
                }

                return u;

            }
            catch
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

        }


    }
}
