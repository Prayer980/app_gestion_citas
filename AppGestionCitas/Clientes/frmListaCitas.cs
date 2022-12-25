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
    public partial class frmListaCitas : DevExpress.XtraEditors.XtraForm
    {
        public frmListaCitas()
        {
            InitializeComponent();
        }

        private void FrmListaCitas_Load(object sender, EventArgs e)
        {
            toggleSwitch1.IsOn = false;
            Refrescar(toggleSwitch1.IsOn);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefrescarSimpleButton_Click(object sender, EventArgs e)
        {
            Refrescar(toggleSwitch1.IsOn);
        }

        private void Refrescar(bool estado)
        {
            List<AccesoDB.CCitas> listaCitas = AccesoDB.AccesoCitas.ObtenerCitasEstado(estado);
            gcCitas.DataSource = listaCitas;
        }

        private void DeleteSimpleButton_Click(object sender, EventArgs e)
        {
            if (gvCitas.GetSelectedRows().Length > 0)
            {
                Int64 idCLiente = Convert.ToInt64(gvCitas.GetRowCellValue(gvCitas.GetSelectedRows()[0], "id").ToString());
                bool estado = Convert.ToBoolean(gvCitas.GetRowCellValue(gvCitas.GetSelectedRows()[0], "estado").ToString());
                
                if (estado == true || (estado == false && XtraMessageBox.Show("¿Desea borrar una cita no completada?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    if (AccesoDB.AccesoCitas.BorrarCitaId(idCLiente))
                    {
                        XtraMessageBox.Show("Cita borrada correctamente", "Información", MessageBoxButtons.OK);
                        this.Refrescar(toggleSwitch1.IsOn);
                    }
                    else
                    {
                        XtraMessageBox.Show("Error durante el borrado de al cita", "Error", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("No se ha selecionado cita", "Error", MessageBoxButtons.OK);
            }
        }

        private void EstadoSimpleButton_Click(object sender, EventArgs e)
        {
            if (gvCitas.GetSelectedRows().Length > 0)
            {
                int idCita = Convert.ToInt32(gvCitas.GetRowCellValue(gvCitas.GetSelectedRows()[0], "id"));
                if (AccesoDB.AccesoCitas.ActualizarCita(idCita))
                {
                    XtraMessageBox.Show("Cita completada correctamente", "Información", MessageBoxButtons.OK);
                    this.Refrescar(toggleSwitch1.IsOn);
                }
            }
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            this.Refrescar(toggleSwitch1.IsOn);
        }
    }

}