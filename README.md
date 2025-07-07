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

**Menú Principal:**
![menu_principal](https://github.com/user-attachments/assets/09b5a1e6-4fe1-431a-9fc7-2edbb3057033)

**Añadir Cliente:**
![añadir_cliente_1](https://github.com/user-attachments/assets/7a08d594-5145-42d0-9ff2-cb9a940e3067)
![añadir_cliente_2](https://github.com/user-attachments/assets/4d733731-ab38-46bb-9823-4b23f5288e44)

**Consultar Cliente Anadido:**
![consultar_cliente_añadido](https://github.com/user-attachments/assets/074d7acb-8b4d-4353-9c1a-300a7fcb8852)

**Cliente por empleado:**
![clientes_por_empleado_1](https://github.com/user-attachments/assets/5c1cb94e-f119-42c6-98fb-eb9b5c1f413a)
![clientes_por_empleado_2](https://github.com/user-attachments/assets/c21ed1fd-d252-4e58-864f-2c051a7fad6f)
![clientes_por_empleado_3](https://github.com/user-attachments/assets/ed7ee631-ac4a-4ec2-b4bb-ed16377dcd9a)

**Consultar Cliente:**
![consultar_cliente_1](https://github.com/user-attachments/assets/ab1dc2e7-4f20-432f-9226-a086f663fe54)
![consultar_cliente_2](https://github.com/user-attachments/assets/e34cada4-d47b-4ffb-917c-89c6910bf954)


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
