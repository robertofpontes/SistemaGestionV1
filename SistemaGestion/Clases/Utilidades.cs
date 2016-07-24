using jnSoftware.Validaciones;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion.Clases
{
    class Utilidades
    {
        public Control[] ControlF;
        Color ControlColor = new Color();
        public Utilidades(Control[] Controles)
        {
            ControlF = Controles;
        }
        public static void ColorOriginal(Control ctrControl)
        {
            Color ControlColorC = new Color();
            ctrControl.BackColor = ControlColorC;
        }
        public static bool EsValidoNifCif(string strValor)
        {
            bool bolValido = false;
            try
            {
                bolValido = NumeroNif.CompruebaNif(strValor).EsCorrecto;
            }
            catch
            {
            }
            return bolValido;
        }
        public static bool EsValidoCuentaBancaria(string strValor)
        {
            bool bolValido = false;
            try
            {
                bolValido = CuentasBancarias.ValidaCuentaBancaria(strValor);
            }
            catch
            {
            }
            return bolValido;
        }
        public static string TipoNifCif(string strValor)
        {
            string strTipo = "";
            try
            {                
                strTipo = NumeroNif.CompruebaNif(strValor).TipoNif;
            }
            catch
            {
            }
            return strTipo;
        }
        public static void MostrarErrorControl(Control ctrControl, ErrorProvider erroProvider,string strMensaje)
        {
            erroProvider.SetError(ctrControl, strMensaje);
            ctrControl.BackColor = Color.Khaki;
            ctrControl.LostFocus += CtrControl_LostFocus;
        }
        public static void MostrarErrorControl(ErrorProvider erroProvider,Control ctrControl, string strMensaje)
        {
            erroProvider.SetError(ctrControl, strMensaje);
            ctrControl.BackColor = Color.Khaki;
            ctrControl.LostFocus += CtrControl_LostFocus;
        }
        private static void CtrControl_LostFocus(object sender, EventArgs e)
        {
            Color ControlColor = new Color();
            if (sender.GetType() == typeof(TextBox))
            {
                ((TextBox)sender).BackColor = ControlColor;
            }
            if (sender.GetType() == typeof(CheckBox))
            {
                ((CheckBox)sender).BackColor = ControlColor;
            }
            if (sender.GetType() == typeof(RadioButton))
            {
                ((RadioButton)sender).BackColor = ControlColor;
            }
            if (sender.GetType() == typeof(ComboBox))
            {
                ((ComboBox)sender).BackColor = ControlColor;
            }
            if (sender.GetType() == typeof(DateTimePicker))
            {
                ((DateTimePicker)sender).BackColor = ControlColor;
            }
            if (sender.GetType() == typeof(MonthCalendar))
            {
                ((MonthCalendar)sender).BackColor = ControlColor;
            }
        }

        public static void AsignarValorCombo(ComboBox cmbCombo,string strValor)
        {
            cmbCombo.SelectedIndex = cmbCombo.FindStringExact(strValor);
        }
        public static bool EmailEsValido(string strCorreo)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (strCorreo.Length > 0 && strCorreo.Trim().Length != 0)
            {
                if (!rEmail.IsMatch(strCorreo.Trim()))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool CodigoPostalEsValido(string strCodigoPostal)
        {
            System.Text.RegularExpressions.Regex rCodigoPostal = new System.Text.RegularExpressions.Regex(@"^([1-9]{2}|[0-9][1-9]|[1-9][0-9])[0-9]{3}$");

            if (strCodigoPostal.Length > 0 && strCodigoPostal.Trim().Length != 0)
            {
                if (!rCodigoPostal.IsMatch(strCodigoPostal.Trim()))
                {
                    return false;
                }
            }
            return true;
        }
        public void ObtenerFoco()
        {
            foreach (Control _Ctrl_ in ControlF)
            {
                _Ctrl_.Leave += new EventHandler(ControlLeave);
                _Ctrl_.Enter += new EventHandler(ControlEnter);
            }
        }
        public static void AbrirFormulario(Form frmFormulario, Form frmPadre)
        {
            FormCollection frmFormulariosAbiertos = Application.OpenForms;
            bool bolAbierto = false;
            foreach (Form frmForm in frmFormulariosAbiertos)
            {
                if (frmForm.Name == frmFormulario.Name)
                {
                    frmForm.Show();
                    frmForm.BringToFront();
                    frmForm.Activate();
                    bolAbierto = true;
                    break;
                }
            }
            if (!bolAbierto)
            {
                frmFormulario.MdiParent = frmPadre;
                frmFormulario.Show();
            }
        }

        void ControlLeave(object sender, EventArgs e)
        {

            if (sender.GetType() == typeof(TextBox))
            {
                ((TextBox)sender).BackColor = ControlColor;
            }
            if (sender.GetType() == typeof(CheckBox))
            {
                ((CheckBox)sender).BackColor = ControlColor;
            }
            if (sender.GetType() == typeof(RadioButton))
            {
                ((RadioButton)sender).BackColor = ControlColor;
            }
            if (sender.GetType() == typeof(ComboBox))
            {
                ((ComboBox)sender).BackColor = ControlColor;
            }
            if (sender.GetType() == typeof(DateTimePicker))
            {
                ((DateTimePicker)sender).BackColor = ControlColor;
            }
            if (sender.GetType() == typeof(MonthCalendar))
            {
                ((MonthCalendar)sender).BackColor = ControlColor;
            }
        }
        void ControlEnter(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
            {
                ((TextBox)sender).BackColor = Color.Khaki;
            }
            if (sender.GetType() == typeof(CheckBox))
            {
                ((CheckBox)sender).BackColor = Color.Khaki;
            }
            if (sender.GetType() == typeof(RadioButton))
            {
                ((RadioButton)sender).BackColor = Color.Khaki;
            }
            if (sender.GetType() == typeof(ComboBox))
            {
                ((ComboBox)sender).BackColor = Color.Khaki;
            }
            if (sender.GetType() == typeof(DateTimePicker))
            {
                ((DateTimePicker)sender).BackColor = Color.Khaki;
            }
            if (sender.GetType() == typeof(MonthCalendar))
            {
                ((MonthCalendar)sender).BackColor = Color.Khaki;
            }
        }
        // Clase de Encriptamiento de caracteres creado por Roberto Ferreira
        /// <summary>
        /// Método que encripta un string cualquiera
        /// </summary>
        /// <param name="variable">String a ser encriptado</param>
        /// <returns>String</returns>
        public static string Encriptar(string variable)
        {
            Byte[] bytEncriptar = Encoding.UTF8.GetBytes(variable);
            string strEncriptar;
            strEncriptar = Convert.ToBase64String(bytEncriptar);
            string strEncriptar2;
            Byte[] bytEncriptar2 = Encoding.UTF7.GetBytes(strEncriptar);
            strEncriptar2 = Convert.ToBase64String(bytEncriptar2);
            string strEncriptar3 = strEncriptar2.Replace("=", "SGv");
            return strEncriptar3;
        }
        /// <summary>
        /// Método que desencripta un string que haya sido encriptado por la clase _Mtd_EncriptarString
        /// </summary>
        /// <param name="variable2">String a ser desencriptado</param>
        /// <returns>String</returns>
        public static string Desemcriptar(string variable2)
        {
            string strEncriptar = variable2.Replace("SGv", "=");
            Byte[] bytEncriptar = Convert.FromBase64String(strEncriptar);
            string strEncriptar2 = Encoding.UTF7.GetString(bytEncriptar);
            Byte[] bytEncriptar2 = Convert.FromBase64String(strEncriptar2);
            string strEncriptar3 = Encoding.UTF8.GetString(bytEncriptar2);
            return strEncriptar3;
        }
    }
}