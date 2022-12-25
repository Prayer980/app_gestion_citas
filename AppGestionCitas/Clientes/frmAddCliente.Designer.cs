
namespace AppGestionCitas.Clientes
{
    partial class frmAddCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCliente));
            this.nombreLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.clienteTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.direccionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.localidadTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.telefonoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DNITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.direccionLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.telefonoLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.DNILabelControl = new DevExpress.XtraEditors.LabelControl();
            this.buttonExit = new DevExpress.XtraEditors.SimpleButton();
            this.buttonGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.localidadLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.CPLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.CPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.provinciaLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.comunidadLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.paisTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.paisLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.provinciaLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.comunidadLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DNITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comunidadLookUpEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabelControl
            // 
            this.nombreLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.nombreLabelControl.Location = new System.Drawing.Point(12, 26);
            this.nombreLabelControl.Name = "nombreLabelControl";
            this.nombreLabelControl.Size = new System.Drawing.Size(65, 13);
            this.nombreLabelControl.TabIndex = 0;
            this.nombreLabelControl.Text = "Nombre";
            // 
            // clienteTextEdit
            // 
            this.clienteTextEdit.Location = new System.Drawing.Point(83, 23);
            this.clienteTextEdit.Name = "clienteTextEdit";
            this.clienteTextEdit.Size = new System.Drawing.Size(637, 20);
            this.clienteTextEdit.TabIndex = 1;
            // 
            // direccionTextEdit
            // 
            this.direccionTextEdit.Location = new System.Drawing.Point(83, 49);
            this.direccionTextEdit.Name = "direccionTextEdit";
            this.direccionTextEdit.Size = new System.Drawing.Size(637, 20);
            this.direccionTextEdit.TabIndex = 2;
            // 
            // localidadTextEdit
            // 
            this.localidadTextEdit.Location = new System.Drawing.Point(83, 101);
            this.localidadTextEdit.Name = "localidadTextEdit";
            this.localidadTextEdit.Size = new System.Drawing.Size(353, 20);
            this.localidadTextEdit.TabIndex = 5;
            // 
            // telefonoTextEdit
            // 
            this.telefonoTextEdit.Location = new System.Drawing.Point(83, 75);
            this.telefonoTextEdit.Name = "telefonoTextEdit";
            this.telefonoTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.telefonoTextEdit.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.telefonoTextEdit.Properties.MaskSettings.Set("mask", "000-000-000");
            this.telefonoTextEdit.Size = new System.Drawing.Size(353, 20);
            this.telefonoTextEdit.TabIndex = 3;
            this.telefonoTextEdit.Enter += new System.EventHandler(this.TelefonoTextEdit_Enter);
            // 
            // DNITextEdit
            // 
            this.DNITextEdit.Location = new System.Drawing.Point(492, 75);
            this.DNITextEdit.Name = "DNITextEdit";
            this.DNITextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.DNITextEdit.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.DNITextEdit.Properties.MaskSettings.Set("mask", "00000000L");
            this.DNITextEdit.Size = new System.Drawing.Size(228, 20);
            this.DNITextEdit.TabIndex = 4;
            this.DNITextEdit.Enter += new System.EventHandler(this.DNITextEdit_Enter);
            // 
            // direccionLabelControl
            // 
            this.direccionLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.direccionLabelControl.Location = new System.Drawing.Point(12, 52);
            this.direccionLabelControl.Name = "direccionLabelControl";
            this.direccionLabelControl.Size = new System.Drawing.Size(65, 13);
            this.direccionLabelControl.TabIndex = 6;
            this.direccionLabelControl.Text = "Dirección";
            // 
            // telefonoLabelControl
            // 
            this.telefonoLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.telefonoLabelControl.Location = new System.Drawing.Point(12, 78);
            this.telefonoLabelControl.Name = "telefonoLabelControl";
            this.telefonoLabelControl.Size = new System.Drawing.Size(65, 13);
            this.telefonoLabelControl.TabIndex = 7;
            this.telefonoLabelControl.Text = "Teléfono";
            // 
            // DNILabelControl
            // 
            this.DNILabelControl.Appearance.Options.UseTextOptions = true;
            this.DNILabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DNILabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.DNILabelControl.Location = new System.Drawing.Point(442, 78);
            this.DNILabelControl.Name = "DNILabelControl";
            this.DNILabelControl.Size = new System.Drawing.Size(44, 13);
            this.DNILabelControl.TabIndex = 8;
            this.DNILabelControl.Text = "DNI";
            // 
            // buttonExit
            // 
            this.buttonExit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonExit.Appearance.Options.UseFont = true;
            this.buttonExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.ImageOptions.Image")));
            this.buttonExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.buttonExit.ImageOptions.ImageToTextIndent = 10;
            this.buttonExit.Location = new System.Drawing.Point(12, 255);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(708, 70);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Atras";
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonGuardar.Appearance.Options.UseFont = true;
            this.buttonGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.ImageOptions.Image")));
            this.buttonGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.buttonGuardar.ImageOptions.ImageToTextIndent = 10;
            this.buttonGuardar.Location = new System.Drawing.Point(12, 179);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(708, 70);
            this.buttonGuardar.TabIndex = 10;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // localidadLabelControl
            // 
            this.localidadLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.localidadLabelControl.Location = new System.Drawing.Point(12, 104);
            this.localidadLabelControl.Name = "localidadLabelControl";
            this.localidadLabelControl.Size = new System.Drawing.Size(65, 13);
            this.localidadLabelControl.TabIndex = 11;
            this.localidadLabelControl.Text = "Localidad";
            // 
            // CPLabelControl
            // 
            this.CPLabelControl.Appearance.Options.UseTextOptions = true;
            this.CPLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CPLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.CPLabelControl.Location = new System.Drawing.Point(442, 104);
            this.CPLabelControl.Name = "CPLabelControl";
            this.CPLabelControl.Size = new System.Drawing.Size(44, 13);
            this.CPLabelControl.TabIndex = 13;
            this.CPLabelControl.Text = "CP";
            // 
            // CPTextEdit
            // 
            this.CPTextEdit.Location = new System.Drawing.Point(492, 101);
            this.CPTextEdit.Name = "CPTextEdit";
            this.CPTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.CPTextEdit.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.CPTextEdit.Properties.MaskSettings.Set("mask", "00000");
            this.CPTextEdit.Size = new System.Drawing.Size(228, 20);
            this.CPTextEdit.TabIndex = 6;
            this.CPTextEdit.Enter += new System.EventHandler(this.CPTextEdit_Enter);
            // 
            // provinciaLabelControl
            // 
            this.provinciaLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.provinciaLabelControl.Location = new System.Drawing.Point(12, 130);
            this.provinciaLabelControl.Name = "provinciaLabelControl";
            this.provinciaLabelControl.Size = new System.Drawing.Size(65, 13);
            this.provinciaLabelControl.TabIndex = 14;
            this.provinciaLabelControl.Text = "Provincia";
            // 
            // comunidadLabelControl
            // 
            this.comunidadLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.comunidadLabelControl.Location = new System.Drawing.Point(12, 156);
            this.comunidadLabelControl.Name = "comunidadLabelControl";
            this.comunidadLabelControl.Size = new System.Drawing.Size(65, 13);
            this.comunidadLabelControl.TabIndex = 15;
            this.comunidadLabelControl.Text = "Comunidad";
            // 
            // paisTextEdit
            // 
            this.paisTextEdit.Location = new System.Drawing.Point(492, 153);
            this.paisTextEdit.Name = "paisTextEdit";
            this.paisTextEdit.Size = new System.Drawing.Size(228, 20);
            this.paisTextEdit.TabIndex = 9;
            // 
            // paisLabelControl
            // 
            this.paisLabelControl.Appearance.Options.UseTextOptions = true;
            this.paisLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.paisLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.paisLabelControl.Location = new System.Drawing.Point(442, 156);
            this.paisLabelControl.Name = "paisLabelControl";
            this.paisLabelControl.Size = new System.Drawing.Size(44, 13);
            this.paisLabelControl.TabIndex = 20;
            this.paisLabelControl.Text = "Pais";
            // 
            // provinciaLookUpEdit
            // 
            this.provinciaLookUpEdit.Location = new System.Drawing.Point(83, 127);
            this.provinciaLookUpEdit.Name = "provinciaLookUpEdit";
            this.provinciaLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.provinciaLookUpEdit.Properties.DisplayMember = "nombre";
            this.provinciaLookUpEdit.Properties.NullText = "";
            this.provinciaLookUpEdit.Properties.PopupSizeable = false;
            this.provinciaLookUpEdit.Properties.ValueMember = "id";
            this.provinciaLookUpEdit.Size = new System.Drawing.Size(353, 20);
            this.provinciaLookUpEdit.TabIndex = 7;
            // 
            // comunidadLookUpEdit
            // 
            this.comunidadLookUpEdit.Location = new System.Drawing.Point(83, 153);
            this.comunidadLookUpEdit.Name = "comunidadLookUpEdit";
            this.comunidadLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comunidadLookUpEdit.Properties.DisplayMember = "nombre";
            this.comunidadLookUpEdit.Properties.NullText = "";
            this.comunidadLookUpEdit.Properties.PopupSizeable = false;
            this.comunidadLookUpEdit.Properties.ValueMember = "id";
            this.comunidadLookUpEdit.Size = new System.Drawing.Size(353, 20);
            this.comunidadLookUpEdit.TabIndex = 8;
            // 
            // frmAddCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 331);
            this.Controls.Add(this.paisLabelControl);
            this.Controls.Add(this.paisTextEdit);
            this.Controls.Add(this.comunidadLabelControl);
            this.Controls.Add(this.provinciaLabelControl);
            this.Controls.Add(this.CPLabelControl);
            this.Controls.Add(this.CPTextEdit);
            this.Controls.Add(this.localidadLabelControl);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.DNILabelControl);
            this.Controls.Add(this.telefonoLabelControl);
            this.Controls.Add(this.direccionLabelControl);
            this.Controls.Add(this.DNITextEdit);
            this.Controls.Add(this.telefonoTextEdit);
            this.Controls.Add(this.localidadTextEdit);
            this.Controls.Add(this.direccionTextEdit);
            this.Controls.Add(this.clienteTextEdit);
            this.Controls.Add(this.nombreLabelControl);
            this.Controls.Add(this.provinciaLookUpEdit);
            this.Controls.Add(this.comunidadLookUpEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir Cliente";
            this.Load += new System.EventHandler(this.FrmAddCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DNITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comunidadLookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl nombreLabelControl;
        private DevExpress.XtraEditors.TextEdit clienteTextEdit;
        private DevExpress.XtraEditors.TextEdit direccionTextEdit;
        private DevExpress.XtraEditors.TextEdit localidadTextEdit;
        private DevExpress.XtraEditors.TextEdit telefonoTextEdit;
        private DevExpress.XtraEditors.TextEdit DNITextEdit;
        private DevExpress.XtraEditors.LabelControl direccionLabelControl;
        private DevExpress.XtraEditors.LabelControl telefonoLabelControl;
        private DevExpress.XtraEditors.LabelControl DNILabelControl;
        private DevExpress.XtraEditors.SimpleButton buttonExit;
        private DevExpress.XtraEditors.SimpleButton buttonGuardar;
        private DevExpress.XtraEditors.LabelControl localidadLabelControl;
        private DevExpress.XtraEditors.LabelControl CPLabelControl;
        private DevExpress.XtraEditors.TextEdit CPTextEdit;
        private DevExpress.XtraEditors.LabelControl provinciaLabelControl;
        private DevExpress.XtraEditors.LabelControl comunidadLabelControl;
        private DevExpress.XtraEditors.TextEdit paisTextEdit;
        private DevExpress.XtraEditors.LabelControl paisLabelControl;
        private DevExpress.XtraEditors.LookUpEdit provinciaLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit comunidadLookUpEdit;
    }
}