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
using System.Globalization;

namespace Gestion_Constructora
{
    public partial class chequeTerceroConsulta : Form
    {
        CultureInfo culture = new CultureInfo("en-US");

        public chequeTerceroConsulta()
        {
            InitializeComponent();
            chequeTerceroConsulta chequeTerceroConsulta = this;
            procedures proc = new procedures();
            //                               form                               title                start position              resizable
            proc.inicializarFormulario(chequeTerceroConsulta, "Consulta de Cheques de Terceros", FormStartPosition.CenterScreen, false);
            proc.inicializarGrid(this.dgv_cheque);
        }

        private void chequeTerceroConsulta_Load(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void buscar(string busqueda = null)
        {
            this.dgv_cheque.Rows.Clear();

            /*string query = @"SELECT 
                                chequetercero.id, 
                                banco.nombre, 
                                chequetercero.numero, 
                                chequetercero.importe, 
                                chequetercerotipo.descripcion, 
                                chequetercerodestino.descripcion, 
                                chequetercero.fechaCobro 
                            FROM chequetercero 
                            INNER JOIN 
                                chequetercerodestino 
                            ON (chequetercero.idDestino = chequetercerodestino.id) 
                            INNER JOIN 
                                banco 
                            ON (chequetercero.idBanco = banco.id) 
                            INNER JOIN 
                                chequetercerotipo 
                            ON (chequetercero.idTipo = chequetercerotipo.id)";*/

            string query = "SELECT chequetercero.id, banco.nombre, chequetercero.numero, chequetercero.importe, chequetercerotipo.descripcion, chequetercerodestino.descripcion, chequetercero.fechaCobro FROM chequetercero INNER JOIN chequetercerodestino ON (chequetercero.idDestino = chequetercerodestino.id) INNER JOIN banco ON (chequetercero.idBanco = banco.id) INNER JOIN chequetercerotipo ON (chequetercero.idTipo = chequetercerotipo.id) ";
            MySqlCommand consulta = new MySqlCommand();
            bool hayFiltro = false;

            if (this.chk_cartera.Checked)
            {
                string opcion;
                if (!hayFiltro)
                {
                    opcion = "WHERE ";
                }
                else
                {
                    opcion = "AND ";
                }
                opcion += "chequetercerodestino.descripcion = 'En Cartera' ";
                query += opcion;
                hayFiltro = true;
            }

            if (this.chk_corriente.Checked)
            {
                DateTime fecha = DateTime.Today;
                string fechaHoy = Convert.ToString(fecha.Year) + "-" + Convert.ToString(fecha.Month) + "-" + Convert.ToString(fecha.Day);
                string opcion;
                if (!hayFiltro)
                {
                    opcion = "WHERE ";
                }
                else
                {
                    opcion = "AND ";
                }
                opcion += "@hoy BETWEEN fechaCobro AND DATE_ADD(fechaCobro, INTERVAL 30 DAY) ";
                MySqlParameter prmFechaHoy = new MySqlParameter("@hoy", MySqlDbType.Date);
                prmFechaHoy.Value = fechaHoy;
                consulta.Parameters.Add(prmFechaHoy);
                query += opcion;
                hayFiltro = true;
            }

            if (this.chk_aCobrar.Checked)
            {
                int dias = Convert.ToInt16(this.nud_dias.Value);
                DateTime fecha = DateTime.Today.AddDays(dias);
                string sFecha = Convert.ToString(fecha.Year) + "-" + Convert.ToString(fecha.Month) + "-" + Convert.ToString(fecha.Day);
                string opcion;
                if (!hayFiltro)
                {
                    opcion = "WHERE ";
                }
                else
                {
                    opcion = "AND ";
                }
                opcion += "@fecha >= fechaCobro AND @fecha BETWEEN fechaCobro AND DATE_ADD(fechaCobro, INTERVAL 30 DAY) ";
                MySqlParameter prmFecha = new MySqlParameter("@fecha", MySqlDbType.Date);
                prmFecha.Value = sFecha;
                consulta.Parameters.Add(prmFecha);
                query += opcion;
                hayFiltro = true;
            }

            if (this.chk_vencido.Checked)
            {
                DateTime fecha = DateTime.Today;
                string hoy = Convert.ToString(fecha.Year) + "-" + Convert.ToString(fecha.Month) + "-" + Convert.ToString(fecha.Day);
                string opcion;
                if (!hayFiltro)
                {
                    opcion = "WHERE ";
                }
                else
                {
                    opcion = "AND ";
                }
                opcion += "@hoy >= DATE_ADD(fechaCobro, INTERVAL 30 DAY) ";
                MySqlParameter prmHoy = new MySqlParameter("@hoy", MySqlDbType.Date);
                prmHoy.Value = hoy;
                consulta.Parameters.Add(prmHoy);
                query += opcion;
                hayFiltro = true;
            }

            consulta.Connection = procedures.conexion;
            consulta.CommandText = query;
            
            try
            {
                procedures.conexion.Open();
                MySqlDataReader reader = consulta.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.dgv_cheque.Rows.Add(reader[0], reader[1], reader[2], procedures.stringToCurrencyTextbox(Convert.ToString(reader[3])), reader[4], reader[5], reader[6]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            procedures.conexion.Close();
            this.total();
        }

        private void chk_cartera_CheckedChanged(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void chk_corriente_CheckedChanged(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void chk_aCobrar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_aCobrar.Checked)
            {
                this.nud_dias.Enabled = true;
                this.chk_cartera.Checked = true;
            }
            else
            {
                this.nud_dias.Enabled = false;
                this.buscar();
            }
        }

        private void nud_dias_ValueChanged(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void chk_vencido_CheckedChanged(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void totall()
        {
            double importeTotal = 0;
            string importe = "";
            foreach (DataGridViewRow row in this.dgv_cheque.Rows)
            {
                importe = Convert.ToString(row.Cells["importe"].Value);
                importe = importe.Replace(",", "");
                importe = importe.Replace("$", "");
                importeTotal += Convert.ToDouble(importe, culture);
            }
            this.txt_total.Text = importeTotal.ToString("C", culture);
        }
        private void total()
        {
            double importeTotal = 0;
            string importe = "";
            foreach (DataGridViewRow row in this.dgv_cheque.Rows)
            {
                importe = Convert.ToString(row.Cells["importe"].Value);
                importeTotal += Convert.ToDouble(procedures.stringToCurrencyTextbox(importe));
            }
            this.txt_total.Text = importeTotal.ToString("C", culture);
        }
    }
}
