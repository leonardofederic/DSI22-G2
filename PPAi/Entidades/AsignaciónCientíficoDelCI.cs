using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAi.Entidades
{
    public class AsignaciónCientíficoDelCI
    {
        public AsignaciónCientíficoDelCI()
        {

        }
        private int _idAsgCienti;
        private int _cod_centro_invest;

        private string _fechaHasta;
        private string _fechaDesde;
        private List<Turno> turnos;
        private PersonalCientífico personalCientífico;

        public int idAsgCienti
        {
            get => _idAsgCienti;
            set => _idAsgCienti = value;
        }
        public int cod_centro_invest
        {
            get => _cod_centro_invest;
            set => _cod_centro_invest = value;
        }
        public string fechaHasta
        {
            get => _fechaHasta;
            set => _fechaHasta = value;
        }
        public string fechaDesde
        {
            get => _fechaDesde;
            set => _fechaDesde = value;
        }
        public bool esTuTurno(Turno turn)
        {
            // si la asignacionCientifico posee el turno enviado como parametro retorna true
            bool respuesta = false;
            foreach(Turno turno in turnos)
            {
                if (turno == turn) { respuesta = true; }
            }
            return respuesta;
        }
        public List<string> mostrarDatosCientifico()
        {
            //retorna una lista con los datos minimos del personal cientifico asocioado a esta asignacionCientifico
            return personalCientífico.mostrarDatos();
        }
    }
}
