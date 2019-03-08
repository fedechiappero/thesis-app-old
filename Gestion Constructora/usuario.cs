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
    public partial class usuario : Form
    {
        //para saber en que estado se encuentran los controles del formulario (0=inicio, 1=nuevo, 2=editar, 3=eliminar)
        private int estadoControles = 0;

        public usuario()
        {
            InitializeComponent();
            usuario usuario = this;
            procedures proc = new procedures();
            //                 form         title                start position          resizable
            proc.inicializarFormulario(usuario, "ABM de Usuarios", FormStartPosition.CenterScreen, false);
            proc.inicializarGrid(this.dgv_usuario);
        }

        private void usuario_Load(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            this.cambiarControles(1);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (this.dgv_usuario.SelectedRows.Count > 0)
            {
                this.cargarControles(dgv_usuario);
                this.cambiarControles(2);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (this.dgv_usuario.SelectedRows.Count > 0)
            {
                this.cambiarControles(3);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void cambiarControles(int estado)
        {
            switch (estado)
            {
                case 0://inicio
                    this.buscar();
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
                    this.cbo_nivel.SelectedIndex = 0;
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
            this.txt_celular.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            this.txt_email.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
            this.txt_nombre.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            this.txt_usuario.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
            this.txt_password.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
            this.cbo_nivel.SelectedItem = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
        }

        private void dgv_usuario_SelectionChanged(object sender, EventArgs e)
        {
            this.cargarControles(dgv_usuario);
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            switch (estadoControles)
            {
                case 1:
                    this.insertar(this.txt_nombre.Text.Trim(), this.txt_celular.Text.Trim(), this.txt_email.Text.Trim(), this.txt_usuario.Text.Trim(), this.txt_password.Text.Trim(), Convert.ToInt16(this.cbo_nivel.SelectedItem));
                    break;
                case 2:
                    this.actualizar(Convert.ToInt32(this.dgv_usuario.CurrentRow.Cells[0].Value), this.txt_nombre.Text.Trim(), this.txt_celular.Text.Trim(), this.txt_email.Text.Trim(), this.txt_usuario.Text.Trim(), this.txt_password.Text.Trim(), Convert.ToInt16(this.cbo_nivel.SelectedItem));
                    break;
                case 3:
                    this.eliminar(Convert.ToInt32(this.dgv_usuario.CurrentRow.Cells[0].Value));
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
            this.dgv_usuario.Rows.Clear();

            MySqlParameter prmBusqueda = new MySqlParameter("@nombre", MySqlDbType.VarChar);
            MySqlCommand consulta = new MySqlCommand("SELECT persona.id, persona.nombre, persona.celular, persona.email, usuario.usuario, usuario.password, usuario.nivel_acceso FROM persona INNER JOIN usuario ON (persona.id = usuario.id) WHERE persona.nombre LIKE @nombre AND usuario.activo = 1", procedures.conexion);
            consulta.Parameters.AddWithValue("@nombre", "%" + Convert.ToString(busqueda) + "%");
            try
            {
                procedures.conexion.Open();
                MySqlDataReader reader = consulta.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.dgv_usuario.Rows.Add(reader[0], reader[2], reader[3], reader[1], reader[4], reader[5], reader[6]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            procedures.conexion.Close();
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
            MySqlCommand cmdEmpleado = new MySqlCommand("INSERT INTO usuario (id, usuario, password, nivel_acceso) VALUES (@id, @usuario, @password, @nivel)", procedures.conexion);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            procedures.conexion.Close();
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

            MySqlCommand cmdEmpleado = new MySqlCommand("UPDATE usuario SET usuario = @usuario, password = @password, nivel_acceso = @nivel WHERE id = @id", procedures.conexion);
            cmdEmpleado.Parameters.Add(prmId);
            cmdEmpleado.Parameters.Add(prmUsuario);
            cmdEmpleado.Parameters.Add(prmPassword);
            cmdEmpleado.Parameters.Add(prmNivel);
            try
            {
                procedures.conexion.Open();
                cmdPersona.ExecuteNonQuery();
                cmdEmpleado.ExecuteNonQuery();
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
            MySqlCommand mycmd = new MySqlCommand("UPDATE usuario SET activo = 0 WHERE id = @id", procedures.conexion);
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
