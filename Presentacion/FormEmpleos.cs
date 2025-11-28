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
            ConfigurarLabels();
            MostrarEmpleos(nEmpleos.ListarTodo());
        }

        private void ConfigurarLabels()
        {
            label1.Text = "Nombre Empleo:";
            label2.Text = "Salario Mínimo:";
            label3.Text = "Salario Máximo:";
            Registrar.Text = "Registrar";
            Modificar.Text = "Modificar";
            Eliminar.Text = "Eliminar";
            Historial_Empleos.Text = "Historial";
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

        private int GenerarCodigo()
        {
            if (nEmpleos.ListarTodo().Count == 0)
            {
                return 1;
            }
            else
            {
                return nEmpleos.ListarTodo().Max(e => e.Codigo) + 1;
            }
        }

        private bool Validacion(out Empleos empleo)
        {
            empleo = null;

            // Validar que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(TB_nombre.Text) ||
                string.IsNullOrWhiteSpace(TB_salariomin.Text) ||
                string.IsNullOrWhiteSpace(TB_salariomax.Text))
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

            int codigoGenerado = GenerarCodigo();

            empleo = new Empleos
            {
                Codigo = codigoGenerado,
                Nombre_empleo = TB_nombre.Text.Trim(), // AGREGADO: Asignar el nombre del empleo
                Salario_minimo = salarioMin,
                Salario_maximo = salarioMax
            };
            return true;
        }

        private int seleccionCodigo()
        {
            if (dgEmpleos.SelectedRows.Count == 0)
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
            if (valor == 0)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(TB_nombre.Text) ||
                string.IsNullOrWhiteSpace(TB_salariomin.Text) ||
                string.IsNullOrWhiteSpace(TB_salariomax.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de modificar.",
                                "Campos vacíos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            decimal salarioMin, salarioMax;

            if (!decimal.TryParse(TB_salariomin.Text, out salarioMin))
            {
                MessageBox.Show("El salario mínimo debe ser un valor numérico.",
                                "Dato inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(TB_salariomax.Text, out salarioMax))
            {
                MessageBox.Show("El salario máximo debe ser un valor numérico.",
                                "Dato inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (salarioMin <= 0 || salarioMax <= 0)
            {
                MessageBox.Show("Los salarios deben ser mayores que cero.",
                                "Valor inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (salarioMin > salarioMax)
            {
                MessageBox.Show("El salario mínimo no puede ser mayor que el salario máximo.",
                                "Rango incorrecto",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            Empleos empleo = new Empleos
            {
                Codigo = valor,
                Nombre_empleo = TB_nombre.Text.Trim(),
                Salario_minimo = salarioMin,
                Salario_maximo = salarioMax
            };

            string mensaje = nEmpleos.Modificar(empleo);
            MessageBox.Show(mensaje);
            MostrarEmpleos(nEmpleos.ListarTodo());
            LimpiarCampos();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            int valor = seleccionCodigo();
            if (valor == 0)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                "¿Está seguro de eliminar este empleo?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string mensaje = nEmpleos.Eliminar(valor);
                    MessageBox.Show(mensaje);
                    MostrarEmpleos(nEmpleos.ListarTodo());
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message,
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void Historial_Empleos_Click(object sender, EventArgs e)
        {
            int valor = seleccionCodigo();
            if (valor == 0)
            {
                return;
            }
            FormHistorial formHistorial = new FormHistorial(valor);
            formHistorial.Show();
        }
    }
}
