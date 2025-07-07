¡Claro! No te preocupes, aquí tienes el contenido completo y final del fichero README.md, listo para que lo copies y pegues de nuevo en GitHub.

Aplicación de Gestión de "Jardinería"

Aplicación de escritorio desarrollada en C# y Windows Forms para la gestión de clientes y pedidos de una base de datos Oracle, como parte de un proyecto de clase. El proyecto demuestra la implementación de una arquitectura limpia y profesional utilizando el patrón de diseño DAO (Data Access Object).

Características Principales

    Gestión de Clientes: Formulario para el alta de nuevos clientes en la base de datos.

    Consulta Avanzada: Una potente interfaz unificada que permite:

        Buscar clientes por nombre.

        Seleccionar un cliente para ver la lista de todos sus pedidos.

        Seleccionar un pedido para ver su detalle completo (productos, cantidades y precios).

    Interfaz Personalizable: El usuario puede elegir dinámicamente qué columnas de datos de los clientes desea visualizar en la tabla de resultados.

    Arquitectura Profesional: Implementación del patrón de diseño DAO para una clara separación entre la interfaz de usuario y la lógica de acceso a datos.

    Diseño Cuidado: Uso de colores pastel para diferenciar las acciones de los botones y mejorar la experiencia de usuario.

Capturas de Pantalla

**

Menú Principal:

Vista de Consulta (Maestro-Detalle-Detalle):

Arquitectura: Patrón DAO

El proyecto está estructurado siguiendo el patrón DAO (Data Access Object) para separar la lógica de negocio de la lógica de acceso a datos. Esto resulta en un código más limpio, mantenible y reutilizable.

    ClienteDAO.cs: Gestiona todas las operaciones sobre la tabla cliente (búsquedas, inserciones).

    EmpleadoDAO.cs: Gestiona las operaciones sobre la tabla empleado (obtener la lista para los ComboBox).

    PedidoDAO.cs: Gestiona las consultas sobre la tabla pedido.

    DetallePedidoDAO.cs: Gestiona las consultas sobre la tabla detalle_pedido, cruzándola con producto.

    Cliente.cs: Clase modelo (POCO) que sirve como contenedor para transportar los datos de un cliente de forma estructurada.

Tecnologías Utilizadas

    Lenguaje: C#

    Framework: .NET Framework (Windows Forms)

    IDE: Visual Studio 2022

    Base de Datos: Oracle

    Conector: ODP.NET (Oracle.ManagedDataAccess.Client vía NuGet)

Instalación y Configuración

Paso 1: Configurar la Base de Datos

    El repositorio incluye el fichero jardineria.sql con la estructura y los datos necesarios.

    En tu instancia de Oracle, crea un nuevo usuario/esquema (por ejemplo, con el nombre CHEMARY y la contraseña 123456).

    Usando una herramienta como SQL Developer, conéctate a ese nuevo esquema.

    Abre el fichero jardineria.sql y ejecuta el script completo. Esto creará y poblará todas las tablas necesarias.

Paso 2: Configurar y Ejecutar la Aplicación

    Clona o descarga este repositorio.

    Abre la solución (.sln) con Visual Studio 2022. Visual Studio restaurará automáticamente el paquete NuGet de Oracle.

    IMPORTANTE: Antes de ejecutar, es necesario configurar la cadena de conexión a la base de datos. Esta se encuentra como un campo private string connectionString al principio de cada una de las clases DAO.

    Modifica la cadena con los datos de tu instancia de Oracle:
    C#

private string connectionString = "Data Source=TU_HOST:TU_PUERTO/TU_SID;User Id=TU_USUARIO;Password=TU_CONTRASENA;";

Se recomienda compilar y ejecutar el proyecto usando la plataforma x86 para maximizar la compatibilidad.

Ejecuta el proyecto (F5).
