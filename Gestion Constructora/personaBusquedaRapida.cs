using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_Constructora
{
    public partial class personaBusquedaRapida : Form
    {
        public personaBusquedaRapida()
        {
            InitializeComponent();
            personaBusquedaRapida personaBusquedaRapida = this;
            procedures proc = new procedures();
            //                         form                         title           start position            resizable
            proc.initilizeForm(personaBusquedaRapida, "Persona Busqueda Rápida", FormStartPosition.CenterScreen, false);
            proc.initializeGrid(this.dgv_persona);
        }

        private void personaBusquedaRapida_Load(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar(string busqueda = null)
        {
            dgv_persona.Rows.Clear();

            MySqlParameter prmBusqueda = new MySqlParameter("@nombre", MySqlDbType.VarChar);
            MySqlCommand consulta = new MySqlCommand("SELECT id, nombre FROM persona WHERE nombre LIKE @nombre", procedures.conexion);
            consulta.Parameters.AddWithValue("@nombre", "%" + Convert.ToString(busqueda) + "%");
            try
            {
                procedures.conexion.Open();
                MySqlDataReader reader = consulta.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dgv_persona.Rows.Add(reader[0], reader[1]);
                    }
                }
                procedures.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_persona_SelectionChanged(object sender, EventArgs e)
        {
            this.txt_persona.Text = Convert.ToString(this.dgv_persona.CurrentRow.Cells[1].Value);
        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            buscar(this.txt_busqueda.Text.Trim());
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            chequeEmision.idPersona = Convert.ToInt32(this.dgv_persona.CurrentRow.Cells[0].Value);
            chequeEmision.nombrePersona = Convert.ToString(this.dgv_persona.CurrentRow.Cells[1].Value);
            this.Dispose();
        }
    }
}
