using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAi.Entidades
{
    public class Estado
    {
        public Estado()
        {

        }
        private string nombre;
        private string descripcion;
        private string ambito;
        private bool esReservable;
        private bool esCancelable;
        private int idCambEsTurno;
        private int cod_estado;
        private int idCambEstRT;

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
        public string Ambito
        {
            get => ambito;
            set => ambito = value;
        }
        public bool EsReservable
        {
            get => esReservable;
            set => esReservable = value;
        }
        public bool EsCancelable
        {
            get => esCancelable;
            set => esCancelable = value;
        }
        public int IdCambEsTurno
        {
            get => idCambEsTurno;
            set => idCambEsTurno = value;
        }
        public int Cod_estado
        {
            get => cod_estado;
            set => cod_estado = value;
        }
        public int IdCambEstRT
        {
            get => idCambEstRT;
            set => idCambEstRT = value;
        }

    }
}
