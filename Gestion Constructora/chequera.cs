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
    public partial class chequera : Form
    {
        //para saber en que estado se encuentran los controles del formulario (0=inicio, 1=nuevo, 2=editar, 3=eliminar)
        private int estadoControles = 0;

        public chequera()
        {
            InitializeComponent();
            chequera chequera = this;
            procedures proc = new procedures();
            //                     form       title               start position            resizable
            proc.inicializarFormulario(chequera, "ABM de Chequeras", FormStartPosition.CenterScreen, false);
            proc.inicializarGrid(this.dgv_cuenta);
            proc.inicializarGrid(this.dgv_chequera);
        }

        private void chequera_Load(object sender, EventArgs e)
        {
            this.buscarCuenta();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            this.cambiarControles(1);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dgv_chequera.SelectedRows.Count > 0)
            {
                this.cargarControles(dgv_cuenta, dgv_chequera);
                this.cambiarControles(2);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una cuenta para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (this.dgv_chequera.SelectedRows.Count > 0)
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
                    this.buscarCuenta();
                    this.pnl_datos.Enabled = false;
                    this.btn_aceptar.ForeColor = Color.Black;
                    this.btn_nuevo.Enabled = true;
                    this.btn_editar.Enabled = true;
                    this.btn_eliminar.Enabled = true;
                    break;
                case 1://nuevo
                    this.pnl_datos.Enabled = true;
                    this.txt_numeroInicial.Text = String.Empty;
                    this.txt_numeroInicial.Focus();
                    this.txt_cantidad.Text = String.Empty;
                    this.dtp_fecha.Value = DateTime.Today;
                    this.btn_nuevo.Enabled = false;
                    this.btn_editar.Enabled = false;
                    this.btn_eliminar.Enabled = false;
                    break;
                case 2://editar
                    this.pnl_datos.Enabled = true;
                    this.txt_numeroInicial.Focus();
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

        private void dgv_cuenta_SelectionChanged(object sender, EventArgs e)
        {
            this.buscarChequera(Convert.ToInt32(this.dgv_cuenta.CurrentRow.Cells[0].Value));
            this.cargarControles(this.dgv_cuenta, this.dgv_chequera);
        }

        private void cargarControles(DataGridView cuenta, DataGridView chequera)
        {
            this.txt_cuenta.Text = Convert.ToString(cuenta.CurrentRow.Cells[2].Value);
            if (chequera.SelectedRows.Count > 0)
            {
                this.dtp_fecha.Value = Convert.ToDateTime(chequera.CurrentRow.Cells[4].Value);
                this.txt_numeroInicial.Text = Convert.ToString(chequera.CurrentRow.Cells[2].Value);
                this.txt_cantidad.Text = Convert.ToString(chequera.CurrentRow.Cells[3].Value);
                this.chk_activa.Checked = Convert.ToBoolean(chequera.CurrentRow.Cells[5].Value);
            }
            else
            {
                this.dtp_fecha.Value = DateTime.Today;
                this.txt_numeroInicial.Text = String.Empty;
                this.txt_cantidad.Text = String.Empty;
                this.chk_activa.Checked = true;
            }

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string fecha = procedures.dateToMySQL(this.dtp_fecha);
            switch (estadoControles)
            {
                case 1:
                    this.insertar(Convert.ToInt32(this.dgv_cuenta.CurrentRow.Cells[0].Value), this.txt_numeroInicial.Text, Convert.ToInt16(this.txt_cantidad.Text), fecha, this.chk_activa.Checked);
                    break;
                case 2:
                    this.actualizar(Convert.ToInt32(this.dgv_chequera.CurrentRow.Cells[0].Value), Convert.ToInt32(this.dgv_cuenta.CurrentRow.Cells[0].Value), this.txt_numeroInicial.Text, Convert.ToInt16(this.txt_cantidad.Text), fecha, this.chk_activa.Checked);
                    break;
                case 3:
                    this.eliminar(Convert.ToInt32(this.dgv_chequera.CurrentRow.Cells[0].Value));
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

        private void buscarCuenta(string busqueda = null)
        {
            this.dgv_cuenta.Rows.Clear();

            MySqlParameter prmBusqueda = new MySqlParameter("@nombre", MySqlDbType.VarChar);
            MySqlCommand consulta = new MySqlCommand("SELECT bancocuenta.id, banco.nombre, bancocuenta.numero FROM banco INNER JOIN bancocuenta ON (banco.id = bancocuenta.idBanco) WHERE banco.nombre LIKE @nombre", procedures.conexion);
            consulta.Parameters.AddWithValue("@nombre", "%" + Convert.ToString(busqueda) + "%");
            try
            {
                procedures.conexion.Open();
                MySqlDataReader reader = consulta.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.dgv_cuenta.Rows.Add(reader[0], reader[1], reader[2]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            procedures.conexion.Close();
        }

        private void buscarChequera(int idCuenta)
        {
            this.dgv_chequera.Rows.Clear();

            MySqlParameter prmBusqueda = new MySqlParameter("@id", MySqlDbType.VarChar);
            prmBusqueda.Value = Convert.ToInt32(idCuenta);
            MySqlCommand consulta = new MySqlCommand("SELECT * FROM chequera WHERE idCuenta = @id", procedures.conexion2);
            consulta.Parameters.Add(prmBusqueda);
            try
            {
                procedures.conexion2.Open();
                MySqlDataReader reader = consulta.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.dgv_chequera.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            procedures.conexion2.Close();
        }

        private void insertar(int idCuenta, string inicial, int cantidad, string fecha, bool activa)
        {
            MySqlParameter prmIdCuenta = new MySqlParameter("@idCuenta", MySqlDbType.Int32);
            MySqlParameter prmInicial = new MySqlParameter("@inicial", MySqlDbType.VarChar);
            MySqlParameter prmCantidad = new MySqlParameter("@cantidad", MySqlDbType.Int16);
            MySqlParameter prmFecha = new MySqlParameter("@fecha", MySqlDbType.Date);
            MySqlParameter prmActiva = new MySqlParameter("@activa", MySqlDbType.Int16);
            prmIdCuenta.Value = Convert.ToString(idCuenta);
            prmInicial.Value = Convert.ToString(inicial);
            prmCantidad.Value = Convert.ToString(cantidad);
            prmFecha.Value = Convert.ToString(fecha);
            prmActiva.Value = Convert.ToInt16(activa);
            MySqlCommand mycmd = new MySqlCommand("INSERT INTO chequera (idCuenta, numeroInicial, cantidad, fecha, activa) VALUES (@idCuenta, @inicial, @cantidad, @fecha, @activa)", procedures.conexion);
            mycmd.Parameters.Add(prmIdCuenta);
            mycmd.Parameters.Add(prmInicial);
            mycmd.Parameters.Add(prmCantidad);
            mycmd.Parameters.Add(prmFecha);
            mycmd.Parameters.Add(prmActiva);
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

        private void actualizar(int id, int idCuenta, string inicial, int cantidad, string fecha, bool activa)
        {
            MySqlParameter prmId = new MySqlParameter("@id", MySqlDbType.Int32);
            MySqlParameter prmIdCuenta = new MySqlParameter("@idCuenta", MySqlDbType.Int32);
            MySqlParameter prmInicial = new MySqlParameter("@inicial", MySqlDbType.VarChar);
            MySqlParameter prmCantidad = new MySqlParameter("@cantidad", MySqlDbType.Int16);
            MySqlParameter prmFecha = new MySqlParameter("@fecha", MySqlDbType.Date);
            MySqlParameter prmActiva = new MySqlParameter("@activa", MySqlDbType.Int16);
            prmId.Value = Convert.ToInt32(id);
            prmIdCuenta.Value = Convert.ToString(idCuenta);
            prmInicial.Value = Convert.ToString(inicial);
            prmCantidad.Value = Convert.ToString(cantidad);
            prmFecha.Value = Convert.ToString(fecha);
            prmActiva.Value = Convert.ToInt16(activa);
            MySqlCommand mycmd = new MySqlCommand("UPDATE chequera SET idCuenta = @idCuenta, numeroInicial = @inicial, cantidad = @cantidad, fecha = @fecha, activa = @activa WHERE id = @id", procedures.conexion);
            mycmd.Parameters.Add(prmId);
            mycmd.Parameters.Add(prmIdCuenta);
            mycmd.Parameters.Add(prmInicial);
            mycmd.Parameters.Add(prmCantidad);
            mycmd.Parameters.Add(prmFecha);
            mycmd.Parameters.Add(prmActiva);
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
            MySqlCommand mycmd = new MySqlCommand("UPDATE chequera SET activa = 0 WHERE id = @id", procedures.conexion);
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
            this.buscarCuenta(this.txt_busqueda.Text.Trim());
        }

        private void dgv_chequera_SelectionChanged(object sender, EventArgs e)
        {
            this.cargarControles(this.dgv_cuenta, this.dgv_chequera);
        }
    }
}
