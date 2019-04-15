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
    public partial class contrato : Form
    {
        public static int idPersona;
        public static string nombrePersona;

        //para saber en que estado se encuentran los controles del formulario (0=inicio, 1=nuevo, 2=editar, 3=eliminar)
        private int estadoControles = 0;

        public contrato()
        {
            InitializeComponent();
            contrato contrato = this;
            procedures proc = new procedures();
            //                         form                  title             start position            resizable
            proc.inicializarFormulario(contrato, "ABM de Contrato", FormStartPosition.CenterScreen, false);
            proc.inicializarGrid(this.dgv_contrato);
        }

        private void btn_busquedaPersona_Click(object sender, EventArgs e)
        {
            personaBusquedaRapida personaBusquedaRapida = new personaBusquedaRapida();
            personaBusquedaRapida.FormClosing += new FormClosingEventHandler(busquedaPersonaCerrando);
            personaBusquedaRapida.ShowDialog();
        }

        private void busquedaPersonaCerrando(object sender, FormClosingEventArgs e)
        {
            idPersona = Convert.ToInt32(((personaBusquedaRapida)sender).idPersona);
            nombrePersona = ((personaBusquedaRapida)sender).nombrePersona;
            this.txt_persona.Text = nombrePersona;
        }

        private void contrato_Load(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            this.cambiarControles(1);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (this.dgv_contrato.SelectedRows.Count > 0)
            {
                
                this.cambiarControles(2);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un contrato para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (this.dgv_contrato.SelectedRows.Count > 0)
            {
                this.cargarControles(this.dgv_contrato);
                this.cambiarControles(3);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un contrato para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cambiarControles(int estado)
        {
            switch (estado)
            {
                case 0://inicio
                    this.buscar();
                    this.pnl_datos.Enabled = false;
                    idPersona = 0;
                    this.txt_persona.Text = String.Empty;
                    this.txt_numero.Text = String.Empty;
                    this.txt_arquitectoMatricula.Text = String.Empty;
                    this.txt_arquitectoNombre.Text = String.Empty;
                    this.txt_arquitectoDomicilio.Text = String.Empty;
                    this.btn_aceptar.ForeColor = Color.Black;
                    this.btn_nuevo.Enabled = true;
                    this.btn_editar.Enabled = true;
                    this.btn_eliminar.Enabled = true;
                    break;
                case 1://nuevo
                    this.pnl_datos.Enabled = true;
                    idPersona = 0;
                    this.txt_persona.Text = String.Empty;
                    this.txt_numero.Text = String.Empty;
                    this.txt_arquitectoMatricula.Text = String.Empty;
                    this.txt_arquitectoNombre.Text = String.Empty;
                    this.txt_arquitectoDomicilio.Text = String.Empty;
                    this.txt_numero.Focus();
                    this.btn_nuevo.Enabled = false;
                    this.btn_editar.Enabled = false;
                    this.btn_eliminar.Enabled = false;
                    break;
                case 2://editar
                    this.pnl_datos.Enabled = true;
                    this.txt_numero.Focus();
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
            idPersona = Convert.ToInt32(dgv.CurrentRow.Cells[1].Value);
            this.txt_persona.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
            this.txt_numero.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            this.txt_arquitectoMatricula.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
            this.txt_arquitectoNombre.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
            this.txt_arquitectoDomicilio.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
        }

        private void dgv_contrato_SelectionChanged(object sender, EventArgs e)
        {
            this.cargarControles(this.dgv_contrato);
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            switch (estadoControles)
            {
                case 1:
                    this.insertar(idPersona, Convert.ToInt32(this.txt_numero.Text.Trim()), this.txt_arquitectoNombre.Text.Trim(), this.txt_arquitectoMatricula.Text.Trim(), this.txt_arquitectoDomicilio.Text.Trim());
                    break;
                case 2:
                    this.actualizar(Convert.ToInt32(this.dgv_contrato.CurrentRow.Cells[0].Value), idPersona, Convert.ToInt32(this.txt_numero.Text.Trim()), this.txt_arquitectoNombre.Text.Trim(), this.txt_arquitectoMatricula.Text.Trim(), this.txt_arquitectoDomicilio.Text.Trim());
                    break;
                case 3:
                    this.eliminar(Convert.ToInt32(this.dgv_contrato.CurrentRow.Cells[0].Value));
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
            this.dgv_contrato.Rows.Clear();

            MySqlCommand consulta = new MySqlCommand("SELECT contrato.id, contrato.idPersona, persona.nombre, contrato.numero, contrato.arquitectoNombre, contrato.arquitectoMatricula, contrato.arquitectoDomicilio FROM contrato INNER JOIN persona ON (contrato.idPersona = persona.id) WHERE persona.nombre LIKE @nombre AND contrato.activo = 1", procedures.conexion);
            consulta.Parameters.AddWithValue("@nombre", "%" + Convert.ToString(busqueda) + "%");
            try
            {
                procedures.conexion.Open();
                MySqlDataReader reader = consulta.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.dgv_contrato.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            procedures.conexion.Close();
        }

        private void insertar(int idPersona, int numero, string arquitectoNombre, string arquitectoMatricula, string arquitectoDomicilio)
        {
            MySqlParameter prmIdPersona = new MySqlParameter("@idPersona", MySqlDbType.Int32);
            MySqlParameter prmNumero = new MySqlParameter("@numero", MySqlDbType.Int32);
            MySqlParameter prmArquitectoNombre = new MySqlParameter("@arquitectoNombre", MySqlDbType.VarChar);
            MySqlParameter prmArquitectoMatricula = new MySqlParameter("@arquitectoMatricula", MySqlDbType.VarChar);
            MySqlParameter prmArquitectoDomicilio = new MySqlParameter("@arquitectoDomicilio", MySqlDbType.VarChar);
            prmIdPersona.Value = Convert.ToInt32(idPersona);
            prmNumero.Value = Convert.ToInt32(numero);
            prmArquitectoNombre.Value = Convert.ToString(arquitectoNombre);
            prmArquitectoMatricula.Value = Convert.ToString(arquitectoMatricula);
            prmArquitectoDomicilio.Value = Convert.ToString(arquitectoDomicilio);
            MySqlCommand mycmd = new MySqlCommand("INSERT INTO contrato (idPersona, numero, arquitectoNombre, arquitectoMatricula, arquitectoDomicilio) VALUES (@idPersona, @numero, @arquitectoNombre, @arquitectoMatricula, @arquitectoDomicilio)", procedures.conexion);
            mycmd.Parameters.Add(prmIdPersona);
            mycmd.Parameters.Add(prmNumero);
            mycmd.Parameters.Add(prmArquitectoNombre);
            mycmd.Parameters.Add(prmArquitectoMatricula);
            mycmd.Parameters.Add(prmArquitectoDomicilio);
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

        private void actualizar(int id, int idPersona, int numero, string arquitectoNombre, string arquitectoMatricula, string arquitectoDomicilio)
        {
            MySqlParameter prmId = new MySqlParameter("@id", MySqlDbType.Int32);
            MySqlParameter prmIdPersona = new MySqlParameter("@idPersona", MySqlDbType.Int32);
            MySqlParameter prmNumero = new MySqlParameter("@numero", MySqlDbType.Int32);
            MySqlParameter prmArquitectoNombre = new MySqlParameter("@arquitectoNombre", MySqlDbType.VarChar);
            MySqlParameter prmArquitectoMatricula = new MySqlParameter("@arquitectoMatricula", MySqlDbType.VarChar);
            MySqlParameter prmArquitectoDomicilio = new MySqlParameter("@arquitectoDomicilio", MySqlDbType.VarChar);
            prmId.Value = Convert.ToInt32(id);
            prmIdPersona.Value = Convert.ToInt32(idPersona);
            prmNumero.Value = Convert.ToInt32(numero);
            prmArquitectoNombre.Value = Convert.ToString(arquitectoNombre);
            prmArquitectoMatricula.Value = Convert.ToString(arquitectoMatricula);
            prmArquitectoDomicilio.Value = Convert.ToString(arquitectoDomicilio);
            MySqlCommand mycmd = new MySqlCommand("UPDATE contrato SET idPersona = @idPersona, numero = @numero, arquitectoNombre = @arquitectoNombre, arquitectoMatricula = @arquitectoMatricula, arquitectoDomicilio = @arquitectoDomicilio WHERE id = @id", procedures.conexion);
            mycmd.Parameters.Add(prmId);
            mycmd.Parameters.Add(prmIdPersona);
            mycmd.Parameters.Add(prmNumero);
            mycmd.Parameters.Add(prmArquitectoNombre);
            mycmd.Parameters.Add(prmArquitectoMatricula);
            mycmd.Parameters.Add(prmArquitectoDomicilio);
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
            MySqlCommand mycmd = new MySqlCommand("UPDATE contrato SET activo = 0 WHERE id = @id", procedures.conexion);
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
