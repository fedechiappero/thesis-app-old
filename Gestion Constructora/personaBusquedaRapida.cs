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
        public string nombrePersona { get { return nombrePers; } }
        public string idPersona { get { return idPers; } }

        private string idPers;
        private string nombrePers;

        public personaBusquedaRapida()
        {
            InitializeComponent();
            personaBusquedaRapida personaBusquedaRapida = this;
            procedures proc = new procedures();
            //                         form                         title           start position            resizable
            proc.inicializarFormulario(personaBusquedaRapida, "Persona Busqueda Rápida", FormStartPosition.CenterScreen, false);
            proc.inicializarGrid(this.dgv_persona);
        }

        private void personaBusquedaRapida_Load(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void buscar(string busqueda = null)
        {
            this.dgv_persona.Rows.Clear();

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
                        this.dgv_persona.Rows.Add(reader[0], reader[1]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            procedures.conexion.Close();
        }

        private void dgv_persona_SelectionChanged(object sender, EventArgs e)
        {
            this.txt_persona.Text = Convert.ToString(this.dgv_persona.CurrentRow.Cells[1].Value);
            this.nombrePers = this.txt_persona.Text;
            this.idPers = Convert.ToString(this.dgv_persona.CurrentRow.Cells[0].Value);
        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            this.buscar(this.txt_busqueda.Text.Trim());
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.nombrePers = null;
            this.idPers = null;
            this.Dispose();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void personaBusquedaRapida_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.nombrePers = null;
                this.idPers = null;
            }
            
        }
    }
}
