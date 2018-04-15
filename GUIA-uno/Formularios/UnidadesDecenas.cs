using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIA_uno.Formularios
{
    public partial class UnidadesDecenas : Form
    {
        public UnidadesDecenas()
        {
            InitializeComponent();
        }








        private void mostrarUnidadesYdecenas(object sender, KeyEventArgs e)
        {
          

            
                int numeroingresado = Convert.ToInt16(txtentero.Text);

                int decena = numeroingresado / 10;
                string DECENA = Convert.ToString(decena);
                lbldecenas.Text = DECENA;

                int unidades = numeroingresado % 10;
                string UNIDADES = Convert.ToString(unidades);

                lblunidades.Text = UNIDADES;


        }


    }
}
