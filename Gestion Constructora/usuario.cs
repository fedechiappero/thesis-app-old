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
            //                          form         title                start position          resizable
            proc.inicializarFormulario(usuario, "ABM de Usuarios", FormStartPosition.CenterScreen, false);
            proc.inicializarGrid(this.dgv_usuario);
        }

        private void usuario_Load(object sender, EventArgs e)
        {
            this.buscar();
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
                    this.dgv_usuario.Enabled = true;
                    this.txt_busqueda.Enabled = true;
                    this.btn_aceptar.ForeColor = Color.Black;
                    this.txt_password.Text = String.Empty;
                    this.txt_confirma.Text = String.Empty;
                    this.btn_editar.Enabled = true;
                    this.btn_eliminar.Enabled = true;
                    break;
                case 1://nuevo (USELESS CODE)
                    this.pnl_datos.Enabled = true;
                    this.dgv_usuario.Enabled = false;
                    this.txt_busqueda.Enabled = false;
                    this.txt_usuario.Text = String.Empty;
                    this.txt_password.Text = String.Empty;
                    this.txt_confirma.Text = String.Empty;
                    this.cbo_nivel.SelectedIndex = 0;
                    this.txt_usuario.Focus();
                    this.btn_editar.Enabled = false;
                    this.btn_eliminar.Enabled = false;
                    break;
                case 2://editar
                    this.dgv_usuario.Enabled = false;
                    this.txt_busqueda.Enabled = false;
                    this.pnl_datos.Enabled = true;
                    this.txt_usuario.Focus();
                    this.btn_editar.Enabled = false;
                    this.btn_eliminar.Enabled = false;
                    break;
                case 3://eliminar
                    this.dgv_usuario.Enabled = false;
                    this.txt_busqueda.Enabled = false;
                    this.btn_aceptar.ForeColor = Color.Red;
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
            if (Convert.ToString(dgv.CurrentRow.Cells[2].Value) == String.Empty)
            {
                this.txt_usuario.Text = String.Empty;
                this.cbo_nivel.SelectedIndex = 0;
            }
            else
            {
                this.txt_usuario.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                this.cbo_nivel.SelectedItem = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            }
        }

        private void dgv_usuario_SelectionChanged(object sender, EventArgs e)
        {
            this.cargarControles(dgv_usuario);
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (this.txt_password.Text != String.Empty && this.txt_password.Text == this.txt_confirma.Text || estadoControles == 3)
            {
                switch (estadoControles)
                {
                    case 2:
                        this.actualizar(Convert.ToInt32(this.dgv_usuario.CurrentRow.Cells[0].Value), this.txt_usuario.Text.Trim(), CCryptorEngine.Encriptar(this.txt_confirma.Text.Trim()), Convert.ToInt16(this.cbo_nivel.SelectedItem));
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
            else
            {
                MessageBox.Show("Las contraseñas deben coincidir y no pueden estar en blanco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

            string command = "SELECT persona.id, persona.nombre, usuario.usuario, usuario.nivel_acceso FROM persona ";
            
            if (this.chk_buscarTodo.Checked)
            {
                command += "LEFT JOIN usuario ON (persona.id = usuario.id)";
            }
            else
            {
                command += "INNER JOIN usuario ON (persona.id = usuario.id) WHERE persona.nombre LIKE @nombre AND usuario.activo = 1";
            }

            MySqlCommand consulta = new MySqlCommand(command, procedures.conexion);
            consulta.Parameters.AddWithValue("@nombre", "%" + Convert.ToString(busqueda) + "%");
            try
            {
                procedures.conexion.Open();
                MySqlDataReader reader = consulta.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.dgv_usuario.Rows.Add(reader[0], reader[1], reader[2], reader[3]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            procedures.conexion.Close();
        }

        private void actualizar(int id, string usuario, string password, int nivel)
        {
            MySqlParameter prmId = new MySqlParameter("@id", MySqlDbType.Int32);
            MySqlParameter prmUsuario = new MySqlParameter("@usuario", MySqlDbType.VarChar);
            MySqlParameter prmPassword = new MySqlParameter("@password", MySqlDbType.VarChar);
            MySqlParameter prmNivel = new MySqlParameter("@nivel", MySqlDbType.Int16);
            prmId.Value = Convert.ToInt32(id);
            prmUsuario.Value = Convert.ToString(usuario);
            prmPassword.Value = Convert.ToString(password);
            prmNivel.Value = Convert.ToInt16(nivel);

            MySqlCommand mycmd = new MySqlCommand("INSERT INTO usuario (id, usuario, password, nivel_acceso) VALUES (@id, @usuario, @password, @nivel) ON DUPLICATE KEY UPDATE usuario = @usuario, password = @password, nivel_acceso = @nivel", procedures.conexion);
            mycmd.Parameters.Add(prmId);
            mycmd.Parameters.Add(prmUsuario);
            mycmd.Parameters.Add(prmPassword);
            mycmd.Parameters.Add(prmNivel);
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

        private void chk_usuario_CheckedChanged(object sender, EventArgs e)
        {
            this.buscar(this.txt_busqueda.Text.Trim());
        }
    }
}
