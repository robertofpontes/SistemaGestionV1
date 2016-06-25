using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using jnSoftware.Validaciones;
using SistemaGestion.Modelo;
using System.Net.Mail;

namespace SistemaGestion.Mantenimientos
{
    public partial class FrmProveedores : Form
    {
        SGPAEntities SGPADatos = new SGPAEntities();
        public FrmProveedores()
        {
            InitializeComponent();
            LlenarGrid("");
            LlenarProvincias();
        }
        private void LlenarProvincias()
        {
            try
            {
                cmbProvincias.DataSource = (from provincias in SGPADatos.Provincias
                                         select new { provincias.ProvinciaId, provincias.NombreProvincia }).ToList();
                cmbProvincias.DisplayMember = "NombreProvincia";
                cmbProvincias.ValueMember = "ProvinciaId";
                cmbProvincias.SelectedIndex = -1;
            }
            catch
            {
            }
        }
        private void LlenarMunicipios()
        {
            try
            {
                if (cmbProvincias.SelectedValue != null)
                {
                    cmbMunicipios.DataSource = (from municipios in SGPADatos.Municipios
                                                where municipios.ProvinciaId.ToString() == cmbProvincias.SelectedValue.ToString()
                                                select new { municipios.MunicipioId, municipios.NombreMunicipio }).ToList();
                    cmbMunicipios.DisplayMember = "NombreMunicipio";
                    cmbMunicipios.ValueMember = "MunicipioId";
                    cmbMunicipios.SelectedIndex = -1;
                }
            }
            catch
            {
            }
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
        private void LlenarGrid(string strBusqueda)
        {
            try
            {
                dtgConsulta.AutoGenerateColumns = false;
                dtgConsulta.DataSource = (from proveedores in SGPADatos.Proveedores where (proveedores.NombreProveedor.Contains(strBusqueda) || proveedores.Identificacion.Contains(strBusqueda) || proveedores.ProveedorId.ToString().Contains(strBusqueda))&&proveedores.EmpresaId.ToString()==FrmPadre.strEmpresa select proveedores).ToList();
                tabFormulario.SelectedIndex = 0;
                dtgConsulta.Columns[0].Width = 80;
            }
            catch
            {
            }
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            LlenarGrid(txtConsulta.Text);
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            CambiarColorControles(this);
        }

        private void FrmProveedores_Activated(object sender, EventArgs e)
        {
            ActivarBotonera();
        }
        string strProceso = "G";
        public void ActivarBotonera()
        {
            CONTROLES._Ctrl_Buscar._frm_Formulario = this;
            CONTROLES._Ctrl_Buscar._Tb_Tab = tabFormulario;
            CONTROLES._Ctrl_Buscar._Bl_Especial = true;
            CONTROLES._Ctrl_Buscar._txt_ExistForm.Text = "";
            CONTROLES._Ctrl_Buscar._txt_ExistForm.Text = "Abierto";
            ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_cancelar2.Enabled = false;
            if (strProceso == "N")
            {
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_nuevo2.Enabled = true;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_editar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_guardar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_borrar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_cancelar2.Enabled = false;
            }
            if (strProceso == "A")
            {
                CONTROLES._Ctrl_Buscar._Bl_Modifi = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_nuevo2.Enabled = true;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_editar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_guardar2.Enabled = true;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_cancelar2.Enabled = true;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_borrar2.Enabled = false;
            }
            if (strProceso == "E")
            {
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_nuevo2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_editar2.Enabled = true;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_guardar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_borrar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_cancelar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_borrar2.Enabled = true;
            }
            if (strProceso == "M")
            {
                CONTROLES._Ctrl_Buscar._Bl_Modifi = true;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_nuevo2.Enabled = true;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_editar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_guardar2.Enabled = true;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_cancelar2.Enabled = true;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_borrar2.Enabled = false;
            }
            if (strProceso == "")
            {
                if (txtNombreProveedor.Enabled)
                {
                    ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_nuevo2.Enabled = false;
                    ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_editar2.Enabled = false;
                    ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_guardar2.Enabled = true;
                    ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_borrar2.Enabled = false;
                    ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_cancelar2.Enabled = true;
                }
                else
                {
                    ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_nuevo2.Enabled = false;
                    ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_editar2.Enabled = false;
                    ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_guardar2.Enabled = false;
                    ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_borrar2.Enabled = false;
                    ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_cancelar2.Enabled = false;
                }
            }
        }
        public void HabilitarControles()
        {
            BloquearControles(true);
            strProceso = "M";
        }
        private void BloquearControles(bool bolActivo)
        {
            txtCodigo.Enabled = false;
            txtNombreProveedor.Enabled = bolActivo;
            txtDireccion.Enabled = bolActivo;
            txtNifCif.Enabled = bolActivo;
            cmbMunicipios.Enabled = bolActivo;
            cmbProvincias.Enabled = bolActivo;
            txtCodigoPostal.Enabled = bolActivo;
            txtTelefono1.Enabled = bolActivo;
            txtTelefono2.Enabled = bolActivo;
            txtObservaciones.Enabled = bolActivo;
            txtEmail.Enabled = bolActivo;
            txtIBAN.Enabled = bolActivo;
            txtSWIFT.Enabled = bolActivo;
            txtNombreBanco.Enabled = bolActivo;
            txtNumeroCuenta.Enabled = bolActivo;
        }

        private void cmbMunicipios_DropDown(object sender, EventArgs e)
        {
            LlenarMunicipios();
        }

        private void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarMunicipios();
        }
        private bool ValidarGuardar()
        {
            ErrorValidador.Dispose();
            if (txtNombreProveedor.Text.Trim().Length == 0)
            {
                ErrorValidador.SetError(txtNombreProveedor, "El campo es obligatorio");
                return false;
            }
            if (txtNifCif.Text.Trim().Length == 0)
            {
                ErrorValidador.SetError(txtNifCif, "El campo es obligatorio");
                return false;
            }
            if (!Clases.Utilidades.EsValidoNifCif(txtNifCif.Text))
            {
                ErrorValidador.SetError(txtNifCif, "El NIT o CIF es incorrecto");
                return false;
            }
            if (txtDireccion.Text.Trim().Length == 0)
            {
                ErrorValidador.SetError(txtDireccion, "El campo es obligatorio");
                return false;
            }
            if (cmbProvincias.SelectedValue == null)
            {
                ErrorValidador.SetError(cmbProvincias, "El campo es obligatorio");
                return false;
            }
            if (cmbMunicipios.SelectedValue == null)
            {
                ErrorValidador.SetError(cmbMunicipios, "El campo es obligatorio");
                return false;
            }
            if (txtCodigoPostal.Text.Trim().Length == 0)
            {
                ErrorValidador.SetError(txtCodigoPostal, "El campo es obligatorio");
                return false;
            }
            else
            {
                if (!Clases.Utilidades.CodigoPostalEsValido(txtCodigoPostal.Text))
                {
                    ErrorValidador.SetError(txtCodigoPostal, "El formato del código postal no es válido");
                    return false;
                }
                else
                {
                    string strCodigoBuscar = txtCodigoPostal.Text.Substring(0, 2);
                    decimal dcmCodigoBuscar = Convert.ToDecimal(strCodigoBuscar);
                    var oProvincia = SGPADatos.Provincias.FirstOrDefault(a => a.ProvinciaId == dcmCodigoBuscar);
                    if (oProvincia != null)
                    {
                        if (oProvincia.ProvinciaId.ToString() != cmbProvincias.SelectedValue.ToString())
                        {
                            ErrorValidador.SetError(cmbProvincias, "La provincia seleccionada no concuerda con el código postal ingresado");
                            return false;
                        }
                    }
                }
            }
            if (txtTelefono1.Text.Trim().Length == 0)
            {
                ErrorValidador.SetError(txtTelefono1, "El campo es obligatorio");
                return false;
            }
            if (!Clases.Utilidades.EmailEsValido(txtEmail.Text))
            {
                ErrorValidador.SetError(txtEmail, "El formato del correo es invalido");
                return false;
            }
            //if (txtNumeroCuenta.Text.Trim() != "")
            //{
            //    if (!Clases.Utilidades.EsValidoCuentaBancaria(txtNumeroCuenta.Text))
            //    {
            //        ErrorValidador.SetError(txtNumeroCuenta, "El formato del número de cuenta no es válido");
            //        return false;
            //    }
            //}
            return true;
        }
        public bool Modificar()
        {
            bool bolEditado = false;
            if (ValidarGuardar())
            {
                var oProveedor = SGPADatos.Proveedores.FirstOrDefault(a => a.ProveedorId.ToString() == txtCodigo.Text && a.EmpresaId.ToString()==FrmPadre.strCodCompania);
                if (oProveedor != null)
                {
                    oProveedor.NombreProveedor = txtNombreProveedor.Text;
                    oProveedor.Identificacion = txtNifCif.Text.Trim().ToUpper();
                    oProveedor.Direccion = txtDireccion.Text;
                    oProveedor.MunicipioId = Convert.ToDecimal(cmbMunicipios.SelectedValue.ToString());
                    oProveedor.CodigoPostal = txtCodigoPostal.Text.Trim();
                    oProveedor.Telefono1 = txtTelefono1.Text.Trim();
                    oProveedor.Telefono2 = txtTelefono2.Text.Trim();
                    oProveedor.Observaciones = txtObservaciones.Text.Trim();
                    oProveedor.Email = txtEmail.Text.Trim();
                    oProveedor.Iban = txtIBAN.Text;
                    oProveedor.Swift = txtSWIFT.Text;
                    oProveedor.NombreBanco = txtNombreBanco.Text;
                    oProveedor.NumeroCuenta = txtNumeroCuenta.Text;
                    SGPADatos.SaveChanges();
                    LlenarGrid("");
                }
            }
            return bolEditado;
        }
        public void Inicializar()
        {
            strProceso = "";
            txtCodigo.Text = "";
            txtNombreProveedor.Text = "";
            txtDireccion.Text = "";
            txtNifCif.Text = "";
            txtCodigoPostal.Text = "";
            txtTelefono1.Text = "";
            txtTelefono2.Text = "";
            txtObservaciones.Text = "";
            txtEmail.Text = "";
            txtIBAN.Text = "";
            txtSWIFT.Text = "";
            txtNombreBanco.Text = "";
            txtNumeroCuenta.Text = "";
            cmbProvincias.SelectedIndex = -1;
            cmbMunicipios.DataSource=null;
            BloquearControles(false);
        }

