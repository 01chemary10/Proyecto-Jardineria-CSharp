/*
NOMBRE: JOSE MARÍA MOLINA SÁNCHEZ. 
DNI: 29061256C.
CURSO: PROGRAMACIÓN EN LENGUAJES ESTRUCTURADOS DE APLICACIONES DE GESTIÓN.
 */

using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace E1_UF2180___Practica_evaluable
{
    // Formulario Alta Cliente
    public partial class FormAltaCliente : Form
    {
        private string connectionString = "Data Source=localhost:1521/xe;User Id=CHEMARY;Password=123456;";

        public FormAltaCliente()
        {
            InitializeComponent();
        }

        // Formulario alta cliente
        private void FormAltaCliente_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        // Método para cargar los empleados que se mostrarán en el ComboBox
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

        // Botón guardar el nuevo cliente
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // 1. Validamos los datos del formulario
            if (string.IsNullOrWhiteSpace(txtCodigoCliente.Text) || string.IsNullOrWhiteSpace(txtNombreCliente.Text) || cmbEmpleados.SelectedItem == null)
            {
                MessageBox.Show("El Código, Nombre del cliente y Representante de Ventas son obligatorios.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Creamos un objeto Cliente y lo rellenamos con los datos de los controles
                Cliente nuevoCliente = new Cliente
                {
                    CodigoCliente = int.Parse(txtCodigoCliente.Text),
                    NombreCliente = txtNombreCliente.Text,
                    NombreContacto = txtNombreContacto.Text,
                    ApellidoContacto = txtApellidoContacto.Text,
                    Telefono = txtTelefono.Text,
                    Fax = txtFax.Text,
                    LineaDireccion1 = txtDireccion1.Text,
                    LineaDireccion2 = txtDireccion2.Text,
                    Ciudad = txtCiudad.Text,
                    Region = txtRegion.Text,
                    Pais = txtPais.Text,
                    CodigoPostal = txtCodigoPostal.Text,
                    CodigoEmpleadoRepVentas = Convert.ToInt32(cmbEmpleados.SelectedValue),
                    LimiteCredito = decimal.Parse(txtLimiteCredito.Text)
                };

                // 3. Creamos una instancia del DAO y llamamos al método Guardar
                ClienteDAO clienteDAO = new ClienteDAO();
                bool exito = clienteDAO.Guardar(nuevoCliente);

                // 4. Informamos al usuario del resultado
                if (exito)
                {
                    MessageBox.Show("Cliente guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error de formato. Asegúrate de que el código y el límite de crédito sean números válidos.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cancela la operación
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}