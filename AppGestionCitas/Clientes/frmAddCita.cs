using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
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
    public partial class frmAddCita : DevExpress.XtraEditors.XtraForm
    {
        Int64 idCliente;
        string nombreCliente;

        public frmAddCita(Int64 idClienteParam, string nombreClienteParam)
        {
            idCliente = idClienteParam;
            nombreCliente = nombreClienteParam;
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddCliente_Load(object sender, EventArgs e)
        {
            clienteTextEdit.Text = nombreCliente;
            inicioDateEdit.EditValue = DateTime.Now;
            finDateEdit.EditValue = DateTime.Now;
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (clienteTextEdit.Text == null || inicioDateEdit.EditValue == null || inicioDateEdit.EditValue.ToString() == string.Empty || finDateEdit.EditValue == null || finDateEdit.EditValue.ToString() == string.Empty)
            {
                XtraMessageBox.Show("Error, debe rellenar todos los campos", "Error", MessageBoxButtons.OK);
            }

            AccesoDB.CCitas cita = new AccesoDB.CCitas();
            cita.nombre = nombreCliente;
            cita.inicioCita = Convert.ToDateTime(inicioDateEdit.EditValue);
            cita.finCita = Convert.ToDateTime(finDateEdit.EditValue);
            cita.estado = false;
            cita.idCliente = idCliente;


            if (AccesoDB.AccesoCitas.InsertarCita(cita))
            {
                XtraMessageBox.Show("Cita guardada correctamente", "Información", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Error durante el guardado de la cita", "Error", MessageBoxButtons.OK);
            }
        }

    }

}