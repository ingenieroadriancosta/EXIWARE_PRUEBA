**Tabla de contenido**
[TOC]
<br>
<br>
# Especificaciones del proyecto
1. Crear una cuenta de ahorros
    - Nombre de la persona
    - Valor inicial de la cuenta
2. Consignar
    - Número de cuenta
    - Valor a consignar
3. Retirar dinero
    - Número de cuenta
    - Valor a retirar
4. Consultar saldo
    - Número de cuenta
<br>

##Requerimientos técnicos
1. API REST **(Backend)**
2. Persistencia de información **(Base de datos)**
3. Framework **(Angular)** para realizar llamados REST **(FrontEnd)**
4. Auditoría a base de archivos de texto
5. Pruebas unitarias del código desarrollado
<br>
<br>



#Descripción de la solución
La solución se plantea en base a una sucursal no virtual que ejecuta las acciones desde su propia red privada. Los cajeros son los administradores de las operaciones requeridas: 
- Creación de cuenta
- Consignación de fondos
- Retiro de fondos
- Consulta de saldo.

Para el desarrollo de las especificaciones se necesitarán bases de datos como soporte de información para las diferentes acciones, estas son los modelos de información del proyecto.

También se necesitará un BackEnd que provea la administración de las diferentes acciones.

Por último se necesitará una interfaz entre administradores y el BackEnd, este es el FrontEnd.

![](00.png)

## Base de datos

La base de contiene tres tablas, en ella se almacena la información de las transacciones, clientes y administradores.

### Usuarios administrativos
`USUARIOS DE ADMINISTRATIVOS` son aquellos que están autorizados para realizar las transacciones en el banco, cajeros por ejemplo.
Estos deben usar un login con un número de cedula y la respectiva contraseña para poder realizar las diferentes acciones.

    USUARIOS ADMINISTRATIVOS(ADMINUSERS)
    - Cédula
    - Nombre
    - Apellido
    - Password

### Registro de usuarios administrativos
El registro de usuarios administrativos almacena información respecto a sus **logins**.

    REGISTRO DE USUARIOS ADMINISTRATIVOS(REGADMINUSERS)
    - Cédula
    - IdToken
    - ip
    - Información adicional

El **IdToken** es una clave encriptada que contiene información del registro del administrador.

### Clientes
`CLIENTES` es la base de datos de los clientes del banco. En esta base de datos se almacenan siguientes datos:

    CLIENTES(CLIENTS)
    - Número de cuenta
    - Cédula
    - Nombre
    - Apellido
    - Saldo disponible


### Transacciones
`Transacciones` es la base de datos de los movimientos bancarios de los administradores:

    TRANSACCIONES(TRANSACTIONS)
    - IdToken
    - Número de cuenta
    - Tipo
    - Valor
    - DateTime
<br>
<br>




##API REST
Para el desarrollo de la API se toma en cuenta la arquitectura **RESTful** y sus métodos GET/POST/PUT. Esta se encargará del consumo de los servicios del BACKEND para dar cumplimiento a las `especificaciones del proyecto`.


 - 
 - 
 - 
 - 
 - 
 - 
 - 
 - 
 - 
 - 
 - 
 - 
