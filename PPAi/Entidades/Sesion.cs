using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAi.Entidades
{
    public class Sesion
    {
        public Sesion()
        {

        }

        private int idSesion;
        private string fechaInicio;
        private string fechaFin;
        private string horaInicio;
        private string horaFin;
        private int idUsuario;

        public int iDSesion
        {
            get => idSesion;
            set => idSesion = value;
        }

        public int iDUsu
        {
            get => idUsuario;
            set => idUsuario = value;
        }

        public string fechaIni
        {
            get => fechaInicio;
            set => fechaInicio = value;
        }

        public string fechaF
        {
            get => fechaFin;
            set => fechaFin = value;
        }

        public string horaIni
        {
            get => horaInicio;
            set => horaInicio = value;
        }

        public string horaF
        {
            get => horaFin;
            set => horaFin = value;
        }

    }
}
