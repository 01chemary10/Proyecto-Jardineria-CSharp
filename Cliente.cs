/*
NOMBRE: JOSE MARÍA MOLINA SÁNCHEZ. 
DNI: 29061256C.
CURSO: PROGRAMACIÓN EN LENGUAJES ESTRUCTURADOS DE APLICACIONES DE GESTIÓN.
 */

namespace E1_UF2180___Practica_evaluable
{
    // Esta clase sirve como un 'molde' o 'contenedor' para los datos de un cliente.
    public class Cliente
    {
        // Las propiedades se corresponden con las columnas de la tabla 'cliente'
        public int CodigoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string NombreContacto { get; set; }
        public string ApellidoContacto { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string LineaDireccion1 { get; set; }
        public string LineaDireccion2 { get; set; }
        public string Ciudad { get; set; }
        public string Region { get; set; }
        public string Pais { get; set; }
        public string CodigoPostal { get; set; }
        public int? CodigoEmpleadoRepVentas { get; set; }
        public decimal LimiteCredito { get; set; }
    }
}