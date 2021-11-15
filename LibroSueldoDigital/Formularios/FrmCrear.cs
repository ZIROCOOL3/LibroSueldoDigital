using LibroSueldoDigital.Clases;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Telerik.WinControls;

namespace LibroSueldoDigital.Formularios
{
    public partial class FrmCrear : Telerik.WinControls.UI.RadForm
    {
        public FrmCrear()
        {
            InitializeComponent();
        }
        public bool Conceptos = false;
        public bool DatosFIjos = false;
        public bool CrearLibro = false;
        bool error = false;
        string RutaArchivoFijo = string.Empty;
        string RutaArchivoLiquidacion = string.Empty;
        string RutaArchivoConcepto = string.Empty;
    
        List<ClassError> ListaDeErrores = new List<ClassError>();
        List<ClassDatosFijos> ListaDatosFijos = new List<ClassDatosFijos>();
        ClassConsultas instConsultas = new ClassConsultas();
        int NumeroUltimaLiquidacion = 0;
        string DiasBase = string.Empty;
        string CuilEmpleado = string.Empty;
        string IdentEnvio = string.Empty;
        string TipoLiquidacion = string.Empty;
        string RenumeracionBruta = string.Empty;
        string CantDiasSacProporcional = string.Empty;
        string CantDiasAdelantoVacaciones = string.Empty;
        string CantDiasHorasExtra = string.Empty;
        string CantDiasHorasExtra50= string.Empty;
        string CantDiasHorasExtra100= string.Empty;
        string CantDiasHorasExtra200 = string.Empty;
        string BaseImponible1 = string.Empty;
        string BaseImponible2 = string.Empty;
        string BaseImponible3 = string.Empty;
        string BaseImponible4 = string.Empty;
        string BaseImponible5 = string.Empty;
        string BaseImponible6 = string.Empty;
        string BaseImponible7 = string.Empty;
        string BaseImponible8 = string.Empty;
        string BaseImponible9 = string.Empty;
        string BaseImponible10 = string.Empty;
        string BaseCalculoAporteSegSoc = string.Empty;
        string BaseCalculoContSegSoc = string.Empty;
        string ImporteDetraer = string.Empty;
        string Cantidad = string.Empty;
        

        public object Maths { get; private set; }

