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

        private void Registrar_Click(object sender, EventArgs e)
        {
            if (!Validacion(out HistorialEmpleos nuevoEmpleo))
            {
                return;
            }
            string mensaje = nhistorial.RegistrarEmpleo(nuevoEmpleo);
            MessageBox.Show(mensaje);
            MostrarEmpleos(nhistorial.ListarTodo(codigohistorial));
            LimpiarCampos();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            int valor = seleccionCodigo();
            if (valor == 0 || !Validacion(out HistorialEmpleos historial))
            {
                return;
            }
            string mensaje = nhistorial.Modificar(historial);
            MostrarEmpleos(nhistorial.ListarTodo(codigohistorial));
            LimpiarCampos();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            int valor = seleccionCodigo();
            if (valor == 0 || !Validacion(out HistorialEmpleos historial))
            {
                return;
            }
            string mensaje = nhistorial.Eliminar(historial.Codigo_empleado);
            MostrarEmpleos(nhistorial.ListarTodo(codigohistorial));
            LimpiarCampos();
        }
    }
}
