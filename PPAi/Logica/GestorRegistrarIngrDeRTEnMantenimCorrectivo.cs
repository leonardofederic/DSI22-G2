using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAi.Entidades;

namespace PPAi.Logica
{
    public class GestorRegistrarIngrDeRTEnMantenimCorrectivo
    {
        //public static DataTable tomarRegIngreRTMantenimCorrect()
        //{
        //DataTable grilla = obtenerUsuarioLogueado()
        // return grilla; }


         int UsuarioLoguidado;
        
        public static int obtenerUsuarioLogueado()
        {
            //busca el usuario Logueado, Metodo ubicado en Sesion.
            var emple = Secion.getUsuarioEnSesion(1);
            int i = emple.LegajoCientifi;
            //DataTable grilla = buscarSede(i);
            //return grilla;



            return i;
        }
        public static DateTime tomarFechaYHoraActualSistema()
        {
            DateTime today = DateTime.Today;
            return today;
        }
        

        //public static DataTable buscarEstadoDisponible()
        //{ return; }

        //public static DataTable buscarRTDisponible() leo
        //{ return; }
        //public static DataTable ordenarTipoRT() leo
        //{ return; }
        //public static DataTable tomarRTSelecionado() leo
        //{ return; }
        //public static DataTable tomarFechaPrevistaDatosMant() leo
        //{ return; }
        //public static DataTable tomarMotivoMantenimiento() leo
        //{ return; }


        
        //public static DataTable buscarExistenciaTurno()
        //{ return; }
        //public static DataTable ordenarPorCientifico()
        //{ return; }
        //public static DataTable tomarConfirmacionMantenimiento()
        //{ return; }
        //public static DataTable registrarMantenimetoRT()
        //{ return; }
        //public static DataTable generarNotificacion()
        //{ return; }


    }
}
