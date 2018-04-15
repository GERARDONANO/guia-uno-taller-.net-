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
    public partial class HermanoMayor : Form
    {
        public HermanoMayor()
        {
            InitializeComponent();
           
             
        }

        

        private void Calcular(object sender, EventArgs e)
        {


            int edad1 = Convert.ToInt16(txtedah1.Text);
            int edad2 = Convert.ToInt16(txtedah2.Text);
            
            if (edad1 > edad2)
            {
                int resu = edad1 - edad2;

                MessageBox.Show(txtnomh1.Text+" es mayor "+ resu+ " años que "+txtnomh2.Text);
            }
            else if (edad2 > edad1){
                
                int resu = edad2 - edad1;
                MessageBox.Show(txtnomh2.Text + " es mayor " + resu + " años que " + txtnomh1.Text);
            } 

            

        }
    }
}
