using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAi.Entidades
{
    public class PersonalCientífico
    {
       public PersonalCientífico()
        {
           
        }
        private string correo_institucional;
        private string correo_personal;
        private string nombre;
        private string apellido;
        private int num_docu;
        private int legajo;
        private int telef;
        private int cod_facultad;
        private int idAsiRepRT;
        private int idAsiDirect;
        private int idAsgCienti;

        public string Correo_institucional
        {
            get => correo_institucional;
            set => correo_institucional = value;
        }
        public string Correo_personal
        {
            get => correo_personal;
            set => correo_personal = value;
        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }
        public int Num_docu
        {
            get => num_docu;
            set => num_docu = value;
        }
        public int Legajo
        {
            get => legajo;
            set => legajo = value;
        }
        public int Telef
        {
            get => telef;
            set => telef = value;
        }
        public int Cod_facultad
        {
            get => cod_facultad;
            set => cod_facultad = value;
        }
        public int IdAsiRepRT
        {
            get => idAsiRepRT;
            set => idAsiRepRT = value;
        }
        public int IdAsiDirect
        {
            get => idAsiDirect;
            set => idAsiDirect = value;
        }
        public int IdAsgCienti
        {
            get => idAsgCienti;
            set => idAsgCienti = value;
        }
        public List<string> mostrarDatos()
        {
            //retorna una lista con los datos minimos del personal cientifico
            List<string> datos = new List<string>();
            datos.Add(Nombre);
            datos.Add(apellido);
            datos.Add(legajo.ToString());

            return datos;
        }
    }
}
