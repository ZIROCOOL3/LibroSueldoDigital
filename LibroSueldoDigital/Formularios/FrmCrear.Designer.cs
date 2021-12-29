namespace LibroSueldoDigital.Formularios
{
    partial class FrmCrear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrear));
            this.office2019LightTheme1 = new Telerik.WinControls.Themes.Office2019LightTheme();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtRuta = new Telerik.WinControls.UI.RadTextBox();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.PgbProceso = new Telerik.WinControls.UI.RadProgressBarElement();
            this.TxtNombreHoja = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.HiloCrearArchivo = new System.ComponentModel.BackgroundWorker();
            this.TxtPeriodo = new Telerik.WinControls.UI.RadTextBox();
            this.LblPeriodo = new Telerik.WinControls.UI.RadLabel();
            this.OfdAbrirArchivo = new System.Windows.Forms.OpenFileDialog();
            this.LblIdentificacionEnvio = new Telerik.WinControls.UI.RadLabel();
            this.LblTipoLiquidacion = new Telerik.WinControls.UI.RadLabel();
            this.CmbIdentificacionEnvio = new Telerik.WinControls.UI.RadDropDownList();
            this.CmbTipoLiquidacion = new Telerik.WinControls.UI.RadDropDownList();
            this.radRadialGauge1 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.CmdProcesar = new Telerik.WinControls.UI.RadButton();
            this.CmbSeleccionarArchivo = new Telerik.WinControls.UI.RadButton();
            this.LblNumeroLiquidacion = new Telerik.WinControls.UI.RadLabel();
            this.TxtNumeroDeLiquidaicon = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombreHoja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblIdentificacionEnvio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblTipoLiquidacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIdentificacionEnvio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbTipoLiquidacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmdProcesar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbSeleccionarArchivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblNumeroLiquidacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumeroDeLiquidaicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(15, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(126, 19);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Ruta del Archivo Excel";
            this.radLabel1.ThemeName = "Office2019Light";
            // 
            // TxtRuta
            // 
            this.TxtRuta.Location = new System.Drawing.Point(17, 36);
            this.TxtRuta.Name = "TxtRuta";
            this.TxtRuta.Size = new System.Drawing.Size(278, 22);
            this.TxtRuta.TabIndex = 0;
            this.TxtRuta.ThemeName = "Office2019Light";
            this.TxtRuta.TextChanged += new System.EventHandler(this.radTextBox1_TextChanged);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement1,
            this.PgbProceso});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 214);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(631, 24);
            this.radStatusStrip1.TabIndex = 4;
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.Name = "radLabelElement1";
            this.radStatusStrip1.SetSpring(this.radLabelElement1, false);
            this.radLabelElement1.Text = "Procesos:";
            this.radLabelElement1.TextWrap = true;
            // 
            // PgbProceso
            // 
            this.PgbProceso.DefaultSize = new System.Drawing.Size(50, 20);
            this.PgbProceso.Minimum = 0;
            this.PgbProceso.MinSize = new System.Drawing.Size(500, 0);
            this.PgbProceso.Name = "PgbProceso";
            this.PgbProceso.SeparatorColor1 = System.Drawing.Color.White;
            this.PgbProceso.SeparatorColor2 = System.Drawing.Color.White;
            this.PgbProceso.SeparatorColor3 = System.Drawing.Color.White;
            this.PgbProceso.SeparatorColor4 = System.Drawing.Color.White;
            this.PgbProceso.SeparatorGradientAngle = 0;
            this.PgbProceso.SeparatorGradientPercentage1 = 0.4F;
            this.PgbProceso.SeparatorGradientPercentage2 = 0.6F;
            this.PgbProceso.SeparatorNumberOfColors = 2;
            this.PgbProceso.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.radStatusStrip1.SetSpring(this.PgbProceso, false);
            this.PgbProceso.StepWidth = 14;
            this.PgbProceso.SweepAngle = 90;
            this.PgbProceso.Text = "";
            this.PgbProceso.Value1 = 0;
            this.PgbProceso.Value2 = 0;
            // 
            // TxtNombreHoja
            // 
            this.TxtNombreHoja.Location = new System.Drawing.Point(306, 36);
            this.TxtNombreHoja.Name = "TxtNombreHoja";
            this.TxtNombreHoja.Size = new System.Drawing.Size(95, 22);
            this.TxtNombreHoja.TabIndex = 1;
            this.TxtNombreHoja.Text = "PASO3";
            this.TxtNombreHoja.ThemeName = "Office2019Light";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(304, 12);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(108, 19);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Nombre de la hoja";
            this.radLabel2.ThemeName = "Office2019Light";
            // 
            // HiloCrearArchivo
            // 
            this.HiloCrearArchivo.WorkerReportsProgress = true;
            this.HiloCrearArchivo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.HiloCrearArchivo_DoWork);
            this.HiloCrearArchivo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.HiloCrearArchivo_ProgressChanged);
            this.HiloCrearArchivo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.HiloCrearArchivo_RunWorkerCompleted);
            // 
            // TxtPeriodo
            // 
            this.TxtPeriodo.Location = new System.Drawing.Point(17, 101);
            this.TxtPeriodo.MaxLength = 6;
            this.TxtPeriodo.Name = "TxtPeriodo";
            this.TxtPeriodo.NullText = "AAAAMM";
            this.TxtPeriodo.Size = new System.Drawing.Size(105, 22);
            this.TxtPeriodo.TabIndex = 3;
            this.TxtPeriodo.ThemeName = "Office2019Light";
            this.TxtPeriodo.Visible = false;
            // 
            // LblPeriodo
            // 
            this.LblPeriodo.Location = new System.Drawing.Point(17, 77);
            this.LblPeriodo.Name = "LblPeriodo";
            this.LblPeriodo.Size = new System.Drawing.Size(49, 19);
            this.LblPeriodo.TabIndex = 7;
            this.LblPeriodo.Text = "Periodo";
            this.LblPeriodo.ThemeName = "Office2019Light";
            this.LblPeriodo.Visible = false;
            // 
            // OfdAbrirArchivo
            // 
            this.OfdAbrirArchivo.FileName = "openFileDialog1";
            // 
            // LblIdentificacionEnvio
            // 
            this.LblIdentificacionEnvio.Location = new System.Drawing.Point(135, 77);
            this.LblIdentificacionEnvio.Name = "LblIdentificacionEnvio";
            this.LblIdentificacionEnvio.Size = new System.Drawing.Size(129, 19);
            this.LblIdentificacionEnvio.TabIndex = 9;
            this.LblIdentificacionEnvio.Text = "Identificacion de Envio";
            this.LblIdentificacionEnvio.ThemeName = "Office2019Light";
            this.LblIdentificacionEnvio.Visible = false;
            // 
            // LblTipoLiquidacion
            // 
            this.LblTipoLiquidacion.Location = new System.Drawing.Point(278, 76);
            this.LblTipoLiquidacion.Name = "LblTipoLiquidacion";
            this.LblTipoLiquidacion.Size = new System.Drawing.Size(114, 19);
            this.LblTipoLiquidacion.TabIndex = 11;
            this.LblTipoLiquidacion.Text = "Tipo de Liquidacion";
            this.LblTipoLiquidacion.ThemeName = "Office2019Light";
            this.LblTipoLiquidacion.Visible = false;
            // 
            // CmbIdentificacionEnvio
            // 
            this.CmbIdentificacionEnvio.DropDownAnimationEnabled = true;
            this.CmbIdentificacionEnvio.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.CmbIdentificacionEnvio.Location = new System.Drawing.Point(137, 101);
            this.CmbIdentificacionEnvio.Name = "CmbIdentificacionEnvio";
            this.CmbIdentificacionEnvio.Size = new System.Drawing.Size(125, 22);
            this.CmbIdentificacionEnvio.TabIndex = 4;
            this.CmbIdentificacionEnvio.Text = "radDropDownList1";
            this.CmbIdentificacionEnvio.ThemeName = "Office2019Light";
            this.CmbIdentificacionEnvio.Visible = false;
            // 
            // CmbTipoLiquidacion
            // 
            this.CmbTipoLiquidacion.DropDownAnimationEnabled = true;
            this.CmbTipoLiquidacion.Location = new System.Drawing.Point(278, 101);
            this.CmbTipoLiquidacion.Name = "CmbTipoLiquidacion";
            this.CmbTipoLiquidacion.Size = new System.Drawing.Size(125, 22);
            this.CmbTipoLiquidacion.TabIndex = 5;
            this.CmbTipoLiquidacion.Text = "radDropDownList1";
            this.CmbTipoLiquidacion.ThemeName = "Office2019Light";
            this.CmbTipoLiquidacion.Visible = false;
            // 
            // radRadialGauge1
            // 
            this.radRadialGauge1.Location = new System.Drawing.Point(76, 159);
            this.radRadialGauge1.Name = "radRadialGauge1";
            this.radRadialGauge1.Size = new System.Drawing.Size(8, 8);
            this.radRadialGauge1.TabIndex = 12;
            this.radRadialGauge1.Text = "radRadialGauge1";
            // 
            // CmdProcesar
            // 
            this.CmdProcesar.Image = global::LibroSueldoDigital.Properties.Resources.procesar_32;
            this.CmdProcesar.Location = new System.Drawing.Point(250, 159);
            this.CmdProcesar.Name = "CmdProcesar";
            this.CmdProcesar.Size = new System.Drawing.Size(142, 34);
            this.CmdProcesar.TabIndex = 7;
            this.CmdProcesar.Text = "Procesar";
            this.CmdProcesar.ThemeName = "Office2019Light";
            this.CmdProcesar.Click += new System.EventHandler(this.CmdProcesar_Click);
            // 
            // CmbSeleccionarArchivo
            // 
            this.CmbSeleccionarArchivo.Image = global::LibroSueldoDigital.Properties.Resources.buscar_32;
            this.CmbSeleccionarArchivo.Location = new System.Drawing.Point(425, 24);
            this.CmbSeleccionarArchivo.Name = "CmbSeleccionarArchivo";
            this.CmbSeleccionarArchivo.Size = new System.Drawing.Size(142, 34);
            this.CmbSeleccionarArchivo.TabIndex = 2;
            this.CmbSeleccionarArchivo.Text = "Seleccionar";
            this.CmbSeleccionarArchivo.ThemeName = "Office2019Light";
            this.CmbSeleccionarArchivo.Click += new System.EventHandler(this.CmbSeleccionarArchivo_Click);
            // 
            // LblNumeroLiquidacion
            // 
            this.LblNumeroLiquidacion.Location = new System.Drawing.Point(422, 76);
            this.LblNumeroLiquidacion.Name = "LblNumeroLiquidacion";
            this.LblNumeroLiquidacion.Size = new System.Drawing.Size(134, 19);
            this.LblNumeroLiquidacion.TabIndex = 15;
            this.LblNumeroLiquidacion.Text = "Numero de Liquidacion";
            this.LblNumeroLiquidacion.ThemeName = "Office2019Light";
            // 
            // TxtNumeroDeLiquidaicon
            // 
            this.TxtNumeroDeLiquidaicon.Location = new System.Drawing.Point(425, 103);
            this.TxtNumeroDeLiquidaicon.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.TxtNumeroDeLiquidaicon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtNumeroDeLiquidaicon.Name = "TxtNumeroDeLiquidaicon";
            this.TxtNumeroDeLiquidaicon.Size = new System.Drawing.Size(126, 20);
            this.TxtNumeroDeLiquidaicon.TabIndex = 6;
            this.TxtNumeroDeLiquidaicon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 238);
            this.Controls.Add(this.TxtNumeroDeLiquidaicon);
            this.Controls.Add(this.LblNumeroLiquidacion);
            this.Controls.Add(this.radRadialGauge1);
            this.Controls.Add(this.CmbTipoLiquidacion);
            this.Controls.Add(this.CmbIdentificacionEnvio);
            this.Controls.Add(this.LblTipoLiquidacion);
            this.Controls.Add(this.LblIdentificacionEnvio);
            this.Controls.Add(this.TxtPeriodo);
            this.Controls.Add(this.LblPeriodo);
            this.Controls.Add(this.TxtNombreHoja);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.CmdProcesar);
            this.Controls.Add(this.CmbSeleccionarArchivo);
            this.Controls.Add(this.TxtRuta);
            this.Controls.Add(this.radLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCrear";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Libro";
            this.ThemeName = "Office2019Light";
            this.Load += new System.EventHandler(this.FrmCrearLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombreHoja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblIdentificacionEnvio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblTipoLiquidacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIdentificacionEnvio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbTipoLiquidacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmdProcesar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbSeleccionarArchivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblNumeroLiquidacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumeroDeLiquidaicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2019LightTheme office2019LightTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox TxtRuta;
        private Telerik.WinControls.UI.RadButton CmbSeleccionarArchivo;
        private Telerik.WinControls.UI.RadButton CmdProcesar;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        private Telerik.WinControls.UI.RadProgressBarElement PgbProceso;
        private Telerik.WinControls.UI.RadTextBox TxtNombreHoja;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.ComponentModel.BackgroundWorker HiloCrearArchivo;
        private Telerik.WinControls.UI.RadTextBox TxtPeriodo;
        private Telerik.WinControls.UI.RadLabel LblPeriodo;
        private System.Windows.Forms.OpenFileDialog OfdAbrirArchivo;
        private Telerik.WinControls.UI.RadLabel LblIdentificacionEnvio;
        private Telerik.WinControls.UI.RadLabel LblTipoLiquidacion;
        private Telerik.WinControls.UI.RadDropDownList CmbIdentificacionEnvio;
        private Telerik.WinControls.UI.RadDropDownList CmbTipoLiquidacion;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge1;
        private Telerik.WinControls.UI.RadLabel LblNumeroLiquidacion;
        private System.Windows.Forms.NumericUpDown TxtNumeroDeLiquidaicon;
    }
}
