namespace LibroSueldoDigital
{
    partial class FrmPrincipal
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.office2019LightTheme1 = new Telerik.WinControls.Themes.Office2019LightTheme();
            this.DtgDatos = new Telerik.WinControls.UI.RadGridView();
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarButtonGroup2 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.CmbAgregarConcepto = new Telerik.WinControls.UI.RadButtonElement();
            this.CmbModificarConceptos = new Telerik.WinControls.UI.RadButtonElement();
            this.CmbListarConceptos = new Telerik.WinControls.UI.RadButtonElement();
            this.CmdExportarCOnceptos = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarButtonGroup1 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.CmbAltaDatosFijos = new Telerik.WinControls.UI.RadButtonElement();
            this.CmbModificarDatosFijos = new Telerik.WinControls.UI.RadButtonElement();
            this.CmdListarDatosFijos = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup3 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarButtonGroup3 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.CmbCrearLibro = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup4 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarButtonGroup4 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.CmbDatosEmpresa = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup5 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarButtonGroup5 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.CmbAcercaDe = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonFormBehavior1 = new Telerik.WinControls.UI.RadRibbonFormBehavior();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgDatos
            // 
            this.DtgDatos.AutoSizeRows = true;
            this.DtgDatos.BackColor = System.Drawing.Color.White;
            this.DtgDatos.Cursor = System.Windows.Forms.Cursors.Default;
            this.DtgDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgDatos.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DtgDatos.ForeColor = System.Drawing.Color.Black;
            this.DtgDatos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DtgDatos.Location = new System.Drawing.Point(0, 171);
            // 
            // 
            // 
            this.DtgDatos.MasterTemplate.AllowAddNewRow = false;
            this.DtgDatos.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.ReadOnly = true;
            this.DtgDatos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DtgDatos.ShowGroupPanel = false;
            this.DtgDatos.Size = new System.Drawing.Size(811, 230);
            this.DtgDatos.TabIndex = 1;
            this.DtgDatos.ThemeName = "Office2019Light";
            this.DtgDatos.TitleText = "Datos FIjos";
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1});
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            this.radRibbonBar1.Size = new System.Drawing.Size(811, 171);
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Text = "Libro Sueldo Digital 1.2";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1,
            this.radRibbonBarGroup2,
            this.radRibbonBarGroup3,
            this.radRibbonBarGroup4,
            this.radRibbonBarGroup5});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Menu";
            this.ribbonTab1.UseMnemonic = false;
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarButtonGroup2,
            this.CmbListarConceptos,
            this.CmdExportarCOnceptos});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "Conceptos";
            // 
            // radRibbonBarButtonGroup2
            // 
            this.radRibbonBarButtonGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.CmbAgregarConcepto,
            this.CmbModificarConceptos});
            this.radRibbonBarButtonGroup2.Name = "radRibbonBarButtonGroup2";
            this.radRibbonBarButtonGroup2.Padding = new System.Windows.Forms.Padding(1);
            this.radRibbonBarButtonGroup2.ShowBorder = false;
            // 
            // CmbAgregarConcepto
            // 
            this.CmbAgregarConcepto.Image = global::LibroSueldoDigital.Properties.Resources.agregar_48;
            this.CmbAgregarConcepto.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.CmbAgregarConcepto.Name = "CmbAgregarConcepto";
            this.CmbAgregarConcepto.ShowBorder = false;
            this.CmbAgregarConcepto.Text = "Alta";
            this.CmbAgregarConcepto.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.CmbAgregarConcepto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CmbAgregarConcepto.Click += new System.EventHandler(this.CmbAgregarConcepto_Click);
            // 
            // CmbModificarConceptos
            // 
            this.CmbModificarConceptos.Image = global::LibroSueldoDigital.Properties.Resources.modificacion_48;
            this.CmbModificarConceptos.Name = "CmbModificarConceptos";
            this.CmbModificarConceptos.ShowBorder = false;
            this.CmbModificarConceptos.Text = "Modificar";
            this.CmbModificarConceptos.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.CmbModificarConceptos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CmbModificarConceptos.Click += new System.EventHandler(this.CmbModificarConceptos_Click);
            // 
            // CmbListarConceptos
            // 
            this.CmbListarConceptos.Image = global::LibroSueldoDigital.Properties.Resources.Ver_48;
            this.CmbListarConceptos.Name = "CmbListarConceptos";
            this.CmbListarConceptos.Text = "Listar";
            this.CmbListarConceptos.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.CmbListarConceptos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CmbListarConceptos.Click += new System.EventHandler(this.CmbListarConceptos_Click);
            // 
            // CmdExportarCOnceptos
            // 
            this.CmdExportarCOnceptos.Name = "CmdExportarCOnceptos";
            this.CmdExportarCOnceptos.Text = "Exportar";
            this.CmdExportarCOnceptos.Click += new System.EventHandler(this.CmdExportarCOnceptos_Click);
            // 
            // radRibbonBarGroup2
            // 
            this.radRibbonBarGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarButtonGroup1,
            this.CmdListarDatosFijos});
            this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
            this.radRibbonBarGroup2.Text = "Datos Fijos";
            // 
            // radRibbonBarButtonGroup1
            // 
            this.radRibbonBarButtonGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.CmbAltaDatosFijos,
            this.CmbModificarDatosFijos});
            this.radRibbonBarButtonGroup1.Name = "radRibbonBarButtonGroup1";
            this.radRibbonBarButtonGroup1.Padding = new System.Windows.Forms.Padding(1);
            this.radRibbonBarButtonGroup1.ShowBorder = false;
            // 
            // CmbAltaDatosFijos
            // 
            this.CmbAltaDatosFijos.Image = global::LibroSueldoDigital.Properties.Resources.agregar_48;
            this.CmbAltaDatosFijos.Name = "CmbAltaDatosFijos";
            this.CmbAltaDatosFijos.ShowBorder = false;
            this.CmbAltaDatosFijos.Text = "Alta";
            this.CmbAltaDatosFijos.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.CmbAltaDatosFijos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CmbAltaDatosFijos.Click += new System.EventHandler(this.CmbAltaDatosFijos_Click);
            // 
            // CmbModificarDatosFijos
            // 
            this.CmbModificarDatosFijos.Image = global::LibroSueldoDigital.Properties.Resources.modificacion_48;
            this.CmbModificarDatosFijos.Name = "CmbModificarDatosFijos";
            this.CmbModificarDatosFijos.ShowBorder = false;
            this.CmbModificarDatosFijos.Text = "Modificar";
            this.CmbModificarDatosFijos.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.CmbModificarDatosFijos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CmbModificarDatosFijos.Click += new System.EventHandler(this.CmbModificarDatosFijos_Click);
            // 
            // CmdListarDatosFijos
            // 
            this.CmdListarDatosFijos.Image = global::LibroSueldoDigital.Properties.Resources.Ver_48;
            this.CmdListarDatosFijos.Name = "CmdListarDatosFijos";
            this.CmdListarDatosFijos.Text = "Listar";
            this.CmdListarDatosFijos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CmdListarDatosFijos.Click += new System.EventHandler(this.CmdListarDatosFijos_Click);
            // 
            // radRibbonBarGroup3
            // 
            this.radRibbonBarGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarButtonGroup3});
            this.radRibbonBarGroup3.Name = "radRibbonBarGroup3";
            this.radRibbonBarGroup3.Text = "Libro Sueldo";
            // 
            // radRibbonBarButtonGroup3
            // 
            this.radRibbonBarButtonGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.CmbCrearLibro});
            this.radRibbonBarButtonGroup3.Name = "radRibbonBarButtonGroup3";
            this.radRibbonBarButtonGroup3.Padding = new System.Windows.Forms.Padding(1);
            this.radRibbonBarButtonGroup3.ShowBorder = false;
            // 
            // CmbCrearLibro
            // 
            this.CmbCrearLibro.Image = global::LibroSueldoDigital.Properties.Resources.crear_libro_48;
            this.CmbCrearLibro.Name = "CmbCrearLibro";
            this.CmbCrearLibro.ShowBorder = false;
            this.CmbCrearLibro.StretchVertically = false;
            this.CmbCrearLibro.Text = "Crear";
            this.CmbCrearLibro.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.CmbCrearLibro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CmbCrearLibro.Click += new System.EventHandler(this.CmbCrearLibro_Click);
            // 
            // radRibbonBarGroup4
            // 
            this.radRibbonBarGroup4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarButtonGroup4});
            this.radRibbonBarGroup4.Name = "radRibbonBarGroup4";
            this.radRibbonBarGroup4.Text = "Empresa";
            // 
            // radRibbonBarButtonGroup4
            // 
            this.radRibbonBarButtonGroup4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.CmbDatosEmpresa});
            this.radRibbonBarButtonGroup4.Name = "radRibbonBarButtonGroup4";
            this.radRibbonBarButtonGroup4.Padding = new System.Windows.Forms.Padding(1);
            this.radRibbonBarButtonGroup4.ShowBorder = false;
            // 
            // CmbDatosEmpresa
            // 
            this.CmbDatosEmpresa.Image = global::LibroSueldoDigital.Properties.Resources.empresa_48;
            this.CmbDatosEmpresa.Name = "CmbDatosEmpresa";
            this.CmbDatosEmpresa.ShowBorder = false;
            this.CmbDatosEmpresa.Text = "Datos";
            this.CmbDatosEmpresa.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.CmbDatosEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CmbDatosEmpresa.Click += new System.EventHandler(this.CmbDatosEmpresa_Click);
            // 
            // radRibbonBarGroup5
            // 
            this.radRibbonBarGroup5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarButtonGroup5});
            this.radRibbonBarGroup5.Name = "radRibbonBarGroup5";
            this.radRibbonBarGroup5.Text = "Info";
            // 
            // radRibbonBarButtonGroup5
            // 
            this.radRibbonBarButtonGroup5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.CmbAcercaDe});
            this.radRibbonBarButtonGroup5.Name = "radRibbonBarButtonGroup5";
            this.radRibbonBarButtonGroup5.Padding = new System.Windows.Forms.Padding(1);
            this.radRibbonBarButtonGroup5.ShowBorder = false;
            // 
            // CmbAcercaDe
            // 
            this.CmbAcercaDe.Image = global::LibroSueldoDigital.Properties.Resources.icon_48;
            this.CmbAcercaDe.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.CmbAcercaDe.Name = "CmbAcercaDe";
            this.CmbAcercaDe.ShowBorder = false;
            this.CmbAcercaDe.Text = "Acerca Del Programa";
            this.CmbAcercaDe.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.CmbAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CmbAcercaDe.Click += new System.EventHandler(this.CmbAcercaDe_Click);
            // 
            // radRibbonFormBehavior1
            // 
            this.radRibbonFormBehavior1.Form = this;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 401);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.radRibbonBar1);
            this.FormBehavior = this.radRibbonFormBehavior1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None;
            this.Name = "FrmPrincipal";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Libro Sueldo Digital 1.2";
            this.ThemeName = "Office2019Light";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2019LightTheme office2019LightTheme1;
        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RadRibbonFormBehavior radRibbonFormBehavior1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup2;
        private Telerik.WinControls.UI.RadButtonElement CmbAgregarConcepto;
        private Telerik.WinControls.UI.RadButtonElement CmbModificarConceptos;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup1;
        private Telerik.WinControls.UI.RadButtonElement CmbAltaDatosFijos;
        private Telerik.WinControls.UI.RadButtonElement CmbModificarDatosFijos;
        private Telerik.WinControls.UI.RadGridView DtgDatos;
        private Telerik.WinControls.UI.RadButtonElement CmbListarConceptos;
        private Telerik.WinControls.UI.RadButtonElement CmdListarDatosFijos;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup3;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup3;
        private Telerik.WinControls.UI.RadButtonElement CmbCrearLibro;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup4;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup4;
        private Telerik.WinControls.UI.RadButtonElement CmbDatosEmpresa;
        private Telerik.WinControls.UI.RadButtonElement CmdExportarCOnceptos;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup5;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup5;
        private Telerik.WinControls.UI.RadButtonElement CmbAcercaDe;
    }
}