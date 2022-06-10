using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAi.Entidades
{
    public class TipoRecursoTecnológico
    {
        public TipoRecursoTecnológico()
            {
            }
        private int _cod_tipoRT;
        private int _numeroRT;
        private string _nombre;
        private string _descripcion;

        public int cod_tipoRT
        {
            get => _cod_tipoRT;
            set => _cod_tipoRT = value;
        }
        public int numeroRT
        {
            get => _numeroRT;
            set => _numeroRT = value;
        }
        public string nombre
        {
            get => _nombre;
            set => _nombre = value;
        }
        public string descripcion
        {
            get => _descripcion;
            set => _descripcion = value;
        }



    }
}
