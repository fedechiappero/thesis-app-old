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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            login login = this;
            procedures proc = new procedures();
            //                 form       title               start position          resizable
            proc.inicializarFormulario(login, "Iniciar Sesion", FormStartPosition.CenterScreen, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = this.txt_usuario.Text.Trim();
            int nivel = 0;
            bool res = this.buscarCredenciales(usuario, this.txt_contraseña.Text.Trim(), ref nivel);
            if (res)
            {
                this.Visible = false;
                inicio inicio = new inicio(usuario, nivel);
                inicio.ShowDialog();
                this.Visible = true;
                this.txt_contraseña.Text = String.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool buscarCredenciales(string usuario, string password, ref int nivel)
        {
            MySqlParameter prmUsuario = new MySqlParameter("@usuario", MySqlDbType.VarChar);
            MySqlParameter prmPassword = new MySqlParameter("@password", MySqlDbType.VarChar);
            prmUsuario.Value = Convert.ToString(usuario);
            prmPassword.Value = Convert.ToString(password);
            MySqlCommand mycmd = new MySqlCommand("SELECT * FROM usuario WHERE usuario = @usuario AND password = @password", procedures.conexion);
            mycmd.Parameters.Add(prmUsuario);
            mycmd.Parameters.Add(prmPassword);
            try
            {
                procedures.conexion.Open();
                MySqlDataReader reader = mycmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if(Convert.ToBoolean(reader[4])){//usuario activo
                        MessageBox.Show("Acceso comprobado, bienvenido al sistema.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        nivel = Convert.ToInt16(reader[3]);
                        procedures.conexion.Close();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("El usuario ingresado se encuentra inactivo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Error\n Credenciales invalidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            procedures.conexion.Close();
            return false;
        }

        private void txt_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)13)
                {
                    this.btn_login.PerformClick();
                }
            }
        }

        private void autoLogin()
        {
            this.txt_usuario.Text = "admin";
            this.txt_contraseña.Text = "admin";
            this.btn_login.PerformClick();
        }

        private void login_Load(object sender, EventArgs e)
        {
            this.autoLogin();
        }
    }
}
