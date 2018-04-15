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
    public partial class LiquidacionSueldo : Form
    {
        public LiquidacionSueldo()
        {
            InitializeComponent();
        }

        private void obtenerMonto(object sender, EventArgs e)
        {
            lblnombre.Text = txtnombre.Text;
            lblmes.Text = cbxmes.Text;
            lblhoras.Text = txthoras.Text;

            String sueldo = txtsueldo.Text;
            int SUELDO = Convert.ToInt32(sueldo);

            String horas = txthoras.Text;
            int HORAS = Convert.ToInt16(horas);
            

            double RESULTADO = (SUELDO * 0.0077777)*HORAS;
            String resultado = Convert.ToString(RESULTADO);
            lblmonto.Text = resultado;

        }
    }
}
