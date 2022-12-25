using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppGestionCitas
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea salir realmente?", "Confirmar salida", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void ButtonCliente_Click(object sender, EventArgs e)
        {
            using (Clientes.frmListaClientes frmClientes = new Clientes.frmListaClientes())
            {
                frmClientes.ShowDialog();
            }
        }

        private void buttonCita_Click(object sender, EventArgs e)
        {
            using (Clientes.frmListaCitas frmCitas = new Clientes.frmListaCitas())
            {
                frmCitas.ShowDialog();
            }
        }
    }
}
