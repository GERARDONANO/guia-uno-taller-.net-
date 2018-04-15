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
    public partial class NumerosReales : Form
    {
        public NumerosReales()
        {
            InitializeComponent();
        }

        private void CalcularNumeroMayor(object sender, EventArgs e)
        {
            double uno = Convert.ToDouble(txtn1.Text);
            double dos = Convert.ToDouble(txtn2.Text);
            double tres = Convert.ToDouble(txtn3.Text);

            if (uno < dos && uno < tres)
            {
                MessageBox.Show("el número "+uno+" es el menor");

            } else if (dos < uno && dos < tres)
            {
                MessageBox.Show("el número " + dos + " es el menor");
            } else if (tres < uno && tres <dos)
            {
                MessageBox.Show("el número " + tres + " es el menor");

            }

        }
    }
}
