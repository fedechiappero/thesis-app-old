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
    public partial class localidadBusquedaRapida : Form
    {
        public string nombreProvincia { get { return nombreProv; } }
        public string idProvincia { get { return idProv; } }

        private string idProv;
        private string nombreProv;

        public string nombreLocalidad { get { return nombreLoca; } }
        public string idLocalidad { get { return idLoca; } }

        private string idLoca;
        private string nombreLoca;

        public localidadBusquedaRapida()
        {
            InitializeComponent();
            localidadBusquedaRapida localidadBusquedaRapida = this;
            procedures proc = new procedures();
            //                              form                         title                  start position            resizable
            proc.inicializarFormulario(localidadBusquedaRapida, "Localidad Busqueda Rápida", FormStartPosition.CenterScreen, false);
            proc.inicializarGrid(this.dgv_localidad);
        }

        private void localidadBusquedaRapida_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'provinciaDataSet.provincia' Puede moverla o quitarla según sea necesario.
            this.provinciaTableAdapter.Fill(this.provinciaDataSet.provincia);
        }

        private void cbo_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txt_provincia.Text = this.cbo_provincia.Text;
            this.nombreProv = this.txt_provincia.Text;
            this.idProv = Convert.ToString(this.cbo_provincia.SelectedValue);
            //next condition is very hacky, dunno why when form is disposed, combobox index changes...
            //and i get error when trying to convert.toint32 because idProv is already empty
            if (this.idProv != "")
            {
                this.buscarLocalidad(Convert.ToInt32(this.idProv));
                this.txt_busquedaLocalidad.Focus();
            }
            
        }

        private void buscarLocalidad(int idProvincia, string busqueda = null)
        {
            this.dgv_localidad.Rows.Clear();

            MySqlParameter prmIdProvincia = new MySqlParameter("@idProvincia", MySqlDbType.Int32);
            prmIdProvincia.Value = Convert.ToInt32(idProvincia);
            MySqlCommand consulta = new MySqlCommand("SELECT * FROM localidad WHERE idProvincia = @idProvincia AND nombre LIKE @nombre", procedures.conexion);
            consulta.Parameters.Add(prmIdProvincia);
            consulta.Parameters.AddWithValue("@nombre", "%" + Convert.ToString(busqueda) + "%");
            try
            {
                procedures.conexion.Open();
                MySqlDataReader reader = consulta.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.dgv_localidad.Rows.Add(reader[0], reader[1], reader[2], reader[3]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            procedures.conexion.Close();
        }

        private void txt_busquedaLocalidad_TextChanged(object sender, EventArgs e)
        {
            this.buscarLocalidad(Convert.ToInt32(this.idProv), this.txt_busquedaLocalidad.Text);
        }

        private void dgv_localidad_SelectionChanged(object sender, EventArgs e)
        {
            this.txt_localidad.Text = Convert.ToString(this.dgv_localidad.CurrentRow.Cells[2].Value);
            this.nombreLoca = this.txt_localidad.Text;
            this.idLoca = Convert.ToString(this.dgv_localidad.CurrentRow.Cells[0].Value);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.idProv = null;
            this.nombreProv = null;
            this.idLoca = null;
            this.nombreLoca = null;
            this.Dispose();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void localidadBusquedaRapida_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.cbo_provincia.SelectedIndexChanged -= cbo_provincia_SelectedIndexChanged;
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.idProv = null;
                this.nombreProv = null;
                this.idLoca = null;
                this.nombreLoca = null;
            }
        }
    }
}
