using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAi.Entidades
{
    public class CambioEstadoRT
    {
        public CambioEstadoRT()
        {

        }
        private int _numeroRT;
        private int _idCambEstRT;
        private string _fechaHoraDesde;
        private string _fechaHoraHasta;

        public int numeroRT
        {
            get => _numeroRT;
            set => _numeroRT = value;
        }
        public int idCambEstRT
        {
            get => _idCambEstRT;
            set => _idCambEstRT = value;
        }
        public string fechaHoraDesde
        {
            get => _fechaHoraDesde;
            set => _fechaHoraDesde = value;
        }
        public string fechaHoraHasta
        {
            get => _fechaHoraHasta;
            set => _fechaHoraHasta = value;
        }


    }
}
