using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAi.Entidades
{
    public class Mantenimiento
    {
        public Mantenimiento()
        {

        }
        private string fechaFin;
        private string fechaInicio;
        private string fechaInicioPrevista;
        private string motivoMante;
        private int cod_manten;
        private int numeroRT;
        public int cod_manten1
        {
            get => cod_manten;
            set => cod_manten = value;
        }
        public int numeroRT1
        {
            get => numeroRT;
            set => numeroRT = value;
        }
        public string fechaFin1
        {
            get => fechaFin;
            set => fechaFin = value;
        }
        public string fechaInicio1
        {
            get => fechaInicio;
            set => fechaInicio = value;
        }
        public string fechaInicioPrevista1
        {
            get => fechaInicioPrevista;
            set => fechaInicioPrevista = value;
        }
        public string motivoMante1
        {
            get => motivoMante;
            set => motivoMante = value;
        }



    }
}
