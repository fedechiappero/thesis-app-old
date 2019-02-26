using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Constructora
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            login login = this;
            procedures proc = new procedures();
            //                 form    title          start position          resizable
            proc.initilizeForm(login, "Login", FormStartPosition.CenterScreen, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            inicio inicio = new inicio();
            inicio.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
