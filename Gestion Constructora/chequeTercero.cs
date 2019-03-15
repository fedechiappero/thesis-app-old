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
    public partial class chequeTercero : Form
    {
        //para saber en que estado se encuentran los controles del formulario (0=inicio, 1=nuevo, 2=editar, 3=eliminar)
        private int estadoControles = 0;

        private int idPerson;
        private string nombrePersona;
        private int idLocal;
        private string nombreLocalidad;

        public chequeTercero()
        {
            InitializeComponent();
            chequeTercero chequeTercero = this;
            procedures proc = new procedures();
            //                               form                 title                start position              resizable
            proc.inicializarFormulario(chequeTercero, "ABM de Cheques de Terceros", FormStartPosition.CenterScreen, false);
            proc.inicializarGrid(this.dgv_cheque);
        }
        
        private void chequeTercero_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'chequeTerceroDestinoDataSet.chequetercerodestino' Puede moverla o quitarla según sea necesario.
            this.chequetercerodestinoTableAdapter.Fill(this.chequeTerceroDestinoDataSet.chequetercerodestino);
            // TODO: esta línea de código carga datos en la tabla 'chequeTerceroTipoDataSet.chequetercerotipo' Puede moverla o quitarla según sea necesario.
            this.chequetercerotipoTableAdapter.Fill(this.chequeTerceroTipoDataSet.chequetercerotipo);
            // TODO: esta línea de código carga datos en la tabla 'bancoDataSet.banco' Puede moverla o quitarla según sea necesario.
            this.bancoTableAdapter.Fill(this.bancoDataSet.banco);
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
        

        private void btn_busquedaPersona_Click(object sender, EventArgs e)
        {
            personaBusquedaRapida personaBusquedaRapida = new personaBusquedaRapida();
            personaBusquedaRapida.FormClosing += new FormClosingEventHandler(busquedaPersonaCerrando);
            personaBusquedaRapida.ShowDialog();
        }

        private void busquedaPersonaCerrando(object sender, FormClosingEventArgs e)
        {
            this.idPerson = Convert.ToInt32(((personaBusquedaRapida)sender).idPersona);
            this.nombrePersona = ((personaBusquedaRapida)sender).nombrePersona;
            this.txt_persona.Text = this.nombrePersona;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            this.cambiarControles(1);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (this.dgv_cheque.SelectedRows.Count > 0)
            {
                this.cargarControles(this.dgv_cheque);
                this.cambiarControles(2);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cheque para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (this.dgv_cheque.SelectedRows.Count > 0)
            {
                this.cambiarControles(3);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cheque para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void cambiarControles(int estado)
        {
            switch (estado)
            {
                case 0://inicio
                    this.buscar();
                    this.pnl_salida.Enabled = false;
                    this.pnl_busqueda.Enabled = true;
                    this.dgv_cheque.Enabled = true;
                    this.pnl_datos.Enabled = false;
                    this.btn_salida.Enabled = false;
                    this.btn_aceptar.ForeColor = Color.Black;
                    this.btn_nuevo.Enabled = true;
                    this.btn_editar.Enabled = true;
                    this.btn_eliminar.Enabled = true;
                    break;
                case 1://nuevo
                    this.pnl_busqueda.Enabled = false;
                    this.dgv_cheque.Enabled = false;
                    this.pnl_datos.Enabled = true;
                    this.txt_titular.Text = String.Empty;
                    this.txt_cuit.Text = String.Empty;
                    this.txt_localidad.Text = String.Empty;
                    this.idLocal = 0;
                    this.txt_persona.Text = String.Empty;
                    this.idPerson = 0;
                    this.cbo_banco.SelectedIndex = 0;
                    this.cbo_tipo.SelectedIndex = 0;
                    this.txt_numero.Text = String.Empty;
                    this.txt_importe.Text = String.Empty;
                    this.dtp_fechaCobro.Value = DateTime.Now;
                    this.dtp_fechaEmision.Value = DateTime.Now;
                    this.dtp_fechaRecibido.Value = DateTime.Now;
                    this.cbo_destino.SelectedValue = 8;
                    this.dtp_fechaSalida.Value = DateTime.Now;
                    this.txt_titular.Focus();
                    this.btn_salida.Enabled = true;
                    this.btn_nuevo.Enabled = false;
                    this.btn_editar.Enabled = false;
                    this.btn_eliminar.Enabled = false;
                    break;
                case 2://editar
                    this.pnl_datos.Enabled = true;
                    this.txt_titular.Focus();
                    this.btn_salida.Enabled = true;
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
                this.txt_titular.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
                this.txt_cuit.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
                this.txt_localidad.Text = Convert.ToString(dgv.CurrentRow.Cells[14].Value);
                this.idLocal = Convert.ToInt32(dgv.CurrentRow.Cells[2].Value);
                this.txt_persona.Text = Convert.ToString(dgv.CurrentRow.Cells[15].Value);
                this.idPerson = Convert.ToInt32(dgv.CurrentRow.Cells[13].Value);
                this.cbo_banco.SelectedValue = Convert.ToInt32(dgv.CurrentRow.Cells[1].Value);
                this.cbo_tipo.SelectedValue = Convert.ToInt32(dgv.CurrentRow.Cells[3].Value);
                this.txt_numero.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
                this.txt_importe.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
                this.dtp_fechaCobro.Value = Convert.ToDateTime(dgv.CurrentRow.Cells[8].Value);
                this.dtp_fechaEmision.Value = Convert.ToDateTime(dgv.CurrentRow.Cells[9].Value);
                this.dtp_fechaRecibido.Value = Convert.ToDateTime(dgv.CurrentRow.Cells[10].Value);
                this.cbo_destino.SelectedValue = Convert.ToInt32(dgv.CurrentRow.Cells[11].Value);
                if (dgv.CurrentRow.Cells[12].Value is DBNull)
                {
                    this.dtp_fechaSalida.Value = DateTime.Now;
                }
                else
                {
                    this.dtp_fechaSalida.Value = Convert.ToDateTime(dgv.CurrentRow.Cells[12].Value);
                }
            }
            else
            {
                this.txt_titular.Text = String.Empty;
                this.txt_cuit.Text = String.Empty;
                this.txt_localidad.Text = String.Empty;
                this.idLocal = 0;
                this.txt_persona.Text = String.Empty;
                this.idPerson = 0;
                this.cbo_banco.SelectedIndex = 0;
                this.cbo_tipo.SelectedIndex = 0;
                this.txt_numero.Text = String.Empty;
                this.txt_importe.Text = String.Empty;
                this.dtp_fechaCobro.Value = DateTime.Now;
                this.dtp_fechaEmision.Value = DateTime.Now;
                this.dtp_fechaRecibido.Value = DateTime.Now;
                this.cbo_destino.SelectedValue = 8;
                this.dtp_fechaSalida.Value = DateTime.Now;
            }            
        }

        private void dgv_cheque_SelectionChanged(object sender, EventArgs e)
        {
            this.cargarControles(this.dgv_cheque);
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string fechaSalida = null;
            if(this.pnl_salida.Enabled)
            {
                fechaSalida = procedures.dateToMySQL(this.dtp_fechaSalida);
            }
            switch (estadoControles)
            {
                case 1:
                    this.insertar(Convert.ToInt16(this.cbo_banco.SelectedValue), this.idLocal, Convert.ToInt16(this.cbo_tipo.SelectedValue), this.txt_numero.Text.Trim(), this.txt_titular.Text.Trim(), this.txt_cuit.Text.Trim(), procedures.stringToCurrencyMySQL(this.txt_importe.Text), procedures.dateToMySQL(this.dtp_fechaCobro), procedures.dateToMySQL(this.dtp_fechaEmision), procedures.dateToMySQL(this.dtp_fechaRecibido), Convert.ToInt16(this.cbo_destino.SelectedValue), fechaSalida, this.idPerson);
                    break;
                case 2:
                    this.actualizar(Convert.ToInt32(this.dgv_cheque.CurrentRow.Cells[0].Value), Convert.ToInt16(this.cbo_banco.SelectedValue), this.idLocal, Convert.ToInt16(this.cbo_tipo.SelectedValue), this.txt_numero.Text.Trim(), this.txt_titular.Text.Trim(), this.txt_cuit.Text.Trim(), procedures.stringToCurrencyMySQL(this.txt_importe.Text), procedures.dateToMySQL(this.dtp_fechaCobro), procedures.dateToMySQL(this.dtp_fechaEmision), procedures.dateToMySQL(this.dtp_fechaRecibido), Convert.ToInt16(this.cbo_destino.SelectedValue), fechaSalida, this.idPerson);
                    break;
                case 3:
                    this.eliminar(Convert.ToInt32(this.dgv_cheque.CurrentRow.Cells[0].Value));
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
            this.dgv_cheque.Rows.Clear();

            string query = "SELECT * FROM chequetercero INNER JOIN chequetercerodestino ON (chequetercero.idDestino = chequetercerodestino.id) INNER JOIN localidad ON (chequetercero.idLocalidad = localidad.id) INNER JOIN persona ON (chequetercero.idPersona = persona.id) WHERE numero LIKE @numero";
            
            if (this.chk_cartera.Checked)
            {
                string option = " AND chequetercerodestino.descripcion = 'En Cartera'";
                query += option;
            }

            MySqlCommand consulta = new MySqlCommand(query, procedures.conexion);
            consulta.Parameters.AddWithValue("@numero", Convert.ToString(busqueda) + "%");
            try
            {
                procedures.conexion.Open();
                MySqlDataReader reader = consulta.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.dgv_cheque.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], procedures.stringToCurrencyTextbox(Convert.ToString(reader[7])), reader[8], reader[9], reader[10], reader[11], reader[12], reader[13], reader[19], reader[22]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            procedures.conexion.Close();
        }

        private void insertar(int idBanco, int idLocalida, int idTipo, string numero, string titular, string cuit, string importe, string fechaCobro, string fechaEmision, string fechaRecibido, int idDestino, string fechaSalida, int idPersona)
        {
            MySqlParameter prmIdBanco = new MySqlParameter("@idBanco", MySqlDbType.Int32);
            MySqlParameter prmIdLocalidad = new MySqlParameter("@idLocalidad", MySqlDbType.Int32);
            MySqlParameter prmIdTipo = new MySqlParameter("@idTipo", MySqlDbType.Int32);
            MySqlParameter prmNumero = new MySqlParameter("@numero", MySqlDbType.VarChar);
            MySqlParameter prmTitular = new MySqlParameter("@titular", MySqlDbType.VarChar);
            MySqlParameter prmCuit = new MySqlParameter("@titularCuit", MySqlDbType.VarChar);
            MySqlParameter prmImporte = new MySqlParameter("@importe", MySqlDbType.VarChar);
            MySqlParameter prmFechaCobro = new MySqlParameter("@fechaCobro", MySqlDbType.Date);
            MySqlParameter prmFechaEmision = new MySqlParameter("@fechaEmision", MySqlDbType.Date);
            MySqlParameter prmFechaRecibido = new MySqlParameter("@fechaRecibido", MySqlDbType.Date);
            MySqlParameter prmIdDestino = new MySqlParameter("@idDestino", MySqlDbType.Int32);
            MySqlParameter prmFechaSalida = new MySqlParameter("@fechaSalida", MySqlDbType.Date);
            MySqlParameter prmIdPersona = new MySqlParameter("@idPersona", MySqlDbType.Int32);
            prmIdBanco.Value = Convert.ToInt32(idBanco);
            prmIdLocalidad.Value = Convert.ToInt32(idLocalida);
            prmIdTipo.Value = Convert.ToInt32(idTipo);
            prmNumero.Value = Convert.ToString(numero);
            prmTitular.Value = Convert.ToString(titular);
            prmCuit.Value = Convert.ToString(cuit);
            prmImporte.Value = Convert.ToString(importe);
            prmFechaCobro.Value = Convert.ToDateTime(fechaCobro);
            prmFechaEmision.Value = Convert.ToDateTime(fechaEmision);
            prmFechaRecibido.Value = Convert.ToDateTime(fechaRecibido);
            prmIdDestino.Value = Convert.ToInt32(idDestino);
            if (fechaSalida == null)
            {
                prmFechaSalida.Value = null;
            }
            else
            {
                prmFechaSalida.Value = Convert.ToDateTime(fechaSalida);
            }
            prmIdPersona.Value = Convert.ToInt32(idPersona);
            MySqlCommand mycmd = new MySqlCommand("INSERT INTO chequetercero (idBanco, idLocalidad, idTipo, numero, titular, titularCuit, importe, fechaCobro, fechaEmision, fechaRecibido, idDestino, fechaSalida, idPersona) VALUES (@idBanco, @idLocalidad, @idTipo, @numero, @titular, @titularCuit, @importe, @fechaCobro, @fechaEmision, @fechaRecibido, @idDestino, @fechaSalida, @idPersona)", procedures.conexion);
            mycmd.Parameters.Add(prmIdBanco);
            mycmd.Parameters.Add(prmIdLocalidad);
            mycmd.Parameters.Add(prmIdTipo);
            mycmd.Parameters.Add(prmNumero);
            mycmd.Parameters.Add(prmTitular);
            mycmd.Parameters.Add(prmCuit);
            mycmd.Parameters.Add(prmImporte);
            mycmd.Parameters.Add(prmFechaCobro);
            mycmd.Parameters.Add(prmFechaEmision);
            mycmd.Parameters.Add(prmFechaRecibido);
            mycmd.Parameters.Add(prmIdDestino);
            mycmd.Parameters.Add(prmFechaSalida);
            mycmd.Parameters.Add(prmIdPersona);
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

        private void actualizar(int id, int idBanco, int idLocalida, int idTipo, string numero, string titular, string cuit, string importe, string fechaCobro, string fechaEmision, string fechaRecibido, int idDestino, string fechaSalida, int idPersona)
        {
            MySqlParameter prmId = new MySqlParameter("@id", MySqlDbType.Int32);
            MySqlParameter prmIdBanco = new MySqlParameter("@idBanco", MySqlDbType.Int32);
            MySqlParameter prmIdLocalidad = new MySqlParameter("@idLocalidad", MySqlDbType.Int32);
            MySqlParameter prmIdTipo = new MySqlParameter("@idTipo", MySqlDbType.Int32);
            MySqlParameter prmNumero = new MySqlParameter("@numero", MySqlDbType.VarChar);
            MySqlParameter prmTitular = new MySqlParameter("@titular", MySqlDbType.VarChar);
            MySqlParameter prmCuit = new MySqlParameter("@titularCuit", MySqlDbType.VarChar);
            MySqlParameter prmImporte = new MySqlParameter("@importe", MySqlDbType.VarChar);
            MySqlParameter prmFechaCobro = new MySqlParameter("@fechaCobro", MySqlDbType.Date);
            MySqlParameter prmFechaEmision = new MySqlParameter("@fechaEmision", MySqlDbType.Date);
            MySqlParameter prmFechaRecibido = new MySqlParameter("@fechaRecibido", MySqlDbType.Date);
            MySqlParameter prmIdDestino = new MySqlParameter("@idDestino", MySqlDbType.Int32);
            MySqlParameter prmFechaSalida = new MySqlParameter("@fechaSalida", MySqlDbType.Date);
            MySqlParameter prmIdPersona = new MySqlParameter("@idPersona", MySqlDbType.Int32);
            prmId.Value = Convert.ToInt32(id);
            prmIdBanco.Value = Convert.ToInt32(idBanco);
            prmIdLocalidad.Value = Convert.ToInt32(idLocalida);
            prmIdTipo.Value = Convert.ToInt32(idTipo);
            prmNumero.Value = Convert.ToString(numero);
            prmTitular.Value = Convert.ToString(titular);
            prmCuit.Value = Convert.ToString(cuit);
            prmImporte.Value = Convert.ToString(importe);
            prmFechaCobro.Value = Convert.ToDateTime(fechaCobro);
            prmFechaEmision.Value = Convert.ToDateTime(fechaEmision);
            prmFechaRecibido.Value = Convert.ToDateTime(fechaRecibido);
            prmIdDestino.Value = Convert.ToInt32(idDestino);
            if (fechaSalida == null)
            {
                prmFechaSalida.Value = null;
            }
            else
            {
                prmFechaSalida.Value = Convert.ToDateTime(fechaSalida);
            }
            prmIdPersona.Value = Convert.ToInt32(idPersona);
            MySqlCommand mycmd = new MySqlCommand("UPDATE chequetercero SET idBanco = @idBanco, idLocalidad = @idLocalidad, idTipo = @idTipo, numero = @numero, titular = @titular, titularCuit = @titularCuit, importe = @importe, fechaCobro = @fechaCobro, fechaEmision = @fechaEmision, fechaRecibido = @fechaRecibido, idDestino = @idDestino, fechaSalida = @fechaSalida, idPersona = @idPersona WHERE id = @id", procedures.conexion);
            mycmd.Parameters.Add(prmId);
            mycmd.Parameters.Add(prmIdBanco);
            mycmd.Parameters.Add(prmIdLocalidad);
            mycmd.Parameters.Add(prmIdTipo);
            mycmd.Parameters.Add(prmNumero);
            mycmd.Parameters.Add(prmTitular);
            mycmd.Parameters.Add(prmCuit);
            mycmd.Parameters.Add(prmImporte);
            mycmd.Parameters.Add(prmFechaCobro);
            mycmd.Parameters.Add(prmFechaEmision);
            mycmd.Parameters.Add(prmFechaRecibido);
            mycmd.Parameters.Add(prmIdDestino);
            mycmd.Parameters.Add(prmFechaSalida);
            mycmd.Parameters.Add(prmIdPersona);
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
            MySqlCommand mycmd = new MySqlCommand("DELETE FROM chequetercero WHERE id = @id", procedures.conexion);
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

        private void txt_importe_Leave(object sender, EventArgs e)
        {
            this.txt_importe.Text = procedures.stringToCurrencyTextbox(this.txt_importe.Text);
        }

        private void txt_importe_Enter(object sender, EventArgs e)
        {
            if (this.txt_importe.Text != "")
            {
                this.txt_importe.Text = procedures.stringToCurrencyMySQL(this.txt_importe.Text);
            }
        }

        private void chk_cartera_CheckedChanged(object sender, EventArgs e)
        {
            this.buscar(this.txt_busqueda.Text.Trim());
        }

        private void chequeTercero_Activated(object sender, EventArgs e)
        {
            //this.txt_persona.Text = this.nombrePersona;
            //this.txt_localidad.Text = this.nombreLocalidad;
        }

        private void btn_salida_Click(object sender, EventArgs e)
        {
            if (this.pnl_salida.Enabled)
            {
                this.pnl_salida.Enabled = false;
            }
            else
            {
                this.pnl_salida.Enabled = true;
            }
        }
    }
}
