
namespace AppGestionCitas.Clientes
{
    partial class frmListaCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaCitas));
            this.buttonExit = new DevExpress.XtraEditors.SimpleButton();
            this.RefrescarSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.gvCitas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InicioGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FinGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EstadoGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCitas = new DevExpress.XtraGrid.GridControl();
            this.estadoSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.gvCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
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
            // RefrescarSimpleButton
            // 
            this.RefrescarSimpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RefrescarSimpleButton.ImageOptions.Image")));
            this.RefrescarSimpleButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.RefrescarSimpleButton.ImageOptions.ImageToTextIndent = 10;
            this.RefrescarSimpleButton.Location = new System.Drawing.Point(757, 26);
            this.RefrescarSimpleButton.Name = "RefrescarSimpleButton";
            this.RefrescarSimpleButton.Size = new System.Drawing.Size(140, 55);
            this.RefrescarSimpleButton.TabIndex = 5;
            this.RefrescarSimpleButton.Text = "Refrescar";
            this.RefrescarSimpleButton.Click += new System.EventHandler(this.RefrescarSimpleButton_Click);
            // 
            // deleteSimpleButton
            // 
            this.deleteSimpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteSimpleButton.ImageOptions.Image")));
            this.deleteSimpleButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.deleteSimpleButton.ImageOptions.ImageToTextIndent = 10;
            this.deleteSimpleButton.Location = new System.Drawing.Point(158, 26);
            this.deleteSimpleButton.Name = "deleteSimpleButton";
            this.deleteSimpleButton.Size = new System.Drawing.Size(140, 55);
            this.deleteSimpleButton.TabIndex = 7;
            this.deleteSimpleButton.Text = "Eliminar";
            this.deleteSimpleButton.Click += new System.EventHandler(this.DeleteSimpleButton_Click);
            // 
            // gvCitas
            // 
            this.gvCitas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdGridColumn,
            this.NombreGridColumn,
            this.InicioGridColumn,
            this.FinGridColumn,
            this.EstadoGridColumn});
            this.gvCitas.GridControl = this.gcCitas;
            this.gvCitas.Name = "gvCitas";
            this.gvCitas.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCitas.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCitas.OptionsBehavior.AutoPopulateColumns = false;
            this.gvCitas.OptionsBehavior.Editable = false;
            this.gvCitas.OptionsView.ShowIndicator = false;
            // 
            // IdGridColumn
            // 
            this.IdGridColumn.Caption = "Id";
            this.IdGridColumn.FieldName = "id";
            this.IdGridColumn.Name = "IdGridColumn";
            // 
            // NombreGridColumn
            // 
            this.NombreGridColumn.Caption = "Nombre Cliente";
            this.NombreGridColumn.FieldName = "nombre";
            this.NombreGridColumn.Name = "NombreGridColumn";
            this.NombreGridColumn.Visible = true;
            this.NombreGridColumn.VisibleIndex = 0;
            // 
            // InicioGridColumn
            // 
            this.InicioGridColumn.Caption = "Inicio Cita";
            this.InicioGridColumn.DisplayFormat.FormatString = "d";
            this.InicioGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.InicioGridColumn.FieldName = "inicioCita";
            this.InicioGridColumn.GroupFormat.FormatString = "d";
            this.InicioGridColumn.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.InicioGridColumn.Name = "InicioGridColumn";
            this.InicioGridColumn.Visible = true;
            this.InicioGridColumn.VisibleIndex = 1;
            // 
            // FinGridColumn
            // 
            this.FinGridColumn.Caption = "Fin Cita";
            this.FinGridColumn.FieldName = "finCita";
            this.FinGridColumn.Name = "FinGridColumn";
            this.FinGridColumn.Visible = true;
            this.FinGridColumn.VisibleIndex = 2;
            // 
            // EstadoGridColumn
            // 
            this.EstadoGridColumn.Caption = "Estado";
            this.EstadoGridColumn.FieldName = "estado";
            this.EstadoGridColumn.Name = "EstadoGridColumn";
            this.EstadoGridColumn.Visible = true;
            this.EstadoGridColumn.VisibleIndex = 3;
            // 
            // gcCitas
            // 
            this.gcCitas.Location = new System.Drawing.Point(12, 87);
            this.gcCitas.MainView = this.gvCitas;
            this.gcCitas.Name = "gcCitas";
            this.gcCitas.Size = new System.Drawing.Size(885, 305);
            this.gcCitas.TabIndex = 1;
            this.gcCitas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCitas});
            // 
            // estadoSimpleButton
            // 
            this.estadoSimpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("estadoSimpleButton.ImageOptions.Image")));
            this.estadoSimpleButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.estadoSimpleButton.ImageOptions.ImageToTextIndent = 10;
            this.estadoSimpleButton.Location = new System.Drawing.Point(12, 26);
            this.estadoSimpleButton.Name = "estadoSimpleButton";
            this.estadoSimpleButton.Size = new System.Drawing.Size(140, 55);
            this.estadoSimpleButton.TabIndex = 8;
            this.estadoSimpleButton.Text = "Completar cita";
            this.estadoSimpleButton.Click += new System.EventHandler(this.EstadoSimpleButton_Click);
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(345, 46);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.OffText = "Sin completar";
            this.toggleSwitch1.Properties.OnText = "Completadas";
            this.toggleSwitch1.Size = new System.Drawing.Size(150, 18);
            this.toggleSwitch1.TabIndex = 9;
            this.toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            // 
            // frmListaCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 480);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.estadoSimpleButton);
            this.Controls.Add(this.deleteSimpleButton);
            this.Controls.Add(this.RefrescarSimpleButton);
            this.Controls.Add(this.gcCitas);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListaCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Citas";
            this.Load += new System.EventHandler(this.FrmListaCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton buttonExit;
        private DevExpress.XtraEditors.SimpleButton RefrescarSimpleButton;
        private DevExpress.XtraEditors.SimpleButton deleteSimpleButton;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCitas;
        private DevExpress.XtraGrid.Columns.GridColumn IdGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NombreGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn InicioGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn FinGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn EstadoGridColumn;
        private DevExpress.XtraGrid.GridControl gcCitas;
        private DevExpress.XtraEditors.SimpleButton estadoSimpleButton;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
    }
}