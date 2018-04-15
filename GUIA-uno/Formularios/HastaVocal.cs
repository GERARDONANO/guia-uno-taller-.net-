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
    public partial class HastaVocal : Form
    {
        public HastaVocal()
        {
            InitializeComponent();
        }


       

        private void ValidarLetras(object sender, KeyEventArgs e)
        {
            if (txtletras.Text.Contains("a")|| txtletras.Text.Contains("e") ||
                txtletras.Text.Contains("i") || txtletras.Text.Contains("o") ||
                txtletras.Text.Contains("u")) {

                MessageBox.Show("se ha ingresado una vocal","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
    }

