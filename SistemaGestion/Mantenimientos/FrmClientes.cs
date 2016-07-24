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
    public partial class FrmClientes : Form
    {
        SGPAEntities SGPADatos = new SGPAEntities();
        public FrmClientes()
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
                dtgConsulta.DataSource = (from clientes in SGPADatos.Clientes where (clientes.NombreCliente.Contains(strBusqueda) || clientes.Identificacion.Contains(strBusqueda) || clientes.ClienteId.ToString().Contains(strBusqueda))&&clientes.EmpresaId.ToString()==FrmPadre.strEmpresa select clientes).ToList();
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

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CambiarColorControles(this);
        }

        private void FrmClientes_Activated(object sender, EventArgs e)
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
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_nuevo2.Enabled = true;
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
                if (txtNombreCliente.Enabled)
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
            txtNombreCliente.Enabled = bolActivo;
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
            if (txtNombreCliente.Text.Trim().Length == 0)
            {
                Clases.Utilidades.MostrarErrorControl(txtNombreCliente,ErrorValidador, "El campo es obligatorio");
                return false;
            }
            if (txtNifCif.Text.Trim().Length == 0)
            {
                Clases.Utilidades.MostrarErrorControl(txtNifCif,ErrorValidador, "El campo es obligatorio");
                return false;
            }
            if (!Clases.Utilidades.EsValidoNifCif(txtNifCif.Text))
            {
                Clases.Utilidades.MostrarErrorControl(txtNifCif,ErrorValidador, "El NIT o CIF es incorrecto");
                return false;
            }           
            if (txtDireccion.Text.Trim().Length == 0)
            {
                Clases.Utilidades.MostrarErrorControl(ErrorValidador,txtDireccion, "El campo es obligatorio");
                return false;
            }
            if (cmbProvincias.SelectedValue == null)
            {
                Clases.Utilidades.MostrarErrorControl(ErrorValidador,cmbProvincias, "El campo es obligatorio");
                return false;
            }
            else
            {
                Clases.Utilidades.ColorOriginal(cmbProvincias);
            }
            if (cmbMunicipios.SelectedValue == null)
            {
                Clases.Utilidades.MostrarErrorControl(ErrorValidador,cmbMunicipios, "El campo es obligatorio");
                return false;
            }
            else
            {
                Clases.Utilidades.ColorOriginal(cmbMunicipios);
            }
            if (txtCodigoPostal.Text.Trim().Length == 0)
            {
                Clases.Utilidades.MostrarErrorControl(ErrorValidador,txtCodigoPostal, "El campo es obligatorio");
                return false;
            }
            else
            {
                if (!Clases.Utilidades.CodigoPostalEsValido(txtCodigoPostal.Text))
                {
                    Clases.Utilidades.MostrarErrorControl(ErrorValidador,txtCodigoPostal, "El formato del código postal no es válido");
                    return false;
                }
                else
                {
                    string strCodigoBuscar = txtCodigoPostal.Text.Substring(0, 2);
                    decimal dcmCodigoBuscar = Convert.ToDecimal(strCodigoBuscar);
                    var oProvincia = SGPADatos.Provincias.FirstOrDefault(a => a.ProvinciaId == dcmCodigoBuscar);
                    if (oProvincia != null)
                    {
                        if(oProvincia.ProvinciaId.ToString()!=cmbProvincias.SelectedValue.ToString())
                        {
                            Clases.Utilidades.MostrarErrorControl(ErrorValidador,cmbProvincias, "La provincia seleccionada no concuerda con el código postal ingresado");
                            return false;
                        }
                        else
                        {
                            Clases.Utilidades.ColorOriginal(cmbProvincias);
                        }
                    }
                }
            }
            if (txtTelefono1.Text.Trim().Length == 0)
            {
                Clases.Utilidades.MostrarErrorControl(ErrorValidador,txtTelefono1, "El campo es obligatorio");
                return false;
            }
            if (!Clases.Utilidades.EmailEsValido(txtEmail.Text))
            {
                Clases.Utilidades.MostrarErrorControl(ErrorValidador,txtEmail, "El formato del correo es invalido");
                return false;
            }
            //if (txtNumeroCuenta.Text.Trim() != "")
            //{
            //    if (!Clases.Utilidades.EsValidoCuentaBancaria(txtNumeroCuenta.Text))
            //    {
            //        Clases.Utilidades.MostrarErrorControl(ErrorValidador,txtNumeroCuenta, "El formato del número de cuenta no es válido");
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
                var oCliente = SGPADatos.Clientes.FirstOrDefault(a => a.ClienteId.ToString() == txtCodigo.Text && a.EmpresaId.ToString()==FrmPadre.strCodCompania);
                if (oCliente != null)
                {
                    oCliente.NombreCliente = txtNombreCliente.Text;
                    oCliente.Identificacion = txtNifCif.Text.Trim().ToUpper();
                    oCliente.Direccion = txtDireccion.Text;
                    oCliente.MunicipioId = Convert.ToDecimal(cmbMunicipios.SelectedValue.ToString());
                    oCliente.CodigoPostal = txtCodigoPostal.Text.Trim();
                    oCliente.Telefono1 = txtTelefono1.Text.Trim();
                    oCliente.Telefono2 = txtTelefono2.Text.Trim();
                    oCliente.Observaciones = txtObservaciones.Text.Trim();
                    oCliente.Email = txtEmail.Text.Trim();
                    oCliente.Iban = txtIBAN.Text;
                    oCliente.Swift = txtSWIFT.Text;
                    oCliente.NombreBanco = txtNombreBanco.Text;
                    oCliente.NumeroCuenta = txtNumeroCuenta.Text;
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
            txtNombreCliente.Text = "";
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

        private void FrmClientes_FormClosing(object sender, FormClosingEventArgs e)
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
                    var oCliente = new Clientes();
                    oCliente.NombreCliente = txtNombreCliente.Text;
                    oCliente.Identificacion = txtNifCif.Text.Trim().ToUpper();
                    oCliente.EmpresaId =  FrmPadre.dcmCodCompania;
                    oCliente.Direccion = txtDireccion.Text;
                    oCliente.MunicipioId = Convert.ToDecimal(cmbMunicipios.SelectedValue.ToString());
                    oCliente.CodigoPostal = txtCodigoPostal.Text.Trim();
                    oCliente.Telefono1 = txtTelefono1.Text.Trim();
                    oCliente.Telefono2 = txtTelefono2.Text.Trim();
                    oCliente.Observaciones = txtObservaciones.Text.Trim();
                    oCliente.Email = txtEmail.Text.Trim();
                    oCliente.Iban = txtIBAN.Text;
                    oCliente.Swift = txtSWIFT.Text;
                    oCliente.NombreBanco = txtNombreBanco.Text;
                    oCliente.NumeroCuenta = txtNumeroCuenta.Text;
                    SGPADatos.Clientes.Add(oCliente);
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
                if (!txtNombreCliente.Enabled & txtCodigo.Text.Trim().Length == 0)
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
                var oCliente = SGPADatos.Clientes.FirstOrDefault(a => a.ClienteId == dcmCliente && a.EmpresaId==FrmPadre.dcmCodCompania);
                if (oCliente != null)
                {
                    txtNombreCliente.Text = oCliente.NombreCliente;
                    txtNifCif.Text = oCliente.Identificacion;
                    txtDireccion.Text = oCliente.Direccion;
                    var oMunicipio = SGPADatos.Municipios.FirstOrDefault(a => a.MunicipioId == oCliente.MunicipioId);
                    Clases.Utilidades.AsignarValorCombo(cmbProvincias, oMunicipio.Provincias.NombreProvincia.ToString());
                    LlenarMunicipios();
                    Clases.Utilidades.AsignarValorCombo(cmbMunicipios, oCliente.Municipios.NombreMunicipio.ToString());
                    txtCodigoPostal.TextChanged -= txtCodigoPostal_TextChanged;
                    txtCodigoPostal.Text = oCliente.CodigoPostal;
                    txtCodigoPostal.TextChanged += txtCodigoPostal_TextChanged;
                    txtTelefono1.Text=oCliente.Telefono1;
                    txtTelefono2.Text = oCliente.Telefono2;
                    txtObservaciones.Text = oCliente.Observaciones;
                    txtEmail.Text = oCliente.Email;
                    txtIBAN.Text=oCliente.Iban;
                    txtSWIFT.Text=oCliente.Swift;
                    txtNombreBanco.Text=oCliente.NombreBanco;
                    txtNumeroCuenta.Text=oCliente.NumeroCuenta;
                    txtCodigo.Text = oCliente.ClienteId.ToString();
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
                    CargarData(Convert.ToDecimal(dtgConsulta.SelectedRows[0].Cells["ClienteId"].Value.ToString()));
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
                    if (txtCodigoPostal.Text.Length ==2)
                    {
                        string strCodigoBuscar = txtCodigoPostal.Text.Substring(0, 2);
                        decimal dcmCodigoBuscar = Convert.ToDecimal(strCodigoBuscar);
                        var oProvincia = SGPADatos.Provincias.FirstOrDefault(a => a.ProvinciaId== dcmCodigoBuscar);
                        if (oProvincia != null)
                        {
                            Clases.Utilidades.AsignarValorCombo(cmbProvincias, oProvincia.NombreProvincia);
                        }
                    }
                }
            }
            catch(Exception ou)
            {
            }
        }

        private void cmbProvincias_DropDown(object sender, EventArgs e)
        {
            LlenarProvincias();
        }
    }
}

