using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAi.Entidades
{
    public class Reserva
    {
        public Reserva()
        {

        }
        private int _idReserva;
        private int _estado;
        private string _fechaInicio;
        private string _fechaFin;

        public int idReserva
        {
            get => _idReserva;
            set => _idReserva = value;
        }
        public int estado
        {
            get => _estado;
            set => _estado = value;
        }
        public string fechaInicio
        {
            get => _fechaInicio;
            set => _fechaInicio = value;
        }
        public string fechaFin
        {
            get => _fechaFin;
            set => _fechaFin = value;
        }
        

    }
}
