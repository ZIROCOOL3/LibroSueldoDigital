using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroSueldoDigital.Clases
{
    public class Conceptos
    {
        public int idConceptos { get; set; }
        public int CodigoDeConcepto { get; set; }
        public string Descripcion { get; set; }
        public int CodigoDeConceptoEmpresa { get; set; }
        public string DebitoCredito { get; set; }
        public int MarcaDeRepeticion { get; set; }
        public int AportesSistemaPrevisionalArgentinoSIPA { get; set; }
        public int ContribucionesSistemaPrevisionalArgentinoSIPA { get; set; }
        public int AportesINSSJyP { get; set; }
        public int ContribucionesINSSJyP { get; set; }
        public int AportesObraSocial { get; set; }
        public int ContribucionesObraSocial { get; set; }
        public int AportesFondoSolidariodeRedistribucion { get; set; }
        public int ContribucionesFondoSolidariodeRedistribucion { get; set; }
        public int AportesRENATEA { get; set; }
        public int ContribucionesRENATEA { get; set; }
        public int ContribucionesAsignacionesFamiliares { get; set; }
        public int ContribucionesFondoNacionaldeEmpleo { get; set; }
        public int ContribucionesLeydeRiesgosdelTrabajo { get; set; }
        public int AportesRegimenesDiferenciales { get; set; }
        public int AportesRegimenesEspeciales { get; set; }
    }
}
