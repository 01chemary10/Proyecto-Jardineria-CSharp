# Aplicación de Gestión de "Jardinería"

Aplicación de escritorio desarrollada en C# y Windows Forms para la gestión de clientes y pedidos de una base de datos Oracle, como parte de un proyecto de clase. El proyecto demuestra la implementación de una arquitectura limpia y profesional utilizando el patrón de diseño DAO (Data Access Object).

## Características Principales

* **Gestión de Clientes:** Formulario para el alta de nuevos clientes en la base de datos.
* **Consulta Avanzada:** Una potente interfaz unificada que permite:
    * Buscar clientes por nombre.
    * Seleccionar un cliente para ver la lista de todos sus pedidos.
    * Seleccionar un pedido para ver su detalle completo (productos, cantidades y precios).
* **Interfaz Personalizable:** El usuario puede elegir dinámicamente qué columnas de datos de los clientes desea visualizar en la tabla de resultados.
* **Arquitectura Profesional:** Implementación del patrón de diseño DAO para una clara separación entre la interfaz de usuario y la lógica de acceso a datos.
* **Diseño Cuidado:** Uso de colores pastel para diferenciar las acciones de los botones y mejorar la experiencia de usuario.

## Capturas de Pantalla

## Arquitectura: Patrón DAO

El proyecto está estructurado siguiendo el patrón **DAO (Data Access Object)** para separar la lógica de negocio de la lógica de acceso a datos. Esto resulta en un código más limpio, mantenible y reutilizable.

* **ClienteDAO.cs:** Gestiona todas las operaciones sobre la tabla `cliente`.
* **EmpleadoDAO.cs:** Gestiona las operaciones sobre la tabla `empleado`.
* **PedidoDAO.cs:** Gestiona las consultas sobre la tabla `pedido`.
* **DetallePedidoDAO.cs:** Gestiona las consultas sobre la tabla `detalle_pedido`.
* **Cliente.cs:** Clase modelo (POCO) para transportar los datos de un cliente.

## Tecnologías Utilizadas

* **Lenguaje:** C#
* **Framework:** .NET Framework (Windows Forms)
* **IDE:** Visual Studio 2022
* **Base de Datos:** Oracle
* **Conector:** ODP.NET (Oracle.ManagedDataAccess.Client vía NuGet)

## Instalación y Configuración

1.  **Configurar la Base de Datos:**
    * Crear un nuevo esquema/usuario en Oracle.
    * Ejecutar el script `jardineria.sql` (incluido en este repositorio) en ese esquema para crear y poblar las tablas.

2.  **Configurar la Aplicación:**
    * Abrir la solución (`.sln`) con Visual Studio 2022.
    * **IMPORTANTE:** En cada una de las clases DAO (`ClienteDAO.cs`, `EmpleadoDAO.cs`, etc.), modificar la cadena de conexión (`connectionString`) con los datos de tu instancia de Oracle.
    * Compilar el proyecto (se recomienda usar la plataforma **x86**).
    * Ejecutar.
