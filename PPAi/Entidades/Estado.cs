using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAi.Entidades
{
    public class Estado
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string ambito { get; set; }
        public bool esReservable { get; set; }
        public bool esCancelable { get; set; }

        public bool esAmbitoRT()
        {
            if (ambito == "Recurso Tecnologico")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool esDisponible()
        {
            if (nombre == "Disponible")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
