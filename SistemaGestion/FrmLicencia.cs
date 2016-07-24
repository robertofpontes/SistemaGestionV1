using SistemaGestion.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class FrmLicencia : Form
    {
        public bool bolValido;
        SGPAEntities SGPADatos = new SGPAEntities();
        public FrmLicencia()
        {
            InitializeComponent();
        }
        public FrmLicencia(string strEquipo)
        {
            InitializeComponent();
            txtSerial.Text = strEquipo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Clases.Utilidades.Encriptar(txtSerial.Text) == txtCodActivacion.Text)
            {
                var oConfiguracionSistema = SGPADatos.SistemaConfiguracion.ToList();
                SistemaConfiguracion oSistemaConfiguracion = null;
                if (oConfiguracionSistema.Count == 0)
                {
                    oSistemaConfiguracion = new SistemaConfiguracion();
                    oSistemaConfiguracion.Equipo = txtSerial.Text;
                    oSistemaConfiguracion.Serial = txtCodActivacion.Text;
                    SGPADatos.SistemaConfiguracion.Add(oSistemaConfiguracion);
                    SGPADatos.SaveChanges();
                    bolValido = true;
                    Clases.Seguridad.SaveAVR(txtSerial.Text);
                    MessageBox.Show("La licencia fue aplicada con éxito", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Disculpe, el código de activación es inválido", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bolValido = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bolValido = false;
            this.Close();
        }
    }
}
