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

using PPAi.Entidades;


namespace PPAi.Formularios
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            RecursoTecnológico RT = new RecursoTecnológico();
            InitializeComponent();
            DataTable tabla = new DataTable();
            tabla = RT.RecuperarRT();
            CargarGrilla(tabla);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
