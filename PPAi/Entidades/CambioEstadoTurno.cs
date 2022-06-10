using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAi.Entidades
{
    public class CambioEstadoTurno
    {
        public CambioEstadoTurno()
        {

        }
        private int _cod_turno;
        private int _idCambEsTurno;
        private string _fechaHoraDesde;
        private string _fechaHoraHasta;

        public int cod_turno
        {
            get => _cod_turno;
            set => _cod_turno = value;
        }
        public int idCambEsTurno
        {
            get => _idCambEsTurno;
            set => _idCambEsTurno = value;
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
