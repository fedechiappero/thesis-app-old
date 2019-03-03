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
    public partial class empleado : Form
    {
        //para saber en que estado se encuentran los controles del formulario (0=inicio, 1=nuevo, 2=editar, 3=eliminar)
        private int controllsStatus = 0;

        public empleado()
        {
            InitializeComponent();
            empleado empleado = this;
            procedures proc = new procedures();
            //                 form         title                start position            resizable
            proc.initilizeForm(empleado, "ABM de Empleados", FormStartPosition.CenterScreen, false);
            proc.initializeGrid(this.dgv_empleado);
        }

        private void empleado_Load(object sender, EventArgs e)
        {
            buscar();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            changeControlls(1);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dgv_empleado.SelectedRows.Count > 0)
            {
                cargarControles(dgv_empleado);
                changeControlls(2);
            }
            else
            {
                /*inform to the dumb user that he must select a record to edit*/
            } 
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            changeControlls(3);
        }

        private void changeControlls(int status)
        {
            switch (status)
            {
                case 0://inicio
                    buscar();
                    this.pnl_datos.Enabled = false;
                    this.btn_aceptar.ForeColor = Color.Black;
                    this.btn_nuevo.Enabled = true;
                    this.btn_editar.Enabled = true;
                    this.btn_eliminar.Enabled = true;
                    break;
                case 1://nuevo
                    this.pnl_datos.Enabled = true;
                    this.txt_celular.Text = String.Empty;
                    this.txt_email.Text = String.Empty;
                    this.txt_nombre.Text = String.Empty;
                    this.txt_nombre.Focus();
                    this.txt_usuario.Text = String.Empty;
                    this.txt_password.Text = String.Empty;
                    this.cbo_nivel.SelectedIndex = 1;
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
            controllsStatus = status;
        }

        private void cargarControles(DataGridView dgv)
        {
            this.txt_celular.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            this.txt_email.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
            this.txt_nombre.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            this.txt_usuario.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
            this.txt_password.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
            this.cbo_nivel.SelectedItem = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
        }

        private void dgv_empleado_SelectionChanged(object sender, EventArgs e)
        {
            cargarControles(dgv_empleado);
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            switch (controllsStatus)
            {
                case 1:
                    insertar(this.txt_nombre.Text.Trim(), this.txt_celular.Text.Trim(), this.txt_email.Text.Trim(), this.txt_usuario.Text.Trim(), this.txt_password.Text.Trim(), Convert.ToInt16(this.cbo_nivel.SelectedItem));
                    break;
                case 2:
                    actualizar(Convert.ToInt32(this.dgv_empleado.CurrentRow.Cells[0].Value), this.txt_nombre.Text.Trim(), this.txt_celular.Text.Trim(), this.txt_email.Text.Trim(), this.txt_usuario.Text.Trim(), this.txt_password.Text.Trim(), Convert.ToInt16(this.cbo_nivel.SelectedItem));
                    break;
                case 3:
                    eliminar(Convert.ToInt32(this.dgv_empleado.CurrentRow.Cells[0].Value));
                    break;
                default:
                    //something went wrong
                    break;
            }
            changeControlls(0);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (controllsStatus != 0)
            {
                changeControlls(0);
            }
            else
            {
                this.Dispose();
            }
        }

        private void buscar(string busqueda = null)
        {
            dgv_empleado.Rows.Clear();

            MySqlParameter prmBusqueda = new MySqlParameter("@nombre", MySqlDbType.VarChar);
            MySqlCommand consulta = new MySqlCommand("SELECT persona.id, persona.nombre, persona.celular, persona.email, empleado.usuario, empleado.password, empleado.nivel_acceso FROM persona INNER JOIN empleado ON (persona.id = empleado.id) WHERE persona.nombre LIKE @nombre AND empleado.activo = 1", procedures.conexion);
            consulta.Parameters.AddWithValue("@nombre", "%" + Convert.ToString(busqueda) + "%");
            try
            {
                procedures.conexion.Open();
                MySqlDataReader reader = consulta.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dgv_empleado.Rows.Add(reader[0], reader[2], reader[3], reader[1], reader[4], reader[5], reader[6]);
                    }
                }
                procedures.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertar(string nombre, string celular, string email, string usuario, string password, int nivel)
        {
            MySqlParameter prmNombre = new MySqlParameter("@nombre", MySqlDbType.VarChar);
            MySqlParameter prmCelular = new MySqlParameter("@celular", MySqlDbType.VarChar);
            MySqlParameter prmEmail = new MySqlParameter("@email", MySqlDbType.VarChar);
            prmNombre.Value = Convert.ToString(nombre);
            prmCelular.Value = Convert.ToString(celular);
            prmEmail.Value = Convert.ToString(email);
            MySqlCommand cmdPersona = new MySqlCommand("INSERT INTO persona (nombre, celular, email) VALUES (@nombre, @celular, @email); SELECT LAST_INSERT_ID()", procedures.conexion);
            cmdPersona.Parameters.Add(prmNombre);
            cmdPersona.Parameters.Add(prmCelular);
            cmdPersona.Parameters.Add(prmEmail);
            MySqlParameter prmId = new MySqlParameter("@id", MySqlDbType.Int32);
            MySqlParameter prmUsuario = new MySqlParameter("@usuario", MySqlDbType.VarChar);
            MySqlParameter prmPassword = new MySqlParameter("@password", MySqlDbType.VarChar);
            MySqlParameter prmNivel = new MySqlParameter("@nivel", MySqlDbType.Int16);
            prmUsuario.Value = Convert.ToString(usuario);
            prmPassword.Value = Convert.ToString(password);
            prmNivel.Value = Convert.ToInt16(nivel);
            MySqlCommand cmdEmpleado = new MySqlCommand("INSERT INTO empleado (id, usuario, password, nivel_acceso) VALUES (@id, @usuario, @password, @nivel)", procedures.conexion);
            cmdEmpleado.Parameters.Add(prmUsuario);
            cmdEmpleado.Parameters.Add(prmPassword);
            cmdEmpleado.Parameters.Add(prmNivel);
            try
            {
                procedures.conexion.Open();
                int idPersona = Convert.ToInt32(cmdPersona.ExecuteScalar());
                prmId.Value = idPersona;
                cmdEmpleado.Parameters.Add(prmId);
                cmdEmpleado.ExecuteNonQuery();
                procedures.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actualizar(int id, string nombre, string celular, string email, string usuario, string password, int nivel)
        {
            MySqlParameter prmId = new MySqlParameter("@id", MySqlDbType.Int32);
            MySqlParameter prmNombre = new MySqlParameter("@nombre", MySqlDbType.VarChar);
            MySqlParameter prmCelular = new MySqlParameter("@celular", MySqlDbType.VarChar);
            MySqlParameter prmEmail = new MySqlParameter("@email", MySqlDbType.VarChar);
            MySqlParameter prmUsuario = new MySqlParameter("@usuario", MySqlDbType.VarChar);
            MySqlParameter prmPassword = new MySqlParameter("@password", MySqlDbType.VarChar);
            MySqlParameter prmNivel = new MySqlParameter("@nivel", MySqlDbType.Int16);
            prmId.Value = Convert.ToInt32(id);
            prmNombre.Value = Convert.ToString(nombre);
            prmCelular.Value = Convert.ToString(celular);
            prmEmail.Value = Convert.ToString(email);
            prmUsuario.Value = Convert.ToString(usuario);
            prmPassword.Value = Convert.ToString(password);
            prmNivel.Value = Convert.ToInt16(nivel);

            MySqlCommand cmdPersona = new MySqlCommand("UPDATE persona SET nombre = @nombre, celular = @celular, email = @email WHERE id = @id", procedures.conexion);
            cmdPersona.Parameters.Add(prmId);
            cmdPersona.Parameters.Add(prmNombre);
            cmdPersona.Parameters.Add(prmCelular);
            cmdPersona.Parameters.Add(prmEmail);

            MySqlCommand cmdEmpleado = new MySqlCommand("UPDATE empleado SET usuario = @usuario, password = @password, nivel_acceso = @nivel WHERE id = @id", procedures.conexion);
            cmdEmpleado.Parameters.Add(prmId);
            cmdEmpleado.Parameters.Add(prmUsuario);
            cmdEmpleado.Parameters.Add(prmPassword);
            cmdEmpleado.Parameters.Add(prmNivel);
            try
            {
                procedures.conexion.Open();
                cmdPersona.ExecuteNonQuery();
                cmdEmpleado.ExecuteNonQuery();
                procedures.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminar(int id)
        {
            MySqlParameter prmId = new MySqlParameter("@id", MySqlDbType.Int32);
            prmId.Value = Convert.ToInt32(id);
            MySqlCommand mycmd = new MySqlCommand("UPDATE empleado SET activo = 0 WHERE id = @id", procedures.conexion);
            mycmd.Parameters.Add(prmId);
            try
            {
                procedures.conexion.Open();
                mycmd.ExecuteNonQuery();
                procedures.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            buscar(this.txt_busqueda.Text.Trim());
        }
    }
}
