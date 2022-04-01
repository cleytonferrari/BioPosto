using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrFingerXLib;

namespace BioPosto
{
    public partial class frmPesqBio : Form
    {
        public frmPesqBio()
        {
            InitializeComponent();
        }
        private Util myUtil;


        private void frmMain_Load(object sender, EventArgs e)
        {
            int err;

            // initialize util class
            myUtil = new Util(lbLog, pbImg);

            // Initialize the GrFingerX Library
            err = myUtil.InitializeGrFinger(axGrFingerXCtrl1);
            // print the result in the log
            if (err < 0)
            {
                myUtil.WriteError((GRConstants)err);
            }
            else
            {
                myUtil.WriteLog("**Sistema Inicializado**");
            } 
            //
            txt03.Text = DateTime.Now.ToString("dd/MM/yyy");
        }

        private void axGrFingerXCtrl1_ImageAcquired(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_ImageAcquiredEvent e)
        {
            // Copying aquired image
            myUtil._raw.img = e.rawImage;
            myUtil._raw.height = (int)e.height;
            myUtil._raw.width = (int)e.width;
            myUtil._raw.Res = e.res;

            // Signaling that an Image Event occurred.
            myUtil.WriteLog("Sensor: " + e.idSensor + ". Imagem Capturada.");
            try
            {
                // display fingerprint image
                myUtil.PrintBiometricDisplay(false, GRConstants.GR_DEFAULT_CONTEXT);
            }
            catch (Exception ex)
            {
                myUtil.WriteLog(ex.Message);
            }
            Extrair();
            //Automatico
            //btnIdentificar.PerformClick();
            
            int id = Reconhecer();
            if (id != -1)
            {
                clsCliente clsCliente = new clsCliente();
                DataSet oDs = new DataSet();
                oDs = clsCliente.ListarCliente(id);
                DataRow oDR = oDs.Tables[0].Rows[0];
                txt01.Text = oDR["cliente_id"].ToString();
                txt02.Text = oDR["nome"].ToString();
                lblStatus.Text = oDR["status"].ToString();
                //pbIcone.Image = BioPosto.Properties.Resources.iconeLupa;
                //pbIcone.Image = BioPosto.Properties.Resources.iconeHMerro;
                //pbIcone.Image = BioPosto.Properties.Resources.iconeMulher;
                //pbIcone.Image = BioPosto.Properties.Resources.iconeHomem;
                if (lblStatus.Text == "ATIVADO")
                {
                    lblStatus.ForeColor = Color.Green;
                    if (oDR["sexo"].ToString() == "MASCULINO")
                    {
                        pbIcone.Image = BioPosto.Properties.Resources.iconeHomem;
                    }
                    else
                    {
                        pbIcone.Image = BioPosto.Properties.Resources.iconeMulher;
                    }
                }
                else
                {
                    lblStatus.ForeColor = Color.Red;
                    pbIcone.Image = BioPosto.Properties.Resources.iconeHMerro;
                }
            }
            else
            {
                //não achou
                txt01.Clear();
                txt02.Clear();
                lblStatus.Text = "";
                pbIcone.Image = BioPosto.Properties.Resources.iconeLupa;
            }
        }

        private void axGrFingerXCtrl1_SensorPlug(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_SensorPlugEvent e)
        {
            myUtil.WriteLog("Sensor: " + e.idSensor + ". Conectado.");
            axGrFingerXCtrl1.CapStartCapture(e.idSensor);
        }

        private void axGrFingerXCtrl1_SensorUnplug(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_SensorUnplugEvent e)
        {
            myUtil.WriteLog("Sensor: " + e.idSensor + ". Desconectado.");
            axGrFingerXCtrl1.CapStopCapture(e.idSensor);
        }

        private void Extrair()
        {
            int ret;

            // extract template
            ret = myUtil.ExtractTemplate();
            // write template quality to the log
            if ((GRConstants)ret == GRConstants.GR_BAD_QUALITY)
            {
                myUtil.WriteLog("Impressão extraida com Sucesso. Baixa Qualidade.");
            }
            else if ((GRConstants)ret == GRConstants.GR_MEDIUM_QUALITY)
            {
                myUtil.WriteLog("Impressão extraida com Sucesso. Média Qualidade.");
            }
            else if ((GRConstants)ret == GRConstants.GR_HIGH_QUALITY)
            {
                myUtil.WriteLog("Impressão extraida com Sucesso. Alta Qualidade.");
            }
            if (ret >= 0)
            {
                // if no error, display minutiae/segments/directions into image
                myUtil.PrintBiometricDisplay(true, GRConstants.GR_NO_CONTEXT);
            }
            else
            {
                // write error to the log
                myUtil.WriteError((GRConstants)ret);
            }
        }

        private int Reconhecer()
        {
            int ret, score;

            score = 0;
            // identify it
            ret = myUtil.Identify(ref score);
            // write the result to the log
            if (ret > 0)
            {
                myUtil.WriteLog("Impressão Identificada. ID = " + ret + ". Pontos = " + score + ".");
                myUtil.PrintBiometricDisplay(true, GRConstants.GR_DEFAULT_CONTEXT);
                return ret;
            }
            else
            {
                if (ret == 0)
                {
                    myUtil.WriteLog("Impressão não Localizada.");
                }
                else
                {
                    myUtil.WriteError((GRConstants)ret);
                }
                return -1;
            }
        }

        private void frmPesqBio_FormClosed(object sender, FormClosedEventArgs e)
        {
            myUtil.FinalizeUtil();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txt04.Text.Equals(string.Empty))
            {
                errErro.SetError(txt04, "Informe a quantidade Abastecida.Ex.: 55,78");
                return;
            }
            else
            {
                errErro.SetError(txt04, "");
            }
            
            if (txt01.Text.Equals(string.Empty))
            {
                errErro.SetError(txt02, "Cliente não Localizado.");
                return;
            }
            else
            {
                errErro.SetError(txt02, "");
            }
            if (lblStatus.Text =="DESATIVADO")
            {
                errErro.SetError(txt02, "Cliente não Pode Abastecer!");
                return;
            }
            else
            {
                errErro.SetError(txt02, "");
            }
            clsCombustivel clsCombustivel = new clsCombustivel();
            clsCombustivel.cliente_id = int.Parse(txt01.Text);
            clsCombustivel.data = DateTime.Parse(txt03.Text).ToString("MM/dd/yyy");
            clsCombustivel.quantidade = txt04.Text;
            clsCombustivel.Gravar();
            //limpa a tela depois de gravar
            txt01.Clear();
            txt02.Clear();
            txt04.Clear();
            lblStatus.Text = "";
            pbIcone.Image = BioPosto.Properties.Resources.iconeLupa;
            pbImg.Image = BioPosto.Properties.Resources.bioMicrosoft;

        }

        private void txt04_Leave(object sender, EventArgs e)
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

        private void txt04_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
