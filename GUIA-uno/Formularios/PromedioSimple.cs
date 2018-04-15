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
    public partial class PromedioSimple : Form
    {
        public PromedioSimple()
        {
            InitializeComponent();

             String nombre = txtnombre.Text;

            pnlresultados.Visible = false;

        }

        private void EnviarDatos(object sender, EventArgs e)
        {
           

            String n1 = txtnota1.Text;
            String n2 = txtnota2.Text;
            String n3 = txtnota3.Text;
            String n4 = txtnota4.Text;

            if (n1 == "" || n2 == "" || n3 == "" || n2 == "" || txtnombre.Text == "")
            {
                pnlresultados.Visible = true;
                label3.Text = "Debe ingresar todos los datos";
            }
            else
            {
                double nota1 = Convert.ToDouble(n1);
                double nota2 = Convert.ToDouble(n2);
                double nota3 = Convert.ToDouble(n3);
                double nota4 = Convert.ToDouble(n4);


                double resu = (nota1 + nota2 + nota3 + nota4) / 4;
                  string resultado = Convert.ToString(resu);


                if (resu != 0 && txtnombre.Text != "")
                {
                    lblnombre.Text = txtnombre.Text;
                    lblpromedio.Text = resultado;
                    pnlresultados.Visible = true;
                    label3.Text = "Su promedio de notas es :";
                    txtnombre.Text = "";
                    txtnota1.Text = "";
                    txtnota2.Text = "";
                    txtnota3.Text = "";
                    txtnota4.Text = "";

                }

            }









        }
    }
}
