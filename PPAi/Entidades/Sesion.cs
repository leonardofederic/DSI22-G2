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
        public string fechaInicio { get; set; }
        public string fechaFin { get; set; }
        public string horaInicio { get; set; }
        public string horaFin { get; set; }
        public Usuario usuario { get; set; }

        public string mostrarUsurioActual()
        {
            return usuario.mostrarUsuario();
        }
    }
}
