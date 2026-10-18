using Capa_Entidad;
using Capa_Negocio;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Frm_Marcador : DevExpress.XtraEditors.XtraForm, DPFP.Capture.EventHandler
    {
        //private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        private DPFP.Capture.Capture Capturer;

        public Frm_Marcador()
        {
            InitializeComponent();
        }

        #region EventHandler Members:

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            Process(Sample);

            this.Invoke(new Action(delegate () {
                lblMensaje.Text = "Se capturó la muestra de huella dactilar.";
                lblStatus.Text = "Espere un momento.";
            }));

            Thread.Sleep(3000);

            this.Invoke(new Action(delegate ()
            {
                LimpiarCajas();
                lblStatus.Text = "Ingrese su dedo en el lector de huellas dactilares.";
            }));

        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            this.Invoke(new Action(delegate () {
                lblMensaje.Text = "El dedo fue retirado del lector de huellas dactilares.";
            }));            
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            this.Invoke(new Action(delegate () {
                lblMensaje.Text = "El lector de huellas dactilares fue tocado.";
            }));
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            this.Invoke(new Action(delegate () {
                lblMensaje.Text = "El lector de huellas digitales esta conectado.";
            }));
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            this.Invoke(new Action(delegate () {
                lblMensaje.Text = "El lector de huellas dactilares esta desconectado.";
            }));
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            //if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
            //{
            //    this.Invoke(new Action(delegate () {
            //        lblMensaje.Text = "The quality of the fingerprint sample is good.";
            //    }));
            //}
            //else
            //{
            //    this.Invoke(new Action(delegate () {
            //        lblMensaje.Text = "The quality of the fingerprint sample is poor.";
            //    }));
            //}
        }
        #endregion

        protected virtual void Init()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();				// Create a capture operation.

                if (null != Capturer)
                {
                    Capturer.EventHandler = this;					// Subscribe for capturing events.
                }
                else
                {
                    lblMensaje.Text = "No se puede iniciar la operación de captura!";
                }
            }
            catch
            {
                MessageBox.Show("No se puede iniciar la operación de captura!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Verificator = new DPFP.Verification.Verification();
        }
        protected void Process(DPFP.Sample Sample)
        {
            //base.Process(Sample);

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            if (features != null)
            {
                // Compare the feature set with our template
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                
                DPFP.Template template = new DPFP.Template();
                Stream stream;

                List<CE_Huella_Empleado> lstEmpleados = new List<CE_Huella_Empleado>();
                CN_Empleado negocio = new CN_Empleado();

                lstEmpleados = negocio.ListarEmpleado();
                if (lstEmpleados == null)
                {
                    //MessageBox.Show("No se pudo obtener a los Empleados", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                    this.Invoke(new Action(delegate () {
                        lblStatus.Text = "No se pudo obtener a los Empleados.";
                    }));
                    return;
                }

                foreach (var item in lstEmpleados)
                {
                    if(item.Huella != null)
                    {
                        stream = new MemoryStream(item.Huella);
                        template = new DPFP.Template(stream);

                        Verificator.Verify(features, template, ref result);
                        if (result.Verified)
                        {
                            this.Invoke(new Action(delegate () {
                                Marcar(item);
                            }));
                            break;
                        }
                        
                    }
                }

            }
        }

        protected void Start()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    lblStatus.Text = "Ingrese su dedo en el lector de huellas dactilares.";
                }
                catch
                {
                    lblStatus.Text = "No se puede iniciar la captura!";
                }
            }
        }

        protected void Stop()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    lblStatus.Text = "No se puede finalizar la captura!";
                }
            }
        }

        private void Frm_Marcador_Load(object sender, EventArgs e)
        {
            Init();
            Start();
        }

        private void Frm_Marcador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stop();
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();  // Create a feature extractor
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);            // TODO: return features as a result?
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
            {
                return features;
            }
            else
            {
                return null;
            }
        }

        public void Marcar(CE_Huella_Empleado empleado)
        {
            LimpiarCajas();
            lblCodigo.Text = empleado.Codigo.ToString();
            lblNombres.Text = empleado.Nombres.ToString();
            lblApellidos.Text = empleado.Apellidos.ToString();
            lblArea.Text = empleado.Area.ToString();
            if (!string.IsNullOrEmpty(empleado.RutaImg) && File.Exists(empleado.RutaImg))
            {
                pct_Imagen.Image = Image.FromFile(empleado.RutaImg);
                pct_Imagen.Tag = empleado.RutaImg;
            }

            CN_Empleado negocio = new CN_Empleado();
            List<CE_Marcacion> lstMarcacion = new List<CE_Marcacion>();
            lstMarcacion = negocio.ListarMarcaciones(empleado);

            if (lstMarcacion.Count > 0)
            {
                gridMarcaciones.DataSource = null;
                gridMarcaciones.DataSource = lstMarcacion;
            }

        }

        public void LimpiarCajas()
        {
            lblCodigo.Text = "";
            lblNombres.Text = "";
            lblApellidos.Text = "";
            lblArea.Text = "";
            pct_Imagen.EditValue = null;
            gridMarcaciones.DataSource = null;
        }


    }
}   