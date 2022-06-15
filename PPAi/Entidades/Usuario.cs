using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAi.Entidades;




namespace PPAi.Entidades
{
    public class Usuario
    {
        public string clave { get; set; }
        public string usuario { get; set; }
        public bool habilitado { get; set; }

        public string mostrarUsuario()
        {
            return usuario;
        }
    }
}
