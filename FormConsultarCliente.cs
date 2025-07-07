/*
NOMBRE: JOSE MARÍA MOLINA SÁNCHEZ. 
DNI: 29061256C.
CURSO: PROGRAMACIÓN EN LENGUAJES ESTRUCTURADOS DE APLICACIONES DE GESTIÓN.
 */

using System;
using System.Windows.Forms;

// Asegúrate de que el namespace es el correcto
namespace E1_UF2180___Practica_evaluable
{
    // Formulario para consultar cliente
    public partial class FormConsultarCliente : Form
    {
        public FormConsultarCliente()
        {
            InitializeComponent();
        }

        // Formulario de ChekedListBox, por defecto hay algunos marcados (true)
        private void FormConsultarCliente_Load(object sender, EventArgs e)
        {
            // Carga la lista de columnas para poder elegirlas
            clbColumnas.Items.Add("codigo_cliente", true);
            clbColumnas.Items.Add("nombre_cliente", true);
            clbColumnas.Items.Add("nombre_contacto", false);
            clbColumnas.Items.Add("apellido_contacto", false);
            clbColumnas.Items.Add("telefono", true);
            clbColumnas.Items.Add("fax", false);
            clbColumnas.Items.Add("linea_direccion1", true);
            clbColumnas.Items.Add("linea_direccion2", false);
            clbColumnas.Items.Add("ciudad", true);
            clbColumnas.Items.Add("region", false);
            clbColumnas.Items.Add("pais", true);
            clbColumnas.Items.Add("codigo_postal", false);
            clbColumnas.Items.Add("codigo_empleado_rep_ventas", false);
            clbColumnas.Items.Add("limite_credito", true);
        }

        // Botón para buscar Cliente.
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try  // Primero carga los clientes
            {
                ClienteDAO clienteDAO = new ClienteDAO();
                string criterioBusqueda = "%" + txtNombreBusqueda.Text + "%";
                dgvResultados.DataSource = clienteDAO.BuscarPorNombre(criterioBusqueda);
                dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Bucle para actualizar la visibilidad de las columnas
                for (int i = 0; i < clbColumnas.Items.Count; i++)
                {
                    string nombreColumna = clbColumnas.Items[i].ToString();
                    bool estaMarcado = clbColumnas.GetItemChecked(i);
                    dgvResultados.Columns[nombreColumna].Visible = estaMarcado;
                }
            }
            catch (Exception ex) // en caso de que no haya nos muestra que no hay clientes
            {
                MessageBox.Show("Error al buscar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvResultados_SelectionChanged(object sender, EventArgs e)
        {
            // Este método ahora solo se preocupa de la tabla de pedidos
            if (dgvResultados.CurrentRow == null)
            {
                dgvPedidos.DataSource = null;
                return;
            }
            try  // Primero carga los pedidos
            {
                int codigoCliente = Convert.ToInt32(dgvResultados.CurrentRow.Cells["codigo_cliente"].Value);
                PedidoDAO pedidoDAO = new PedidoDAO();
                dgvPedidos.DataSource = pedidoDAO.BuscarPorCliente(codigoCliente);
                dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex) // en caso de que no haya nos muestra que no hay pedidos
            {
                MessageBox.Show("Error al cargar los pedidos del cliente: " + ex.Message);
                dgvPedidos.DataSource = null;
            }
        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Este método solo se preocupa de la tabla de detalles
            if (e.RowIndex < 0) // Si se hace clic en la cabecera
            {
                return;
            }
            try  // Primero carga el detalle de los pedidos
            {
                int codigoPedido = Convert.ToInt32(dgvPedidos.Rows[e.RowIndex].Cells["codigo_pedido"].Value);
                DetallePedidoDAO detalleDAO = new DetallePedidoDAO();
                dgvDetalles.DataSource = detalleDAO.BuscarPorPedido(codigoPedido);
                dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex) // en caso de que no haya nos muestra que no hay pedidos
            {
                MessageBox.Show("Error al cargar el detalle del pedido: " + ex.Message);
                dgvDetalles.DataSource = null;
            }
        }

        // Botón Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
