using Dato;
using Negocio;
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
    public partial class FormEmpleos : Form
    {
        private NEmpleos nEmpleos = new NEmpleos();
        public FormEmpleos()
        {
            InitializeComponent();
        }
        private void MostrarEmpleos(List<Empleos> empleos)
        {
            dgEmpleos.DataSource = null;
            if (empleos.Count() == 0)
            {
                return;
            }
            dgEmpleos.DataSource = empleos;
        }
        private void LimpiarCampos()
        {
            TB_nombre.Clear();
            TB_salariomax.Clear();
            TB_salariomin.Clear();
        }
        private bool Validacion(out Empleos empleo)
        {
            empleo = null;
            if (TB_salariomin.Text == "" || TB_salariomax.Text == "" || TB_nombre.Text == "")
            {
                MessageBox.Show("Por favor, completa todos los campos antes de registrar.",
                                "Campos vacíos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            decimal salarioMin, salarioMax;

            if (!decimal.TryParse(TB_salariomin.Text, out salarioMin))
            {
                MessageBox.Show("El salario mínimo debe ser un valor numérico.",
                                "Dato inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(TB_salariomax.Text, out salarioMax))
            {
                MessageBox.Show("El salario máximo debe ser un valor numérico.",
                                "Dato inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            if (salarioMin <= 0 || salarioMax <= 0)
            {
                MessageBox.Show("Los salarios deben ser mayores que cero.",
                                "Valor inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            if (salarioMin > salarioMax)
            {
                MessageBox.Show("El salario mínimo no puede ser mayor que el salario máximo.",
                                "Rango incorrecto",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            empleo = new Empleos
            {
                Salario_minimo = salarioMin,
                Salario_maximo = salarioMax
            };
            return true;
        }
        private int seleccionCodigo()
        {
            if (dgEmpleos.SelectedRows.Count == 0)//Verifica si hay una fila seleccionada
            {
                MessageBox.Show("Seleccione un codigo ");
                return 0;
            }
            int IdEspacio = int.Parse(dgEmpleos.SelectedRows[0].Cells["Codigo"].Value.ToString());
            return IdEspacio;
        }
        private void Registrar_Click(object sender, EventArgs e)
        {
            if (!Validacion(out Empleos nuevoEmpleo)) 
            {
                return;
            }
                string mensaje = nEmpleos.RegistrarEmpleo(nuevoEmpleo);
                MessageBox.Show(mensaje);
                MostrarEmpleos(nEmpleos.ListarTodo());
                LimpiarCampos();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            int valor = seleccionCodigo();
             if (valor == 0 || !Validacion(out Empleos empleo))
            {
                return;
            }
            string mensaje = nEmpleos.Modificar(empleo);
            MostrarEmpleos(nEmpleos.ListarTodo());
            LimpiarCampos();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            int valor = seleccionCodigo();
            if (valor == 0 || !Validacion(out Empleos empleo))
            {
                return;
            }
            string mensaje = nEmpleos.Eliminar(empleo.Codigo);
            MostrarEmpleos(nEmpleos.ListarTodo());
            LimpiarCampos();
        }

        private void Historial_Empleos_Click(object sender, EventArgs e)
        {
            int valor = seleccionCodigo();
            if (valor == 0)
            {
                return;
            }
            FormHistorial formHistorial = new FormHistorial(valor);
        }
    }
}
