using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Org.Mentalis.Files;
using System.IO;

namespace BioPosto
{
    public partial class frmMain : Form
    {

        mmCadastro mnCadastro = new mmCadastro();
        mmAjuda mnAjuda = new mmAjuda();

        public frmMain()
        {

            InitializeComponent();
            //chama o form splash
            frmSplash frmSplash = new frmSplash();
            frmSplash.ShowDialog();
        }

        public void menuPrincipal(string menu)
        {
            //estica para a area toda
            mnAjuda.Dock = DockStyle.Fill;
            mnCadastro.Dock = DockStyle.Fill;

            //remove o painel que estiver aberto para adicionar o novo
            BarraFerramentasPainel.Panel2.Controls.Remove(mnAjuda);
            BarraFerramentasPainel.Panel2.Controls.Remove(mnCadastro);

            //limpa os botão selecionado
            btnCadastros.Checked = false;
            btnAjuda.Checked = false;


            switch (menu)
            {
                case "cadastro":
                    {
                        BarraFerramentasPainel.Panel2.Controls.Add(mnCadastro);
                        btnCadastros.Checked = true;
                        break;
                    }
                case "ajuda":
                    {
                        BarraFerramentasPainel.Panel2.Controls.Add(mnAjuda);
                        btnAjuda.Checked = true;
                        break;
                    }
            }
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            menuPrincipal("cadastro");
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            menuPrincipal("ajuda");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string file = "";
            string server = "";
            string bd = "";
            file = Application.StartupPath;
            file += "\\conf.ini";
            IniReader ini = new IniReader(file);
            server = ini.ReadString("ALSoftware", "server");
            bd = ini.ReadString("ALSoftware", "banco");

            //Coloca a versão do programa na Barra
            sbLabel001.Text = "Versão " + Application.ProductVersion;
            sbLabel002.Text = "Servidor [" + server + "] - Banco [" + bd + "]";
            sbLabel004.Text = DateTime.Now.ToLongDateString();
            this.Text = "TopCard System - BioPosto Controle Biometrico de Combustivel - Versão: " + Application.ProductVersion;
            menuPrincipal("cadastro");
        }
    }
}
