using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAi.Entidades
{
    public class Turno
    {
        public Turno()
        {

        }
        private int idAsgCienti;
        private int numeroRT;
        private int cod_turno;
       
        private string fechaGenera;
        private string diaSemana;
        private string fechaHoraInicio;
        private string fechaHoraFin;
        private Reserva reserva;

        public int idAsgCienti1
        {
            get => idAsgCienti;
            set => idAsgCienti = value;
        }
        public int numeroRT1
        {
            get => numeroRT;
            set => numeroRT = value;
        }
        public int cod_turno1
        {
            get => cod_turno;
            set => cod_turno = value;
        }
        public string fechaGenera1
        {
            get => fechaGenera;
            set => fechaGenera = value;
        }
        public string diaSemana1
        {
            get => diaSemana;
            set => diaSemana = value;
        }
        public string fechaHoraInicio1
        {
            get => fechaHoraInicio;
            set => fechaHoraInicio = value;
        }
        public string fechaHoraFin1
        {
            get => fechaHoraFin;
            set => fechaHoraFin = value;
        }
        public List<string> mostarReserva(Estado pendienteDeConfirmacion, Estado confirmado, List<AsignaciónCientíficoDelCI> asignacionesCientificos)
        {
            //si el estado de la reserva asociada al turno es confirmado o pendiente de confirmacion retorna los datos del turno y del personal cientifico
            List<string> datos = null;
            if (reserva.esConfirmado(confirmado) || reserva.esPendienteDeConfirmacion(pendienteDeConfirmacion))
            {
                datos.Add(cod_turno.ToString()); //numero de turno
                datos.Add(reserva.mostrarReserva()); //fecha y hora reserva
                
                //busca la asignacion que tenga asocioado este turno entre las asgnaciones que llegaron como parametro y agrega a la cadena los datos del personal cientifico
                foreach(AsignaciónCientíficoDelCI asignacion in asignacionesCientificos)
                {
                    if (asignacion.esTuTurno(this))
                    {
                        datos.Add(asignacion.mostrarDatosCientifico()); //nombre y apellido cientifico
                    }
                }
                return datos;
            }
            return datos;
    }
    }
}
