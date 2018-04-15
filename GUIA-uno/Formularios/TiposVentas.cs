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
    public partial class TiposVentas : Form
    {
        public TiposVentas()
        {
            InitializeComponent();
        }

        private void CalcularPorcentaje(object sender, EventArgs e)
        {

            if (txtmonto.Text != "")
            {
                int monto = Convert.ToInt32(txtmonto.Text);

                if (txtmonto.Text != "" && txtnombre.Text == "")
                {
                    MessageBox.Show("Debe ingresar el nombre del vendedor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {


                    if (monto >= 0 && monto <= 500000)
                    {
                        MessageBox.Show("el vendedor " + txtnombre.Text + " recibe bonificación del 0%", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (monto >= 500001 && monto <= 1500000)
                    {
                        MessageBox.Show("el vendedor " + txtnombre.Text + "recibe bonificación del 3%", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (monto >= 1500001 && monto <= 2500000)
                    {
                        MessageBox.Show("el vendedor " + txtnombre.Text + " recibe bonificación del 8%", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (monto >= 2500001)
                    {
                        MessageBox.Show("el vendedor " + txtnombre.Text + " recibe bonificación del 12%", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else {
                MessageBox.Show("Debe ingresar un monto","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
                    }

        }
    }
}
