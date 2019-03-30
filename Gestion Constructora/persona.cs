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
    public partial class persona : Form
    {
        //para saber en que estado se encuentran los controles del formulario (0=inicio, 1=nuevo, 2=editar, 3=eliminar)
        private int estadoControles = 0;

        private int idLocal;
        private string nombreLocalidad;

        public persona()
        {
            InitializeComponent();
            persona persona = this;
            procedures proc = new procedures();
            //                               form                 title         start position              resizable
            proc.inicializarFormulario(persona, "ABM de Cheques de Personas", FormStartPosition.CenterScreen, false);
            proc.inicializarGrid(this.dgv_persona);
        }

        private void persona_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'documentoTipoDataSet.documentotipo' Puede moverla o quitarla según sea necesario.
            this.documentotipoTableAdapter.Fill(this.documentoTipoDataSet.documentotipo);
            this.buscar();
        }

        private void btn_busquedaLocalidad_Click(object sender, EventArgs e)
        {
            localidadBusquedaRapida localidadBusquedaRapida = new localidadBusquedaRapida();
            localidadBusquedaRapida.FormClosing += new FormClosingEventHandler(busquedaLocalidadCerrando);
            localidadBusquedaRapida.ShowDialog();
        }

        private void busquedaLocalidadCerrando(object sender, FormClosingEventArgs e)
        {
            this.idLocal = Convert.ToInt32(((localidadBusquedaRapida)sender).idLocalidad);
            this.nombreLocalidad = ((localidadBusquedaRapida)sender).nombreLocalidad;
            this.txt_localidad.Text = this.nombreLocalidad;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            this.cambiarControles(1);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (this.dgv_persona.SelectedRows.Count > 0)
            {
                this.cargarControles(this.dgv_persona);
                this.cambiarControles(2);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una persona para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (this.dgv_persona.SelectedRows.Count > 0)
            {
                this.cambiarControles(3);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una persona para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cambiarControles(int estado)
        {
            switch (estado)
            {
                case 0://inicio
                    this.buscar();
                    this.pnl_busqueda.Enabled = true;
                    this.dgv_persona.Enabled = true;
                    this.pnl_datos.Enabled = false;
                    this.cbo_documentoTipo.SelectedItem = "DNI";
                    this.btn_aceptar.ForeColor = Color.Black;
                    this.btn_nuevo.Enabled = true;
                    this.btn_editar.Enabled = true;
                    this.btn_eliminar.Enabled = true;
                    break;
                case 1://nuevo
                    this.pnl_busqueda.Enabled = false;
                    this.dgv_persona.Enabled = false;
                    this.pnl_datos.Enabled = true;
                    this.txt_nombre.Text = String.Empty;
                    this.txt_cuit.Text = String.Empty;
                    this.chk_juridica.Checked = false;
                    this.txt_celular.Text = String.Empty;
                    this.txt_email.Text = String.Empty;
                    this.txt_dni.Text = String.Empty;
                    this.cbo_documentoTipo.SelectedItem = "DNI";
                    this.txt_localidad.Text = String.Empty;
                    this.idLocal = 0;
                    this.txt_direccion.Text = String.Empty;
                    this.txt_nombre.Focus();
                    this.btn_nuevo.Enabled = false;
                    this.btn_editar.Enabled = false;
                    this.btn_eliminar.Enabled = false;
                    break;
                case 2://editar
                    this.pnl_datos.Enabled = true;
                    this.txt_nombre.Focus();
                    this.btn_nuevo.Enabled = false;
                    this.btn_editar.Enabled = false;
                    this.btn_eliminar.Enabled = false;
                    break;
                case 3://eliminar
                    this.btn_aceptar.ForeColor = Color.Red;
                    this.btn_nuevo.Enabled = false;
                    this.btn_editar.Enabled = false;
                    this.btn_eliminar.Enabled = false;
                    break;
                default:
                    //something went wrong
                    break;
            }
            estadoControles = estado;
        }

        private void cargarControles(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                this.txt_nombre.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                this.txt_cuit.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                this.chk_juridica.Checked = Convert.ToBoolean(dgv.CurrentRow.Cells[3].Value);
                this.txt_celular.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
                this.txt_email.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
                this.txt_dni.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
                this.cbo_documentoTipo.SelectedValue = Convert.ToInt32(dgv.CurrentRow.Cells[6].Value);
                this.txt_localidad.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
                this.idLocal = Convert.ToInt32(dgv.CurrentRow.Cells[8].Value);
                this.txt_direccion.Text = Convert.ToString(dgv.CurrentRow.Cells[10].Value);
            }
            else
            {
                this.txt_nombre.Text = String.Empty;
                this.txt_cuit.Text = String.Empty;
                this.chk_juridica.Checked = false;
                this.txt_celular.Text = String.Empty;
                this.txt_email.Text = String.Empty;
                this.txt_dni.Text = String.Empty;
                this.cbo_documentoTipo.SelectedIndex = 0;
                this.txt_localidad.Text = String.Empty;
                this.idLocal = 0;
                this.txt_direccion.Text = String.Empty;
            }
        }

        private void dgv_persona_SelectionChanged(object sender, EventArgs e)
        {
            this.cargarControles(this.dgv_persona);
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            switch (estadoControles)
            {
                case 1:
                    this.insertar(this.txt_nombre.Text, this.txt_cuit.Text, Convert.ToInt16(this.chk_juridica.Checked), this.txt_celular.Text, this.txt_dni.Text, Convert.ToInt16(this.cbo_documentoTipo.SelectedValue), this.txt_email.Text, this.idLocal, this.txt_direccion.Text);
                    break;
                case 2:
                    this.actualizar(Convert.ToInt32(this.dgv_persona.CurrentRow.Cells[0].Value), this.txt_nombre.Text, this.txt_cuit.Text, Convert.ToInt16(this.chk_juridica.Checked), this.txt_celular.Text, this.txt_dni.Text, Convert.ToInt16(this.cbo_documentoTipo.SelectedValue), this.txt_email.Text, this.idLocal, this.txt_direccion.Text);
                    break;
                case 3:
                    this.eliminar(Convert.ToInt32(this.dgv_persona.CurrentRow.Cells[0].Value));
                    break;
                default:
                    //something went wrong
                    break;
            }
            this.cambiarControles(0);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (estadoControles != 0)
            {
                this.cambiarControles(0);
            }
            else
            {
                this.Dispose();
            }
        }

        private void buscar(string busqueda = null)
        {
            this.dgv_persona.Rows.Clear();

            string query = "SELECT * FROM persona INNER JOIN localidad ON (persona.idLocalidad = localidad.id) WHERE persona.nombre LIKE @nombre AND activo = 1";

            MySqlCommand consulta = new MySqlCommand(query, procedures.conexion);
            consulta.Parameters.AddWithValue("@nombre", Convert.ToString(busqueda) + "%");
            try
            {
                procedures.conexion.Open();
                MySqlDataReader reader = consulta.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.dgv_persona.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7], reader[8], reader[13], reader[9]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            procedures.conexion.Close();
        }

        private void insertar(string nombre, string cuit, int juridica, string celular, string dni, int documentoTipo, string email, int idLocalidad, string direccion)
        {
            MySqlParameter prmNombre = new MySqlParameter("@nombre", MySqlDbType.VarChar);
            MySqlParameter prmCuit = new MySqlParameter("@cuit", MySqlDbType.VarChar);
            MySqlParameter prmJuridica = new MySqlParameter("@juridica", MySqlDbType.Int16);
            MySqlParameter prmCelular = new MySqlParameter("@celular", MySqlDbType.VarChar);
            MySqlParameter prmDni = new MySqlParameter("@dni", MySqlDbType.VarChar);
            MySqlParameter prmIdDocumentoTipo = new MySqlParameter("@idDocumentoTipo", MySqlDbType.Int32);
            MySqlParameter prmEmail = new MySqlParameter("@email", MySqlDbType.VarChar);
            MySqlParameter prmIdLocalidad = new MySqlParameter("@idLocalidad", MySqlDbType.Int32);
            MySqlParameter prmDireccion = new MySqlParameter("@direccion", MySqlDbType.VarChar);
            prmNombre.Value = Convert.ToString(nombre);
            prmCuit.Value = Convert.ToString(cuit);
            prmJuridica.Value = Convert.ToInt16(juridica);
            prmCelular.Value = Convert.ToString(celular);
            prmDni.Value = Convert.ToString(dni);
            prmIdDocumentoTipo.Value = Convert.ToInt16(documentoTipo);
            prmEmail.Value = Convert.ToString(email);
            prmIdLocalidad.Value = Convert.ToInt32(idLocalidad);
            prmDireccion.Value = Convert.ToString(direccion);
            MySqlCommand mycmd = new MySqlCommand("INSERT INTO persona (nombre, cuit, juridica, celular, dni, idDocumentoTipo, email, idLocalidad, direccion) VALUES (@nombre, @cuit, @juridica, @celular, @dni, @idDocumentoTipo, @email, @idLocalidad, @direccion)", procedures.conexion);
            mycmd.Parameters.Add(prmNombre);
            mycmd.Parameters.Add(prmCuit);
            mycmd.Parameters.Add(prmJuridica);
            mycmd.Parameters.Add(prmCelular);
            mycmd.Parameters.Add(prmDni);
            mycmd.Parameters.Add(prmIdDocumentoTipo);
            mycmd.Parameters.Add(prmEmail);
            mycmd.Parameters.Add(prmIdLocalidad);
            mycmd.Parameters.Add(prmDireccion);
            try
            {
                procedures.conexion.Open();
                mycmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            procedures.conexion.Close();
        }

        private void actualizar(int id, string nombre, string cuit, int juridica, string celular, string dni, int documentoTipo, string email, int idLocalidad, string direccion)
        {
            MySqlParameter prmId = new MySqlParameter("@id", MySqlDbType.Int32);
            MySqlParameter prmNombre = new MySqlParameter("@nombre", MySqlDbType.VarChar);
            MySqlParameter prmCuit = new MySqlParameter("@cuit", MySqlDbType.VarChar);
            MySqlParameter prmJuridica = new MySqlParameter("@juridica", MySqlDbType.Int16);
            MySqlParameter prmCelular = new MySqlParameter("@celular", MySqlDbType.VarChar);
            MySqlParameter prmDni = new MySqlParameter("@dni", MySqlDbType.VarChar);
            MySqlParameter prmIdDocumentoTipo = new MySqlParameter("@idDocumentoTipo", MySqlDbType.Int32);
            MySqlParameter prmEmail = new MySqlParameter("@email", MySqlDbType.VarChar);
            MySqlParameter prmIdLocalidad = new MySqlParameter("@idLocalidad", MySqlDbType.Int32);
            MySqlParameter prmDireccion = new MySqlParameter("@direccion", MySqlDbType.VarChar);
            prmId.Value = Convert.ToInt32(id);
            prmNombre.Value = Convert.ToString(nombre);
            prmCuit.Value = Convert.ToString(cuit);
            prmJuridica.Value = Convert.ToInt16(juridica);
            prmCelular.Value = Convert.ToString(celular);
            prmDni.Value = Convert.ToString(dni);
            prmIdDocumentoTipo.Value = Convert.ToInt16(documentoTipo);
            prmEmail.Value = Convert.ToString(email);
            prmIdLocalidad.Value = Convert.ToInt32(idLocalidad);
            prmDireccion.Value = Convert.ToString(direccion);
            MySqlCommand mycmd = new MySqlCommand("UPDATE persona SET nombre = @nombre, cuit = @cuit, juridica = @juridica, celular = @celular, dni = @dni, idDocumentoTipo = @idDocumentoTipo, email = @email, idLocalidad = @idLocalidad, direccion = @direccion WHERE id = @id", procedures.conexion);
            mycmd.Parameters.Add(prmId);
            mycmd.Parameters.Add(prmNombre);
            mycmd.Parameters.Add(prmCuit);
            mycmd.Parameters.Add(prmJuridica);
            mycmd.Parameters.Add(prmCelular);
            mycmd.Parameters.Add(prmDni);
            mycmd.Parameters.Add(prmIdDocumentoTipo);
            mycmd.Parameters.Add(prmEmail);
            mycmd.Parameters.Add(prmIdLocalidad);
            mycmd.Parameters.Add(prmDireccion);
            try
            {
                procedures.conexion.Open();
                mycmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            procedures.conexion.Close();
        }

        private void eliminar(int id)
        {
            MySqlParameter prmId = new MySqlParameter("@id", MySqlDbType.Int32);
            prmId.Value = Convert.ToInt32(id);
            MySqlCommand mycmd = new MySqlCommand("UPDATE persona SET activo = 0 WHERE id = @id", procedures.conexion);
            mycmd.Parameters.Add(prmId);
            try
            {
                procedures.conexion.Open();
                mycmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            procedures.conexion.Close();
        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            this.buscar(this.txt_busqueda.Text.Trim());
        }
    }
}
