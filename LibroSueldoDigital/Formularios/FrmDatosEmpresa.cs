using LibroSueldoDigital.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace LibroSueldoDigital.Formularios
{
    public partial class FrmDatosEmpresa : Telerik.WinControls.UI.RadForm
    {
        public FrmDatosEmpresa()
        {
            InitializeComponent();
        }
        ClassConsultas instconsultas = new ClassConsultas();
        private void FrmDatosEmpresa_Load(object sender, EventArgs e)
        {
            DataTable dtEmpresa = new DataTable();
            dtEmpresa= instconsultas.TraerDatosBase("Empresa");
            foreach (DataRow item in dtEmpresa.Rows)
            {
                TxtRazonSocial.Text = item[1].ToString();
                TxtCuit.Text = item[2].ToString();
                TxtDiaDePago.Text= item[3].ToString();
            }
        }
 
        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            instconsultas.InsertarDatosEmpresa(TxtRazonSocial.Text,long.Parse(TxtCuit.Text.Replace("-","")),int.Parse(TxtDiaDePago.Text));
            this.Close();
        }
    }
}
