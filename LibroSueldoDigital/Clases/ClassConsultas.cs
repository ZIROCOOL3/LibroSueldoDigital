using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroSueldoDigital.Clases
{
    class ClassConsultas
    {
        ClassConectar instCon = new ClassConectar();
        //List<ClassDatosFijos> ListaDatosFijos = new List<ClassDatosFijos>();

        public string path { get; set; }
        public string periodo { get; set; }
        public DataTable TraerDatosBase(string Tabla)
        {
            DataTable dt2 = new DataTable();
            SQLiteDataAdapter ad1 = new SQLiteDataAdapter("SELECT * FROM  " + Tabla, instCon.abrirConexion());
            ad1.Fill(dt2);
            instCon.cerrarConexion();
            return dt2;
        }
        public DataTable TraerDatosFijo(string cuit)
        {
            DataTable dt2 = new DataTable();
            SQLiteDataAdapter ad1 = new SQLiteDataAdapter("select * from datosfijos where cuit ="+cuit, instCon.abrirConexion());
            ad1.Fill(dt2);
            instCon.cerrarConexion();
            return dt2;
        }
        public string  TraerCuitEmpresa()
        {
            DataTable dt2 = new DataTable();
            string cuit = string.Empty;
            SQLiteDataAdapter ad1 = new SQLiteDataAdapter("SELECT * FROM  empresa", instCon.abrirConexion());
            ad1.Fill(dt2);
            instCon.cerrarConexion();
            foreach (DataRow item in dt2.Rows)
            {
                cuit = item["cuit"].ToString();
            }
            return cuit;
        }

        public string TraerCodigoDeAfip(string CodigoEmpresa)
        {
            DataTable dt2 = new DataTable();
            string CodigoAfip = string.Empty;
            SQLiteDataAdapter ad1 = new SQLiteDataAdapter("select * from conceptos where CodigoDeConceptoEmpresa =" + CodigoEmpresa, instCon.abrirConexion());
            ad1.Fill(dt2);
            instCon.cerrarConexion();
            foreach (DataRow item in dt2.Rows)
            {
                CodigoAfip = item["CodigoDeConcepto"].ToString();
            }
            return CodigoAfip;
        }
        public string TraerCreditoDebito(string CodigoEmpresa)
        {
            DataTable dt2 = new DataTable();
            string DebitoCredito = string.Empty;
            SQLiteDataAdapter ad1 = new SQLiteDataAdapter("select * from conceptos where CodigoDeConceptoEmpresa =" + CodigoEmpresa, instCon.abrirConexion());
            ad1.Fill(dt2);
            instCon.cerrarConexion();
            foreach (DataRow item in dt2.Rows)
            {
                DebitoCredito = item["DebitoCredito"].ToString();
            }
            return DebitoCredito;
        }
        public int TraerNumeroUltimaLiquidacion()
        {
            DataTable dt2 = new DataTable();
            int ultimaLiquidacion = 0;
            SQLiteDataAdapter ad1 = new SQLiteDataAdapter("SELECT * FROM  liquidaciones order by id", instCon.abrirConexion());
            ad1.Fill(dt2);
            instCon.cerrarConexion();
            foreach (DataRow item in dt2.Rows)
            {
                ultimaLiquidacion = int.Parse(item["id"].ToString());
            }
            return ultimaLiquidacion;
        }
        public void InsertarDatosFijos(List<ClassDatosFijos> ListaDatosFijos)
        {
            //recorrer la lista
            for (int i = 0; i < ListaDatosFijos.Count; i++)
            {
                SQLiteCommand nComando = new SQLiteCommand(@"INSERT INTO DatosFijos (
                    CUIT, 
                    NombreEmpleado,
                    DiasBase,
                    Legajo,
                    DependenciaDeRevista,
                    CBU,
                    CantDeDiasParaProporcionarElTope,
                    FormaDePago,
                    Conyuge,
                    CantidadDeHijos,
                    MarcaCCT,
                    MarcaSCVO,
                    MarcaCorrespondeReduccion,
                    TipoEmpresa,
                    CodigoCondicion,
                    CodigoActividad,
                    CodigoModalidadContratacion,
                    CodigoSiniestrado,
                    CodigoDeLocalidad,
                    SituacionDeRevista1,
                    DiaInicioSituacionDeRevista1,
                    SituacionDeRevista2,
                    DiaInicioSituacionDeRevista2,
                    SituacionDeRevista3,
                    DiaInicioSituacionDeRevista3,
                    CantDiasTrabajados,
                    HorasTrabajadas,
                    PorcentajeAporteAdicionalSS,
                    ContribucionTareaDiferencial,
                    CodigoObraSocial,
                    Cantidadadherentes,
                    AporteAdicionalOS,
                    ContribucionAdicionalOS,
                    BaseCalculoDiferencialAportesOSyFSR,
                    BaseCalculoDiferencialOSyFSR,
                    BaseCalculoDiferencialLRT,
                    RemuneracionMaternidadANSeS)
                    VALUES(
                    @CUIT, 
                    @NombreEmpleado,
                    @DiasBase,
                    @Legajo,
                    @DependenciaDeRevista,
                    @CBU,
                    @CantDeDiasParaProporcionarElTope,
                    @FormaDePago,
                    @Conyuge,
                    @CantidadDeHijos,
                    @MarcaCCT,
                    @MarcaSCVO,
                    @MarcaCorrespondeReduccion,
                    @TipoEmpresa,
                    @CodigoCondicion,
                    @CodigoActividad,
                    @CodigoModalidadContratacion,
                    @CodigoSiniestrado,
                    @CodigoDeLocalidad,
                    @SituacionDeRevista1,
                    @DiaInicioSituacionDeRevista1,
                    @SituacionDeRevista2,
                    @DiaInicioSituacionDeRevista2,
                    @SituacionDeRevista3,
                    @DiaInicioSituacionDeRevista3,
                    @CantDiasTrabajados,
                    @HorasTrabajadas,
                    @PorcentajeAporteAdicionalSS,
                    @ContribucionTareaDiferencial,
                    @CodigoObraSocial,
                    @Cantidadadherentes,
                    @AporteAdicionalOS,
                    @ContribucionAdicionalOS,
                    @BaseCalculoDiferencialAportesOSyFSR,
                    @BaseCalculoDiferencialOSyFSR,
                    @BaseCalculoDiferencialLRT,
                    @RemuneracionMaternidadANSeS)", instCon.abrirConexion());

                nComando.Parameters.AddWithValue("@CUIT", ListaDatosFijos[i].Cuit);
                nComando.Parameters.AddWithValue("@NombreEmpleado", ListaDatosFijos[i].Nombre);
                nComando.Parameters.AddWithValue("@DiasBase", ListaDatosFijos[i].DiasBase);
                nComando.Parameters.AddWithValue("@Legajo", ListaDatosFijos[i].Legajo);
                nComando.Parameters.AddWithValue("@DependenciaDeRevista", ListaDatosFijos[i].DependenciaRevista);
                nComando.Parameters.AddWithValue("@CBU", ListaDatosFijos[i].Cbu);
                nComando.Parameters.AddWithValue("@CantDeDiasParaProporcionarElTope", ListaDatosFijos[i].DiasPropTope);
                nComando.Parameters.AddWithValue("@FormaDePago", ListaDatosFijos[i].FormaPago);
                nComando.Parameters.AddWithValue("@Conyuge", ListaDatosFijos[i].conyugue);
                nComando.Parameters.AddWithValue("@CantidadDeHijos", ListaDatosFijos[i].Hijos);
                nComando.Parameters.AddWithValue("@MarcaCCT", ListaDatosFijos[i].MarcaCct);
                nComando.Parameters.AddWithValue("@MarcaSCVO", ListaDatosFijos[i].MarcaScvo);
                nComando.Parameters.AddWithValue("@MarcaCorrespondeReduccion", ListaDatosFijos[i].MarcaReduccion);
                nComando.Parameters.AddWithValue("@TipoEmpresa", ListaDatosFijos[i].TipoEmpresa);
                nComando.Parameters.AddWithValue("@CodigoCondicion", ListaDatosFijos[i].CodigoCondicion);
                nComando.Parameters.AddWithValue("@CodigoActividad", ListaDatosFijos[i].CodigoActividad);
                nComando.Parameters.AddWithValue("@CodigoModalidadContratacion", ListaDatosFijos[i].CodigoContratacion);
                nComando.Parameters.AddWithValue("@CodigoSiniestrado", ListaDatosFijos[i].CodigoSiniestrado);
                nComando.Parameters.AddWithValue("@CodigoDeLocalidad", ListaDatosFijos[i].CodigoLocalidad);
                nComando.Parameters.AddWithValue("@SituacionDeRevista1", ListaDatosFijos[i].SituacionRevista1);
                nComando.Parameters.AddWithValue("@DiaInicioSituacionDeRevista1", ListaDatosFijos[i].DiaInicioSituacion1);
                nComando.Parameters.AddWithValue("@SituacionDeRevista2", ListaDatosFijos[i].SituacionRevista2);
                nComando.Parameters.AddWithValue("@DiaInicioSituacionDeRevista2", ListaDatosFijos[i].DiaInicioSituacion2);
                nComando.Parameters.AddWithValue("@SituacionDeRevista3", ListaDatosFijos[i].SituacionRevista3);
                nComando.Parameters.AddWithValue("@DiaInicioSituacionDeRevista3", ListaDatosFijos[i].DiaInicioSituacion3);
                nComando.Parameters.AddWithValue("@CantDiasTrabajados", ListaDatosFijos[i].DiasTrabajado);
                nComando.Parameters.AddWithValue("@HorasTrabajadas", ListaDatosFijos[i].HorasTrabajdo);
                nComando.Parameters.AddWithValue("@PorcentajeAporteAdicionalSS", ListaDatosFijos[i].PorAporteSS);
                nComando.Parameters.AddWithValue("@ContribucionTareaDiferencial", ListaDatosFijos[i].PorTareaDiferencial);
                nComando.Parameters.AddWithValue("@CodigoObraSocial", ListaDatosFijos[i].CodigoObraSocial);
                nComando.Parameters.AddWithValue("@Cantidadadherentes", ListaDatosFijos[i].CantidadAherente);
                nComando.Parameters.AddWithValue("@AporteAdicionalOS", ListaDatosFijos[i].AporteAdicOS);
                nComando.Parameters.AddWithValue("@ContribucionAdicionalOS", ListaDatosFijos[i].ContAdicOS);
                nComando.Parameters.AddWithValue("@BaseCalculoDiferencialAportesOSyFSR", ListaDatosFijos[i].BaseCalculoAporteOsFsr);
                nComando.Parameters.AddWithValue("@BaseCalculoDiferencialOSyFSR", ListaDatosFijos[i].BaseCalculoOsFsr);
                nComando.Parameters.AddWithValue("@BaseCalculoDiferencialLRT", ListaDatosFijos[i].BaseCalculoLRT);
                nComando.Parameters.AddWithValue("@RemuneracionMaternidadANSeS", ListaDatosFijos[i].RenumeracionMatAnses);
                nComando.ExecuteNonQuery();
                instCon.cerrarConexion();
            }
            

        }
        public void ActualizoDatosFijos(List<ClassDatosFijos> ListaDatosFijos)
        {
            //recorrer la lista
            for (int i = 0; i < ListaDatosFijos.Count; i++)
            {
                SQLiteCommand nComando = new SQLiteCommand(@"UPDATE  DatosFijos SET
                    CUIT =@CUIT, 
                    NombreEmpleado=@NombreEmpleado,
                    DiasBase=@DiasBase,
                    Legajo=@Legajo,
                    DependenciaDeRevista=@DependenciaDeRevista,,
                    CBU=@CBU,
                    CantDeDiasParaProporcionarElTope=@CantDeDiasParaProporcionarElTope,
                    FormaDePago=@FormaDePago,
                    Conyuge=@Conyuge,
                    CantidadDeHijos=@CantidadDeHijos,
                    MarcaCCT=@MarcaCCT,
                    MarcaSCVO=@MarcaSCVO,
                    MarcaCorrespondeReduccion=@MarcaCorrespondeReduccion,
                    TipoEmpresa=@TipoEmpresa,
                    CodigoCondicion=@CodigoCondicion,
                    CodigoActividad=@CodigoActividad,
                    CodigoModalidadContratacion=@CodigoModalidadContratacion,
                    CodigoSiniestrado=@CodigoSiniestrado,
                    CodigoDeLocalidad=@CodigoDeLocalidad,
                    SituacionDeRevista1=@SituacionDeRevista1,
                    DiaInicioSituacionDeRevista1=@DiaInicioSituacionDeRevista1,
                    SituacionDeRevista2=@SituacionDeRevista2,
                    DiaInicioSituacionDeRevista2=@DiaInicioSituacionDeRevista2,
                    SituacionDeRevista3=@SituacionDeRevista3,
                    DiaInicioSituacionDeRevista3=@DiaInicioSituacionDeRevista3,
                    CantDiasTrabajados=@CantDiasTrabajados,
                    HorasTrabajadas=@HorasTrabajadas,
                    PorcentajeAporteAdicionalSS=@PorcentajeAporteAdicionalSS,
                    ContribucionTareaDiferencial=@ContribucionTareaDiferencial,
                    CodigoObraSocial=@CodigoObraSocial,
                    Cantidadadherentes=@Cantidadadherentes,
                    AporteAdicionalOS=@AporteAdicionalOS,
                    ContribucionAdicionalOS=@ContribucionAdicionalOS,
                    BaseCalculoDiferencialAportesOSyFSR=@BaseCalculoDiferencialAportesOSyFSR,
                    BaseCalculoDiferencialOSyFSR=@BaseCalculoDiferencialOSyFSR,
                    BaseCalculoDiferencialLRT=@BaseCalculoDiferencialLRT,
                    RemuneracionMaternidadANSeS=@RemuneracionMaternidadANSeS where cuit=@CUIT", instCon.abrirConexion());

                nComando.Parameters.AddWithValue("@CUIT", ListaDatosFijos[i].Cuit);
                nComando.Parameters.AddWithValue("@NombreEmpleado", ListaDatosFijos[i].Nombre);
                nComando.Parameters.AddWithValue("@DiasBase", ListaDatosFijos[i].DiasBase);
                nComando.Parameters.AddWithValue("@Legajo", ListaDatosFijos[i].Legajo);
                nComando.Parameters.AddWithValue("@DependenciaDeRevista", ListaDatosFijos[i].DependenciaRevista);
                nComando.Parameters.AddWithValue("@CBU", ListaDatosFijos[i].Cbu);
                nComando.Parameters.AddWithValue("@CantDeDiasParaProporcionarElTope", ListaDatosFijos[i].DiasPropTope);
                nComando.Parameters.AddWithValue("@FormaDePago", ListaDatosFijos[i].FormaPago);
                nComando.Parameters.AddWithValue("@Conyuge", ListaDatosFijos[i].conyugue);
                nComando.Parameters.AddWithValue("@CantidadDeHijos", ListaDatosFijos[i].Hijos);
                nComando.Parameters.AddWithValue("@MarcaCCT", ListaDatosFijos[i].MarcaCct);
                nComando.Parameters.AddWithValue("@MarcaSCVO", ListaDatosFijos[i].MarcaScvo);
                nComando.Parameters.AddWithValue("@MarcaCorrespondeReduccion", ListaDatosFijos[i].MarcaReduccion);
                nComando.Parameters.AddWithValue("@TipoEmpresa", ListaDatosFijos[i].TipoEmpresa);
                nComando.Parameters.AddWithValue("@CodigoCondicion", ListaDatosFijos[i].CodigoCondicion);
                nComando.Parameters.AddWithValue("@CodigoActividad", ListaDatosFijos[i].CodigoActividad);
                nComando.Parameters.AddWithValue("@CodigoModalidadContratacion", ListaDatosFijos[i].CodigoContratacion);
                nComando.Parameters.AddWithValue("@CodigoSiniestrado", ListaDatosFijos[i].CodigoSiniestrado);
                nComando.Parameters.AddWithValue("@CodigoDeLocalidad", ListaDatosFijos[i].CodigoLocalidad);
                nComando.Parameters.AddWithValue("@SituacionDeRevista1", ListaDatosFijos[i].SituacionRevista1);
                nComando.Parameters.AddWithValue("@DiaInicioSituacionDeRevista1", ListaDatosFijos[i].DiaInicioSituacion1);
                nComando.Parameters.AddWithValue("@SituacionDeRevista2", ListaDatosFijos[i].SituacionRevista2);
                nComando.Parameters.AddWithValue("@DiaInicioSituacionDeRevista2", ListaDatosFijos[i].DiaInicioSituacion2);
                nComando.Parameters.AddWithValue("@SituacionDeRevista3", ListaDatosFijos[i].SituacionRevista3);
                nComando.Parameters.AddWithValue("@DiaInicioSituacionDeRevista3", ListaDatosFijos[i].DiaInicioSituacion3);
                nComando.Parameters.AddWithValue("@CantDiasTrabajados", ListaDatosFijos[i].DiasTrabajado);
                nComando.Parameters.AddWithValue("@HorasTrabajadas", ListaDatosFijos[i].HorasTrabajdo);
                nComando.Parameters.AddWithValue("@PorcentajeAporteAdicionalSS", ListaDatosFijos[i].PorAporteSS);
                nComando.Parameters.AddWithValue("@ContribucionTareaDiferencial", ListaDatosFijos[i].PorTareaDiferencial);
                nComando.Parameters.AddWithValue("@CodigoObraSocial", ListaDatosFijos[i].CodigoObraSocial);
                nComando.Parameters.AddWithValue("@Cantidadadherentes", ListaDatosFijos[i].CantidadAherente);
                nComando.Parameters.AddWithValue("@AporteAdicionalOS", ListaDatosFijos[i].AporteAdicOS);
                nComando.Parameters.AddWithValue("@ContribucionAdicionalOS", ListaDatosFijos[i].ContAdicOS);
                nComando.Parameters.AddWithValue("@BaseCalculoDiferencialAportesOSyFSR", ListaDatosFijos[i].BaseCalculoAporteOsFsr);
                nComando.Parameters.AddWithValue("@BaseCalculoDiferencialOSyFSR", ListaDatosFijos[i].BaseCalculoOsFsr);
                nComando.Parameters.AddWithValue("@BaseCalculoDiferencialLRT", ListaDatosFijos[i].BaseCalculoLRT);
                nComando.Parameters.AddWithValue("@RemuneracionMaternidadANSeS", ListaDatosFijos[i].RenumeracionMatAnses);
                nComando.ExecuteNonQuery();
            }
            instCon.cerrarConexion();

        }
        public void InsertarDatosEmpresa( string RazonSocial, long Cuit)
        {
            SQLiteCommand nComando = new SQLiteCommand(@"UPDATE empresa SET
             RazonSocial=@RazonSocial,Cuit=@Cuit", instCon.abrirConexion());
            nComando.Parameters.AddWithValue("@RazonSocial", RazonSocial);
            nComando.Parameters.AddWithValue("@Cuit", Cuit);
            nComando.ExecuteNonQuery();
            instCon.cerrarConexion();

        }
        public void VerificarExixtenciaArchivo(string Registro)
        {
            path = @"c:\LibroSueldoDigital\Liquidacion" + "-" + periodo + "-" + Registro + ".txt";
            //verico si existe archivo de ser asi los borro
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
        public bool VerificoExistenciaEmpleado(string cuit)
        {
            bool Existe = false;
            DataTable dt2 = new DataTable();
            SQLiteDataAdapter ad1 = new SQLiteDataAdapter("select * from datosfijos where cuit =" + cuit, instCon.abrirConexion());
            ad1.Fill(dt2);
            instCon.cerrarConexion();
            foreach (DataRow item in dt2.Rows)
            {
                Existe = true;
            }
            return Existe;
        }
    }
}
