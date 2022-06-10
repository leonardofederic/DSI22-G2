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

    }
}
