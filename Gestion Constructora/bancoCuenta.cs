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
    public partial class bancoCuenta : Form
    {
        //para saber en que estado se encuentran los controles del formulario (0=inicio, 1=nuevo, 2=editar, 3=eliminar)
        private int estadoControles = 0;

        public bancoCuenta()
        {
            InitializeComponent();
            bancoCuenta bancoCuenta = this;
            procedures proc = new procedures();
            //                     form               title               start position            resizable
            proc.inicializarFormulario(bancoCuenta, "ABM de Cuentas de Banco", FormStartPosition.CenterScreen, false);
            proc.inicializarGrid(this.dgv_banco);
            proc.inicializarGrid(this.dgv_cuenta);
        }

        private void bancoCuenta_Load(object sender, EventArgs e)
        {
            this.buscarBanco();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            this.cambiarControles(1);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (this.dgv_cuenta.SelectedRows.Count > 0)
            {
                this.cargarControles(dgv_banco, dgv_cuenta);
                this.cambiarControles(2);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una cuenta para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (this.dgv_cuenta.SelectedRows.Count > 0)
            {
                this.cambiarControles(3);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una cuenta para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void cambiarControles(int estado)
        {
            switch (estado)
            {
                case 0://inicio
                    this.buscarBanco();
                    this.pnl_datos.Enabled = false;
                    this.btn_aceptar.ForeColor = Color.Black;
                    this.btn_nuevo.Enabled = true;
                    this.btn_editar.Enabled = true;
                    this.btn_eliminar.Enabled = true;
                    break;
                case 1://nuevo
                    this.pnl_datos.Enabled = true;
                    this.cbo_tipo.SelectedIndex = 0;
                    this.txt_cbu.Text = String.Empty;
                    this.txt_numero.Text = String.Empty;
                    this.txt_cbu.Focus();
                    this.btn_nuevo.Enabled = false;
                    this.btn_editar.Enabled = false;
                    this.btn_eliminar.Enabled = false;
                    break;
                case 2://editar
                    this.pnl_datos.Enabled = true;
                    this.txt_cbu.Focus();
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

        private void dgv_banco_SelectionChanged(object sender, EventArgs e)
        {
            //this.txt_banco.Text = Convert.ToString(this.dgv_banco.CurrentRow.Cells[1].Value);
            this.buscarCuenta(Convert.ToInt32(this.dgv_banco.CurrentRow.Cells[0].Value));
            this.cargarControles(this.dgv_banco, this.dgv_cuenta);
        }

        private void cargarControles(DataGridView banco, DataGridView cuenta)
        {
            this.txt_banco.Text = Convert.ToString(banco.CurrentRow.Cells[1].Value);
            if (cuenta.SelectedRows.Count > 0)
            {
                this.cbo_tipo.SelectedItem = Convert.ToString(cuenta.CurrentRow.Cells[2].Value);
                this.txt_cbu.Text = Convert.ToString(cuenta.CurrentRow.Cells[4].Value);
                this.txt_numero.Text = Convert.ToString(cuenta.CurrentRow.Cells[3].Value);
                this.chk_activa.Checked = Convert.ToBoolean(cuenta.CurrentRow.Cells[5].Value);
            }
            else
            {
                this.cbo_tipo.SelectedIndex = 0;
                this.txt_cbu.Text = String.Empty;
                this.txt_numero.Text = String.Empty;
                this.chk_activa.Checked = true;
            }
            
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            switch (estadoControles)
            {
                case 1:
                    this.insertar(Convert.ToInt32(this.dgv_banco.CurrentRow.Cells[0].Value), Convert.ToString(this.cbo_tipo.SelectedItem), this.txt_numero.Text, this.txt_cbu.Text, this.chk_activa.Checked);
                    break;
                case 2:
                    this.actualizar(Convert.ToInt32(this.dgv_cuenta.CurrentRow.Cells[0].Value), Convert.ToInt32(this.dgv_banco.CurrentRow.Cells[0].Value), Convert.ToString(this.cbo_tipo.SelectedItem), this.txt_numero.Text, this.txt_cbu.Text, this.chk_activa.Checked);
                    break;
                case 3:
                    this.eliminar(Convert.ToInt32(this.dgv_cuenta.CurrentRow.Cells[0].Value));
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

        private void buscarBanco(string busqueda = null)
        {
            this.dgv_banco.Rows.Clear();

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
                        this.dgv_banco.Rows.Add(reader[0], reader[1]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            procedures.conexion.Close();
        }

        private void buscarCuenta(int idBanco)
        {
            this.dgv_cuenta.Rows.Clear();

            MySqlParameter prmBusqueda = new MySqlParameter("@id", MySqlDbType.VarChar);
            prmBusqueda.Value = Convert.ToInt32(idBanco);
            MySqlCommand consulta = new MySqlCommand("SELECT * FROM bancoCuenta WHERE idBanco = @id", procedures.conexion2);
            consulta.Parameters.Add(prmBusqueda);
            try
            {
                procedures.conexion2.Open();
                MySqlDataReader reader = consulta.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.dgv_cuenta.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            procedures.conexion2.Close();
        }

        private void insertar(int idBanco, string tipo, string numero, string cbu, bool activa)
        {
            MySqlParameter prmIdBanco = new MySqlParameter("@idBanco", MySqlDbType.Int32);
            MySqlParameter prmTipo = new MySqlParameter("@tipo", MySqlDbType.VarChar);
            MySqlParameter prmNumero = new MySqlParameter("@numero", MySqlDbType.VarChar);
            MySqlParameter prmCbu = new MySqlParameter("@cbu", MySqlDbType.VarChar);
            MySqlParameter prmActiva = new MySqlParameter("@activa", MySqlDbType.Int16);
            prmIdBanco.Value = Convert.ToString(idBanco);
            prmTipo.Value = Convert.ToString(tipo);
            prmNumero.Value = Convert.ToString(numero);
            prmCbu.Value = Convert.ToString(cbu);
            prmActiva.Value = Convert.ToInt16(activa);
            MySqlCommand mycmd = new MySqlCommand("INSERT INTO bancoCuenta (idBanco, tipo, numero, cbu, activa) VALUES (@idBanco, @tipo, @numero, @cbu, @activa)", procedures.conexion);
            mycmd.Parameters.Add(prmIdBanco);
            mycmd.Parameters.Add(prmTipo);
            mycmd.Parameters.Add(prmNumero);
            mycmd.Parameters.Add(prmCbu);
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

        private void actualizar(int id, int idBanco, string tipo, string numero, string cbu, bool activa)
        {
            MySqlParameter prmId = new MySqlParameter("@id", MySqlDbType.Int32);
            MySqlParameter prmIdBanco = new MySqlParameter("@idBanco", MySqlDbType.Int32);
            MySqlParameter prmTipo = new MySqlParameter("@tipo", MySqlDbType.VarChar);
            MySqlParameter prmNumero = new MySqlParameter("@numero", MySqlDbType.VarChar);
            MySqlParameter prmCbu = new MySqlParameter("@cbu", MySqlDbType.VarChar);
            MySqlParameter prmActiva = new MySqlParameter("@activa", MySqlDbType.Int16);
            prmId.Value = Convert.ToInt32(id);
            prmIdBanco.Value = Convert.ToString(idBanco);
            prmTipo.Value = Convert.ToString(tipo);
            prmNumero.Value = Convert.ToString(numero);
            prmCbu.Value = Convert.ToString(cbu);
            prmActiva.Value = Convert.ToInt16(activa);
            MySqlCommand mycmd = new MySqlCommand("UPDATE bancoCuenta SET idBanco = @idBanco, tipo = @tipo, numero = @numero, cbu = @cbu, activa = @activa WHERE id = @id", procedures.conexion);
            mycmd.Parameters.Add(prmId);
            mycmd.Parameters.Add(prmIdBanco);
            mycmd.Parameters.Add(prmTipo);
            mycmd.Parameters.Add(prmNumero);
            mycmd.Parameters.Add(prmCbu);
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
            MySqlCommand mycmd = new MySqlCommand("UPDATE bancoCuenta SET activa = 0 WHERE id = @id", procedures.conexion);
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
            this.buscarBanco(this.txt_busqueda.Text.Trim());
        }

        private void dgv_cuenta_SelectionChanged(object sender, EventArgs e)
        {
            this.cargarControles(this.dgv_banco, this.dgv_cuenta);
        }
    }
}
