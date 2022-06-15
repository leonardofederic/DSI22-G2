﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAi.Entidades
{
    public class AsignaciónCientíficoDelCI
    {
        public string fechaHasta { get; set; }
        public string fechaDesde { get; set; }
        public Turno turno { get; set; }
        public PersonalCientífico personalCientifico { get; set; }
    }
}
