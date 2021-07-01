
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SistemaNegocio;

namespace SistemaPresentacion
{
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void Listar()
        //{
         //   try
           // {
           //     DGVReporte.DataSource = NLibro.Listar();
           // }
           // catch(Exception ex)
           // {
           //     MessageBox.Show(ex.Message + ex.StackTrace);
           // }
        //}

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            //this.Listar();
        }
    }
}
