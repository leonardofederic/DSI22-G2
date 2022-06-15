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
    public class AsignacionRepotTecRT
    {
        private int idAsiRepRT;
        private int numeroRT;
        private int personal;
        private string fechaDesde;
        private string fechaHasta;

        public int IdAsiRepRT
        {
            get => idAsiRepRT;
            set => idAsiRepRT = value;
        }
        public int NumeroRT
        {
            get => numeroRT;
            set => numeroRT = value;
        }
        public int Personal
        {
            get => personal;
            set => personal = value;
        }
        public string FechaDesde
        {
            get => fechaDesde;
            set => fechaDesde = value;
        }
        public string FechaHasta
        {
            get => fechaHasta;
            set => fechaHasta = value;
        }

        //  public static RecursoTecnológico buscarRTDisponible(int responsable)
        public static List<AsignacionRepotTecRT> buscarRTDisponible(int responsable)
        {
            List<AsignacionRepotTecRT> lista = new List<AsignacionRepotTecRT>();
            String cadenaConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=PPAi;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand comando = new SqlCommand();
                String consulta = "SELECT * FROM AsignacionRepotTecRT where idAsiRepRT like @idAsiRepRT";
                comando.Parameters.AddWithValue("@idAsiRepRT", responsable);
                comando.CommandType = CommandType.Text;
                comando.CommandText = consulta;
                cn.Open();
                comando.Connection = cn;
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    AsignacionRepotTecRT te = new AsignacionRepotTecRT();
                    te.idAsiRepRT = int.Parse(dr["idAsiRepRT"].ToString());
                    te.fechaHasta = dr["fechaHasta"].ToString();
                    te.fechaDesde = dr["fechaDesde"].ToString();
                    te.numeroRT = int.Parse(dr["numeroRT"].ToString());
                    te.personal = int.Parse(dr["personal"].ToString());
                    lista.Add(te);

                }


                return lista;
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




    }
}
