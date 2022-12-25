
namespace AppGestionCitas.Clientes
{
    partial class frmAddCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCita));
            this.nombreLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.clienteTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.buttonExit = new DevExpress.XtraEditors.SimpleButton();
            this.buttonGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.inicioDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.inicioLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.finLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.finDateEdit = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inicioDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inicioDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabelControl
            // 
            this.nombreLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.nombreLabelControl.Location = new System.Drawing.Point(12, 26);
            this.nombreLabelControl.Name = "nombreLabelControl";
            this.nombreLabelControl.Size = new System.Drawing.Size(65, 13);
            this.nombreLabelControl.TabIndex = 0;
            this.nombreLabelControl.Text = "Cliente";
            // 
            // clienteTextEdit
            // 
            this.clienteTextEdit.Enabled = false;
            this.clienteTextEdit.EnterMoveNextControl = true;
            this.clienteTextEdit.Location = new System.Drawing.Point(83, 23);
            this.clienteTextEdit.Name = "clienteTextEdit";
            this.clienteTextEdit.Size = new System.Drawing.Size(637, 20);
            this.clienteTextEdit.TabIndex = 1;
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
            // inicioDateEdit
            // 
            this.inicioDateEdit.EditValue = null;
            this.inicioDateEdit.Location = new System.Drawing.Point(83, 50);
            this.inicioDateEdit.Name = "inicioDateEdit";
            this.inicioDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inicioDateEdit.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.inicioDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inicioDateEdit.Properties.MaskSettings.Set("mask", "g");
            this.inicioDateEdit.Size = new System.Drawing.Size(254, 20);
            this.inicioDateEdit.TabIndex = 12;
            // 
            // inicioLabelControl
            // 
            this.inicioLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.inicioLabelControl.Location = new System.Drawing.Point(12, 53);
            this.inicioLabelControl.Name = "inicioLabelControl";
            this.inicioLabelControl.Size = new System.Drawing.Size(65, 13);
            this.inicioLabelControl.TabIndex = 13;
            this.inicioLabelControl.Text = "Inicio Cita";
            // 
            // finLabelControl
            // 
            this.finLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.finLabelControl.Location = new System.Drawing.Point(395, 53);
            this.finLabelControl.Name = "finLabelControl";
            this.finLabelControl.Size = new System.Drawing.Size(65, 13);
            this.finLabelControl.TabIndex = 15;
            this.finLabelControl.Text = "Fin Cita";
            // 
            // finDateEdit
            // 
            this.finDateEdit.EditValue = null;
            this.finDateEdit.Location = new System.Drawing.Point(466, 50);
            this.finDateEdit.Name = "finDateEdit";
            this.finDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.finDateEdit.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.finDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.finDateEdit.Properties.MaskSettings.Set("mask", "g");
            this.finDateEdit.Size = new System.Drawing.Size(254, 20);
            this.finDateEdit.TabIndex = 14;
            // 
            // frmAddCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 331);
            this.Controls.Add(this.finLabelControl);
            this.Controls.Add(this.finDateEdit);
            this.Controls.Add(this.inicioLabelControl);
            this.Controls.Add(this.inicioDateEdit);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.clienteTextEdit);
            this.Controls.Add(this.nombreLabelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir Cliente";
            this.Load += new System.EventHandler(this.FrmAddCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inicioDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inicioDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl nombreLabelControl;
        private DevExpress.XtraEditors.TextEdit clienteTextEdit;
        private DevExpress.XtraEditors.SimpleButton buttonExit;
        private DevExpress.XtraEditors.SimpleButton buttonGuardar;
        private DevExpress.XtraEditors.DateEdit inicioDateEdit;
        private DevExpress.XtraEditors.LabelControl inicioLabelControl;
        private DevExpress.XtraEditors.LabelControl finLabelControl;
        private DevExpress.XtraEditors.DateEdit finDateEdit;
    }
}