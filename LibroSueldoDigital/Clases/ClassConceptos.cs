using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibroSueldoDigital.Clases
{
    public class ClassConceptos
    {
        private static ClassConceptos _instancia = null;
        ClassConectar instCon = new ClassConectar();
        public ClassConceptos()
        {

        }
        public static ClassConceptos Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new ClassConceptos();
                return _instancia;
            }
        }
        public void Registrar(List<Conceptos> ListaConceptos)
        {
            //recorrer la lista
            for (int i = 0; i < ListaConceptos.Count; i++)
            {
                SQLiteCommand nComando = new SQLiteCommand(@"INSERT INTO Conceptos (
                    CodigoDeConcepto, 
                    Descripcion, 
                    CodigoDeConceptoEmpresa, 
                    DebitoCredito, 
                    MarcaDeRepeticion, 
                    AportesSistemaPrevisionalArgentinoSIPA, 
                    ContribucionesSistemaPrevisionalArgentinoSIPA, 
                    AportesINSSJyP, 
                    ContribucionesINSSJyP, 
                    AportesObraSocial, 
                    ContribucionesObraSocial, 
                    AportesFondoSolidariodeRedistribucion, 
                    ContribucionesFondoSolidariodeRedistribucion, 
                    AportesRENATEA, 
                    ContribucionesRENATEA, 
                    ContribucionesAsignacionesFamiliares, 
                    ContribucionesFondoNacionaldeEmpleo, 
                    ContribucionesLeydeRiesgosdelTrabajo, 
                    AportesRegimenesDiferenciales,
                    AportesRegimenesEspeciales)
                    VALUES(
                    @fk_empresa, 
                    @CodigoDeConcepto, 
                    @Descripcion, 
                    @CodigoDeConceptoEmpresa, 
                    @DebitoCredito, 
                    @MarcaDeRepeticion, 
                    @AportesSistemaPrevisionalArgentinoSIPA, 
                    @ContribucionesSistemaPrevisionalArgentinoSIPA, 
                    @AportesINSSJyP, 
                    @ContribucionesINSSJyP, 
                    @AportesObraSocial, 
                    @ContribucionesObraSocial, 
                    @AportesFondoSolidariodeRedistribucion, 
                    @ContribucionesFondoSolidariodeRedistribucion, 
                    @AportesRENATEA, 
                    @ContribucionesRENATEA, 
                    @ContribucionesAsignacionesFamiliares, 
                    @ContribucionesFondoNacionaldeEmpleo, 
                    @ContribucionesLeydeRiesgosdelTrabajo, 
                    @AportesRegimenesDiferenciales,
                    @AportesRegimenesEspeciales)", instCon.abrirConexion());

                nComando.Parameters.AddWithValue("@CodigoDeConcepto", ListaConceptos[i].CodigoDeConcepto);
                nComando.Parameters.AddWithValue("@Descripcion", ListaConceptos[i].Descripcion);
                nComando.Parameters.AddWithValue("@CodigoDeConceptoEmpresa", ListaConceptos[i].CodigoDeConceptoEmpresa);
                nComando.Parameters.AddWithValue("@DebitoCredito", ListaConceptos[i].DebitoCredito);
                nComando.Parameters.AddWithValue("@MarcaDeRepeticion", ListaConceptos[i].MarcaDeRepeticion);
                nComando.Parameters.AddWithValue("@AportesSistemaPrevisionalArgentinoSIPA", ListaConceptos[i].AportesSistemaPrevisionalArgentinoSIPA);
                nComando.Parameters.AddWithValue("@ContribucionesSistemaPrevisionalArgentinoSIPA", ListaConceptos[i].ContribucionesSistemaPrevisionalArgentinoSIPA);
                nComando.Parameters.AddWithValue("@AportesINSSJyP", ListaConceptos[i].AportesINSSJyP);
                nComando.Parameters.AddWithValue("@ContribucionesINSSJyP", ListaConceptos[i].ContribucionesINSSJyP);
                nComando.Parameters.AddWithValue("@AportesObraSocial", ListaConceptos[i].AportesObraSocial);
                nComando.Parameters.AddWithValue("@ContribucionesObraSocial", ListaConceptos[i].ContribucionesObraSocial);
                nComando.Parameters.AddWithValue("@AportesFondoSolidariodeRedistribucion", ListaConceptos[i].AportesFondoSolidariodeRedistribucion);
                nComando.Parameters.AddWithValue("@ContribucionesFondoSolidariodeRedistribucion", ListaConceptos[i].ContribucionesFondoSolidariodeRedistribucion);
                nComando.Parameters.AddWithValue("@AportesRENATEA", ListaConceptos[i].AportesRENATEA);
                nComando.Parameters.AddWithValue("@ContribucionesRENATEA", ListaConceptos[i].ContribucionesRENATEA);
                nComando.Parameters.AddWithValue("@ContribucionesAsignacionesFamiliares", ListaConceptos[i].ContribucionesAsignacionesFamiliares);
                nComando.Parameters.AddWithValue("@ContribucionesFondoNacionaldeEmpleo", ListaConceptos[i].ContribucionesFondoNacionaldeEmpleo);
                nComando.Parameters.AddWithValue("@ContribucionesLeydeRiesgosdelTrabajo", ListaConceptos[i].ContribucionesLeydeRiesgosdelTrabajo);
                nComando.Parameters.AddWithValue("@AportesRegimenesDiferenciales", ListaConceptos[i].AportesRegimenesDiferenciales);
                nComando.Parameters.AddWithValue("@AportesRegimenesEspeciales", ListaConceptos[i].AportesRegimenesEspeciales);
                nComando.ExecuteNonQuery();
                instCon.cerrarConexion();
            }


        }
        public void RegistrarIndividual(Conceptos Conceptos)
        {

            SQLiteCommand nComando = new SQLiteCommand(@"INSERT INTO Conceptos (
                 
                CodigoDeConcepto, 
                Descripcion, 
                CodigoDeConceptoEmpresa, 
                DebitoCredito, 
                MarcaDeRepeticion, 
                AportesSistemaPrevisionalArgentinoSIPA, 
                ContribucionesSistemaPrevisionalArgentinoSIPA, 
                AportesINSSJyP, 
                ContribucionesINSSJyP, 
                AportesObraSocial, 
                ContribucionesObraSocial, 
                AportesFondoSolidariodeRedistribucion, 
                ContribucionesFondoSolidariodeRedistribucion, 
                AportesRENATEA, 
                ContribucionesRENATEA, 
                ContribucionesAsignacionesFamiliares, 
                ContribucionesFondoNacionaldeEmpleo, 
                ContribucionesLeydeRiesgosdelTrabajo, 
                AportesRegimenesDiferenciales,
                AportesRegimenesEspeciales)
                VALUES(
                
                @CodigoDeConcepto, 
                @Descripcion, 
                @CodigoDeConceptoEmpresa, 
                @DebitoCredito, 
                @MarcaDeRepeticion, 
                @AportesSistemaPrevisionalArgentinoSIPA, 
                @ContribucionesSistemaPrevisionalArgentinoSIPA, 
                @AportesINSSJyP, 
                @ContribucionesINSSJyP, 
                @AportesObraSocial, 
                @ContribucionesObraSocial, 
                @AportesFondoSolidariodeRedistribucion, 
                @ContribucionesFondoSolidariodeRedistribucion, 
                @AportesRENATEA, 
                @ContribucionesRENATEA, 
                @ContribucionesAsignacionesFamiliares, 
                @ContribucionesFondoNacionaldeEmpleo, 
                @ContribucionesLeydeRiesgosdelTrabajo, 
                @AportesRegimenesDiferenciales,
                @AportesRegimenesEspeciales)", instCon.abrirConexion());

            //nComando.Parameters.AddWithValue("@fk_empresa", Conceptos.fk_empresa);
            nComando.Parameters.AddWithValue("@CodigoDeConcepto", Conceptos.CodigoDeConcepto);
            nComando.Parameters.AddWithValue("@Descripcion", Conceptos.Descripcion);
            nComando.Parameters.AddWithValue("@CodigoDeConceptoEmpresa", Conceptos.CodigoDeConceptoEmpresa);
            nComando.Parameters.AddWithValue("@DebitoCredito", Conceptos.DebitoCredito);
            nComando.Parameters.AddWithValue("@MarcaDeRepeticion", Conceptos.MarcaDeRepeticion);
            nComando.Parameters.AddWithValue("@AportesSistemaPrevisionalArgentinoSIPA", Conceptos.AportesSistemaPrevisionalArgentinoSIPA);
            nComando.Parameters.AddWithValue("@ContribucionesSistemaPrevisionalArgentinoSIPA", Conceptos.ContribucionesSistemaPrevisionalArgentinoSIPA);
            nComando.Parameters.AddWithValue("@AportesINSSJyP", Conceptos.AportesINSSJyP);
            nComando.Parameters.AddWithValue("@ContribucionesINSSJyP", Conceptos.ContribucionesINSSJyP);
            nComando.Parameters.AddWithValue("@AportesObraSocial", Conceptos.AportesObraSocial);
            nComando.Parameters.AddWithValue("@ContribucionesObraSocial", Conceptos.ContribucionesObraSocial);
            nComando.Parameters.AddWithValue("@AportesFondoSolidariodeRedistribucion", Conceptos.AportesFondoSolidariodeRedistribucion);
            nComando.Parameters.AddWithValue("@ContribucionesFondoSolidariodeRedistribucion", Conceptos.ContribucionesFondoSolidariodeRedistribucion);
            nComando.Parameters.AddWithValue("@AportesRENATEA", Conceptos.AportesRENATEA);
            nComando.Parameters.AddWithValue("@ContribucionesRENATEA", Conceptos.ContribucionesRENATEA);
            nComando.Parameters.AddWithValue("@ContribucionesAsignacionesFamiliares", Conceptos.ContribucionesAsignacionesFamiliares);
            nComando.Parameters.AddWithValue("@ContribucionesFondoNacionaldeEmpleo", Conceptos.ContribucionesFondoNacionaldeEmpleo);
            nComando.Parameters.AddWithValue("@ContribucionesLeydeRiesgosdelTrabajo", Conceptos.ContribucionesLeydeRiesgosdelTrabajo);
            nComando.Parameters.AddWithValue("@AportesRegimenesDiferenciales", Conceptos.AportesRegimenesDiferenciales);
            nComando.Parameters.AddWithValue("@AportesRegimenesEspeciales", Conceptos.AportesRegimenesEspeciales);
            nComando.ExecuteNonQuery();
            instCon.cerrarConexion();



        }
        public List<Conceptos> Listar(int IdEmpresa, string Opcion = "")
        {
            List<Conceptos> oConceptos = new List<Conceptos>();
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(ClassConectar.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select * from Conceptos where fk_empresa = " + IdEmpresa + Opcion);

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            //MessageBox.Show(dr["fk_empresa"].ToString());
                            oConceptos.Add(new Conceptos()
                            {
                                idConceptos = int.Parse(dr["idConceptos"].ToString()),
                                //fk_empresa = int.Parse(dr["fk_empresa"].ToString()),
                                CodigoDeConcepto = int.Parse(dr["CodigoDeConcepto"].ToString()),
                                Descripcion = dr["Descripcion"].ToString(),
                                CodigoDeConceptoEmpresa = int.Parse(dr["CodigoDeConceptoEmpresa"].ToString()),
                                DebitoCredito = dr["DebitoCredito"].ToString(),
                                MarcaDeRepeticion = int.Parse(dr["MarcaDeRepeticion"].ToString()),
                                AportesSistemaPrevisionalArgentinoSIPA = int.Parse(dr["AportesSistemaPrevisionalArgentinoSIPA"].ToString()),
                                ContribucionesSistemaPrevisionalArgentinoSIPA = int.Parse(dr["ContribucionesSistemaPrevisionalArgentinoSIPA"].ToString()),
                                AportesINSSJyP = int.Parse(dr["AportesINSSJyP"].ToString()),
                                ContribucionesINSSJyP = int.Parse(dr["ContribucionesINSSJyP"].ToString()),
                                AportesObraSocial = int.Parse(dr["AportesObraSocial"].ToString()),
                                ContribucionesObraSocial = int.Parse(dr["ContribucionesObraSocial"].ToString()),
                                AportesFondoSolidariodeRedistribucion = int.Parse(dr["AportesFondoSolidariodeRedistribucion"].ToString()),
                                ContribucionesFondoSolidariodeRedistribucion = int.Parse(dr["ContribucionesFondoSolidariodeRedistribucion"].ToString()),
                                AportesRENATEA = int.Parse(dr["AportesRENATEA"].ToString()),
                                ContribucionesRENATEA = int.Parse(dr["ContribucionesRENATEA"].ToString()),
                                ContribucionesAsignacionesFamiliares = int.Parse(dr["ContribucionesAsignacionesFamiliares"].ToString()),
                                ContribucionesFondoNacionaldeEmpleo = int.Parse(dr["ContribucionesFondoNacionaldeEmpleo"].ToString()),
                                ContribucionesLeydeRiesgosdelTrabajo = int.Parse(dr["ContribucionesLeydeRiesgosdelTrabajo"].ToString()),
                                AportesRegimenesDiferenciales = int.Parse(dr["AportesRegimenesDiferenciales"].ToString()),
                                AportesRegimenesEspeciales = int.Parse(dr["AportesRegimenesEspeciales"].ToString()),
                            });


                        }
                    }
                    //conexion.Close();
                }
            }
            catch (Exception ex)
            {
                oConceptos = new List<Conceptos>();
                MessageBox.Show(ex.Message);

            }

            return oConceptos;
        }
        public int Eliminar(int fk_empresa)
        {
            int respuesta = 0;

            using (SQLiteConnection conexion = new SQLiteConnection(ClassConectar.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("delete from Conceptos where fk_empresa= @id;");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@id", fk_empresa));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    respuesta = 0;
                }

            }


            return respuesta;
        }
        public int EliminarIndividual(int idConceptos)
        {
            int respuesta = 0;

            using (SQLiteConnection conexion = new SQLiteConnection(ClassConectar.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("delete from Conceptos where idConceptos=@idConceptos;");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@idConceptos", idConceptos));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    respuesta = 0;
                }

            }


            return respuesta;
        }
        public int Editar(Conceptos oConcepto, out string mensaje)
        {

            mensaje = string.Empty;
            int respuesta = 0;
            SQLiteTransaction objTransaccion = null;

            using (SQLiteConnection conexion = new SQLiteConnection(ClassConectar.cadena))
            {
                try
                {
                    conexion.Open();
                    objTransaccion = conexion.BeginTransaction();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine(string.Format("UPDATE Conceptos SET CodigoDeConcepto = '{2}'," +
                        "Descripcion = '{3}',CodigoDeConceptoEmpresa = '{4}'," +
                        "DebitoCredito = '{5}',MarcaDeRepeticion = '{6}',AportesSistemaPrevisionalArgentinoSIPA = '{7}'," +
                        "ContribucionesSistemaPrevisionalArgentinoSIPA = '{8}',AportesINSSJyP = '{9}',ContribucionesINSSJyP = '{10}'," +
                        "AportesObraSocial= '{11}',ContribucionesObraSocial = '{12}', AportesFondoSolidariodeRedistribucion = '{13}'," +
                        "ContribucionesFondoSolidariodeRedistribucion= '{14}',AportesRENATEA = '{15}',ContribucionesRENATEA = '{16}'," +
                        "ContribucionesAsignacionesFamiliares= '{17}',ContribucionesFondoNacionaldeEmpleo = '{18}',ContribucionesLeydeRiesgosdelTrabajo = '{19}'," +
                        "AportesRegimenesDiferenciales= '{20}',AportesRegimenesEspeciales = '{21}'" +
                        "WHERE  idConceptos = {1};",
                        //oConcepto.fk_empresa,
                        oConcepto.idConceptos,
                        oConcepto.CodigoDeConcepto,
                        oConcepto.Descripcion,
                        oConcepto.CodigoDeConceptoEmpresa,
                        oConcepto.DebitoCredito,
                        oConcepto.MarcaDeRepeticion,
                        oConcepto.AportesSistemaPrevisionalArgentinoSIPA,
                        oConcepto.ContribucionesSistemaPrevisionalArgentinoSIPA,
                        oConcepto.AportesINSSJyP,
                        oConcepto.ContribucionesINSSJyP,
                        oConcepto.AportesObraSocial,
                        oConcepto.ContribucionesObraSocial,
                        oConcepto.AportesFondoSolidariodeRedistribucion,
                        oConcepto.ContribucionesFondoSolidariodeRedistribucion,
                        oConcepto.AportesRENATEA,
                        oConcepto.ContribucionesRENATEA,
                        oConcepto.ContribucionesAsignacionesFamiliares,
                        oConcepto.ContribucionesFondoNacionaldeEmpleo,
                        oConcepto.ContribucionesLeydeRiesgosdelTrabajo,
                        oConcepto.AportesRegimenesDiferenciales,
                        oConcepto.AportesRegimenesEspeciales
                        ));

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Transaction = objTransaccion;
                    respuesta = cmd.ExecuteNonQuery();


                    if (respuesta < 1)
                    {
                        objTransaccion.Rollback();
                        mensaje = "No se pudo editar";
                    }

                    objTransaccion.Commit();

                }
                catch (Exception ex)
                {
                    objTransaccion.Rollback();
                    respuesta = 0;
                    mensaje = ex.Message;
                }
            }


            return respuesta;
        }
    }
}
