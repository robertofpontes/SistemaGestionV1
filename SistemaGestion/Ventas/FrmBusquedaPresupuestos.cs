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

namespace SistemaGestion.Ventas
{
    public partial class FrmBusquedaPresupuestos : Form
    {
        SGPAEntities SGPADatos = new SGPAEntities();
        public FrmBusquedaPresupuestos()
        {
            InitializeComponent();
            LlenarGrid("");
        }
        public string strPresupuestoId = "";
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LlenarGrid(txtConsulta.Text);
            Cursor = Cursors.Default;
        }
        private void LlenarGrid(string strBusqueda)
        {
            try
            {
                dtgConsulta.AutoGenerateColumns = false;
                dtgConsulta.DataSource = (from presupuestos in SGPADatos.vw_PresupuestosConsulta where (presupuestos.NombreCliente.Contains(strBusqueda) || presupuestos.PresupuestoId.ToString().Contains(strBusqueda)) && presupuestos.Facturado==false && presupuestos.EmpresaId.ToString() == FrmPadre.strEmpresa select presupuestos).ToList();
                dtgConsulta.Columns[0].Width = 80;
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
                    strPresupuestoId= dtgConsulta.SelectedRows[0].Cells["PresupuestoId"].Value.ToString();                 
                    this.Close();
                }
            }
            catch (Exception ou)
            {

            }
        }
    }
}
