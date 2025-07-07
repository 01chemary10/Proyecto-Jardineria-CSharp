/*
NOMBRE: JOSE MARÍA MOLINA SÁNCHEZ. 
DNI: 29061256C.
CURSO: PROGRAMACIÓN EN LENGUAJES ESTRUCTURADOS DE APLICACIONES DE GESTIÓN.
 */

using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace E1_UF2180___Practica_evaluable
{
    public class EmpleadoDAO
    {
        private string connectionString = "Data Source=localhost:1521/xe;User Id=CHEMARY;Password=123456;";

        /// <summary>
        /// Obtiene una lista de todos los empleados para poblar un ComboBox.
        /// </summary>
        /// <returns>Una lista de objetos anónimos con propiedades Texto y Valor.</returns>
        public List<object> ObtenerTodos()
        {
            using (OracleConnection conexion = new OracleConnection(connectionString))
            {
                // Abrimos la conexión dentro de un bloque try-catch
                try
                {
                    conexion.Open();
                    // Consulta para obtener los empleados
                    string consulta = "SELECT codigo_empleado, nombre, apellido1 FROM empleado ORDER BY nombre";
                    OracleCommand comando = new OracleCommand(consulta, conexion);
                    OracleDataReader lector = comando.ExecuteReader();

                    // Creamos la lista que devolveremos
                    List<object> empleados = new List<object>();
                    while (lector.Read())
                    {
                        // Creamos un objeto anónimo para cada empleado
                        empleados.Add(new
                        {
                            Texto = $"{lector["NOMBRE"]} {lector["APELLIDO1"]}",
                            Valor = lector["CODIGO_EMPLEADO"]
                        });
                    }
                    // Devolvemos la lista llena
                    return empleados;
                }
                catch (Exception)
                {
                    // Si hay un error, devolvemos una lista vacía para no romper la aplicación
                    // Podríamos también relanzar la excepción para que el formulario la gestione
                    return new List<object>();
                }
            }
        }
    }
}