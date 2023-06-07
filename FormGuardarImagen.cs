using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WebCam
{
    public partial class FormGuardarImagen : Form
    {
        public Image Imagen { get; set; }
        public FormGuardarImagen()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormGuardarImagen_Load(object sender, EventArgs e)
        {
            pictureBox.Image = Imagen;
            
        }
        //boton que inserta la imagen en la base de datos
        private void BtAceptar_Click(object sender, EventArgs e)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bytesImagen = ms.ToArray();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.DefaultExt = "jpg";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, bytesImagen); 
                }
            }
            Close();
        }
    }
}
