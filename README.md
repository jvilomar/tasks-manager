JMV Company - Permit System
===========================

Sistema de registro de solicitudes de permisos.

Introducción
------------

Este aplicativo consta de dos aplicaciones: Un back end que es nuestro web api,
y el front end que servirá como nuestro cliente.-

BackEnd
-------

El backend es una aplicación web api, desarrollada utilizando .Net Framework Core 3.1,
con C# como lenguaje de programación y SQL Server como base de datos.

Para realizar la instalación, luego de clonar el repositorio, se necesita restaurar las
dependencias o paquetes de NuGet:

    1. En VisualStudio, Abrir la Solución.
    2. En Solution Explorer Hacer click derecho sobre la solución.
    3. Seleccionar Restore NuGet Packages

Para configurar la base de datos existen dos maneras:

    1. Corriendo el script localizado en la carpeta Data del repositorio en SQL Server Management Studio.
    2. Por medio de la herramienta Migrations de Entity Framework Core.

Para ejecutar la herramienta Migrations, primero ajustar en el archivo de configuracion
la información referente al connection string, como servidor, base de datos y credenciales,
luego seguir los siguientes pasos:

    1. En Visual Studio, Seleccionar Tools > NuGet Package Manager > Package Manager Console
    2. En La Consola Escribir el siguiente comando:
  ~~~
  Update-Database
  ~~~

Compile y ejecute la aplicación y en el navegador aparecería la lista de los Tipos de Permisos (PermitTypes).

> Los tipos de permisos, se agregan por defecto a la base de datos, durante el proceso de la migración.
> Se podría configurar mediante el archivo de configuración al momento de crearse la aplicación  cargandolos desde una fuente externa.

la ruta de los endpoints inicia con api/NombreDelRecurso.  Ejemplo:

    https://localhost:5001/exapi/permitTypes

FrontEnd
------------

El front end es nuestra aplicación cliente y esta desarrollada utilizando Vuejs como framework JavaScript y BootstrapVue como framework CSS y es una aplicación basada en NodeJS.

> VueJS v2.6.11

> VuetifyJS v2.4

> La version de Nodejs es la 14.15.0.

Al igual que el Back - End, se necesita instalar las dependencias necesarias, por lo que debe verificar que tiene instalado NodeJS.  La version utilizada en este caso es la 14.15.0.

para verificar la version instalada ejecute el siguiente comando :

    node --version

Para instalar las dependencias, debe realizar los siguientes pasos:

    1. Acceder a la siguiente ruta:

      \Front\permit-client-app

    2. Ejecutar el siguiente comando:

      yarn install

    3. Luego que se instalen  las dependencias, ejecutar el siguiente comando:

      yarn serve

Es necesario que el web api este ejecutandose para que el cliente pueda acceder a los recursos necesarios.
