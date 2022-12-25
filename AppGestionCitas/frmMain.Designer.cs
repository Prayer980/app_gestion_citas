
namespace AppGestionCitas
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.buttonExit = new DevExpress.XtraEditors.SimpleButton();
            this.buttonCliente = new DevExpress.XtraEditors.SimpleButton();
            this.buttonCita = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonExit.Appearance.Options.UseFont = true;
            this.buttonExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.ImageOptions.Image")));
            this.buttonExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.buttonExit.ImageOptions.ImageToTextIndent = 10;
            this.buttonExit.Location = new System.Drawing.Point(12, 304);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(645, 70);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Salir";
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonCliente
            // 
            this.buttonCliente.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonCliente.Appearance.Options.UseFont = true;
            this.buttonCliente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonCliente.ImageOptions.Image")));
            this.buttonCliente.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.buttonCliente.ImageOptions.ImageToTextIndent = 10;
            this.buttonCliente.Location = new System.Drawing.Point(12, 12);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(645, 70);
            this.buttonCliente.TabIndex = 1;
            this.buttonCliente.Text = "Alta / Mantenimiento de cliente";
            this.buttonCliente.Click += new System.EventHandler(this.ButtonCliente_Click);
            // 
            // buttonCita
            // 
            this.buttonCita.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonCita.Appearance.Options.UseFont = true;
            this.buttonCita.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.buttonCita.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.buttonCita.ImageOptions.ImageToTextIndent = 10;
            this.buttonCita.Location = new System.Drawing.Point(12, 88);
            this.buttonCita.Name = "buttonCita";
            this.buttonCita.Size = new System.Drawing.Size(645, 70);
            this.buttonCita.TabIndex = 2;
            this.buttonCita.Text = "Citas";
            this.buttonCita.Click += new System.EventHandler(this.buttonCita_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 385);
            this.Controls.Add(this.buttonCita);
            this.Controls.Add(this.buttonCliente);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppGestionCitas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton buttonExit;
        private DevExpress.XtraEditors.SimpleButton buttonCliente;
        private DevExpress.XtraEditors.SimpleButton buttonCita;
    }
}

