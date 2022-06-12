using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace prueba1.Clases
{
     class ComboBox01 : ComboBox
    {
        public string Pp_Pk { get; set; }
        public string Pp_descripcion { get; set; }
        public string Pp_tabla { get; set; }
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
        public void cargarCombo()
        {
            string sql = "select " + Pp_Pk + "," + Pp_descripcion + " from " + Pp_tabla;
            DataTable table = new DataTable();
            table = _BD.Ejecutar_Select(sql);
            this.DisplayMember = Pp_descripcion;
            this.ValueMember = Pp_Pk;
            this.DataSource = table;

        }
    }
    
    
}
