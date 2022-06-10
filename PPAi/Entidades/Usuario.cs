using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PPAi.Entidades
{
    public class Usuario
    {
        public Usuario()
        {

        }

        private int _cod_usuario;
        private string _clave;
        private string _usuario;
        private int _legajoCientifi;
        private bool _habilitado;

        public int legajoCientifi
        {
            get => _legajoCientifi;
            set => _legajoCientifi = value;
        }
        public int cod_usuario
        {
            get => _cod_usuario;
            set => _cod_usuario = value;
        }
        public string clave
        {
            get => _clave;
            set => _clave = value;
        }
        public string usuario
        {
            get => _usuario;
            set => _usuario = value;
        }
        public bool habilitado
        {
            get => _habilitado;
            set => _habilitado = value;
        }




    }
}
