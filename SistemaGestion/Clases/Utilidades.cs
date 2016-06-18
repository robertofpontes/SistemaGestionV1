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
