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
    public partial class frmCadBio : Form
    {
        public frmCadBio()
        {
            InitializeComponent();
        }
        private Util myUtil;
        private string _codSelecionado;
        public string codSelecionado
        {
            get
            {
                return _codSelecionado;
            }
            set
            {
                _codSelecionado = value;
            }
        }
        private string _nomeSelecionado;
        public string nomeSelecionado
        {
            get
            {
                return _nomeSelecionado;
            }
            set
            {
                _nomeSelecionado = value;
            }
        }

        private void frmCadBio_Load(object sender, EventArgs e)
        {
            txt01.Text = _codSelecionado;
            txt02.Text = _nomeSelecionado;

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

        private void frmCadBio_FormClosing(object sender, FormClosingEventArgs e)
        {
            myUtil.FinalizeUtil();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;

            // add fingerprint
            id = myUtil.GravarBio("BIO1",codSelecionado);
            // write the result to the log
            if (id >= 0)
            {
                myUtil.WriteLog("Impressão Gravada no ID = " + id);
            }
            else
            {
                myUtil.WriteLog("Erro: Impressão não foi gravada.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id;

            // add fingerprint
            id = myUtil.GravarBio("BIO2", codSelecionado);
            // write the result to the log
            if (id >= 0)
            {
                myUtil.WriteLog("Impressão Gravada no ID = " + id);
            }
            else
            {
                myUtil.WriteLog("Erro: Impressão não foi gravada.");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
