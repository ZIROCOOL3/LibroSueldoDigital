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
            this.CmdProcesar = new Telerik.WinControls.UI.RadButton();
            this.CmbSeleccionarArchivo = new Telerik.WinControls.UI.RadButton();
            this.OfdAbrirArchivo = new Telerik.WinControls.UI.RadOpenFileDialog();
            this.TxtNombreHoja = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmdProcesar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbSeleccionarArchivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombreHoja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
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
            this.TxtRuta.TabIndex = 1;
            this.TxtRuta.ThemeName = "Office2019Light";
            this.TxtRuta.TextChanged += new System.EventHandler(this.radTextBox1_TextChanged);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement1,
            this.PgbProceso});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 155);
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
            this.PgbProceso.Minimum = 0;
            this.PgbProceso.MinSize = new System.Drawing.Size(300, 0);
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
            this.PgbProceso.Value1 = 100;
            this.PgbProceso.Value2 = 100;
            // 
            // CmdProcesar
            // 
            this.CmdProcesar.Image = global::LibroSueldoDigital.Properties.Resources.procesar_32;
            this.CmdProcesar.Location = new System.Drawing.Point(243, 99);
            this.CmdProcesar.Name = "CmdProcesar";
            this.CmdProcesar.Size = new System.Drawing.Size(142, 34);
            this.CmdProcesar.TabIndex = 3;
            this.CmdProcesar.Text = "Procesar";
            this.CmdProcesar.ThemeName = "Office2019Light";
            this.CmdProcesar.Click += new System.EventHandler(this.CmdProcesar_Click);
            // 
            // CmbSeleccionarArchivo
            // 
            this.CmbSeleccionarArchivo.Image = global::LibroSueldoDigital.Properties.Resources.buscar_32;
            this.CmbSeleccionarArchivo.Location = new System.Drawing.Point(415, 24);
            this.CmbSeleccionarArchivo.Name = "CmbSeleccionarArchivo";
            this.CmbSeleccionarArchivo.Size = new System.Drawing.Size(142, 34);
            this.CmbSeleccionarArchivo.TabIndex = 2;
            this.CmbSeleccionarArchivo.Text = "Seleccionar";
            this.CmbSeleccionarArchivo.ThemeName = "Office2019Light";
            this.CmbSeleccionarArchivo.Click += new System.EventHandler(this.CmbSeleccionarArchivo_Click);
            // 
            // OfdAbrirArchivo
            // 
            this.OfdAbrirArchivo.Filter = "";
            // 
            // TxtNombreHoja
            // 
            this.TxtNombreHoja.Location = new System.Drawing.Point(306, 36);
            this.TxtNombreHoja.Name = "TxtNombreHoja";
            this.TxtNombreHoja.Size = new System.Drawing.Size(79, 22);
            this.TxtNombreHoja.TabIndex = 6;
            this.TxtNombreHoja.Text = "Hoja1";
            this.TxtNombreHoja.ThemeName = "Office2019Light";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(301, 12);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(108, 19);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Nombre de la hoja";
            this.radLabel2.ThemeName = "Office2019Light";
            // 
            // FrmCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 179);
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
            ((System.ComponentModel.ISupportInitialize)(this.CmdProcesar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbSeleccionarArchivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombreHoja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
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
        private Telerik.WinControls.UI.RadOpenFileDialog OfdAbrirArchivo;
        private Telerik.WinControls.UI.RadTextBox TxtNombreHoja;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
