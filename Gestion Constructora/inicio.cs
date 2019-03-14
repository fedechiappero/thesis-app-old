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
    public partial class inicio : Form
    {
        public inicio(string usuario, int nivel)
        {
            InitializeComponent();
            inicio inicio = this;
            procedures proc = new procedures();
            //                   form         title                                                start position               resizable
            proc.inicializarFormulario(inicio, usuario + " | Nivel de acceso " + Convert.ToString(nivel), FormStartPosition.CenterScreen, false);
        }

        private void aBMSitioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sitio sitio = new sitio();
            sitio.ShowDialog();
        }

        private void aBMDeTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tarea tarea = new tarea();
            tarea.ShowDialog();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void aBMDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuario usuario = new usuario();
            usuario.ShowDialog();
        }

        private void aBMDeBancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banco banco = new banco();
            banco.ShowDialog();
        }

        private void altaDeCuentasPropiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bancoCuenta bancoCuenta = new bancoCuenta();
            bancoCuenta.ShowDialog();
        }

        private void altaDeChequerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chequera chequera = new chequera();
            chequera.ShowDialog();
        }

        private void emisionDeChequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chequeEmision chequeEmision = new chequeEmision();
            chequeEmision.ShowDialog();
        }

        private void aBMDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuenta cuenta = new cuenta();
            cuenta.ShowDialog();
        }

        private void aBMDeRubrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rubro rubro = new rubro();
            rubro.ShowDialog();
        }

        private void aBMDeDestinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chequeTerceroDestino chequeTerceroDestino = new chequeTerceroDestino();
            chequeTerceroDestino.ShowDialog();
        }

        private void aBMDeTiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chequeTerceroTipo chequeTerceroTipo = new chequeTerceroTipo();
            chequeTerceroTipo.ShowDialog();
        }

        private void aBMDeChequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chequeTercero chequeTercero = new chequeTercero();
            chequeTercero.ShowDialog();
        }
    }
}
