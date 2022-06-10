using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAi.Entidades
{
    public class RecursoTecnológico
    {
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
        
    }
}
