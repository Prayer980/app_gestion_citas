using AppGestionCitas.AccesoDB;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionCitas.Clientes
{
    public partial class frmListaClientes : DevExpress.XtraEditors.XtraForm
    {
        public frmListaClientes()
        {
            InitializeComponent();
        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefrescarSimpleButton_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void AddSimpleButton_Click(object sender, EventArgs e)
        {
            using (frmAddCliente frmAdd = new frmAddCliente())
            {
                frmAdd.ShowDialog();
                Refrescar();
            }
        }

        private void Refrescar()
        {
            List<AccesoDB.CClientes> listaClientes = AccesoDB.AccesoClientes.ObtenerClientes();
            gcClientes.DataSource = listaClientes;
        }

        private void DeleteSimpleButton_Click(object sender, EventArgs e)
        {
            if (gvClientes.GetSelectedRows().Length > 0)
            {
                Int64 idCLiente = Convert.ToInt64(gvClientes.GetRowCellValue(gvClientes.GetSelectedRows()[0], "id").ToString());

                if (AccesoDB.AccesoClientes.BorrarCliente(idCLiente))
                {
                    XtraMessageBox.Show("Cliente borrado correctamente", "Información", MessageBoxButtons.OK);
                    this.Refrescar();
                }
                else
                {
                    XtraMessageBox.Show("Error durante el borrado del cliente", "Error", MessageBoxButtons.OK);
                }

            }
            else
            {
                XtraMessageBox.Show("No se ha selecionado cliente", "Error", MessageBoxButtons.OK);
            }
        }

        private void ButtonAnadir_Click(object sender, EventArgs e)
        {
            if (gvClientes.GetSelectedRows().Length > 0)
            {
                Int64 idCliente = Convert.ToInt64(gvClientes.GetRowCellValue(gvClientes.GetSelectedRows()[0], "id").ToString());
                string nombreCliente = gvClientes.GetRowCellValue(gvClientes.GetSelectedRows()[0], "cliente").ToString();

                using (frmAddCita frmAdd = new frmAddCita(idCliente, nombreCliente))
                {
                    frmAdd.ShowDialog();
                }
            }
            else
            {
                XtraMessageBox.Show("No se ha selecionado cliente", "Error", MessageBoxButtons.OK);
            }
        }
    }
}