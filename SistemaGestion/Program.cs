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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var SGPADatos = new Modelo.SGPAEntities();
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
    }
}