        private void FrmProveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            CONTROLES._Ctrl_Buscar._txt_text.Text = "";
            CONTROLES._Ctrl_Buscar._txt_ExistForm.Text = "Cerrado";
        }
        public void CrearNuevo()
        {
            Inicializar();
            BloquearControles(true);
            strProceso = "A";
            tabFormulario.SelectedIndex = 1;
            ActivarBotonera();
        }
        public bool Guardar()
        {
            try
            {
                if (ValidarGuardar())
                {
                    var oProveedor = new Proveedores();
                    oProveedor.NombreProveedor = txtNombreProveedor.Text;
                    oProveedor.Identificacion = txtNifCif.Text.Trim().ToUpper();
                    oProveedor.EmpresaId =  FrmPadre.dcmCodCompania;
                    oProveedor.Direccion = txtDireccion.Text;
                    oProveedor.MunicipioId = Convert.ToDecimal(cmbMunicipios.SelectedValue.ToString());
                    oProveedor.CodigoPostal = txtCodigoPostal.Text.Trim();
                    oProveedor.Telefono1 = txtTelefono1.Text.Trim();
                    oProveedor.Telefono2 = txtTelefono2.Text.Trim();
                    oProveedor.Observaciones = txtObservaciones.Text.Trim();
                    oProveedor.Email = txtEmail.Text.Trim();
                    oProveedor.Iban = txtIBAN.Text;
                    oProveedor.Swift = txtSWIFT.Text;
                    oProveedor.NombreBanco = txtNombreBanco.Text;
                    oProveedor.NumeroCuenta = txtNumeroCuenta.Text;
                    SGPADatos.Proveedores.Add(oProveedor);
                    SGPADatos.SaveChanges();
                    LlenarGrid("");
                    Inicializar();
                    strProceso = "N";
                    return true;
                }
                return false;
            }
            catch(Exception oException)
            {
                return false;
            }
        }
        private void tabFormulario_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex != 0)
            {
                if (!txtNombreProveedor.Enabled & txtCodigo.Text.Trim().Length == 0)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_guardar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_editar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_borrar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_cancelar2.Enabled = false;
            }
        }
        private void CargarData(decimal dcmCliente)
        {
            try
            {
                var oProveedor = SGPADatos.Proveedores.FirstOrDefault(a => a.ProveedorId == dcmCliente && a.EmpresaId==FrmPadre.dcmCodCompania);
                if (oProveedor != null)
                {
                    txtNombreProveedor.Text = oProveedor.NombreProveedor;
                    txtNifCif.Text = oProveedor.Identificacion;
                    txtDireccion.Text = oProveedor.Direccion;
                    var oMunicipio = SGPADatos.Municipios.FirstOrDefault(a => a.MunicipioId == oProveedor.MunicipioId);
                    Clases.Utilidades.AsignarValorCombo(cmbProvincias, oMunicipio.Provincias.NombreProvincia.ToString());
                    LlenarMunicipios();
                    Clases.Utilidades.AsignarValorCombo(cmbMunicipios, oProveedor.Municipios.NombreMunicipio.ToString());
                    txtCodigoPostal.TextChanged -= txtCodigoPostal_TextChanged;
                    txtCodigoPostal.Text = oProveedor.CodigoPostal;
                    txtCodigoPostal.TextChanged += txtCodigoPostal_TextChanged;
                    txtTelefono1.Text=oProveedor.Telefono1;
                    txtTelefono2.Text = oProveedor.Telefono2;
                    txtObservaciones.Text = oProveedor.Observaciones;
                    txtEmail.Text = oProveedor.Email;
                    txtIBAN.Text=oProveedor.Iban;
                    txtSWIFT.Text=oProveedor.Swift;
                    txtNombreBanco.Text=oProveedor.NombreBanco;
                    txtNumeroCuenta.Text=oProveedor.NumeroCuenta;
                    txtCodigo.Text = oProveedor.ProveedorId.ToString();
                }
            }
            catch
            {
            }
        }
        private void dtgConsulta_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dtgConsulta.RowCount >= 0)
                {
                    Cursor = Cursors.WaitCursor;
                    Inicializar();
                    CargarData(Convert.ToDecimal(dtgConsulta.SelectedRows[0].Cells["ProveedorId"].Value.ToString()));
                    strProceso = "E";
                    ActivarBotonera();
                    Cursor = Cursors.Default;
                    tabFormulario.SelectedIndex = 1;
                }
            }
            catch(Exception ou)
            {

            }
        }

        private void txtCodigoPostal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoPostal.Text.Trim() != "")
                {
                    if (txtCodigoPostal.Text.Length == 2)
                    {
                        string strCodigoBuscar = txtCodigoPostal.Text.Substring(0, 2);
                        decimal dcmCodigoBuscar = Convert.ToDecimal(strCodigoBuscar);
                        var oProvincia = SGPADatos.Provincias.FirstOrDefault(a => a.ProvinciaId == dcmCodigoBuscar);
                        if (oProvincia != null)
                        {
                            Clases.Utilidades.AsignarValorCombo(cmbProvincias, oProvincia.NombreProvincia);
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void cmbProvincias_DropDown(object sender, EventArgs e)
        {
            LlenarProvincias();
        }
    }
}

