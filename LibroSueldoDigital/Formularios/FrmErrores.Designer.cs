namespace LibroSueldoDigital.Formularios
{
    partial class FrmErrores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmErrores));
            this.office2019LightTheme1 = new Telerik.WinControls.Themes.Office2019LightTheme();
            this.DtgDatos = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos.MasterTemplate)).BeginInit();
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
            this.DtgDatos.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.DtgDatos.MasterTemplate.AllowColumnReorder = false;
            this.DtgDatos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.DtgDatos.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.ReadOnly = true;
            this.DtgDatos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DtgDatos.ShowGroupPanel = false;
            this.DtgDatos.Size = new System.Drawing.Size(709, 246);
            this.DtgDatos.TabIndex = 0;
            // 
            // FrmErrores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 246);
            this.Controls.Add(this.DtgDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmErrores";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Errores";
            this.ThemeName = "Office2019Light";
            this.Load += new System.EventHandler(this.FrmErrores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2019LightTheme office2019LightTheme1;
        private Telerik.WinControls.UI.RadGridView DtgDatos;
    }
}
