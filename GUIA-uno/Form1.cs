using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUIA_uno.Formularios;

namespace GUIA_uno
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void desplegarPromedioSimple(object sender, EventArgs e)
        {
            PromedioSimple promedios = new PromedioSimple();
            promedios.Show();
            
        }

        private void desplegarPuntajeFinal(object sender, EventArgs e)
        {
            PuntajeFinal puntaje = new PuntajeFinal();
            puntaje.Show();
        }

        private void desplegarLiquidacionSueldo(object sender, EventArgs e)
        {
            LiquidacionSueldo liquidacion = new LiquidacionSueldo();
            liquidacion.Show();
        }

        private void desplegarCuantosDVD(object sender, EventArgs e)
        {
            CuantosDVD dvd = new CuantosDVD();
            dvd.Show();
        }

        private void desplegarHermanoMayor(object sender, EventArgs e)
        {
            HermanoMayor Hmayor = new HermanoMayor();
            Hmayor.Show();
        }

        private void desplegarProduccionTrabajador(object sender, EventArgs e)
        {
            ProduccionTrabajador formulario = new ProduccionTrabajador();
            formulario.Show();
        }

        private void desplegarNumerosReales(object sender, EventArgs e)
        {
            NumerosReales formulario = new NumerosReales();
            formulario.Show();
        }

        private void desplegarTipoTriangulo(object sender, EventArgs e)
        {
            TipoTriangulo formulario = new TipoTriangulo();
            formulario.Show();
        }

        private void desplegarMetasVentas(object sender, EventArgs e)
        {
            TiposVentas formulario = new TiposVentas();
            formulario.Show();
        }

        private void desplegarUnidadesDecenas(object sender, EventArgs e)
        {
            UnidadesDecenas formulario = new UnidadesDecenas();
            formulario.Show();
        }

        private void desplegarHastaVocal(object sender, EventArgs e)
        {
            HastaVocal formulario = new HastaVocal();
            formulario.Show();
        }
    }
}
