using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PPAi.Logica;
using PPAi.Formularios;
using PPAi.Entidades;


namespace PPAi.Formularios
{
    public partial class Ventana_Secuandario : Form
    {
        //int UsuarioLoguidado;
        public Ventana_Secuandario()
        {
            RecursoTecnológico RT = new RecursoTecnológico();
            InitializeComponent();
            DataTable tabla = new DataTable();
            tabla = RT.RecuperarRT();
            CargarGrilla(tabla);
            txtHora.Text = DateTime.Now.ToString("hh:mm:ss");
            txtFecha.Text = GestorRegistrarIngrDeRTEnMantenimCorrectivo.tomarFechaYHoraActualSistema().ToString("yyyy/MM/dd");
            //UsuarioLoguidado = GestorRegistrarIngrDeRTEnMantenimCorrectivo.obtenerUsuarioLogueado();
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           // cmb_TipoRT.cargarCombo();
        }
        private void CargarGrilla(DataTable tabla)
        {
            grid_RT.Rows.Clear();


            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_RT.Rows.Add();
                grid_RT.Rows[i].Cells[0].Value = tabla.Rows[i]["cod_tipoRT"].ToString();
                grid_RT.Rows[i].Cells[1].Value = tabla.Rows[i]["numeroRT"].ToString();
                grid_RT.Rows[i].Cells[2].Value = tabla.Rows[i]["marca"].ToString();
                grid_RT.Rows[i].Cells[3].Value = tabla.Rows[i]["modelo"].ToString();


            }
        }

        private void grid_RT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_NombreRT.Text = grid_RT.CurrentRow.Cells[0].Value.ToString();
                txt_NumeroRT.Text = grid_RT.CurrentRow.Cells[1].Value.ToString();
                cbx_notificar.SelectedIndex = 0;
                cbx_motivo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Ingrese hasta que fecha vas esta inahilitado y el motivo por favor ", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            int recursoSelec = Convert.ToInt32(txt_NumeroRT.Text);
            DateTime fecha = Convert.ToDateTime(txt_fechaPrevista.Value.ToString());
            string motivo = cbx_motivo.Text;

            MessageBox.Show(recursoSelec.ToString() + " " + fecha.Date.ToString("dd/MM/yyyy") + " " + motivo.ToString());

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc=MessageBox.Show("desea cancelar el registro de Mantenimiento ?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
