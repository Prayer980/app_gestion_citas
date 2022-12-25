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
    public partial class frmAddCliente : DevExpress.XtraEditors.XtraForm
    {
        public frmAddCliente()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelefonoTextEdit_Enter(object sender, EventArgs e)
        {
            var edit = ((DevExpress.XtraEditors.TextEdit)sender);
            BeginInvoke(new MethodInvoker(() =>
            {
                edit.SelectionStart = 0;
                edit.SelectionLength = edit.Text.Length;
            }));
        }

        private void DNITextEdit_Enter(object sender, EventArgs e)
        {
            var edit = ((DevExpress.XtraEditors.TextEdit)sender);
            BeginInvoke(new MethodInvoker(() =>
            {
                edit.SelectionStart = 0;
                edit.SelectionLength = edit.Text.Length;
            }));
        }

        private void FrmAddCliente_Load(object sender, EventArgs e)
        {   List<AccesoDB.CProvincias> listaProvincias = AccesoDB.AccesoProvincias.ObtenerProvincias();
            List<AccesoDB.CComunidades> listaComunidades = AccesoDB.AccesoComunidades.ObtenerComunidades();

            provinciaLookUpEdit.Properties.DataSource = listaProvincias;
            comunidadLookUpEdit.Properties.DataSource = listaComunidades;
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (clienteTextEdit.Text == null || clienteTextEdit.Text == string.Empty || direccionTextEdit.Text == null || direccionTextEdit.Text == string.Empty || 
                telefonoTextEdit.Text == null || telefonoTextEdit.Text == string.Empty || DNITextEdit.Text == null || DNITextEdit.Text == string.Empty ||
                localidadTextEdit.Text == null || localidadTextEdit.Text == string.Empty || CPTextEdit.Text == null || CPTextEdit.Text == string.Empty ||
                provinciaLookUpEdit.EditValue == null || provinciaLookUpEdit.EditValue.ToString() == string.Empty || comunidadLookUpEdit.EditValue == null || comunidadLookUpEdit.EditValue.ToString() == string.Empty ||
                paisTextEdit.Text == null || paisTextEdit.Text == string.Empty)
            {
                XtraMessageBox.Show("Error, debe rellenar todos los campos", "Error", MessageBoxButtons.OK);
            }
            else
            {
                AccesoDB.CClientes cliente = new AccesoDB.CClientes();
                cliente.cliente = clienteTextEdit.Text;
                cliente.direccion = direccionTextEdit.Text;
                cliente.telefono = telefonoTextEdit.Text;
                cliente.dni = DNITextEdit.Text;
                cliente.localidad = localidadTextEdit.Text;
                cliente.cp = CPTextEdit.Text;
                cliente.idProvincia = Convert.ToInt32(provinciaLookUpEdit.EditValue);
                cliente.idComunidad = Convert.ToInt32(comunidadLookUpEdit.EditValue);
                cliente.pais = paisTextEdit.Text;

                if (AccesoDB.AccesoClientes.InsertarCliente(cliente))
                {
                    XtraMessageBox.Show("Cliente guardado correctamente", "Información", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Error durante el guardado del cliente", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void CPTextEdit_Enter(object sender, EventArgs e)
        {
            var edit = ((DevExpress.XtraEditors.TextEdit)sender);
            BeginInvoke(new MethodInvoker(() =>
            {
                edit.SelectionStart = 0;
                edit.SelectionLength = edit.Text.Length;
            }));
        }
    }
}