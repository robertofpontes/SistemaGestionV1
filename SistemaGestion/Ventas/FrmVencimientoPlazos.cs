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
    public partial class FrmVencimientoPlazos : Form
    {
        public List<Clases.RecibosFactura> oRecibosFacturas = new List<Clases.RecibosFactura>();
        public FrmVencimientoPlazos()
        {
            InitializeComponent();
        }
        DateTime dtFechaMinima;
        public FrmVencimientoPlazos(string strFecha, int intCantidadPlazos, decimal dcmImporte, string strFechaMinima)
        {
            InitializeComponent();
            dtFechaMinima = Convert.ToDateTime(strFechaMinima);
            LlenarGrid(strFecha, intCantidadPlazos, dcmImporte);
            dtpFecha.MinDate = dtFechaMinima;
        }
        public FrmVencimientoPlazos(List<Clases.RecibosFactura> oRecibosFacturasM, string strFechaMinima)
        {
            InitializeComponent();
            dtFechaMinima = Convert.ToDateTime(strFechaMinima);
            oRecibosFacturas = oRecibosFacturasM;
            LlenarGrid();
            dtpFecha.MinDate = dtFechaMinima;
        }
        private void LlenarGrid(string strFecha, int intCantidadPlazos,decimal dcmImporte)
        {
            decimal dcmCalculo = dcmImporte / intCantidadPlazos;
            for (int i = 0; i < intCantidadPlazos; i++)
            {
                dtgVencimientos.Rows.Add((i + 1).ToString(),strFecha, string.Format("{0:n}", dcmCalculo));
            }
            //dtgVencimientos.Columns[0].Frozen = true;
            //dtgVencimientos.Columns[0].DefaultCellStyle = dtgVencimientos.RowHeadersDefaultCellStyle;
            dtgVencimientos.RowHeadersWidth = 100;
            foreach (DataGridViewRow dtgFilas in dtgVencimientos.Rows)
            {
                dtgFilas.HeaderCell.Value = "Plazo " + dtgFilas.Cells["PlazoId"].Value.ToString();
            }
        }
        private void LlenarGrid()
        {            
            foreach(Clases.RecibosFactura oRecibos in oRecibosFacturas)
            {
                dtgVencimientos.Rows.Add(oRecibos.PlazoId.ToString(), oRecibos.Fecha, string.Format("{0:n}", oRecibos.Importe));
            }
            //dtgVencimientos.Columns[0].Frozen = true;
            //dtgVencimientos.Columns[0].DefaultCellStyle = dtgVencimientos.RowHeadersDefaultCellStyle;
            dtgVencimientos.RowHeadersWidth = 100;
            foreach (DataGridViewRow dtgFilas in dtgVencimientos.Rows)
            {
                dtgFilas.HeaderCell.Value = "Plazo " + dtgFilas.Cells["PlazoId"].Value.ToString();
            }
        }
        private void btnFechas_Click(object sender, EventArgs e)
        {

        }

        private void FrmVencimientoPlazos_Load(object sender, EventArgs e)
        {
            pnlCambiarFecha.Left = (this.Width / 2) - (pnlCambiarFecha.Width / 2);
            pnlCambiarFecha.Top = (this.Height / 2) - (pnlCambiarFecha.Height / 2);
        }

        private void pnlCambiarFecha_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlCambiarFecha.Visible)
            {
                btnAceptar.Enabled = false;
                dtgVencimientos.Enabled = false;
                btnVencimiento.Enabled = false;
            }
            else
            {
                btnAceptar.Enabled = true;
                dtgVencimientos.Enabled = true;
                btnVencimiento.Enabled = true;
            }
        }

        private void btnVencimiento_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgVencimientos.SelectedRows.Count == 1)
                {
                    pnlCambiarFecha.Visible = true;
                    dtpFecha.Value = Convert.ToDateTime(dtgVencimientos.SelectedRows[0].Cells["Fecha"].Value.ToString());
                }
            }
            catch
            {

            }
        }

        private void dtgVencimientos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dtgVencimientos.RowCount >= 0)
                {
                    Cursor = Cursors.WaitCursor;
                    if (dtgVencimientos.SelectedRows.Count == 1)
                    {
                        btnVencimiento.Visible = true;
                    }
                    else
                    {
                        btnVencimiento.Visible = false;
                    }
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ou)
            {

            }
        }

        private void btnAceptarCambiarFecha_Click(object sender, EventArgs e)
        {
            if (dtgVencimientos.SelectedRows.Count == 1)
            {
                dtgVencimientos.SelectedRows[0].Cells["Fecha"].Value = dtpFecha.Value.ToString("dd/MM/yyyy");
                pnlCambiarFecha.Visible = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dtgFilas in dtgVencimientos.Rows)
                {
                    var oRecibo = new Clases.RecibosFactura();
                    oRecibo.Fecha = Convert.ToDateTime(dtgFilas.Cells["Fecha"].Value.ToString());
                    oRecibo.Importe = Convert.ToDecimal(dtgFilas.Cells["Importe"].Value.ToString());
                    oRecibo.PlazoId = Convert.ToDecimal(dtgFilas.Cells["PlazoId"].Value.ToString());
                    oRecibosFacturas.Add(oRecibo);
                }
                this.Close();
            }
            catch
            {
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dtgFilas in dtgVencimientos.Rows)
                {
                    var oRecibo = new Clases.RecibosFactura();
                    oRecibo.Fecha = Convert.ToDateTime(dtgFilas.Cells["Fecha"].Value.ToString());
                    oRecibo.Importe = Convert.ToDecimal(dtgFilas.Cells["Importe"].Value.ToString());
                    oRecibo.PlazoId = Convert.ToDecimal(dtgFilas.Cells["PlazoId"].Value.ToString());
                    oRecibosFacturas.Add(oRecibo);
                }
                this.Close();
            }
            catch
            {
            }
        }

        private void btnCancelarCambiarFecha_Click(object sender, EventArgs e)
        {
            pnlCambiarFecha.Visible = false;
        }
    }
}
