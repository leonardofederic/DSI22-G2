using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PPAi.Entidades;


namespace PPAi.Entidades
{
    public class RecursoTecnológico
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public RecursoTecnológico()
        {

        }
        private byte _imgen;
        private string fechaAlta;
        private string fracicionHoraTurno;
        private int cod_centro_invest;
        private int idAsiRepRT;
        private int numeroRT;
        private int periodicidadMant;
        private int duracionMant;

        public byte imgen
        {
            get => _imgen;
            set => _imgen = value;
        }
        public string fechaAlta1
        {
            get => fechaAlta;
            set => fechaAlta = value;
        }
        public string fracicionHoraTurno1
        {
            get => fracicionHoraTurno;
            set => fracicionHoraTurno = value;
        }
        public int cod_centro_invest1
        {
            get => cod_centro_invest;
            set => cod_centro_invest = value;
        }
        public int idAsiRepRT1
        {
            get => idAsiRepRT;
            set => idAsiRepRT = value;
        }
        public int numeroRT1
        {
            get => numeroRT;
            set => numeroRT = value;
        }
        public int periodicidadMant1
        {
            get => periodicidadMant;
            set => periodicidadMant = value;
        }
        public int duracionMant1
        {
            get => duracionMant;
            set => duracionMant = value;
        }
        public DataTable RecuperarRT()
        {
            string sql = "select t.nombre as cod_tipoRT, r.numeroRT, p.nombre as marca, q.nombre as modelo from RecursoTecnologico r,Marca p, Modelo q, TipoRecursoTecnologico t WHERE r.modelo = q.cod_modelo and p.cod_marca = r.marca and t.cod_tipoRT = r.cod_tipoRT Order BY  t.nombre";
            //BE_Acceso_Datos _BD = new BE_Acceso_Datos();
            return _BD.Ejecutar_Select(sql);
            
        }
        
    }
}
