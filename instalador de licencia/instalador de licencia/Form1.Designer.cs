namespace instalador_de_licencia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CmdInstalar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdInstalar
            // 
            this.CmdInstalar.Location = new System.Drawing.Point(32, 8);
            this.CmdInstalar.Name = "CmdInstalar";
            this.CmdInstalar.Size = new System.Drawing.Size(126, 43);
            this.CmdInstalar.TabIndex = 0;
            this.CmdInstalar.Text = "Instalar";
            this.CmdInstalar.UseVisualStyleBackColor = true;
            this.CmdInstalar.Click += new System.EventHandler(this.CmdInstalar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 63);
            this.Controls.Add(this.CmdInstalar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instalador de Licencia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdInstalar;
    }
}

