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
    public partial class FrmBusquedaClientes : Form
    {
        SGPAEntities SGPADatos = new SGPAEntities();
        public FrmBusquedaClientes()
        {
            InitializeComponent();
        }
        public string strClienteId = "";
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
                dtgConsulta.DataSource = (from clientes in SGPADatos.Clientes where (clientes.NombreCliente.Contains(strBusqueda) || clientes.Identificacion.Contains(strBusqueda) || clientes.ClienteId.ToString().Contains(strBusqueda)) && clientes.EmpresaId.ToString() == FrmPadre.strEmpresa select clientes).ToList();
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
                    strClienteId= dtgConsulta.SelectedRows[0].Cells["ClienteId"].Value.ToString();                 
                    this.Close();
                }
            }
            catch (Exception ou)
            {

            }
        }
    }
}
