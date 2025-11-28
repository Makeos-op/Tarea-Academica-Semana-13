using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormPresentacion : Form
    {
        public FormPresentacion()
        {
            InitializeComponent();
        }

        private void Empleos_Click(object sender, EventArgs e)
        {
            FormEmpleos form = new FormEmpleos();
            form.Show();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reportes_Click(object sender, EventArgs e)
        {
            FormReporte form = new FormReporte();
            form.Show();
        }
    }
}
