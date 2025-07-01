/*
NOMBRE: JOSE MARÍA MOLINA SÁNCHEZ. 
DNI: 29061256C.
CURSO: PROGRAMACIÓN EN LENGUAJES ESTRUCTURADOS DE APLICACIONES DE GESTIÓN.
 */

using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace E1_UF2180___Practica_evaluable
{
    // Formulario Clientes por Empleado
    public partial class FormClientesPorEmpleado : Form
    {
        private string connectionString = "Data Source=localhost:1521/xe;User Id=CHEMARY;Password=123456;";

        public FormClientesPorEmpleado()
        {
            InitializeComponent();
        }

        // Al cargar el formulario, llenamos la lista de empleados
        private void FormClientesPorEmpleado_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        // Método para llenar el ComboBox (idéntico al de FormAltaCliente)
        private void CargarEmpleados()
        {
            try  // Primero carga los empleados
            {
                EmpleadoDAO empleadoDAO = new EmpleadoDAO();
                cmbEmpleados.DataSource = empleadoDAO.ObtenerTodos();
                cmbEmpleados.DisplayMember = "Texto";
                cmbEmpleados.ValueMember = "Valor";
            }
            catch (Exception ex) // en caso de que no haya nos muestra que no hay empleados
            {
                MessageBox.Show("Error al cargar los empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Al hacer clic en el botón, mostramos los clientes de ese empleado
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (cmbEmpleados.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un empleado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try  // Primero carga los clientes
            {
                // 1. Obtenemos el código del empleado del ComboBox
                int codigoEmpleadoSeleccionado = Convert.ToInt32(cmbEmpleados.SelectedValue);

                // 2. Creamos una instancia del DAO
                ClienteDAO clienteDAO = new ClienteDAO();

                // 3. Llamamos al nuevo método del DAO para obtener los clientes
                dgvResultados.DataSource = clienteDAO.BuscarPorEmpleado(codigoEmpleadoSeleccionado);

                // 4. Ajustamos la visualización
                dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex) // en caso de que no haya nos muestra que no hay clientes
            {
                MessageBox.Show("Error al consultar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón para salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}