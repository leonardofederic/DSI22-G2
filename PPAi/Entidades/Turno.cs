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
        
    }
}
