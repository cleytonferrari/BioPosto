using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace BioPosto
{
    public partial class frmImportarDados : Form
    {
        public frmImportarDados()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCaminho_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivo XML|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblCaminho.Text = ofd.FileName;

            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            int cont = 0;
            clsCliente clsCliente = new clsCliente();

            if (lblCaminho.Text != "")
            {
                XmlTextReader x = new XmlTextReader(lblCaminho.Text);
                while (x.Read())
                {
                    cont++;
                }
                x.Close();
                pbar.Minimum = 0;
                pbar.Maximum = cont;
                //
                XmlTextReader xmltr = new XmlTextReader(lblCaminho.Text);

                while (xmltr.Read())
                {
                    pbar.Increment(1);
                    switch (xmltr.NodeType) //Verifica o tipo de nó
                    {

                        case (XmlNodeType.Text):
                            {                               
                                string[] campos = xmltr.Value.Split('#');
                                if (clsCliente.ExisteCliente(int.Parse(campos[0])))
                                    clsCliente.InserirCliente(campos[1].ToString());
                                else
                                    clsCliente.InserirCliente(campos[2].ToString());
                                break;
                            }
                    }
                }
                xmltr.Close();
                MessageBox.Show("Dados Importados com Sucesso!", Application.ProductName,
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecione o Arquivo para a Importação!\nAntes de tentar Importar os Dados", Application.ProductName,
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
