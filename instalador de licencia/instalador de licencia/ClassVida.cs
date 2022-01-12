using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace instalador_de_licencia
{
    class ClaseVida
    {
        public void SaberEstadoDeJavier()
        {
            if(DateTime.Now >= 
                DateTime.Parse("05/01/2022 16:00")
                & 
                DateTime.Now <= 
                DateTime.Parse("11/01/2022 08:00"))
            {
                MessageBox.Show("De Vacaciones ;)");
            }
            else
            {
                MessageBox.Show("Trabajando....:(");
            }
        }
    }
}
