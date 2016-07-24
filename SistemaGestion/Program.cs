using SistemaGestion.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool bolValido = false;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Serial único del equipo para lincenciamiento                     
            var SGPADatos = new Modelo.SGPAEntities();
            var oConfiguracionSistema = SGPADatos.SistemaConfiguracion.ToList();
            if (oConfiguracionSistema.Count == 0)
            {
                string strVolumen = Clases.Seguridad.UniqueId();
                FrmLicencia frmLicencia = new FrmLicencia(strVolumen);
                frmLicencia.ShowDialog();
                bolValido = frmLicencia.bolValido;
            }
            else
            {
                bolValido = Clases.Seguridad.ValidarSerial(oConfiguracionSistema.FirstOrDefault());                
            }
            if (bolValido)
            {
                var oEmpresas = SGPADatos.Empresas.ToList();
                if (oEmpresas.Count == 0)
                {
                    //Si no hay empresas registradas en la BD
                }
                else
                {
                    var oUsuarios = SGPADatos.Usuarios.ToList();
                    if (oUsuarios.Count == 0)
                    {
                        //Si no hay usuarios registrados en la BD
                    }
                    else
                    {
                        Application.Run(new FrmInicio());
                    }
                }
            }
            else
            {
                MessageBox.Show("Disculpe, existe un problema con la licencia del programa", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
