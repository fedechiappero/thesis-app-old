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
    public partial class chequeEmision : Form
    {
        public static int idPersona;
        public static string nombrePersona;

        //para saber en que estado se encuentran los controles del formulario (0=inicio, 1=nuevo, 2=editar, 3=eliminar)
        private int estadoControles = 0;

        public chequeEmision()
        {
            InitializeComponent();
            chequeEmision chequeEmision = this;
            procedures proc = new procedures();
            //                         form         title             start position            resizable
            proc.inicializarFormulario(chequeEmision, "Emisión de Cheque", FormStartPosition.CenterScreen, false);
            proc.inicializarGrid(this.dgv_chequera);
            proc.inicializarGrid(this.dgv_cheque);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personaBusquedaRapida personaBusquedaRapida = new personaBusquedaRapida();
            personaBusquedaRapida.ShowDialog();
        }

        private void chequeEmision_Load(object sender, EventArgs e)
        {
            this.buscarChequera();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            this.cambiarControles(1);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dgv_cheque.SelectedRows.Count > 0)
            {
                this.cargarControles(this.dgv_cheque, this.dgv_chequera);
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
                    this.buscarChequera();
                    this.pnl_datos.Enabled = false;
                    this.btn_aceptar.ForeColor = Color.Black;
                    this.btn_nuevo.Enabled = true;
                    this.btn_editar.Enabled = true;
                    this.btn_eliminar.Enabled = true;
                    break;
                case 1://nuevo
                    this.pnl_datos.Enabled = true;
                    this.dtp_fechaPago.Value = DateTime.Today;
                    this.dtp_fechaEmision.Value = DateTime.Today;
                    this.txt_numero.Text = String.Empty;
                    this.txt_importe.Text = String.Empty;
                    this.btn_nuevo.Enabled = false;
                    this.btn_editar.Enabled = false;
                    this.btn_eliminar.Enabled = false;
                    break;
                case 2://editar
                    this.pnl_datos.Enabled = true;
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

        private void dgv_chequera_SelectionChanged(object sender, EventArgs e)
        {
            this.buscarCheque(Convert.ToInt32(this.dgv_chequera.CurrentRow.Cells[0].Value));
            this.cargarControles(this.dgv_cheque, this.dgv_chequera);
        }

        private void cargarControles(DataGridView cheque, DataGridView chequera)
        {
            if (chequera.SelectedRows.Count > 0)
            {
                this.txt_banco.Text = Convert.ToString(chequera.CurrentRow.Cells[1].Value);
                if (cheque.SelectedRows.Count > 0)
                {
                    this.dtp_fechaPago.Value = Convert.ToDateTime(cheque.CurrentRow.Cells[4].Value);
                    this.dtp_fechaEmision.Value = Convert.ToDateTime(cheque.CurrentRow.Cells[5].Value);
                    this.txt_numero.Text = Convert.ToString(cheque.CurrentRow.Cells[6].Value);
                    this.txt_importe.Text = Convert.ToString(cheque.CurrentRow.Cells[7].Value);
                    this.txt_busquedaPersona.Text = Convert.ToString(cheque.CurrentRow.Cells[3].Value);
                }
                else
                {
                    this.dtp_fechaPago.Value = DateTime.Today;
                    this.dtp_fechaEmision.Value = DateTime.Today;
                    this.txt_numero.Text = String.Empty;
                    this.txt_importe.Text = String.Empty;
                    this.txt_busquedaPersona.Text = String.Empty;
                }
            }
            
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            switch (estadoControles)
            {
                case 1:
                    this.insertar(Convert.ToInt32(this.dgv_chequera.CurrentRow.Cells[0].Value), idPersona, procedures.dateToMySQL(this.dtp_fechaPago), procedures.dateToMySQL(this.dtp_fechaEmision), Convert.ToInt32(this.txt_numero.Text), this.txt_importe.Text);
                    break;
                case 2:
                    this.actualizar(Convert.ToInt32(this.dgv_cheque.CurrentRow.Cells[0].Value), Convert.ToInt32(this.dgv_chequera.CurrentRow.Cells[0].Value), idPersona, procedures.dateToMySQL(this.dtp_fechaPago), procedures.dateToMySQL(this.dtp_fechaEmision), Convert.ToInt32(this.txt_numero.Text), this.txt_importe.Text);
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

        private void buscarChequera(string busqueda = null)
        {
            this.dgv_chequera.Rows.Clear();

            MySqlParameter prmBusqueda = new MySqlParameter("@nombre", MySqlDbType.VarChar);
            MySqlCommand consulta = new MySqlCommand("SELECT chequera.id, chequera.fecha, bancocuenta.numero, banco.nombre FROM chequera INNER JOIN bancocuenta ON (chequera.idCuenta = bancocuenta.id) INNER JOIN banco ON (bancocuenta.idBanco = banco.id) WHERE banco.nombre LIKE @nombre", procedures.conexion);
            consulta.Parameters.AddWithValue("@nombre", "%" + Convert.ToString(busqueda) + "%");
            try
            {
                procedures.conexion.Open();
                MySqlDataReader reader = consulta.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.dgv_chequera.Rows.Add(reader[0], reader[3], reader[2], reader[9]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            procedures.conexion.Close();
        }

        private void buscarCheque(int idChequera)
        {
            this.dgv_cheque.Rows.Clear();

            MySqlParameter prmBusqueda = new MySqlParameter("@id", MySqlDbType.VarChar);
            prmBusqueda.Value = Convert.ToInt32(idChequera);
            MySqlCommand consulta = new MySqlCommand("SELECT * FROM chequepropio INNER JOIN persona ON (chequepropio.idPersona = persona.id) WHERE idChequera = @id", procedures.conexion2);
            consulta.Parameters.Add(prmBusqueda);
            try
            {
                procedures.conexion2.Open();
                MySqlDataReader reader = consulta.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.dgv_cheque.Rows.Add(reader[0], reader[1], reader[2], reader[8], reader[3], reader[4], reader[5], reader[6]);
                    }
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            procedures.conexion2.Close();
        }

        private void insertar(int idChequera, int idPersona, string fechaPago, string fechaEmision, int numero, string importe)
        {
            MySqlParameter prmIdChequera = new MySqlParameter("@idChequera", MySqlDbType.Int32);
            MySqlParameter prmIdPersona = new MySqlParameter("@idPersona", MySqlDbType.Int32);
            MySqlParameter prmFechaPago = new MySqlParameter("@fechaPago", MySqlDbType.Date);
            MySqlParameter prmFechaEmision = new MySqlParameter("@fechaEmision", MySqlDbType.Date);
            MySqlParameter prmNumero = new MySqlParameter("@numero", MySqlDbType.Int32);
            MySqlParameter prmImporte = new MySqlParameter("@importe", MySqlDbType.Float);
            prmIdChequera.Value = Convert.ToInt32(idChequera);
            prmIdPersona.Value = Convert.ToInt32(idPersona);
            prmFechaPago.Value = Convert.ToDateTime(fechaPago);
            prmFechaEmision.Value = Convert.ToDateTime(fechaEmision);
            prmNumero.Value = Convert.ToInt32(numero);
            prmImporte.Value = Convert.ToDouble(importe);
            MySqlCommand mycmd = new MySqlCommand("INSERT INTO chequepropio (idChequera, idPersona, fechaPago, fechaEmision, numero, importe) VALUES (@idChequera, @idPersona, @fechaPago, @fechaEmision, @numero, @importe)", procedures.conexion);
            mycmd.Parameters.Add(prmIdChequera);
            mycmd.Parameters.Add(prmIdPersona);
            mycmd.Parameters.Add(prmFechaPago);
            mycmd.Parameters.Add(prmFechaEmision);
            mycmd.Parameters.Add(prmNumero);
            mycmd.Parameters.Add(prmImporte);
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

        private void actualizar(int id, int idChequera, int idPersona, string fechaPago, string fechaEmision, int numero, string importe)
        {
            MySqlParameter prmId = new MySqlParameter("@id", MySqlDbType.Int32);
            MySqlParameter prmIdChequera = new MySqlParameter("@idChequera", MySqlDbType.Int32);
            MySqlParameter prmIdPersona = new MySqlParameter("@idPersona", MySqlDbType.Int32);
            MySqlParameter prmFechaPago = new MySqlParameter("@fechaPago", MySqlDbType.Date);
            MySqlParameter prmFechaEmision = new MySqlParameter("@fechaEmision", MySqlDbType.Date);
            MySqlParameter prmNumero = new MySqlParameter("@numero", MySqlDbType.Int32);
            MySqlParameter prmImporte = new MySqlParameter("@importe", MySqlDbType.Float);
            prmId.Value = Convert.ToInt32(id);
            prmIdChequera.Value = Convert.ToInt32(idChequera);
            prmIdPersona.Value = Convert.ToInt32(idPersona);
            prmFechaPago.Value = Convert.ToDateTime(fechaPago);
            prmFechaEmision.Value = Convert.ToDateTime(fechaEmision);
            prmNumero.Value = Convert.ToInt32(numero);
            prmImporte.Value = Convert.ToDouble(importe);
            MySqlCommand mycmd = new MySqlCommand("UPDATE chequepropio SET idChequera = @idChequera, idPersona = @idPersona, fechaPago = @fechaPago, fechaEmision = @fechaEmision, numero = @numero, importe = @importe WHERE id = @id", procedures.conexion);
            mycmd.Parameters.Add(prmId);
            mycmd.Parameters.Add(prmIdChequera);
            mycmd.Parameters.Add(prmIdPersona);
            mycmd.Parameters.Add(prmFechaPago);
            mycmd.Parameters.Add(prmFechaEmision);
            mycmd.Parameters.Add(prmNumero);
            mycmd.Parameters.Add(prmImporte);
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
            MySqlCommand mycmd = new MySqlCommand("UPDATE chequepropio SET activa = 0 WHERE id = @id", procedures.conexion);
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

        private void txt_busquedaChequera_TextChanged(object sender, EventArgs e)
        {
            this.buscarChequera(this.txt_busquedaChequera.Text.Trim());
        }

        private void chequeEmision_Activated(object sender, EventArgs e)
        {
            this.txt_busquedaPersona.Text = nombrePersona;
        }
    }
}
