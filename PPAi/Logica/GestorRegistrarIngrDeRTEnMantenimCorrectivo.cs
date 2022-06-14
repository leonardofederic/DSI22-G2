﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAi.Entidades;

namespace PPAi.Logica
{
    class GestorRegistrarIngrDeRTEnMantenimCorrectivo
    {
        int UsuarioLoguidado;
        RecursoTecnológico elegido;       


        public static int obtenerUsuarioLogueado()
        {
            //busca el usuario Logueado, Metodo ubicado en Sesion.
            var emple = Sesion.getUsuarioEnSesion(1);
            
            int i = emple.LegajoCientifi;
            
            return i;
        }
        public static DateTime tomarFechaYHoraActualSistema()
        {
            DateTime today = DateTime.Today;
            return today;
        }
        //public static DataTable tomarRegIngreRTMantenimCorrect()
        //{ return; }

        //public static DataTable buscarEstadoDisponible()
        //{ return; }

        //public static DataTable buscarRTDisponible()
        //{ return; }
        //public static DataTable ordenarTipoRT()
        //{ return; }
        //public static DataTable tomarRTSelecionado()
        //{ return; }
        //public static DataTable tomarFechaPrevistaDatosMant()
        //{ return; }
        //public static DataTable tomarMotivoMantenimiento()
        //{ return; }
        public void buscarExistenciaTurno()
        {
            List<Estado> estados = null; // cargar lista de estados
            Estado pendienteDeConfirmacion = null;
            Estado confirmado = null;
            foreach(Estado estado in estados)
            {
                if (estado.esAmbitoReserva()){
                    if(estado.esPendienteConfirmacion()) { pendienteDeConfirmacion = estado; }
                    else if (estado.esConfirmado()) { confirmado = estado; }
            }
            elegido.mostrarTurnoReservado(pendienteDeConfirmacion, confirmado);
        }
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
