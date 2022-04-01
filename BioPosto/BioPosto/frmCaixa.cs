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
    public partial class frmCaixa : Form
    {
        public frmCaixa()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txt03.Text.Equals(string.Empty))
            {
                errErro.SetError(txt03, "Informe o Valor R$ do combustivel.Ex.: 2,78");
                return;
            }
            else
            {
                errErro.SetError(txt03, "");
            }

            clsCombustivel clsCombustivel = new clsCombustivel();
            string strData1, strData2, strValor = "";

            strData1 = DateTime.Parse(txt01.Text).ToString("MM/dd/yyy");
            strData2 = DateTime.Parse(txt02.Text).ToString("MM/dd/yyy");

            strValor = double.Parse(txt03.Text).ToString().Replace(",", ".");

            dgdGrid.DataSource = clsCombustivel.Relatorio(strData1, strData2, strValor).Tables[0];

            DataSet oDs = new DataSet();
            oDs = clsCombustivel.RelatorioTotais(strData1, strData2, strValor);
            DataRow oDR = oDs.Tables[0].Rows[0];
            txt04.Text = oDR["total"].ToString();
            txt05.Text = oDR["valor"].ToString();
        }

        private void txt03_Leave(object sender, EventArgs e)
        {
            try
            {
                txt03.Text = String.Format("{0:N}", Convert.ToDecimal(txt03.Text));
            }
            catch
            {
                txt03.Text = "0,00";
            }
        }

        private void txt03_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt05_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt05.Text = String.Format("{0:N}", Convert.ToDecimal(txt05.Text));
            }
            catch
            {
                txt05.Text = "0,00";
            }
        }

        private void txt04_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt04.Text = String.Format("{0:N}", Convert.ToDecimal(txt04.Text));
            }
            catch
            {
                txt04.Text = "0,00";
            }
        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            
        }
    }
}
