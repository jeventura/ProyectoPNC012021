using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using SistemaNegocio;
using System.Windows.Forms;

namespace SistemaPresentacion
{
    public partial class FrmConsultar : Form
    {
        public FrmConsultar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = " ";
                if(TBTitulo.Text == string.Empty)
                {

                }
                else
                {
                    DGVConsultar.DataSource = NLibro.Buscar(Convert.ToString(TBTitulo.Text));
                }
            }
            catch
            {

            }
        }
    }
}
