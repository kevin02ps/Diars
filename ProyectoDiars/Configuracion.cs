using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InversionesHermanos
{
    public partial class Configuracion : Form
    {
        public static string UbiComprobante { get; set; }
        public Configuracion()
        {
            InitializeComponent();
            if (UbiComprobante == null)
            {
                txtUbiComprobantes.Text = "C:/";
            }
            else
            {
                txtUbiComprobantes.Text = UbiComprobante;
            }
        }

        private void btnUbiComprobante_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("Ubicación Guardada Exitosamente.");
            
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {

        }
    }
}
