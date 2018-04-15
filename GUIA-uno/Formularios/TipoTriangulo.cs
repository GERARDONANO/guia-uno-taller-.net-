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
    public partial class TipoTriangulo : Form
    {
        public TipoTriangulo()
        {
            InitializeComponent();

            lbltriangulo.Visible = false;
        }

        private void CalcularTipoTriangulo(object sender, EventArgs e)
        {



            if (txtladoA.Text != "" && txtladoB.Text != "" && txtladoC.Text != "")
            {

                #region recibir string y convertirlos a int

                int ladoA = Convert.ToInt16(txtladoA.Text);
                int ladoB = Convert.ToInt16(txtladoB.Text);
                int ladoC = Convert.ToInt16(txtladoC.Text);



                #endregion


                if (ladoA == ladoB && ladoA == ladoC)
                {
                    lbltriangulo.Visible = true;
                    lbltriangulo.Text = "Equilatero";
                    limpiar();
                }
                else if (ladoA == ladoB || ladoB == ladoC || ladoA == ladoC)
                {
                    lbltriangulo.Visible = true;
                    lbltriangulo.Text = "Isosceles";
                    limpiar();
                }
                else if (ladoA != ladoB || ladoB != ladoC || ladoA != ladoC)
                {

                    lbltriangulo.Visible = true;
                    lbltriangulo.Text = "Escaleno";
                    limpiar();
                }

            }else {
                MessageBox.Show("Debe ingresar los 3 lados ","ALERTA", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            void limpiar() {
                txtladoA.Text="";
                txtladoB.Text="";
                txtladoC.Text="";
            }

        }
    }
}
