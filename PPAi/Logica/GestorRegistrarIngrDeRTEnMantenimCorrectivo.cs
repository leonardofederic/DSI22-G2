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
        public Sesion sesion;
        public Usuario usuario;

        public PersonalCientífico[] personalCientifico;
        public PersonalCientífico personalLogueado;

        public Estado[] estados;
        public Estado estadoDisponible;

        public AsignacionResponsableTecnicoRT[] asignaciones;

        public RecursoTecnológico[] recursos;



        public string usuarioLogueado;

        public void cargarObjetos()
        {
            sesion = new Sesion();
            usuario = new Usuario();

            sesion.fechaInicio = "13/06/2022";
            sesion.fechaFin = null;
            sesion.horaInicio = "20:00";
            sesion.horaFin = null;
            sesion.usuario = usuario;

            usuario.usuario = "TomiG";
            usuario.habilitado = true;
            usuario.clave = "12345";

            // creacion del array de cientificos 
            personalCientifico[0] = new PersonalCientífico();
            personalCientifico[0].nombre = "Tomas";
            personalCientifico[0].usuario = new Usuario();
            personalCientifico[0].usuario.usuario = "TomiG";

            personalCientifico[1] = new PersonalCientífico();
            personalCientifico[1].nombre = "Matias";
            personalCientifico[1].usuario = new Usuario();
            personalCientifico[1].usuario.usuario = "MatiC";

            // creacion del array de estados
            estados[0] = new Estado();
            estados[0].nombre = "Disponible";
            estados[0].ambito = "Recurso Tecnologico";

            // creacion del array de asignaciones
            asignaciones[0] = new AsignacionResponsableTecnicoRT();
            asignaciones[0].fechaDesde = "14/06/2022";
            asignaciones[0].fechaHasta = "16/06/2022";
            asignaciones[0].personalCientifico = new PersonalCientífico();
            asignaciones[0].personalCientifico = personalCientifico[0];
            asignaciones[0].recursos = new RecursoTecnológico();
        }

        public void tomarRegIngreRTMantenimCorrect()
        {
            cargarObjetos();
            obtenerUsuarioLogueado(); //PATRÓN CONTROLADOR
        }

        public void obtenerUsuarioLogueado()
        {
            usuarioLogueado = sesion.mostrarUsurioActual();

            for (int i = 0; i < personalCientifico.Length; i++)
            {
                if (personalCientifico[i].mostrarDatosCientifico(usuarioLogueado)) 
                {
                    personalLogueado = personalCientifico[i];
                }
            }
        }

        public void buscarEstadoDisponible()
        {
            for (int i = 0; i < estados.Length; i++)
            {
                if (estados[i].esAmbitoRT() && estados[i].esDisponible())
                {
                    estadoDisponible = new Estado();
                    estadoDisponible = estados[i];
                }
            }
        }

        public static DateTime tomarFechaYHoraActualSistema()
        {
            DateTime fechaActual = DateTime.Today;
            return fechaActual;
        }

        public void buscarRTDisponible()
        {
            
        }
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
