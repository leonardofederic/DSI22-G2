using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAi.Entidades
{
    public class AsignacionResponsableTecnicoRT
    {
        public string fechaHasta { get; set; }
        public string fechaDesde { get; set; }
        public int numeroRT { get; set; }
        public int personal { get; set; }
        public PersonalCientífico personalCientifico { get; set; }
        public RecursoTecnológico recursos { get; set; }
    }
}
