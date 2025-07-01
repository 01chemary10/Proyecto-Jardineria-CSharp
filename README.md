#*Aplicación de Gestión de "Jardinería"*

Aplicación de escritorio desarrollada en C# y Windows Forms para la gestión de clientes y pedidos de una base de datos Oracle, como parte de un proyecto de clase. El proyecto demuestra la implementación de una arquitectura limpia y profesional utilizando el patrón de diseño DAO (Data Access Object).

##*Características Principales*

    *Gestión de Clientes*: Formulario para el alta de nuevos clientes en la base de datos.

    *Consulta Avanzada:* Una potente interfaz unificada que permite:

        Buscar clientes por nombre.

        Seleccionar un cliente para ver la lista de todos sus pedidos.

        Seleccionar un pedido para ver su detalle completo (productos, cantidades y precios).

    *Interfaz Personalizable*: El usuario puede elegir dinámicamente qué columnas de datos de los clientes desea visualizar en la tabla de resultados.

    Arquitectura Profesional: Implementación del patrón de diseño DAO para una clara separación entre la interfaz de usuario y la lógica de acceso a datos.

    *Diseño Cuidado:* Uso de colores para diferenciar las acciones de los botones y mejorar la experiencia de usuario.

###*Capturas de Pantalla*
*Menú Principal:*
![menu_principal](https://github.com/user-attachments/assets/5dce1ab8-d2af-4d4c-b612-7a33dd4ed4fe)

*Vista de Consulta (Maestro-Detalle-Detalle):*
![añadir_cliente_1](https://github.com/user-attachments/assets/e945f7f9-a336-4340-b709-9e3f6c85e1f6)
![clientes_por_empleado_1](https://github.com/user-attachments/assets/99567642-0419-437d-8d99-ec81a48c1dc5)
![consultar_cliente_1](https://github.com/user-attachments/assets/56ddb0e7-7412-40af-a278-c0131f96dc74)


##*Arquitectura: Patrón DAO*

El proyecto está estructurado siguiendo el patrón *DAO (Data Access Object)* para separar la lógica de negocio de la lógica de acceso a datos. Esto resulta en un código más limpio, mantenible y reutilizable.

    ClienteDAO.cs: Gestiona todas las operaciones sobre la tabla cliente (búsquedas, inserciones).

    EmpleadoDAO.cs: Gestiona las operaciones sobre la tabla empleado (obtener la lista para los ComboBox).

    PedidoDAO.cs: Gestiona las consultas sobre la tabla pedido.

    DetallePedidoDAO.cs: Gestiona las consultas sobre la tabla detalle_pedido, cruzándola con producto.

    Cliente.cs: Clase modelo (POCO) que sirve como contenedor para transportar los datos de un cliente de forma estructurada.

##*Tecnologías Utilizadas*

    *Lenguaje:* C#

    *Framework*: .NET Framework (Windows Forms)

    *IDE:* Visual Studio 2022

    *Base de Datos:* Oracle

    *Conector:* ODP.NET (Oracle.ManagedDataAccess.Client vía NuGet)

##*Instalación y Configuración*

    Clonar o descargar este repositorio.

    Abrir la solución (.sln) con Visual Studio 2022.

    Al abrir, Visual Studio restaurará automáticamente el paquete NuGet de Oracle necesario.

    *IMPORTANTE: *Antes de ejecutar, es necesario configurar la cadena de conexión a la base de datos. Esta se encuentra como un campo private string connectionString al principio de cada una de las clases DAO (ClienteDAO.cs, EmpleadoDAO.cs, etc.).

    Modificar la cadena con los datos de tu instancia de Oracle:
    C#

private string connectionString = "Data Source=TU_HOST:TU_PUERTO/TU_SID;User Id=TU_USUARIO;Password=TU_CONTRASENA;";

Se recomienda compilar y ejecutar el proyecto usando la plataforma x86 para maximizar la compatibilidad con diferentes drivers de Oracle.

Ejecutar el proyecto.
