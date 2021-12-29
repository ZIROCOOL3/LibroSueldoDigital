using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace instalador_de_licencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdInstalar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.SystemX86));

            StreamWriter fichero; //Clase que representa un fichero
            fichero = File.CreateText(Environment.GetFolderPath(Environment.SpecialFolder.SystemX86)+@"\lic.dat"); //Creamos un fichero
            //fichero.WriteLine("esto es una línea"); // Lo mismo que cuando escribimos por consola
            //fichero.Write("fin de la cita.");
            fichero.Close();
            MessageBox.Show("listo");
        }
    }
}
