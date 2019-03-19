﻿using System;
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
    public partial class documentoTipo : Form
    {
        //para saber en que estado se encuentran los controles del formulario (0=inicio, 1=nuevo, 2=editar, 3=eliminar)
        private int estadoControles = 0;

        public documentoTipo()
        {
            InitializeComponent();
            documentoTipo documentoTipo = this;
            procedures proc = new procedures();
            //                               form         title                         start position          resizable
            proc.inicializarFormulario(documentoTipo, "ABM de Tipos de Documento", FormStartPosition.CenterScreen, false);
            proc.inicializarGrid(this.dgv_tipo);
        }

        private void documentoTipo_Load(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            this.cambiarControles(1);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (this.dgv_tipo.SelectedRows.Count > 0)
            {
                this.cargarControles(this.dgv_tipo);
                this.cambiarControles(2);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de documento para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (this.dgv_tipo.SelectedRows.Count > 0)
            {
                this.cambiarControles(3);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de documento para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    this.txt_descripcion.Text = String.Empty;
                    this.txt_codigo.Text = String.Empty;
                    this.btn_nuevo.Enabled = false;
                    this.btn_editar.Enabled = false;
                    this.btn_eliminar.Enabled = false;
                    break;
                case 2://editar
                    this.pnl_datos.Enabled = true;
                    this.txt_descripcion.Focus();
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
            this.txt_descripcion.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            this.txt_codigo.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
        }

        private void dgv_tipo_SelectionChanged(object sender, EventArgs e)
        {
            this.cargarControles(this.dgv_tipo);
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            switch (estadoControles)
            {
                case 1:
                    this.insertar(this.txt_descripcion.Text.Trim(), this.txt_codigo.Text.Trim());
                    break;
                case 2:
                    this.actualizar(Convert.ToInt32(this.dgv_tipo.CurrentRow.Cells[0].Value), this.txt_descripcion.Text.Trim(), this.txt_codigo.Text.Trim());
                    break;
                case 3:
                    this.eliminar(Convert.ToInt32(this.dgv_tipo.CurrentRow.Cells[0].Value));
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
            this.dgv_tipo.Rows.Clear();

            MySqlCommand consulta = new MySqlCommand("SELECT * FROM documentotipo WHERE descripcion LIKE @descripcion AND activo = 1", procedures.conexion);
            consulta.Parameters.AddWithValue("@descripcion", "%" + Convert.ToString(busqueda) + "%");
            try
            {
                procedures.conexion.Open();
                MySqlDataReader reader = consulta.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.dgv_tipo.Rows.Add(reader[0], reader[1], reader[2], reader[3]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            procedures.conexion.Close();
        }

        private void insertar(string descripcion, string codigo)
        {
            MySqlParameter prmDescripcion = new MySqlParameter("@descripcion", MySqlDbType.VarChar);
            MySqlParameter prmCodigo = new MySqlParameter("@codigo", MySqlDbType.VarChar);
            prmDescripcion.Value = Convert.ToString(descripcion);
            prmCodigo.Value = Convert.ToString(codigo);
            MySqlCommand mycmd = new MySqlCommand("INSERT INTO documentotipo (descripcion, codigo) VALUES (@descripcion, @codigo)", procedures.conexion);
            mycmd.Parameters.Add(prmDescripcion);
            mycmd.Parameters.Add(prmCodigo);
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

        private void actualizar(int id, string descripcion, string codigo)
        {
            MySqlParameter prmId = new MySqlParameter("@id", MySqlDbType.Int32);
            MySqlParameter prmDescripcion = new MySqlParameter("@descripcion", MySqlDbType.VarChar);
            MySqlParameter prmCodigo = new MySqlParameter("@codigo", MySqlDbType.VarChar);
            prmId.Value = Convert.ToInt32(id);
            prmDescripcion.Value = Convert.ToString(descripcion);
            prmCodigo.Value = Convert.ToString(codigo);
            MySqlCommand mycmd = new MySqlCommand("UPDATE documentotipo SET descripcion = @descripcion, codigo = @codigo WHERE id = @id", procedures.conexion);
            mycmd.Parameters.Add(prmId);
            mycmd.Parameters.Add(prmDescripcion);
            mycmd.Parameters.Add(prmCodigo);
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
            MySqlCommand mycmd = new MySqlCommand("UPDATE documentotipo SET activo = 0 WHERE id = @id", procedures.conexion);
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
