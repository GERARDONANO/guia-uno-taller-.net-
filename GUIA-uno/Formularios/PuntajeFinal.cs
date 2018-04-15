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
    public partial class PuntajeFinal : Form
    {
        // atributos valor fijos
        public const int correctas = 10;
        public  const int erroneas = 5;
        

        public PuntajeFinal()
        { 

         InitializeComponent();
            panel1.Visible = false;


        }



       


        private void CalcularPuntaje(object sender, EventArgs e)
        {   
           

            #region Obtener valores y convertirlos

            int CORRECTAS = Convert.ToInt16(txtcorrectas.Text);
            int ERRONEAS = Convert.ToInt16(txterroneas.Text);
            String correctas = Convert.ToString(CORRECTAS);
            String erroneas = Convert.ToString(ERRONEAS);
            #endregion
                
                //calcular resultado final
                CORRECTAS = CORRECTAS * PuntajeFinal.correctas;
                ERRONEAS = ERRONEAS * PuntajeFinal.erroneas;
                int resu = CORRECTAS - ERRONEAS;
            String resultado = Convert.ToString(resu);

            //mostrar panel con resultado
            panel1.Visible = true;
            lblnombre.Text = txtnombre.Text;
            lblresultado.Text = resultado;

            //borrar campos
            txtcorrectas.Text = "";
            txterroneas.Text = "";
            txtblancas.Text = "";
            txtnombre.Text = "";
        }
    }
}

