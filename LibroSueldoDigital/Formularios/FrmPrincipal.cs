using LibroSueldoDigital.Clases;
using LibroSueldoDigital.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace LibroSueldoDigital
{
    public partial class FrmPrincipal : Telerik.WinControls.UI.RadForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        ClassConsultas instConsultas = new ClassConsultas();
        private void CmbListarConceptos_Click(object sender, EventArgs e)
        {
            MostrarGid("conceptos",200,false);
        }

        private void CmdListarDatosFijos_Click(object sender, EventArgs e)
        {
            MostrarGid("datosfijos",200,true);
        }
        public void MostrarGid(string Tabla, int TamañoColumna,bool Mostrar1Columna)
        {
            DtgDatos.DataSource = instConsultas.TraerDatosBase(Tabla);
            DtgDatos.Columns[0].IsVisible = Mostrar1Columna;
            foreach (var Columna in DtgDatos.Columns)
            {
                Columna.Width = TamañoColumna;
            }
        }

        private void CmbCrearLibro_Click(object sender, EventArgs e)
        {
            FrmCrear formCrearLibro = new FrmCrear();
            formCrearLibro.CrearLibro = true;
            formCrearLibro.Show();
        }

        private void CmbAgregarConcepto_Click(object sender, EventArgs e)
        {
            FrmCrear formCrearLibro = new FrmCrear();
            formCrearLibro.Conceptos = true;
            formCrearLibro.Show();
        }

        private void CmbAltaDatosFijos_Click(object sender, EventArgs e)
        {
            FrmCrear formCrearLibro = new FrmCrear();
            formCrearLibro.DatosFIjos = true;
            formCrearLibro.Show();
        }

        private void CmbDatosEmpresa_Click(object sender, EventArgs e)
        {
            FrmDatosEmpresa frmEmpresa = new FrmDatosEmpresa();
            frmEmpresa.ShowDialog();
        }
    }
}
