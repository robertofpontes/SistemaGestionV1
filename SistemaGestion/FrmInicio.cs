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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
            CargarEmpresa();
        }
        SGPAEntities SGPADatos = new SGPAEntities();
        private void CargarEmpresa()
        {
            cmbEmpresa.DataSource = (from empresas in SGPADatos.Empresas
                                       select new { empresas.EmpresaId, empresas.NombreEmpresa }).ToList();
            cmbEmpresa.DisplayMember = "NombreEmpresa";
            cmbEmpresa.ValueMember = "EmpresaId";
            cmbEmpresa.SelectedIndex = -1;
        }
        private void CambiarColorControles(Control Controles)
        {
            foreach (Control oControl in Controles.Controls)
            {
                if (oControl.Controls.Count > 0)
                {
                    CambiarColorControles(oControl);
                }
                new Clases.Utilidades(new Control[] { oControl }).ObtenerFoco();
            }
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (cmbEmpresa.SelectedValue != null)
            {
                if (txtUsuario.Text != "" && txtClave.Text != "")
                {
                    var oUsuario = SGPADatos.Usuarios.FirstOrDefault(a => a.Usuario == txtUsuario.Text && a.Clave == txtClave.Text);
                    if (oUsuario != null)
                    {
                        FrmPadre frmPadre = new FrmPadre(cmbEmpresa.SelectedValue.ToString());
                        frmPadre.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o clave invalido", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Disculpe, debe ingresar usuario y clave para ingresar", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void cmbEmpresa_DropDown(object sender, EventArgs e)
        {
            CargarEmpresa();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            CambiarColorControles(this);
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtClave.Focus();
            }
        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.Focus();
            }
        }
    }
}
