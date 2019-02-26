﻿using System;
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
        public inicio()
        {
            InitializeComponent();
            inicio inicio = this;
            procedures proc = new procedures();
            //                   form         title           start position               resizable
            proc.initilizeForm(inicio, "Inicio", FormStartPosition.CenterScreen, false);
        }

        private void aBMSitioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sitio sitio = new sitio();
            sitio.ShowDialog();
        }
    }
}