using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using Microsoft.VisualBasic.Logging;

namespace WebCam
{
    public partial class FormPrincipal : Form
    {
        private FilterInfoCollection dispositivosConectados;
        private VideoCaptureDevice videoSource;
        public Image imagen;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // lista de dispositivos conectados
            dispositivosConectados = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (dispositivosConectados.Count > 0)
            {
                // obtenemos el dispositivo de captura en la posicion 0
                videoSource = new VideoCaptureDevice(dispositivosConectados[0].MonikerString);

                // Configurar el evento NewFrame para capturar cada nuevo fotograma del video
                videoSource.NewFrame += VideoSource_NewFrame;
                try
                {
                    videoSource.Start();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }  
            }

            else
            {
                MessageBox.Show("No se encontraron dispositivos de captura disponibles.");
                Close();
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // obtenemos la captura de imagen y la mostramos en la pictureBox
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            pictureBox.Image = frame;
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // interrumpimos la captura de la imagen
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
            }
        }

        private void BtnImagen_Click(object sender, EventArgs e)
        {
            // detenemos la captura de la imagen y la guardamos
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();

                imagen = pictureBox.Image;
                GuardarImagen(imagen);
                videoSource.Start();
            }
        }

        private void GuardarImagen(Image imagen)
        {
            if (imagen != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] bytesImagen = ms.ToArray();

                    FormGuardarImagen form = new FormGuardarImagen();
                    form.Imagen = imagen;

                    //ocultamos la forma actual, abrimos la de guardar imagen y cuando se cierra la otra se vuelve visible esta
                    this.Visible = false;
                    form.ShowDialog();
                    this.Visible = true;
                }
            }

            else
            {
                MessageBox.Show("No se ha capturado ninguna imagen.");
            }
        }
    }
}
