using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAi.Entidades
{
    public class PersonalCientífico
    {
        public string correoElectronicoInstitucional { get; set; }
        public string correoElectronicoPersonal { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int numeroDocumento { get; set; }
        public int legajo { get; set; }
        public int telefonoCelular { get; set; }
        public Usuario usuario { get; set; }

        public bool mostrarDatosCientifico(string nombreUsuario)
        {
            usuario = new Usuario();
            if (usuario.usuario == nombreUsuario)
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
