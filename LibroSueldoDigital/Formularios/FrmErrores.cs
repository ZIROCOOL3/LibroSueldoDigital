using LibroSueldoDigital.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace LibroSueldoDigital.Formularios
{
    public partial class FrmErrores : Telerik.WinControls.UI.RadForm
    {
        
        public FrmErrores()
        {

            InitializeComponent();
        }
        public List<ClassError> _ListaDeErrores = new List<ClassError>();
        public ClassError _ClassError = new ClassError();

        private void FrmErrores_Load(object sender, EventArgs e)
        {
            DtgDatos.DataSource = _ListaDeErrores;
            DtgDatos.Columns[0].Width = 50;
            DtgDatos.Columns[1].Width = 200;
        }
    }
}

