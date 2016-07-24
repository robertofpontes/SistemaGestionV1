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
    public partial class FrmBusquedaArticulos : Form
    {
        SGPAEntities SGPADatos = new SGPAEntities();
        public FrmBusquedaArticulos()
        {
            InitializeComponent();
            LlenarGrid("");
        }
        public string strProductoId = "";
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
                dtgConsulta.DataSource = (from articulos in SGPADatos.vw_ArticulosConsulta where (articulos.Descripcion.Contains(strBusqueda) || articulos.Referencia.Contains(strBusqueda) || articulos.ArticuloId.ToString().Contains(strBusqueda)) && articulos.EmpresaId.ToString() == FrmPadre.strEmpresa select articulos).ToList();
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
                    strProductoId= dtgConsulta.SelectedRows[0].Cells["ArticuloId"].Value.ToString();                 
                    this.Close();
                }
            }
            catch (Exception ou)
            {

            }
        }
    }
}
