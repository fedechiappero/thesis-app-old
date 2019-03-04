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
    public partial class banco : Form
    {
        //para saber en que estado se encuentran los controles del formulario (0=inicio, 1=nuevo, 2=editar, 3=eliminar)
        private int controllsStatus = 0;

        public banco()
        {
            InitializeComponent();
            banco banco = this;
            procedures proc = new procedures();
            //                 form         title           start position            resizable
            proc.initilizeForm(banco, "ABM de Bancos", FormStartPosition.CenterScreen, false);
            proc.initializeGrid(this.dgv_banco);
        }

        private void banco_Load(object sender, EventArgs e)
        {
            buscar();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            changeControlls(1);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dgv_banco.SelectedRows.Count > 0)
            {
                this.txt_banco.Text = Convert.ToString(dgv_banco.CurrentRow.Cells[1].Value);
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
                    this.pnl_banco.Enabled = false;
                    this.btn_aceptar.ForeColor = Color.Black;
                    this.btn_nuevo.Enabled = true;
                    this.btn_editar.Enabled = true;
                    this.btn_eliminar.Enabled = true;
                    break;
                case 1://nuevo
                    this.pnl_banco.Enabled = true;
                    this.txt_banco.Text = String.Empty;
                    this.txt_banco.Focus();
                    this.btn_nuevo.Enabled = false;
                    this.btn_editar.Enabled = false;
                    this.btn_eliminar.Enabled = false;
                    break;
                case 2://editar
                    this.pnl_banco.Enabled = true;
                    this.txt_banco.Focus();
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

        private void dgv_banco_SelectionChanged(object sender, EventArgs e)
        {
            this.txt_banco.Text = Convert.ToString(this.dgv_banco.CurrentRow.Cells[1].Value);
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            switch (controllsStatus)
            {
                case 1:
                    insertar(this.txt_banco.Text.Trim());
                    break;
                case 2:
                    actualizar(Convert.ToInt32(this.dgv_banco.CurrentRow.Cells[0].Value), this.txt_banco.Text);
                    break;
                case 3:
                    eliminar(Convert.ToInt32(this.dgv_banco.CurrentRow.Cells[0].Value));
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
            dgv_banco.Rows.Clear();

            MySqlParameter prmBusqueda = new MySqlParameter("@nombre", MySqlDbType.VarChar);
            MySqlCommand consulta = new MySqlCommand("SELECT * FROM banco WHERE nombre LIKE @nombre AND activo = 1", procedures.conexion);
            consulta.Parameters.AddWithValue("@nombre", "%" + Convert.ToString(busqueda) + "%");
            try
            {
                procedures.conexion.Open();
                MySqlDataReader reader = consulta.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dgv_banco.Rows.Add(reader[0], reader[1]);
                    }
                }
                procedures.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertar(string nombre)
        {
            MySqlParameter prmDescripcion = new MySqlParameter("@nombre", MySqlDbType.VarChar);
            prmDescripcion.Value = Convert.ToString(nombre);
            MySqlCommand mycmd = new MySqlCommand("INSERT INTO banco (nombre) VALUES (@nombre)", procedures.conexion);
            mycmd.Parameters.Add(prmDescripcion);
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

        private void actualizar(int id, string nombre)
        {
            MySqlParameter prmId = new MySqlParameter("@id", MySqlDbType.Int32);
            MySqlParameter prmDescripcion = new MySqlParameter("@nombre", MySqlDbType.VarChar);
            prmId.Value = Convert.ToInt32(id);
            prmDescripcion.Value = Convert.ToString(nombre);
            MySqlCommand mycmd = new MySqlCommand("UPDATE banco SET nombre = @nombre WHERE id = @id", procedures.conexion);
            mycmd.Parameters.Add(prmId);
            mycmd.Parameters.Add(prmDescripcion);
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

        private void eliminar(int id)
        {
            MySqlParameter prmId = new MySqlParameter("@id", MySqlDbType.Int32);
            prmId.Value = Convert.ToInt32(id);
            MySqlCommand mycmd = new MySqlCommand("UPDATE banco SET activo = 0 WHERE id = @id", procedures.conexion);
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
