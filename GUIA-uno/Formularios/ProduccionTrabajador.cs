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
    public partial class ProduccionTrabajador : Form
    {
        public ProduccionTrabajador()
        {
            InitializeComponent();
        }

        
        private void Calcularpromedio(object sender, EventArgs e)
        {

            if (txtlunes.Text != "" || txtmartes.Text != "" || txtmiercoles.Text != "" || txtjueves.Text != "" ||
                txtviernes.Text != "" || txtsabado.Text != "")
            {
                #region obtener valores como enteros

                int BLUNES = Convert.ToInt32(txtlunes.Text);

                int BMARTES = Convert.ToInt32(txtmartes.Text);

                int BMIERCOLES = Convert.ToInt32(txtmiercoles.Text);

                int BJUEVES = Convert.ToInt32(txtjueves.Text);

                int BVIERNES = Convert.ToInt32(txtviernes.Text);

                int BSABADO = Convert.ToInt32(txtsabado.Text);
                #endregion


                int prome = BLUNES + BMARTES + BMIERCOLES + BJUEVES + BVIERNES + BSABADO / 6;
                if (prome < 500)
                {
                    MessageBox.Show("El trabajador no supera \n las 500 bandejas diarias", "ALERTA"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("El promedio del trabajador \n supera las 500 bandejas diarias", "INFORMACION"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else {
                MessageBox.Show("rellene todos los campos", "ALERTA"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
    }
}
