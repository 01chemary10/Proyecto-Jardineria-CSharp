/*
NOMBRE: JOSE MARÍA MOLINA SÁNCHEZ. 
DNI: 29061256C.
CURSO: PROGRAMACIÓN EN LENGUAJES ESTRUCTURADOS DE APLICACIONES DE GESTIÓN.
 */

using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace E1_UF2180___Practica_evaluable
{
    public class DetallePedidoDAO
    {
        private string connectionString = "Data Source=localhost:1521/xe;User Id=CHEMARY;Password=123456;";

        /// <summary>
        /// Busca todas las líneas de detalle para un pedido específico.
        /// </summary>
        /// <param name="codigoPedido">El código del pedido del que se quieren ver los detalles.</param>
        /// <returns>Un DataTable con los detalles del pedido.</returns>
        public DataTable BuscarPorPedido(int codigoPedido)
        {
            using (OracleConnection conexion = new OracleConnection(connectionString))
            {
                // Consulta que cruza detalle_pedido con producto para obtener el nombre del producto
                string consulta = @"
                    SELECT
                        d.numero_linea,
                        d.codigo_producto,
                        p.nombre AS nombre_producto,
                        d.cantidad,
                        d.precio_unidad
                    FROM
                        detalle_pedido d
                    JOIN
                        producto p ON d.codigo_producto = p.codigo_producto
                    WHERE
                        d.codigo_pedido = :p_codigo_pedido
                    ORDER BY
                        d.numero_linea";

                OracleCommand comando = new OracleCommand(consulta, conexion);
                comando.Parameters.Add(new OracleParameter("p_codigo_pedido", codigoPedido));

                OracleDataAdapter dataAdapter = new OracleDataAdapter(comando);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                return dataTable;
            }
        }
    }
}