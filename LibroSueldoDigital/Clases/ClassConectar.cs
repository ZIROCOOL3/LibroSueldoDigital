using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibroSueldoDigital.Clases
{
    class ClassConectar
    {
        SQLiteConnection con = new SQLiteConnection("Data Source=LibroSueldoDigital.db");
        public SQLiteConnection abrirConexion()
        {
            try
            {
                con.Open();
                return con;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return con;
            }

        }
        public void cerrarConexion()
        {
            con.Close();
        }
    }
}
