using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAi.Entidades;
using PPAi.Formularios;

namespace PPAi.Logica
{
    class GestorRegistrarIngrDeRTEnMantenimCorrectivo
    {
        int UsuarioLoguidado;
        RecursoTecnológico elegido;


        //public static int obtenerUsuarioLogueado() { }
        public static DataTable tomarRegIngreRTMantenimCorrect()
        {
            DataTable grilla = obtenerUsuarioLogueado();
            return grilla;
        }

        
        public static DataTable buscarEstadoDisponible(int responsable)
        {
            //Estado es = new Estado();
            var es = Estado.esDisponible();
            DataTable grilla = obtener();
            return grilla;
        }
        public static DataTable buscarRTDisponible(int rtbuscar)
        {
            DataTable grilla = obtenerDisponibible(rtbuscar);
            return grilla;
        }
        public static DataTable ordenarTipoRT()
        {
            DataTable grilla = ordenarTipRT();
            return grilla;
        }
        public static int tomarRTSelecionado(int confirmacion)
        {
            int devuelve = Class1.cargarGrilla(confirmacion);
            return devuelve;
        }
        public static string tomarFechaPrevistaDatosMant(string fecha) 
        {
            return fecha;
        }
        public static string tomarMotivoMantenimiento(string motiv)
        {
            return motiv;
        }
        public static DataTable obtenerUsuarioLogueado()
        {
        // busca el usuario Logueado, Metodo ubicado en Sesion.
        var emple = Secion.getUsuarioEnSesion(1);
        int i = emple.LegajoCientifi;
        DataTable grilla = buscarEstadoDisponible(i);
        return grilla;
         }
        public static DateTime tomarFechaYHoraActualSistema()
        {
        DateTime today = DateTime.Today;
        return today;
        }





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








        public static DataTable obtener()
        {
            int id = 1;
            try
            {
                DataTable grilla = Class1.mostrarMontosVigentes(id);
                return grilla;
            }
            catch
            {
                throw;
            }
        }
        public static DataTable obtenerDisponibible(int id)
        {
            id = 1;
            try
            {
                DataTable grilla = Class1.mostrarMontosVigentes(id);
                return grilla;
            }
            catch
            {
                throw;
            }
        }
        public static DataTable ordenarTipRT()
        {
            int id = 1;
            try
            {
                DataTable grilla = Class1.mostrarMontosVigentes(id);
                return grilla;
            }
            catch
            {
                throw;
            }
        }
        public static DataTable buscarRTSelecionada(int id)
        {
            id = 1;
            try
            {
                DataTable grilla = Class1.mostrarMontosVigentes(id);
                return grilla;
            }
            catch
            {
                throw;
            }
        }


    } 
}
