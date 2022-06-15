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
            List<AsignaciónCientíficoDelCI> asignacionesCientificos = null; // cargar lista de asignaciones de cientificos

            List<Estado> estados = null; // cargar lista de estados
            Estado pendienteDeConfirmacion = null; // estado recuperado de la lista de estados
            Estado confirmado = null; // estado recuperado de la lista de estados

            foreach (Estado estado in estados) // obtenemos los 2 estados necesarios
            {
                if (estado.esAmbitoReserva())
                {
                    if (estado.esPendienteConfirmacion()) { pendienteDeConfirmacion = estado; }
                    else if (estado.esConfirmado()) { confirmado = estado; }
                }
            }

            List<List<string>> datos = null; //lista compuesta de mas listas que tienen [numero de reserva, nombre y apellido del cientifico, fecha y hora de la reserva]
            datos = elegido.mostrarTurnoReservado(pendienteDeConfirmacion, confirmado, asignacionesCientificos); // obtenemos los datos de los turnos

            datos = ordenarPorCientifico(datos);

            DataTable tabla = new DataTable();
            tabla.Columns.Add("NroTurno");
            tabla.Columns.Add("Cientifico");
            tabla.Columns.Add("FechaHoraReserva");

            foreach (List<string> lista in datos) // obtenemos los 2 estados necesarios
            {
                DataRow fila = tabla.NewRow();
                fila["NroTurno"] = lista[0];
                fila["Cientifico"] = lista[1];
                fila["FechaHoraReserva"] = lista[2];

                tabla.Rows.Add(fila);
            }
            //Form3.mostrarDatosTurnoReservado(tabla);
        }
        public static List<List<string>> ordenarPorCientifico(List<List<string>> datos)
        { return datos; }
        //public static DataTable tomarConfirmacionMantenimiento()
        //{ return; }
        //public static DataTable registrarMantenimetoRT()
        //{ return; }
        //public static DataTable generarNotificacion()
        //{ return; }
    }
}
