using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAi.Entidades
{
    public class Modelo
    {
        private int _cod_modelo;
        private int _numeroRT;
        private int _cod_marca;
        private string _nombre;

        public Modelo ()
        {
            
        }
        public int cod_modelo
        {
            get => _cod_modelo;
            set => _cod_modelo = value;
        }
        public int numeroRT
        {
            get => _numeroRT;
            set => _numeroRT = value;
        }
        public int cod_marca
        {
            get => _cod_marca;
            set => _cod_marca = value;
        }
        public string nombre
        {
            get => _nombre;
            set => _nombre = value;
        }
        


    }
}
