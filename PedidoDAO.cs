/*
NOMBRE: JOSE MARÍA MOLINA SÁNCHEZ. 
DNI: 29061256C.
CURSO: PROGRAMACIÓN EN LENGUAJES ESTRUCTURADOS DE APLICACIONES DE GESTIÓN.
 */

using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace E1_UF2180___Practica_evaluable
{
    public class PedidoDAO
    {
        private string connectionString = "Data Source=localhost:1521/xe;User Id=CHEMARY;Password=123456;";

        /// <summary>
        /// Busca todos los pedidos de un cliente específico, cruzando las tablas para obtener también el nombre del cliente.
        /// </summary>
        /// <param name="codigoCliente">El código del cliente del que se quieren ver los pedidos.</param>
        /// <returns>Un DataTable con los pedidos encontrados.</returns>
        public DataTable BuscarPorCliente(int codigoCliente)
        {
            OracleDataAdapter dataAdapter;
            DataTable dataTable = new DataTable();

            using (OracleConnection conexion = new OracleConnection(connectionString))
            {
                // --- CONSULTA SQL MEJORADA CON JOIN ---
                string consulta = @"
                    SELECT
                        p.codigo_pedido,
                        p.fecha_pedido,
                        p.fecha_esperada,
                        p.estado
                    FROM
                        pedido p
                    JOIN
                        cliente c ON p.codigo_cliente = c.codigo_cliente
                    WHERE
                        p.codigo_cliente = :p_codigo_cliente
                    ORDER BY
                        p.fecha_pedido DESC";

                OracleCommand comando = new OracleCommand(consulta, conexion);
                comando.Parameters.Add(new OracleParameter("p_codigo_cliente", codigoCliente));

                dataAdapter = new OracleDataAdapter(comando);
                dataAdapter.Fill(dataTable);

                return dataTable;
            }
        }
    }
}