        private void CmdProcesar_Click(object sender, EventArgs e)
        {
            if (DatosFIjos)
            {
                try
                {
                    SLDocument sl = new SLDocument(RutaArchivoFijo,TxtNombreHoja.Text );
                    SLWorksheetStatistics stats = sl.GetWorksheetStatistics();
                    int filas = stats.EndRowIndex;
                    if (filas == -1)
                    {
                        ListaDeErrores.Add(new ClassError { Numero = 5, Descripcion = "Verifique que el nombre de la hoja de excel sea correcta", ArchivoError = "Excel liquidaciones" });
                        error = true;
                    }
                    for (int i = 6; i < filas + 1; i++)
                    {
                        if (sl.GetCellValueAsString(i, 2) == "")//COMPRUEBO CUANDO LA ULTIMA FILA ES VACIA
                        {
                            break;
                        }
                        //LineaPrecesada++;
                        //01 nombre de empleado   tam=11 
                        string Nombre= sl.GetCellValueAsString(i, 2);

                        //02 cuil tam=11 
                        string Cuit = sl.GetCellValueAsString(i, 3).Replace("-","");
                        if (Cuit.Length !=11)
                        {
                            ListaDeErrores.Add(new ClassError { Numero = 4, Descripcion = "Largo de Cuil Incorrecto("+ sl.GetCellValueAsString(i, 3)+")", ArchivoError = "Excel liquidaciones"});
                            error = true;
                        }

                        //03 dias base
                        string DiasBase = string.Empty;
                        if (sl.GetCellValueAsString(i, 4)=="")
                        {
                            DiasBase = "  ";
                        }
                        else
                        {
                            DiasBase = "30";
                        }
                        //04 legajo
                        string Legajo = Rellena(" ", sl.GetCellValueAsString(i, 5),10,false);

                        //05 dependencia de reviste
                        string DependenciaRevista = Rellena(" ", sl.GetCellValueAsString(i, 6), 50, false);

                        //06 cbu
                        string Cbu = Rellena(" ", sl.GetCellValueAsString(i, 7), 22, true);

                        //07 can de dias proporcianal al tope
                        string DiasPropTope = Rellena("0", sl.GetCellValueAsString(i, 8), 3, true);

                        //08 forma de pago
                        string FormaPago = sl.GetCellValueAsString(i, 9);

                        //09 conyugue
                        string conyugue = sl.GetCellValueAsString(i, 10);

                        //10 cantidada de hijos
                        string Hijos = Rellena("0",sl.GetCellValueAsString(i, 11),2,true);

                        //11 marca cct
                        string MarcaCct = sl.GetCellValueAsString(i, 12);

                        //12 marca scvo
                        string MarcaScvo = sl.GetCellValueAsString(i, 13);

                        //13 marca corresponde a reduccion
                        string MarcaReduccion = sl.GetCellValueAsString(i, 14);

                        //14 tipo de empresa
                        string TipoEmpresa = sl.GetCellValueAsString(i, 15);

                        //15 codigo condicion
                        string CodigoCondicion = Rellena(" ", sl.GetCellValueAsString(i, 16), 2, false);

                        //16 codigo de actividad
                        string CodigoActividad = Rellena("0", sl.GetCellValueAsString(i, 17), 3, true);

                        //17 codigo de modalidad de contratacion
                        string CodigoContratacion = Rellena(" ", sl.GetCellValueAsString(i, 18), 3, true);

                        //18 codigo de siniestrado
                        string CodigoSiniestrado= Rellena(" ", sl.GetCellValueAsString(i, 19), 2, false);

                        //19 codigo de localidad
                        string CodigoLocalidad = Rellena(" ", sl.GetCellValueAsString(i, 20), 2, true);
                        
                        //20 situacion de revista
                        string SituacionRevista1 = Rellena("0", sl.GetCellValueAsString(i, 21), 2, true);

                        //21 dia inicio Situacion 1
                        string DiaInicioSituacion1 = Rellena("0", sl.GetCellValueAsString(i, 22), 2, true);

                        //22 situacion de revista 2
                        string SituacionRevista2 = Rellena(" ", sl.GetCellValueAsString(i, 23), 2, true);

                        //23 dia inicio Situacion 2
                        string DiaInicioSituacion2 = Rellena("0", sl.GetCellValueAsString(i, 24), 2, true);

                        //24 situacion de revista 3
                        string SituacionRevista3 = Rellena(" ", sl.GetCellValueAsString(i, 24), 2, true);

                        //25 dia inicio Situacion 3
                        string DiaInicioSituacion3 = Rellena("0", sl.GetCellValueAsString(i, 26), 2, true);

                        //26 dias trabajados //27 horas trabajadas
                        string DiasTrabajado = string.Empty;
                        string HorasTrabajdo = string.Empty;
                        if (sl.GetCellValueAsString(i, 27)!="")
                        {
                            DiasTrabajado = Rellena("0", sl.GetCellValueAsString(i, 27), 2, true);
                            HorasTrabajdo = "000";
                        }
                        else
                        {
                            DiasTrabajado = "00";
                            HorasTrabajdo = Rellena("0", sl.GetCellValueAsString(i, 28), 3, true);

                        }

                        //28 porcentaje aporte adicional SS
                        string PorAporteSS = sl.GetCellValueAsString(i, 29);
                        if (PorAporteSS != "")
                        {

                            if (PorAporteSS.IndexOf(".",0)!=0 | PorAporteSS.IndexOf(",", 0) != 0)//si  tiene coma
                            {
                                PorAporteSS = Rellena("0", QuitaComa(PorAporteSS), 5, true) ;
                            }
                            else
                            {
                                PorAporteSS = Rellena("0", PorAporteSS, 3, true) + "00";
                                
                            }

                        }
                        else
                        {
                            PorAporteSS = "00000";
                        }
                        //29 porcentaje contribucion tarea diferencia
                        string PorTareaDiferencial = sl.GetCellValueAsString(i, 30);
                        if (PorTareaDiferencial != "")
                        {

                            if (PorTareaDiferencial.IndexOf(".", 0) != 0 | PorTareaDiferencial.IndexOf(",", 0) != 0)//si  tiene coma
                            {
                                PorTareaDiferencial = Rellena("0", QuitaComa(PorTareaDiferencial), 5, true);
                            }
                            else
                            {
                                PorTareaDiferencial = Rellena("0", PorTareaDiferencial, 3, true) + "00";

                            }

                        }
                        else
                        {
                            PorTareaDiferencial = "00000";
                        }

                        //30-codigo obra social
                        string CodigoObraSocial = Rellena("0", sl.GetCellValueAsString(i, 31), 6, true);

                        //31-cantidad de Adherente
                        string CantidadAherente = Rellena("0", sl.GetCellValueAsString(i, 32), 2, true);

                        //32 Aporte Adicional OS
                        string AporteAdicOS = sl.GetCellValueAsString(i, 33);
                        if (AporteAdicOS != "0")
                        {
                            AporteAdicOS = Rellena("0", QuitaComa(AporteAdicOS), 15, true);
                        }
                        else
                        {
                            AporteAdicOS = "000000000000000";
                        }

                        //33 Contribución Adicional OS
                        string ContAdicOS = sl.GetCellValueAsString(i, 34);
                        if (ContAdicOS != "0")
                        {
                            ContAdicOS = Rellena("0", QuitaComa(ContAdicOS), 15, true);
                        }
                        else
                        {
                            ContAdicOS = "000000000000000";
                        }
                        //34 Base cálculo Diferencial Aportes OS y FSR
                        string BaseCalculoAporteOsFsr = sl.GetCellValueAsString(i, 35);
                        if (BaseCalculoAporteOsFsr != "0")
                        {
                            BaseCalculoAporteOsFsr = Rellena("0", QuitaComa(BaseCalculoAporteOsFsr), 15, true);
                        }
                        else
                        {
                            BaseCalculoAporteOsFsr = "000000000000000";
                        }

                        //35 Base cálculo Diferencial OS y FSR
                        string BaseCalculoOsFsr = sl.GetCellValueAsString(i, 36);
                        if (BaseCalculoOsFsr != "0")
                        {
                            BaseCalculoOsFsr = Rellena("0", QuitaComa(BaseCalculoOsFsr), 15, true);
                        }
                        else
                        {
                            BaseCalculoOsFsr = "000000000000000";
                        }

                        //36 Base cálculo Diferencial LRT
                        string BaseCalculoLRT = sl.GetCellValueAsString(i, 37);
                        if (BaseCalculoLRT != "0")
                        {
                            BaseCalculoLRT = Rellena("0", QuitaComa(BaseCalculoLRT), 15, true);
                        }
                        else
                        {
                            BaseCalculoLRT = "000000000000000";
                        }

                        //37 Remuneración Maternidad ANSeS
                        string RenumeracionMatAnses = sl.GetCellValueAsString(i, 38);
                        if (RenumeracionMatAnses != "0")
                        {
                            RenumeracionMatAnses = Rellena("0", QuitaComa(RenumeracionMatAnses), 15, true);
                        }
                        else
                        {
                            RenumeracionMatAnses = "000000000000000";
                        }

                        ////38 Base Imponible
                        //string BaseImponible = sl.GetCellValueAsString(i, 39);
                        //if (BaseImponible != "0")
                        //{
                        //    BaseImponible = Rellena("0", QuitaComa(BaseImponible), 15, true);
                        //}
                        //else
                        //{
                        //    BaseImponible = "000000000000000";
                        //}
                        
                        ////39 Base Imponible 2
                        //string BaseImponible2 = sl.GetCellValueAsString(i, 40);
                        //if (BaseImponible2 != "0")
                        //{
                        //    BaseImponible2 = Rellena("0", QuitaComa(BaseImponible2), 15, true);
                        //}
                        //else
                        //{
                        //    BaseImponible2 = "000000000000000";
                        //}

                        ////40 Base Imponible 3
                        //string BaseImponible3 = sl.GetCellValueAsString(i, 41);
                        //if (BaseImponible3 != "0")
                        //{
                        //    BaseImponible3 = Rellena("0", QuitaComa(BaseImponible3), 15, true);
                        //}
                        //else
                        //{
                        //    BaseImponible3 = "000000000000000";
                        //}

                        ////41 Base Imponible 4
                        //string BaseImponible4 = sl.GetCellValueAsString(i, 42);
                        //if (BaseImponible4 != "0")
                        //{
                        //    BaseImponible4 = Rellena("0", QuitaComa(BaseImponible4), 15, true);
                        //}
                        //else
                        //{
                        //    BaseImponible4 = "000000000000000";
                        //}

                        ////42 Base Imponible 5
                        //string BaseImponible5 = sl.GetCellValueAsString(i, 43);
                        //if (BaseImponible5 != "0")
                        //{
                        //    BaseImponible5 = Rellena("0", QuitaComa(BaseImponible5), 15, true);
                        //}
                        //else
                        //{
                        //    BaseImponible5 = "000000000000000";
                        //}

                        ////43 Base Imponible 6
                        //string BaseImponible6 = sl.GetCellValueAsString(i, 44);
                        //if (BaseImponible6 != "0")
                        //{
                        //    BaseImponible6 = Rellena("0", QuitaComa(BaseImponible6), 15, true);
                        //}
                        //else
                        //{
                        //    BaseImponible6 = "000000000000000";
                        //}

                        ////44 Base Imponible 7
                        //string BaseImponible7 = sl.GetCellValueAsString(i, 45);
                        //if (BaseImponible7 != "0")
                        //{
                        //    BaseImponible7 = Rellena("0", QuitaComa(BaseImponible7), 15, true);
                        //}
                        //else
                        //{
                        //    BaseImponible7 = "000000000000000";
                        //}

                        ////45 Base Imponible 8
                        //string BaseImponible8 = sl.GetCellValueAsString(i, 46);
                        //if (BaseImponible8 != "0")
                        //{
                        //    BaseImponible8 = Rellena("0", QuitaComa(BaseImponible8), 15, true);
                        //}
                        //else
                        //{
                        //    BaseImponible8 = "000000000000000";
                        //}

                        ////46 Base Imponible 9
                        //string BaseImponible9 = sl.GetCellValueAsString(i, 47);
                        //if (BaseImponible9 != "0")
                        //{
                        //    BaseImponible9 = Rellena("0", QuitaComa(BaseImponible9), 15, true);
                        //}
                        //else
                        //{
                        //    BaseImponible9 = "000000000000000";
                        //}

                        ////47 Base para el cálculo diferencial de aporte de Seg. Social
                        //string BaseCalculoSegSocial = sl.GetCellValueAsString(i, 48);
                        //if (BaseCalculoSegSocial != "0")
                        //{
                        //    BaseCalculoSegSocial = Rellena("0", QuitaComa(BaseCalculoSegSocial), 15, true);
                        //}
                        //else
                        //{
                        //    BaseCalculoSegSocial = "000000000000000";
                        //}

                        ////48 Base para el cálculo diferencial de contribuciones de Seg. Social
                        //string BaseCalculoContriSegSocial = sl.GetCellValueAsString(i, 49);
                        //if (BaseCalculoContriSegSocial != "0")
                        //{
                        //    BaseCalculoContriSegSocial = Rellena("0", QuitaComa(BaseCalculoContriSegSocial), 15, true);
                        //}
                        //else
                        //{
                        //    BaseCalculoContriSegSocial = "000000000000000";
                        //}
                        ////49 Base Imponible 10
                        //string BaseImponible10 = sl.GetCellValueAsString(i, 50);
                        //if (BaseImponible10 != "0")
                        //{
                        //    BaseImponible10 = Rellena("0", QuitaComa(BaseImponible10), 15, true);
                        //}
                        //else
                        //{
                        //    BaseImponible10 = "000000000000000";
                        //}

                        ////50 Importe a detraer
                        //string ImporteDetraer = sl.GetCellValueAsString(i, 51);
                        //if (ImporteDetraer != "0")
                        //{
                        //    ImporteDetraer = Rellena("0", QuitaComa(ImporteDetraer), 15, true);
                        //}
                        //else
                        //{
                        //    ImporteDetraer = "000000000000000";
                        //}
                        if (ListaDeErrores.Count==0)
                        {
                            ListaDatosFijos.Clear();

                            ListaDatosFijos.Add(new ClassDatosFijos
                            {
                                Nombre = Nombre,
                                Cuit = Cuit,
                                DiasBase = DiasBase,
                                Legajo = Legajo,
                                DependenciaRevista = DependenciaRevista,
                                Cbu = Cbu,
                                DiasPropTope = DiasPropTope,
                                FormaPago = FormaPago,
                                conyugue = conyugue,
                                Hijos = Hijos,
                                MarcaCct = MarcaCct,
                                MarcaScvo = MarcaScvo,
                                MarcaReduccion = MarcaReduccion,
                                TipoEmpresa = TipoEmpresa,
                                CodigoCondicion = CodigoCondicion,
                                CodigoActividad = CodigoActividad,
                                CodigoContratacion = CodigoContratacion,
                                CodigoSiniestrado = CodigoSiniestrado,
                                CodigoLocalidad = CodigoLocalidad,
                                SituacionRevista1 = SituacionRevista1,
                                DiaInicioSituacion1 = DiaInicioSituacion1,
                                SituacionRevista2 = SituacionRevista2,
                                DiaInicioSituacion2 = DiaInicioSituacion2,
                                SituacionRevista3 = SituacionRevista3,
                                DiaInicioSituacion3 = DiaInicioSituacion3,
                                DiasTrabajado = DiasTrabajado,
                                HorasTrabajdo = HorasTrabajdo,
                                PorAporteSS = PorAporteSS,
                                PorTareaDiferencial = PorTareaDiferencial,
                                CodigoObraSocial = CodigoObraSocial,
                                CantidadAherente = CantidadAherente,
                                AporteAdicOS = AporteAdicOS,
                                ContAdicOS = ContAdicOS,
                                BaseCalculoAporteOsFsr = BaseCalculoAporteOsFsr,
                                BaseCalculoOsFsr = BaseCalculoOsFsr,
                                BaseCalculoLRT = BaseCalculoLRT,
                                RenumeracionMatAnses = RenumeracionMatAnses,
                                //BaseImponible = BaseImponible,
                                //BaseImponible2 = BaseImponible2,
                                //BaseImponible3 = BaseImponible3,
                                //BaseImponible4 = BaseImponible4,
                                //BaseImponible5 = BaseImponible5,
                                //BaseImponible6 = BaseImponible6,
                                //BaseImponible7 = BaseImponible7,
                                //BaseImponible8 = BaseImponible8,
                                //BaseImponible9 = BaseImponible9,
                                //BaseCalculoSegSocial = BaseCalculoSegSocial,
                                //BaseCalculoContriSegSocial = BaseCalculoContriSegSocial,
                                //BaseImponible10 = BaseImponible10,
                                //ImporteDetraer = ImporteDetraer,
                            });
                        }
                        else
                        {
                            FrmErrores Frmerrores = new FrmErrores();
                            //Frmerrores._ListaDeErrores.Clear();
                            Frmerrores._ListaDeErrores = ListaDeErrores;
                            Frmerrores.Show();
                        }

                    }

                    //si no hay error cargo en base de datos
                    instConsultas.InsertarDatosFijos(ListaDatosFijos);
                    RadMessageBox.Show("Archivo Cargado");
                    this.Close();
                }
                catch (Exception er)
                {
                    ListaDeErrores.Add(new ClassError { Numero = 4, Descripcion = er.Message, ArchivoError = "Excel liquidaciones" });
                    //RadMessageBox.Show(er.Message);
                }


            }
            else if (CrearLibro)
            {

                SLDocument sl = new SLDocument(RutaArchivoLiquidacion, TxtNombreHoja.Text);
                SLWorksheetStatistics stats = sl.GetWorksheetStatistics();
                int filas = stats.EndRowIndex;
                int Columnas = stats.EndColumnIndex-2;
                if (filas == -1)
                {
                    ListaDeErrores.Add(new ClassError { Numero = 5, Descripcion = "Verifique que el nombre de la hoja de excel sea correcta", ArchivoError = "Excel liquidaciones" });
                    error = true;
                }
                NumeroUltimaLiquidacion = instConsultas.TraerNumeroUltimaLiquidacion() + 1;
                CrearCarpetaSalida();

                for (int C = 0; C < Columnas; C++)// recorre una columna por empleado
                {
                    CuilEmpleado = sl.GetCellValueAsString(2, Columnas + 2);
                    IdentEnvio = sl.GetCellValueAsString(3, Columnas + 2).ToUpper();
                    if (IdentEnvio == "SJ")
                    {
                        DiasBase = "30";
                    }
                    else
                    {
                        DiasBase = "  ";
                    }
                    TipoLiquidacion = sl.GetCellValueAsString(4, Columnas + 2).ToUpper();
                    RenumeracionBruta = Rellena("0", QuitaComa(sl.GetCellValueAsString(5, Columnas + 2)), 15, true);
                    CantDiasSacProporcional = Rellena("0", QuitaComa(sl.GetCellValueAsString(6, Columnas + 2)), 5, true);
                    CantDiasAdelantoVacaciones = Rellena("0", QuitaComa(sl.GetCellValueAsString(7, Columnas + 2)), 5, true);
                    CantDiasHorasExtra = Rellena("0", QuitaComa(sl.GetCellValueAsString(8, Columnas + 2)), 5, true);
                    CantDiasHorasExtra50 = Rellena("0", QuitaComa(sl.GetCellValueAsString(9, Columnas + 2)), 5, true);
                    CantDiasHorasExtra100 = Rellena("0", QuitaComa(sl.GetCellValueAsString(10, Columnas + 2)), 5, true);
                    CantDiasHorasExtra200 = Rellena("0", QuitaComa(sl.GetCellValueAsString(11, Columnas + 2)), 5, true);
                    instConsultas.periodo = TxtPeriodo.Text;
                    instConsultas.VerificarExixtenciaArchivo("Reg01");
                    if (TxtPeriodo.Text.Length != 6 | TxtPeriodo.Text == "")
                    {
                        ListaDeErrores.Add(new ClassError { Numero = 6, Descripcion = "Verifique el periodo", ArchivoError = "Periodo de Liquidacion" });
                        error = true;
                        break;
                    }
                    //Crear Archivo 01 
                    using (StreamWriter sw = File.CreateText(instConsultas.path))//archivo compras
                    {

                        sw.WriteLine("01" + instConsultas.TraerCuitEmpresa() + IdentEnvio + TxtPeriodo.Text + TipoLiquidacion + Rellena("0", NumeroUltimaLiquidacion.ToString(), 5, true) + DiasBase + Rellena("0", Columnas.ToString(), 6, true));
                    }

                    string strFile = File.ReadAllText(instConsultas.path);
                    strFile = Regex.Replace(strFile, "\r", "");
                    File.WriteAllText(instConsultas.path, strFile);


                    //Crear Archivo 02
                    instConsultas.VerificarExixtenciaArchivo("Reg02");
                    DataTable DtDatosFIjos = new DataTable();
                    CuilEmpleado = "20215465676";
                    DtDatosFIjos = instConsultas.TraerDatosFijo(CuilEmpleado);
                    if (DtDatosFIjos.Rows.Count == 0)
                    {
                        ListaDeErrores.Add(new ClassError { Numero = 7, Descripcion = "No se Encontro datos fijo del empleado: " + CuilEmpleado, ArchivoError = "DatosFijos" });
                        error = true;
                        break;
                    }
                    using (StreamWriter sw = File.CreateText(instConsultas.path))//
                    {
                        foreach (DataRow item in DtDatosFIjos.Rows)
                        {
                            string dato = "02" + CuilEmpleado + item["legajo"].ToString() + item["DependenciaDeRevista"].ToString() + item["CBU"].ToString() + item["CantDeDiasParaProporcionarElTope"].ToString() + TxtPeriodo.Text + "10" + "        " + item["FormaDePago"].ToString();
                            sw.WriteLine("02" + CuilEmpleado + item["legajo"].ToString() + item["DependenciaDeRevista"].ToString() + item["CBU"].ToString() + item["CantDeDiasParaProporcionarElTope"].ToString() + TxtPeriodo.Text + "10" + "        " + item["FormaDePago"].ToString());
                        }
                    }

                    //Crear Archivo 03
                    instConsultas.VerificarExixtenciaArchivo("Reg03");
                    using (StreamWriter sw3 = File.CreateText(instConsultas.path))//archivo compras
                    {
                        for (int i = 12; i < filas + 1; i++) //recooro el excel de liquidacion
                        {
                            if (sl.GetCellValueAsString(i, 1) == "")//COMPRUEBO CUANDO LA ULTIMA FILA ES VACIA
                            {
                                break;
                            }
                            //MessageBox.Show(sl.GetCellValueAsString(i, 1));
                            foreach (DataRow item in DtDatosFIjos.Rows)
                            {
                                string Valor = ValorAbsoluto(sl.GetCellValueAsString(i, Columnas + 2));//valor absoluto del importe
                                if (Regex.IsMatch(sl.GetCellValueAsString(i, 1), @"^[0-9]+$"))//busco solo si es numerico
                                {
                                    if (instConsultas.TraerCodigoDeAfip(sl.GetCellValueAsString(i, 1)) == "120003")//sac proporcional
                                    {
                                        Cantidad = Rellena("0", CantDiasSacProporcional, 5, true);
                                    }
                                    else if (instConsultas.TraerCodigoDeAfip(sl.GetCellValueAsString(i, 1)) == "150000")//adelanto vacacional
                                    {
                                        Cantidad = Rellena("0", CantDiasAdelantoVacaciones, 5, true);
                                    }
                                    else if (instConsultas.TraerCodigoDeAfip(sl.GetCellValueAsString(i, 1)) == "130000")//horas extras
                                    {
                                        Cantidad = Rellena("0", CantDiasHorasExtra, 5, true);
                                    }
                                    else if (instConsultas.TraerCodigoDeAfip(sl.GetCellValueAsString(i, 1)) == "130001")//horas extras al 50%
                                    {
                                        Cantidad = Rellena("0", CantDiasHorasExtra50, 5, true);
                                    }
                                    else if (instConsultas.TraerCodigoDeAfip(sl.GetCellValueAsString(i, 1)) == "130002")//horas extras al 100%
                                    {
                                        Cantidad = Rellena("0", CantDiasHorasExtra100, 5, true);
                                    }
                                    else if (instConsultas.TraerCodigoDeAfip(sl.GetCellValueAsString(i, 1)) == "130003")//horas extras al 200%
                                    {
                                        Cantidad = Rellena("0", CantDiasHorasExtra200, 5, true);
                                    }
                                    else
                                    {
                                        Cantidad = "00000";
                                    }
                                }

                                //pregunto si tiene valor el concepto
                                //MessageBox.Show(sl.GetCellValueAsString(i, 2));
                                if (sl.GetCellValueAsString(i, 1) != "" & sl.GetCellValueAsString(i, Columnas + 2) != "")
                                {
                                    //MessageBox.Show(sl.GetCellValueAsString(i, 1));
                                    if (Regex.IsMatch(sl.GetCellValueAsString(i, 1), @"^[0-9]+$"))
                                    {
                                        string Dato = "03" + CuilEmpleado + Rellena(" ", sl.GetCellValueAsString(i, 1), 10, false) + Cantidad + " " + Rellena("0", Valor, 15, true) + instConsultas.TraerCreditoDebito(sl.GetCellValueAsString(i, 1)) + "      ";
                                        //MessageBox.Show(Rellena("0", Valor, 15, true));
                                        sw3.WriteLine(Dato);
                                    }
                                    else
                                    {
                                        switch (sl.GetCellValueAsString(i, 1))
                                        {
                                            case "B1":
                                                BaseImponible1 = Rellena("0", QuitaComa(sl.GetCellValueAsString(i, Columnas + 2)), 15, true);
                                                break;
                                            case "B2":
                                                BaseImponible2 = Rellena("0", QuitaComa(sl.GetCellValueAsString(i, Columnas + 2)), 15, true);
                                                break;
                                            case "B3":
                                                BaseImponible3 = Rellena("0", QuitaComa(sl.GetCellValueAsString(i, Columnas + 2)), 15, true);
                                                break;
                                            case "B4":
                                                BaseImponible4 = Rellena("0", QuitaComa(sl.GetCellValueAsString(i, Columnas + 2)), 15, true);
                                                break;
                                            case "B5":
                                                BaseImponible5 = Rellena("0", QuitaComa(sl.GetCellValueAsString(i, Columnas + 2)), 15, true);
                                                break;
                                            case "B6":
                                                BaseImponible6 = Rellena("0", QuitaComa(sl.GetCellValueAsString(i, Columnas + 2)), 15, true);
                                                break;
                                            case "B7":
                                                BaseImponible7 = Rellena("0", QuitaComa(sl.GetCellValueAsString(i, Columnas + 2)), 15, true);
                                                break;
                                            case "B8":
                                                BaseImponible8 = Rellena("0", QuitaComa(sl.GetCellValueAsString(i, Columnas + 2)), 15, true);
                                                break;
                                            case "B9":
                                                BaseImponible9 = Rellena("0", QuitaComa(sl.GetCellValueAsString(i, Columnas + 2)), 15, true);
                                                break;
                                            case "B10":
                                                BaseImponible10 = Rellena("0", QuitaComa(sl.GetCellValueAsString(i, Columnas + 2)), 15, true);
                                                break;
                                            case "BCASS":
                                                BaseCalculoAporteSegSoc = Rellena("0", QuitaComa(sl.GetCellValueAsString(i, Columnas + 2)), 15, true);
                                                break;
                                            case "BCCSS":
                                                BaseCalculoContSegSoc = Rellena("0", QuitaComa(sl.GetCellValueAsString(i, Columnas + 2)), 15, true);
                                                break;
                                            case "ID":
                                                ImporteDetraer = Rellena("0", QuitaComa(sl.GetCellValueAsString(i, Columnas + 2)), 15, true);
                                                break;
                                            default:
                                                break;
                                        }
                                    }

                                }


                            }

                        }
                    }



                    //crear archivo 04
                    instConsultas.VerificarExixtenciaArchivo("Reg04");
                    //DataTable dtDatosFijos = new DataTable();
                    using (StreamWriter sw = File.CreateText(instConsultas.path))//
                    {
                        foreach (DataRow item in DtDatosFIjos.Rows)
                        {
                            //MessageBox.Show(item["MarcaCorrespondeReduccion"].ToString());
                            sw.WriteLine("04" + CuilEmpleado + item["Conyuge"].ToString() + item["CantidadDeHijos"].ToString() + item["MarcaCCT"].ToString() + item["MarcaSCVO"].ToString()+ item["MarcaCorrespondeReduccion"].ToString()+ item["TipoEmpresa"].ToString()+ "0"+ item["SituacionDeRevista1"].ToString()+ item["CodigoCondicion"].ToString()+ item["CodigoActividad"].ToString()+ item["CodigoModalidadContratacion"].ToString()+ item["CodigoSiniestrado"].ToString()+ item["CodigoDeLocalidad"].ToString()+ item["SituacionDeRevista1"].ToString()+ item["DiaInicioSituacionDeRevista1"].ToString()+ item["SituacionDeRevista2"].ToString()+ item["DiaInicioSituacionDeRevista2"].ToString()+ item["SituacionDeRevista3"].ToString()+ item["DiaInicioSituacionDeRevista3"].ToString() + item["CantDiasTrabajados"].ToString() + item["HorasTrabajadas"].ToString() + item["PorcentajeAporteAdicionalSS"].ToString() + item["ContribucionTareaDiferencial"].ToString() + item["CodigoObraSocial"].ToString() + item["Cantidadadherentes"].ToString() + item["AporteAdicionalOS"].ToString() + item["ContribucionAdicionalOS"].ToString() + item["BaseCalculoDiferencialAportesOSyFSR"].ToString() + item["BaseCalculoDiferencialOSyFSR"].ToString() + item["BaseCalculoDiferencialLRT"].ToString() + item["RemuneracionMaternidadANSeS"].ToString() +RenumeracionBruta + BaseImponible1 + BaseImponible2 + BaseImponible3 + BaseImponible4 + BaseImponible5 + BaseImponible6 + BaseImponible7 + BaseImponible8 + BaseImponible9 + BaseCalculoAporteSegSoc + BaseCalculoContSegSoc + BaseImponible10  + ImporteDetraer );
                        }
                    }
                }

            }

            if (ListaDeErrores.Count == 0)
            {
                //proceso archivo
                RadMessageBox.Show("Listo");

            }
            else
            {
                FrmErrores Frmerrores = new FrmErrores();
                //Frmerrores._ListaDeErrores.Clear();
                Frmerrores._ListaDeErrores=ListaDeErrores;
                Frmerrores.Show();
            }


        }
        public string ValorAbsoluto(string importe)
        {
            string Valor = string.Empty;
            if (importe != "")
            {
                decimal val = Math.Abs(decimal.Parse(importe.Replace(".", ",")));
                Valor = QuitaComa(val.ToString());
            }
            


            return Valor;
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
        public bool Errores()
        {
            ListaDeErrores.Clear();
            //verifico conceptos
            Verificar("conceptos",1, "la tabla de conceptos esta vacia", "Excel conceptos");
           
            //verifico datos fijos
            Verificar("datosFijos", 2, "la tabla de datos fijos esta vacia", "Excel Datos Fijos");
            //verifico excel
           

            return error;
        }
        public void Verificar(string tabla,int NumeroError, string descripcion, string archivoError)
        {
            DataTable DtTemp = instConsultas.TraerDatosBase(tabla);
            if (DtTemp.Rows.Count == 0)
            {
                ListaDeErrores.Add(new ClassError { Numero = NumeroError, Descripcion = descripcion, ArchivoError = archivoError });
                error = true;
            }
        }


        private void FrmCrearLibro_Load(object sender, EventArgs e)
        {
            if (Conceptos)
            {
                this.Text = "Alta de Conceptos";
            }
            else if (DatosFIjos)
            {
                this.Text = "Alta de Datos Fijos";
            }
            else if (CrearLibro)
            {
                this.Text = "Crear Libro";
                TxtPeriodo.Visible = true;
                LblPeriodo.Visible = true;

            }
        }

        private void CmbSeleccionarArchivo_Click(object sender, EventArgs e)
        {

            OfdAbrirArchivo.Filter = "Archivo de Excel (*.xlsx)|*.xlsx";
            DialogResult dr = OfdAbrirArchivo.ShowDialog();
            //OfdAbrirArchivo.FileName = "Seleciona un archivo de Excel";
            
            if (dr == DialogResult.OK)
            {
                if (DatosFIjos)
                {
                    RutaArchivoFijo = OfdAbrirArchivo.FileName;
                   
                }
                else if (Conceptos)
                {
                    RutaArchivoConcepto = OfdAbrirArchivo.FileName;
                }
                else
                {
                    RutaArchivoLiquidacion = OfdAbrirArchivo.FileName;
                }
                TxtRuta.Text = OfdAbrirArchivo.FileName;
            }
   
     
        }
        public string QuitaComa(string Dato)
        {
            string ImporSinCom = string.Empty;
            if (Dato != "")
            {
                decimal impT = decimal.Parse(Dato.Replace(".", ","));
                impT = Math.Round(impT, 2);

                string Impor = impT.ToString();
                int Coma = Impor.IndexOf(",", 0) + 1;
                int Longi = Impor.Length;

                if (Coma > 0)
                {
                    if (Longi - Coma == 1)
                    {
                        ImporSinCom = Impor.Replace(",", "") + "0";
                    }
                    else
                    {
                        ImporSinCom = Impor.Replace(",", "");
                    }

                }
                else
                {
                    ImporSinCom = Impor + "00";
                }
            }
            else
            {
                ImporSinCom = "0";
            }


            return ImporSinCom;
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void CrearCarpetaSalida()
        {
            string path = @"c:\LibroSueldoDigital";

            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    //Console.WriteLine("That path exists already.");
                    return;
                }
                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
            }
            catch (Exception e)
            {
                MessageBox.Show("Se ha producido un error: " + e.Message);
            }
        }
    }
}
