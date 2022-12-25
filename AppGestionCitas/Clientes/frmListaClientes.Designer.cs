
namespace AppGestionCitas.Clientes
{
    partial class frmListaClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaClientes));
            this.buttonExit = new DevExpress.XtraEditors.SimpleButton();
            this.gcClientes = new DevExpress.XtraGrid.GridControl();
            this.gvClientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClienteGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DireccionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DNIGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TelefonoGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LocalidadGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProvinciaGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ComunidadGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PaisGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdComunidadGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdProvinciaGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RefrescarSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.addSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonAnadir = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonExit.Appearance.Options.UseFont = true;
            this.buttonExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.ImageOptions.Image")));
            this.buttonExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.buttonExit.ImageOptions.ImageToTextIndent = 10;
            this.buttonExit.Location = new System.Drawing.Point(12, 398);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(885, 70);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Atras";
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // gcClientes
            // 
            this.gcClientes.Location = new System.Drawing.Point(12, 73);
            this.gcClientes.MainView = this.gvClientes;
            this.gcClientes.Name = "gcClientes";
            this.gcClientes.Size = new System.Drawing.Size(885, 319);
            this.gcClientes.TabIndex = 1;
            this.gcClientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvClientes});
            // 
            // gvClientes
            // 
            this.gvClientes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdGridColumn,
            this.ClienteGridColumn,
            this.DireccionGridColumn,
            this.DNIGridColumn,
            this.TelefonoGridColumn,
            this.LocalidadGridColumn,
            this.ProvinciaGridColumn,
            this.ComunidadGridColumn,
            this.PaisGridColumn,
            this.IdComunidadGridColumn,
            this.IdProvinciaGridColumn});
            this.gvClientes.GridControl = this.gcClientes;
            this.gvClientes.Name = "gvClientes";
            this.gvClientes.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvClientes.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvClientes.OptionsBehavior.AutoPopulateColumns = false;
            this.gvClientes.OptionsBehavior.Editable = false;
            this.gvClientes.OptionsView.ShowIndicator = false;
            // 
            // IdGridColumn
            // 
            this.IdGridColumn.Caption = "Id";
            this.IdGridColumn.FieldName = "id";
            this.IdGridColumn.Name = "IdGridColumn";
            // 
            // ClienteGridColumn
            // 
            this.ClienteGridColumn.Caption = "Cliente";
            this.ClienteGridColumn.FieldName = "cliente";
            this.ClienteGridColumn.Name = "ClienteGridColumn";
            this.ClienteGridColumn.Visible = true;
            this.ClienteGridColumn.VisibleIndex = 0;
            // 
            // DireccionGridColumn
            // 
            this.DireccionGridColumn.Caption = "Dirección";
            this.DireccionGridColumn.FieldName = "direccion";
            this.DireccionGridColumn.Name = "DireccionGridColumn";
            this.DireccionGridColumn.Visible = true;
            this.DireccionGridColumn.VisibleIndex = 1;
            // 
            // DNIGridColumn
            // 
            this.DNIGridColumn.Caption = "DNI";
            this.DNIGridColumn.FieldName = "dni";
            this.DNIGridColumn.Name = "DNIGridColumn";
            this.DNIGridColumn.Visible = true;
            this.DNIGridColumn.VisibleIndex = 2;
            // 
            // TelefonoGridColumn
            // 
            this.TelefonoGridColumn.Caption = "Telefono";
            this.TelefonoGridColumn.FieldName = "telefono";
            this.TelefonoGridColumn.Name = "TelefonoGridColumn";
            this.TelefonoGridColumn.Visible = true;
            this.TelefonoGridColumn.VisibleIndex = 3;
            // 
            // LocalidadGridColumn
            // 
            this.LocalidadGridColumn.Caption = "Localidad";
            this.LocalidadGridColumn.FieldName = "localidad";
            this.LocalidadGridColumn.Name = "LocalidadGridColumn";
            this.LocalidadGridColumn.Visible = true;
            this.LocalidadGridColumn.VisibleIndex = 4;
            // 
            // ProvinciaGridColumn
            // 
            this.ProvinciaGridColumn.Caption = "Provincia";
            this.ProvinciaGridColumn.FieldName = "provincia";
            this.ProvinciaGridColumn.Name = "ProvinciaGridColumn";
            this.ProvinciaGridColumn.Visible = true;
            this.ProvinciaGridColumn.VisibleIndex = 5;
            // 
            // ComunidadGridColumn
            // 
            this.ComunidadGridColumn.Caption = "Comunidad";
            this.ComunidadGridColumn.FieldName = "comunidad";
            this.ComunidadGridColumn.Name = "ComunidadGridColumn";
            this.ComunidadGridColumn.Visible = true;
            this.ComunidadGridColumn.VisibleIndex = 6;
            // 
            // PaisGridColumn
            // 
            this.PaisGridColumn.Caption = "Pais";
            this.PaisGridColumn.FieldName = "pais";
            this.PaisGridColumn.Name = "PaisGridColumn";
            this.PaisGridColumn.Visible = true;
            this.PaisGridColumn.VisibleIndex = 7;
            // 
            // IdComunidadGridColumn
            // 
            this.IdComunidadGridColumn.Caption = "IdComunidad";
            this.IdComunidadGridColumn.FieldName = "idComunidad";
            this.IdComunidadGridColumn.Name = "IdComunidadGridColumn";
            // 
            // IdProvinciaGridColumn
            // 
            this.IdProvinciaGridColumn.Caption = "IdProvincia";
            this.IdProvinciaGridColumn.FieldName = "idProvincia";
            this.IdProvinciaGridColumn.Name = "IdProvinciaGridColumn";
            // 
            // RefrescarSimpleButton
            // 
            this.RefrescarSimpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RefrescarSimpleButton.ImageOptions.Image")));
            this.RefrescarSimpleButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.RefrescarSimpleButton.ImageOptions.ImageToTextIndent = 10;
            this.RefrescarSimpleButton.Location = new System.Drawing.Point(757, 12);
            this.RefrescarSimpleButton.Name = "RefrescarSimpleButton";
            this.RefrescarSimpleButton.Size = new System.Drawing.Size(140, 55);
            this.RefrescarSimpleButton.TabIndex = 5;
            this.RefrescarSimpleButton.Text = "Refrescar";
            this.RefrescarSimpleButton.Click += new System.EventHandler(this.RefrescarSimpleButton_Click);
            // 
            // addSimpleButton
            // 
            this.addSimpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addSimpleButton.ImageOptions.Image")));
            this.addSimpleButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.addSimpleButton.ImageOptions.ImageToTextIndent = 10;
            this.addSimpleButton.Location = new System.Drawing.Point(12, 12);
            this.addSimpleButton.Name = "addSimpleButton";
            this.addSimpleButton.Size = new System.Drawing.Size(140, 55);
            this.addSimpleButton.TabIndex = 6;
            this.addSimpleButton.Text = "Añadir";
            this.addSimpleButton.Click += new System.EventHandler(this.AddSimpleButton_Click);
            // 
            // deleteSimpleButton
            // 
            this.deleteSimpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteSimpleButton.ImageOptions.Image")));
            this.deleteSimpleButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.deleteSimpleButton.ImageOptions.ImageToTextIndent = 10;
            this.deleteSimpleButton.Location = new System.Drawing.Point(158, 12);
            this.deleteSimpleButton.Name = "deleteSimpleButton";
            this.deleteSimpleButton.Size = new System.Drawing.Size(140, 55);
            this.deleteSimpleButton.TabIndex = 7;
            this.deleteSimpleButton.Text = "Eliminar";
            this.deleteSimpleButton.Click += new System.EventHandler(this.DeleteSimpleButton_Click);
            // 
            // ButtonAnadir
            // 
            this.ButtonAnadir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAnadir.ImageOptions.Image")));
            this.ButtonAnadir.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonAnadir.ImageOptions.ImageToTextIndent = 10;
            this.ButtonAnadir.Location = new System.Drawing.Point(331, 12);
            this.ButtonAnadir.Name = "ButtonAnadir";
            this.ButtonAnadir.Size = new System.Drawing.Size(140, 55);
            this.ButtonAnadir.TabIndex = 8;
            this.ButtonAnadir.Text = "Añadir Cita";
            this.ButtonAnadir.Click += new System.EventHandler(this.ButtonAnadir_Click);
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(304, 12);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(21, 55);
            this.separatorControl1.TabIndex = 9;
            // 
            // frmListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 480);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.ButtonAnadir);
            this.Controls.Add(this.deleteSimpleButton);
            this.Controls.Add(this.addSimpleButton);
            this.Controls.Add(this.RefrescarSimpleButton);
            this.Controls.Add(this.gcClientes);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Clientes";
            this.Load += new System.EventHandler(this.FrmListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton buttonExit;
        private DevExpress.XtraGrid.GridControl gcClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvClientes;
        private DevExpress.XtraGrid.Columns.GridColumn IdGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn ClienteGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn DireccionGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn DNIGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn LocalidadGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn ProvinciaGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn ComunidadGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn TelefonoGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn PaisGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn IdComunidadGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn IdProvinciaGridColumn;
        private DevExpress.XtraEditors.SimpleButton RefrescarSimpleButton;
        private DevExpress.XtraEditors.SimpleButton addSimpleButton;
        private DevExpress.XtraEditors.SimpleButton deleteSimpleButton;
        private DevExpress.XtraEditors.SimpleButton ButtonAnadir;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
    }
}