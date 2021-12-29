using LibroSueldoDigital.Clases;
using LibroSueldoDigital.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            //FrmCrear formCrearLibro = new FrmCrear();
            //formCrearLibro.Conceptos = true;
            //formCrearLibro.Show();
        }

        private void CmbAltaDatosFijos_Click(object sender, EventArgs e)
        {
            FrmCrear formCrearLibro = new FrmCrear();
            formCrearLibro.DatosFijosAlta = true;
            formCrearLibro.Show();
        }

        private void CmbDatosEmpresa_Click(object sender, EventArgs e)
        {
            FrmDatosEmpresa frmEmpresa = new FrmDatosEmpresa();
            frmEmpresa.ShowDialog();
        }

        private void CmdExportarCOnceptos_Click(object sender, EventArgs e)
        {
            
            DataTable dtConceptos = new DataTable();
            dtConceptos = instConsultas.TraerDatosBase("conceptos");
            if (dtConceptos.Rows.Count!=0)//fverifico que conceptos no este vacio
            {
                instConsultas.VerificarExixtenciaArchivo("-Conceptos");
                using (StreamWriter sw = File.CreateText(instConsultas.path))//
                {
                    foreach (DataRow item in dtConceptos.Rows)
                    {
                        sw.WriteLine(item["CodigoDeConcepto"].ToString() + Rellena(" ", item["CodigoDeConceptoEmpresa"].ToString(), 10, false) + Rellena(" ", item["Descripcion"].ToString(), 150,false) + item["MarcaDeRepeticion"].ToString() + item["AportesSistemaPrevisionalArgentinoSIPA"].ToString() + item["ContribucionesSistemaPrevisionalArgentinoSIPA"].ToString() + item["AportesINSSJyP"].ToString() + item["ContribucionesINSSJyP"].ToString() + item["AportesObraSocial"].ToString() + item["ContribucionesObraSocial"].ToString() + item["AportesFondoSolidariodeRedistribucion"].ToString() + item["ContribucionesFondoSolidariodeRedistribucion"].ToString() + item["AportesRENATEA"].ToString() + item["ContribucionesRENATEA"].ToString() +" "+ item["ContribucionesAsignacionesFamiliares"].ToString() +" " + item["ContribucionesFondoNacionaldeEmpleo"].ToString() +" "+ item["ContribucionesLeydeRiesgosdelTrabajo"].ToString() + item["AportesRegimenesDiferenciales"].ToString() +" " + item["AportesRegimenesEspeciales"].ToString()+ "         ");
                    }
                    
                }
               
                RadMessageBox.Show("Archivo txt Creado");
            }
            else
            {
                RadMessageBox.Show("La tabla concepto esta vacia");
            }


        }
        public string Rellena(string CaractRellenar, string Dato, int Longitud, bool RellenaIzquierda)
        {

            int N = 1;//relleno hasta 15 caracteres
            while (Dato.Length <= Longitud - 1)
            {
                if (RellenaIzquierda == true)
                {
                    Dato = CaractRellenar + Dato;
                }
                else
                {
                    Dato = Dato + CaractRellenar;
                }

                N++;
            }
            return Dato;

        }

        private void CmbModificarDatosFijos_Click(object sender, EventArgs e)
        {
            FrmCrear formCrearLibro = new FrmCrear();
            formCrearLibro.DatosFijosModificacion = true;
            formCrearLibro.Show();
        }

        private void CmbModificarConceptos_Click(object sender, EventArgs e)
        {

        }

        private void CmbAcercaDe_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frmAcerca = new FrmAcercaDe();
            frmAcerca.ShowDialog();
        
        }
    }
}
