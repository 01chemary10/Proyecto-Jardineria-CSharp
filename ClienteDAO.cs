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
    public class ClienteDAO
    {
        // La cadena de conexión se define una sola vez en el DAO
        private string connectionString = "Data Source=localhost:1521/xe;User Id=CHEMARY;Password=123456;";

        /// <summary>
        /// Busca clientes cuyo nombre coincida parcialmente con el criterio de búsqueda.
        /// </summary>
        /// <param name="nombreCliente">El texto a buscar en el nombre del cliente.</param>
        /// <returns>Un DataTable con los resultados de la búsqueda.</returns>
        public DataTable BuscarPorNombre(string nombreCliente)
        {
            OracleDataAdapter dataAdapter;
            DataTable dataTable = new DataTable();

            // Usamos el bloque 'using' para asegurar que la conexión se cierra sola
            using (OracleConnection conexion = new OracleConnection(connectionString))
            {
                // La consulta para buscar clientes por nombre
                // Usamos LIKE para buscar parcialmente y :p_nombre para un parámetro seguro.
                string consulta = "SELECT * FROM cliente WHERE nombre_cliente LIKE :p_nombre ORDER BY nombre_cliente";
                OracleCommand comando = new OracleCommand(consulta, conexion);
                // Añadimos el parámetro con el valor que nos llega al método
                comando.Parameters.Add(new OracleParameter("p_nombre", nombreCliente));

                // El DataAdapter ejecuta el comando y llena nuestra tabla
                dataAdapter = new OracleDataAdapter(comando);
                dataAdapter.Fill(dataTable);

                // El método devuelve la tabla llena de datos
                return dataTable;
            }
        }
        public bool Guardar(Cliente cliente)
        {
            using (OracleConnection conexion = new OracleConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string sqlInsert = "INSERT INTO cliente (codigo_cliente, nombre_cliente, nombre_contacto, apellido_contacto, telefono, fax, linea_direccion1, linea_direccion2, ciudad, region, pais, codigo_postal, codigo_empleado_rep_ventas, limite_credito) VALUES (:codigo_cliente, :nombre_cliente, :nombre_contacto, :apellido_contacto, :telefono, :fax, :linea_direccion1, :linea_direccion2, :ciudad, :region, :pais, :codigo_postal, :codigo_empleado_rep_ventas, :limite_credito)";
                    OracleCommand comando = new OracleCommand(sqlInsert, conexion);

                    // Populamos los parámetros desde las propiedades del objeto 'cliente'
                    comando.Parameters.Add(new OracleParameter("codigo_cliente", cliente.CodigoCliente));
                    comando.Parameters.Add(new OracleParameter("nombre_cliente", cliente.NombreCliente));
                    comando.Parameters.Add(new OracleParameter("nombre_contacto", cliente.NombreContacto));
                    comando.Parameters.Add(new OracleParameter("apellido_contacto", cliente.ApellidoContacto));
                    comando.Parameters.Add(new OracleParameter("telefono", cliente.Telefono));
                    comando.Parameters.Add(new OracleParameter("fax", cliente.Fax));
                    comando.Parameters.Add(new OracleParameter("linea_direccion1", cliente.LineaDireccion1));
                    comando.Parameters.Add(new OracleParameter("linea_direccion2", cliente.LineaDireccion2));
                    comando.Parameters.Add(new OracleParameter("ciudad", cliente.Ciudad));
                    comando.Parameters.Add(new OracleParameter("region", cliente.Region));
                    comando.Parameters.Add(new OracleParameter("pais", cliente.Pais));
                    comando.Parameters.Add(new OracleParameter("codigo_postal", cliente.CodigoPostal));
                    comando.Parameters.Add(new OracleParameter("codigo_empleado_rep_ventas", cliente.CodigoEmpleadoRepVentas));
                    comando.Parameters.Add(new OracleParameter("limite_credito", cliente.LimiteCredito));

                    // ExecuteNonQuery devuelve el número de filas afectadas.
                    // Si es mayor que 0, la inserción fue exitosa.
                    return comando.ExecuteNonQuery() > 0;
                }
                catch (Exception)
                {
                    // Si ocurre cualquier error, devolvemos false.
                    // Podríamos también lanzar la excepción para que el formulario la capture.
                    return false;
                }
            }
        }
        public DataTable BuscarPorEmpleado(int codigoEmpleado)
        {
            OracleDataAdapter dataAdapter;
            DataTable dataTable = new DataTable();

            using (OracleConnection conexion = new OracleConnection(connectionString))
            {
                try
                {
                    // Consulta para buscar clientes por el código del empleado
                    string consulta = "SELECT codigo_cliente, nombre_cliente, telefono, ciudad FROM cliente WHERE codigo_empleado_rep_ventas = :p_codigo_empleado ORDER BY nombre_cliente";

                    OracleCommand comando = new OracleCommand(consulta, conexion);
                    comando.Parameters.Add(new OracleParameter("p_codigo_empleado", codigoEmpleado));

                    dataAdapter = new OracleDataAdapter(comando);
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception)
                {
                    // En caso de error, devolvemos una tabla vacía
                    return new DataTable();
                }
            }
        }
    }
}