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
    public partial class FormHistorial : Form
    {
        private int codigohistorial;
        private NHistorialEmpleos nhistorial = new NHistorialEmpleos();

        public FormHistorial(int dato)
        {
            InitializeComponent();
            codigohistorial = dato;
            ConfigurarLabels();
            MostrarEmpleos(nhistorial.ListarTodo(codigohistorial));
        }

        private void ConfigurarLabels()
        {
            label1.Text = "Código Empleado:";
            label2.Text = "Fecha Inicio:";
            label3.Text = "Fecha Fin:";
            Registrar.Text = "Registrar";
            Modificar.Text = "Modificar";
            Eliminar.Text = "Eliminar";
            this.Text = $"Historial de Empleo - Código: {codigohistorial}";
        }

        private void MostrarEmpleos(List<HistorialEmpleos> historial)
        {
            dgHistorial.DataSource = null;
            if (historial.Count() == 0)
            {
                return;
            }
            dgHistorial.DataSource = historial;
        }

        private void LimpiarCampos()
        {
            TB_CodigoEmpleado.Clear();
            Inicio.Value = DateTime.Now;
            Fin.Value = DateTime.Now;
        }

        private bool Validacion(out HistorialEmpleos historial)
        {
            historial = null;

            if (string.IsNullOrWhiteSpace(TB_CodigoEmpleado.Text))
            {
                MessageBox.Show("Ingresa el código del empleado.",
                                "Campos vacíos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            int codigoEmpleado;
            if (!int.TryParse(TB_CodigoEmpleado.Text, out codigoEmpleado))
            {
                MessageBox.Show("El código del empleado debe ser un valor numérico.",
                                "Dato inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            if (Inicio.Value > Fin.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha fin.",
                                "Rango de fechas incorrecto",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            historial = new HistorialEmpleos
            {
                Codigo_empleado = codigoEmpleado,
                Codigo_empleo = codigohistorial,
                Fecha_inicio = Inicio.Value,
                Fecha_fin = Fin.Value
            };

            return true;
        }

        private int seleccionCodigo()
        {
            if (dgHistorial.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro del historial.");
                return 0;
            }

            return int.Parse(dgHistorial.SelectedRows[0].Cells["Codigo_empleado"].Value.ToString());
        }

        private void CargarDatosSeleccionados()
        {
            if (dgHistorial.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow row = dgHistorial.SelectedRows[0];
            TB_CodigoEmpleado.Text = row.Cells["Codigo_empleado"].Value.ToString();
            Inicio.Value = Convert.ToDateTime(row.Cells["Fecha_inicio"].Value);
            Fin.Value = Convert.ToDateTime(row.Cells["Fecha_fin"].Value);
        }

        private void dgHistorial_SelectionChanged(object sender, EventArgs e)
        {
            CargarDatosSeleccionados();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            if (!Validacion(out HistorialEmpleos nuevoHistorial))
            {
                return;
            }

            string mensaje = nhistorial.RegistrarEmpleo(nuevoHistorial);
            MessageBox.Show(mensaje);
            MostrarEmpleos(nhistorial.ListarTodo(codigohistorial));
            LimpiarCampos();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            int valor = seleccionCodigo();
            if (valor == 0)
            {
                return;
            }

            // Validar campos sin generar nuevo código
            if (string.IsNullOrWhiteSpace(TB_CodigoEmpleado.Text))
            {
                MessageBox.Show("Ingresa el código del empleado.",
                                "Campos vacíos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int codigoEmpleado;
            if (!int.TryParse(TB_CodigoEmpleado.Text, out codigoEmpleado))
            {
                MessageBox.Show("El código del empleado debe ser un valor numérico.",
                                "Dato inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (Inicio.Value > Fin.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha fin.",
                                "Rango de fechas incorrecto",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Usar el código seleccionado
            HistorialEmpleos historial = new HistorialEmpleos
            {
                Codigo_empleado = valor,
                Codigo_empleo = codigohistorial,
                Fecha_inicio = Inicio.Value,
                Fecha_fin = Fin.Value
            };

            string mensaje = nhistorial.Modificar(historial);
            MessageBox.Show(mensaje);
            MostrarEmpleos(nhistorial.ListarTodo(codigohistorial));
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
                "¿Está seguro de eliminar este registro?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string mensaje = nhistorial.Eliminar(valor);
                    MessageBox.Show(mensaje);
                    MostrarEmpleos(nhistorial.ListarTodo(codigohistorial));
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
    }
}