using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAi.Entidades
{
    public class Marca
    {
        public Marca()
        {
        }
        
        
        private int cod_marca;
        private string nombre;


        public int cod_marca1
        {
            get => cod_marca;
            set => cod_marca = value;
        }

        public string nombre1
        {
            get => nombre;
            set => nombre = value;
        }
        
    }
}
