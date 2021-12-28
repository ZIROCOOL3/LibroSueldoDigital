namespace LibroSueldoDigital.Formularios
{
    partial class FrmDatosEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatosEmpresa));
            this.office2019LightTheme1 = new Telerik.WinControls.Themes.Office2019LightTheme();
            this.TxtRazonSocial = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.TxtCuit = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.CmbCancelar = new Telerik.WinControls.UI.RadButton();
            this.CmdGuardar = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.TxtDiaDePago = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRazonSocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmdGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDiaDePago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Location = new System.Drawing.Point(14, 33);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(278, 22);
            this.TxtRazonSocial.TabIndex = 0;
            this.TxtRazonSocial.ThemeName = "Office2019Light";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(78, 19);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "Razon Social:";
            this.radLabel1.ThemeName = "Office2019Light";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(14, 61);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(31, 19);
            this.radLabel2.TabIndex = 7;
            this.radLabel2.Text = "Cuit:";
            this.radLabel2.ThemeName = "Office2019Light";
            // 
            // TxtCuit
            // 
            this.TxtCuit.Location = new System.Drawing.Point(14, 82);
            this.TxtCuit.Mask = "##-########-#";
            this.TxtCuit.MaskType = Telerik.WinControls.UI.MaskType.Standard;
            this.TxtCuit.Name = "TxtCuit";
            this.TxtCuit.Size = new System.Drawing.Size(120, 22);
            this.TxtCuit.TabIndex = 1;
            this.TxtCuit.TabStop = false;
            this.TxtCuit.Text = "__-________-_";
            this.TxtCuit.ThemeName = "Office2019Light";
            // 
            // CmbCancelar
            // 
            this.CmbCancelar.Image = global::LibroSueldoDigital.Properties.Resources.cancelar_32;
            this.CmbCancelar.Location = new System.Drawing.Point(162, 152);
            this.CmbCancelar.Name = "CmbCancelar";
            this.CmbCancelar.Size = new System.Drawing.Size(142, 34);
            this.CmbCancelar.TabIndex = 4;
            this.CmbCancelar.Text = "Cancelar";
            this.CmbCancelar.ThemeName = "Office2019Light";
            this.CmbCancelar.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // CmdGuardar
            // 
            this.CmdGuardar.Image = global::LibroSueldoDigital.Properties.Resources.procesar_32;
            this.CmdGuardar.Location = new System.Drawing.Point(14, 152);
            this.CmdGuardar.Name = "CmdGuardar";
            this.CmdGuardar.Size = new System.Drawing.Size(142, 34);
            this.CmdGuardar.TabIndex = 3;
            this.CmdGuardar.Text = "Guardar";
            this.CmdGuardar.ThemeName = "Office2019Light";
            this.CmdGuardar.Click += new System.EventHandler(this.CmdGuardar_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(166, 61);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(73, 19);
            this.radLabel3.TabIndex = 17;
            this.radLabel3.Text = "Dia de Pago";
            this.radLabel3.ThemeName = "Office2019Light";
            // 
            // TxtDiaDePago
            // 
            this.TxtDiaDePago.Location = new System.Drawing.Point(165, 83);
            this.TxtDiaDePago.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.TxtDiaDePago.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtDiaDePago.Name = "TxtDiaDePago";
            this.TxtDiaDePago.Size = new System.Drawing.Size(126, 20);
            this.TxtDiaDePago.TabIndex = 2;
            this.TxtDiaDePago.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmDatosEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 198);
            this.Controls.Add(this.TxtDiaDePago);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.CmbCancelar);
            this.Controls.Add(this.TxtCuit);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.CmdGuardar);
            this.Controls.Add(this.TxtRazonSocial);
            this.Controls.Add(this.radLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDatosEmpresa";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de la Empresa";
            this.ThemeName = "Office2019Light";
            this.Load += new System.EventHandler(this.FrmDatosEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtRazonSocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmdGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDiaDePago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2019LightTheme office2019LightTheme1;
        private Telerik.WinControls.UI.RadButton CmdGuardar;
        private Telerik.WinControls.UI.RadTextBox TxtRazonSocial;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadMaskedEditBox TxtCuit;
        private Telerik.WinControls.UI.RadButton CmbCancelar;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private System.Windows.Forms.NumericUpDown TxtDiaDePago;
    }
}
