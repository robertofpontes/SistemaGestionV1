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
        public void ObtenerFoco()
        {
            foreach (Control _Ctrl_ in ControlF)
            {
                _Ctrl_.Leave += new EventHandler(ControlLeave);
                _Ctrl_.Enter += new EventHandler(ControlEnter);
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
    }
}