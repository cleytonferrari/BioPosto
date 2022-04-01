using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BioPosto
{
    public partial class frmClienteLocalizar : Form
    {
        public frmClienteLocalizar()
        {
            InitializeComponent();
        }
        private void CarregarGrid()
        {
            string strCampo = "";
            string strTipo = "";
            clsCliente clsProprietario = new clsCliente();
            switch (lbPesq.Text)
            {
                case "Cidade": strCampo = "municipio.nome";
                    break;
                case "Logradouro": strCampo = "enderecos.logradouro";
                    break;
                case "Mãe": strCampo = "cliente.mae";
                    break;
                case "Nome": strCampo = "cliente.nome";
                    break;
                case "RG": strCampo = "cliente.rg";
                    break;
                case "CPF": strCampo = "cliente.cpf";
                    break;
                case "Código": strCampo = "cliente.cliente_id";
                    break;
                default: strCampo = "cliente.nome";
                    break;
            }
            if (rbQualquer.Checked)
                strTipo = "qualquer";
            if (rbComecar.Checked)
                strTipo = "comecar";
            if (rbExato.Checked)
                strTipo = "exato";
            dgdGrid.DataSource = clsProprietario.ListarComParametro(strCampo, txtDescricao.Text, strTipo).Tables[0];
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void frmClienteLocalizar_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            lbPesq.Text = lbPesq.Items[4].ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmCadBio frm = new frmCadBio();
            frm.codSelecionado = dgdGrid.CurrentRow.Cells[0].Value.ToString();
            frm.nomeSelecionado = dgdGrid.CurrentRow.Cells[1].Value.ToString();
            frm.ShowDialog();
        }

        private void dgdGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnExcluir.PerformClick();
        }

    }
}
