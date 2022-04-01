using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BioPosto
{
    public partial class mmCadastro : UserControl
    {
        public mmCadastro()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmPesqBio frm = new frmPesqBio();
            frm.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmClienteLocalizar frm = new frmClienteLocalizar();
            frm.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmImportarDados frm = new frmImportarDados();
            frm.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmCaixa frm = new frmCaixa();
            frm.ShowDialog();
        }
    }
}
