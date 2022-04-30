using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibroSueldoDigital.Clases;

namespace LibroSueldoDigital
{
    public partial class mdConceptos : Telerik.WinControls.UI.RadForm
    {
        
        public Conceptos oConceptos { get; set; }
        public bool Editar { get; set; }
        public mdConceptos()
        {
            InitializeComponent();
        }

        private void mdCliente_Load(object sender, EventArgs e)
        {
            if (Editar)
            {
                if (oConceptos != null)
                {
                    txtCodigoDeConcepto.Text = oConceptos.CodigoDeConcepto.ToString();
                    txtDescripcion.Text = oConceptos.Descripcion.ToString();
                    txtCodigoDeConceptoEmpresa.Text = oConceptos.CodigoDeConceptoEmpresa.ToString();
                    txtDebitoCredito.Text = oConceptos.DebitoCredito.ToString();
                    txtMarcaDeRepeticion.Text = oConceptos.MarcaDeRepeticion.ToString();
                    txtAportesSistemaPrevisionalArgentinoSIPA.Text = oConceptos.AportesSistemaPrevisionalArgentinoSIPA.ToString();
                    txtContribucionesSistemaPrevisionalArgentinoSIPA.Text = oConceptos.ContribucionesSistemaPrevisionalArgentinoSIPA.ToString();
                    txtAportesINSSJyP.Text = oConceptos.AportesINSSJyP.ToString();
                    txtContribucionesINSSJyP.Text = oConceptos.ContribucionesINSSJyP.ToString();
                    txtAportesObraSocial.Text = oConceptos.AportesObraSocial.ToString();

                    txtContribucionesObraSocial.Text = oConceptos.ContribucionesObraSocial.ToString();
                    txtAportesFondoSolidariodeRedistribucion.Text = oConceptos.AportesFondoSolidariodeRedistribucion.ToString();
                    txtContribucionesFondoSolidariodeRedistribucion.Text = oConceptos.ContribucionesFondoSolidariodeRedistribucion.ToString();

                    txtAportesRENATEA.Text = oConceptos.AportesRENATEA.ToString();
                    txtContribucionesRENATEA.Text = oConceptos.ContribucionesRENATEA.ToString();
                    txtContribucionesAsignacionesFamiliares.Text = oConceptos.ContribucionesAsignacionesFamiliares.ToString();
                    txtContribucionesFondoNacionaldeEmpleo.Text = oConceptos.ContribucionesFondoNacionaldeEmpleo.ToString();
                    txtContribucionesLeydeRiesgosdelTrabajo.Text = oConceptos.ContribucionesLeydeRiesgosdelTrabajo.ToString();
                    txtAportesRegimenesDiferenciales.Text = oConceptos.AportesRegimenesDiferenciales.ToString();
                    txtAportesRegimenesEspeciales.Text = oConceptos.AportesRegimenesEspeciales.ToString();
                }
                btnAceptar.Text = "Modificar";
                this.Text="Modificaion de Conceptos";
            }
            else
            {
                txtDebitoCredito.SelectedIndex = 0;
                txtMarcaDeRepeticion.SelectedIndex = 0;
                txtAportesSistemaPrevisionalArgentinoSIPA.SelectedIndex = 0;
                txtContribucionesSistemaPrevisionalArgentinoSIPA.SelectedIndex = 0;
                txtAportesINSSJyP.SelectedIndex = 0;
                txtContribucionesINSSJyP.SelectedIndex = 0;
                txtAportesObraSocial.SelectedIndex = 0;
                txtContribucionesObraSocial.SelectedIndex = 0;
                txtAportesFondoSolidariodeRedistribucion.SelectedIndex = 0;
                txtContribucionesFondoSolidariodeRedistribucion.SelectedIndex = 0;
                txtAportesRENATEA.SelectedIndex = 0;
                txtContribucionesRENATEA.SelectedIndex = 0;
                txtContribucionesAsignacionesFamiliares.SelectedIndex = 0;
                txtContribucionesFondoNacionaldeEmpleo.SelectedIndex = 0;
                txtContribucionesLeydeRiesgosdelTrabajo.SelectedIndex = 0;
                txtAportesRegimenesDiferenciales.SelectedIndex = 0;
                txtAportesRegimenesEspeciales.SelectedIndex = 0;

            }
            
        }
   


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            if (txtCodigoDeConcepto.Text.Trim() == "" || txtDescripcion.Text.Trim() == "" || txtCodigoDeConceptoEmpresa.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar los campos obligatorios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Editar)
            {
                int _idtemp = oConceptos.idConceptos;
                int nroperacion = ClassConceptos.Instancia.Editar(new Conceptos()
                {
                    idConceptos = oConceptos.idConceptos,
                    //fk_empresa = oConceptos.fk_empresa,
                    CodigoDeConcepto = int.Parse(txtCodigoDeConcepto.Text),
                    Descripcion = txtDescripcion.Text,
                    CodigoDeConceptoEmpresa = int.Parse(txtCodigoDeConceptoEmpresa.Text),
                    DebitoCredito = txtDebitoCredito.Text,
                    MarcaDeRepeticion = int.Parse(txtMarcaDeRepeticion.Text),
                    AportesSistemaPrevisionalArgentinoSIPA = int.Parse(txtAportesSistemaPrevisionalArgentinoSIPA.Text),
                    ContribucionesSistemaPrevisionalArgentinoSIPA = int.Parse(txtContribucionesSistemaPrevisionalArgentinoSIPA.Text),
                    AportesINSSJyP = int.Parse(txtAportesINSSJyP.Text),
                    ContribucionesINSSJyP = int.Parse(txtContribucionesINSSJyP.Text),
                    AportesObraSocial = int.Parse(txtAportesObraSocial.Text),
                    ContribucionesObraSocial = int.Parse(txtContribucionesObraSocial.Text),
                    AportesFondoSolidariodeRedistribucion = int.Parse(txtAportesFondoSolidariodeRedistribucion.Text),
                    ContribucionesFondoSolidariodeRedistribucion = int.Parse(txtContribucionesFondoSolidariodeRedistribucion.Text),
                    AportesRENATEA = int.Parse(txtAportesRENATEA.Text),
                    ContribucionesRENATEA = int.Parse(txtContribucionesRENATEA.Text),
                    ContribucionesAsignacionesFamiliares = int.Parse(txtContribucionesAsignacionesFamiliares.Text),
                    ContribucionesFondoNacionaldeEmpleo = int.Parse(txtContribucionesFondoNacionaldeEmpleo.Text),
                    ContribucionesLeydeRiesgosdelTrabajo = int.Parse(txtContribucionesLeydeRiesgosdelTrabajo.Text),
                    AportesRegimenesDiferenciales = int.Parse(txtAportesRegimenesDiferenciales.Text),
                    AportesRegimenesEspeciales = int.Parse(txtAportesRegimenesEspeciales.Text),
                }, out mensaje);
                if (nroperacion < 1)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                   
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }


            }
            else
            {
                //alta individual
                ClassConceptos.Instancia.RegistrarIndividual(new Conceptos()
                {
                    //idConceptos = oConceptos.idConceptos,
                    //fk_empresa = oEmpresa.IdEmpresa,
                    CodigoDeConcepto = int.Parse(txtCodigoDeConcepto.Text),
                    Descripcion = txtDescripcion.Text,
                    CodigoDeConceptoEmpresa = int.Parse(txtCodigoDeConceptoEmpresa.Text),
                    DebitoCredito = txtDebitoCredito.Text,
                    MarcaDeRepeticion = int.Parse(txtMarcaDeRepeticion.Text),
                    AportesSistemaPrevisionalArgentinoSIPA = int.Parse(txtAportesSistemaPrevisionalArgentinoSIPA.Text),
                    ContribucionesSistemaPrevisionalArgentinoSIPA = int.Parse(txtContribucionesSistemaPrevisionalArgentinoSIPA.Text),
                    AportesINSSJyP = int.Parse(txtAportesINSSJyP.Text),
                    ContribucionesINSSJyP = int.Parse(txtContribucionesINSSJyP.Text),
                    AportesObraSocial = int.Parse(txtAportesObraSocial.Text),
                    ContribucionesObraSocial = int.Parse(txtContribucionesObraSocial.Text),
                    AportesFondoSolidariodeRedistribucion = int.Parse(txtAportesFondoSolidariodeRedistribucion.Text),
                    ContribucionesFondoSolidariodeRedistribucion = int.Parse(txtContribucionesFondoSolidariodeRedistribucion.Text),
                    AportesRENATEA = int.Parse(txtAportesRENATEA.Text),
                    ContribucionesRENATEA = int.Parse(txtContribucionesRENATEA.Text),
                    ContribucionesAsignacionesFamiliares = int.Parse(txtContribucionesAsignacionesFamiliares.Text),
                    ContribucionesFondoNacionaldeEmpleo = int.Parse(txtContribucionesFondoNacionaldeEmpleo.Text),
                    ContribucionesLeydeRiesgosdelTrabajo = int.Parse(txtContribucionesLeydeRiesgosdelTrabajo.Text),
                    AportesRegimenesDiferenciales = int.Parse(txtAportesRegimenesDiferenciales.Text),
                    AportesRegimenesEspeciales = int.Parse(txtAportesRegimenesEspeciales.Text),

                });

                this.Close();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
