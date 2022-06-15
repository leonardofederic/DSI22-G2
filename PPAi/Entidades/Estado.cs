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
    public class Estado
    {
        public Estado()
        {
            
        }
        private string nombre;
        private string descripcion;
        private string ambito;
        //sql boolean tomo bit
        private int esReservable;
        private int esCancelable;
        
        private int cod_estado;
        

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
        public string Ambito
        {
            get => ambito;
            set => ambito = value;
        }
        public int EsReservable
        {
            get => esReservable;
            set => esReservable = value;
        }
        public int EsCancelable
        {
            get => esCancelable;
            set => esCancelable = value;
        }
      
        public int Cod_estado
        {
            get => cod_estado;
            set => cod_estado = value;
        }
        public static List<Estado> esAmbitoRT()
        {
            List<Estado> Lista = new List<Estado>();
            String cadenaConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=PPAi;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comando = new SqlCommand();
                
                String consulta = "select * from Estado ;";
                comando.CommandType = CommandType.Text;
                comando.CommandText = consulta;
                cn.Open();
                comando.Connection = cn;
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Estado te = new Estado();
                    te.cod_estado = int.Parse(dr["cod_estado"].ToString()); 
                    te.nombre = dr["nombre"].ToString();
                    te.descripcion = dr["descripcion"].ToString();
                    te.ambito = dr["ambito"].ToString();
                    te.esCancelable = int.Parse(dr["esReservable"].ToString());
                    te.esCancelable = int.Parse(dr["esCancelable"].ToString());
                    Lista.Add(te);
                }

                return Lista;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static List<Estado> esDisponible()
        {
            List<Estado> Lista = new List<Estado>();
            String cadenaConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=PPAi;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand comando = new SqlCommand();
                
                String consulta = "select * from Estado ;";
                comando.CommandType = CommandType.Text;
                comando.CommandText = consulta;
                cn.Open();
                comando.Connection = cn;
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Estado te = new Estado();
                    te.cod_estado = int.Parse(dr["cod_estado"].ToString()); ;
                    te.nombre = dr["nombre"].ToString();
                    te.descripcion = dr["descripcion"].ToString();
                    te.ambito = dr["ambito"].ToString();
                    te.esCancelable = int.Parse(dr["esReservable"].ToString());
                    te.esCancelable = int.Parse(dr["esCancelable"].ToString());
                    Lista.Add(te);
                }

                return Lista;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public bool esAmbitoReserva() { return ambito == "Reserva"; }
        public bool esPendienteConfirmacion() { return nombre == "Pendiente de confirmacion"; }
        public bool esConfirmado() { return nombre == "Confirmado"; }
    }
}
