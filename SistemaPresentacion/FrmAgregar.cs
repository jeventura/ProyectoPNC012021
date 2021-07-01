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
    public partial class FrmAgregar : Form
    {
        public FrmAgregar()
        {
            InitializeComponent();
        }

        private void FrmAgregar_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = " ";

                /*if(tbAutor.Text == string.Empty)
                {

                }
                else if(tbIdioma.Text == string.Empty)
                {

                }
                else if(tbPais.Text == string.Empty)
                {

                }
                else if(tbNEdicion.Text == string.Empty)
                {

                }*/
                /*else
                {*/
                    Rpta = NLibro.Insertar(Convert.ToString(TBTitulo.Text), Convert.ToString(tbAutor.Text),Convert.ToString(tbPais.Text),Convert.ToString(tbIdioma.Text), Convert.ToInt32(tbAñoEdicion.Text), Convert.ToInt32(tbNEdicion.Text), Convert.ToString(tbMateria.Text),Convert.ToString(TBISBN.Text),Convert.ToString(tbUbicacion.Text),Convert.ToInt32(tbNumeroPaginas.Text),Convert.ToString(tbDescripcion.Text));
                //}
            }
            catch
            {

            }
        }

    }
}
