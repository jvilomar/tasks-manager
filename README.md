Task List Manager
===========================

Manage Tasks System base on .Net Core and VueJS

Introducción
------------

This application is a full stack app: A back end which is our web api,
and the front end that will serve as our client.

BackEnd
-------

The backend is a web application api, developed using .Net Framework Core 5.0,
with C# as programming language and SQL Server as database (localdb).

To perform the installation, after cloning the repository, you need to restore NuGet's
dependencies or NuGet packages:

    1. In VisualStudio, Open Solution.
    2. In Solution Explorer right click on the solution.
    3. Select Restore NuGet Packages

To Setup the DB:

    1. Open the Console Manager for Nuget and run the Migration tool provided by Entity Framework Core.

To run the Migrations tool, first adjust in the configuration file the information regarding the connection string,
such as server, database and credentials.

The information concerning the connection string, such as server, database and credentials,
then follow these steps:

    1. In Visual Studio, Select Tools > NuGet Package Manager > Package Manager Console
    2. In The Console Type the following command:
  ~~~
  Update-Database
  ~~~

Compile and run the application and the Swagger interface will appear in the browser, which allows you to test our API End Points.

> Tasks are added by default to the database during the migration process.

the endpoint path starts with api/ResourceName.  Example:

    https://localhost:5001/api/tasks

FrontEnd
------------
The front end is our client application and is developed using Vuejs as JavaScript framework and VuetifyJs a Material Design framework and is a NodeJS based application.

> VueJS v2.6.14

> VuetifyJS v2.6.0

> La version de Nodejs es la 16.14.0.

Like the Back - End, you need to install the necessary dependencies, so you must verify that you have NodeJS installed.  The version used in this case is 16.14.0.

To verify the installed version run the following command :

    node --version

To install the dependencies, you must perform the following steps:

    1. Got to the app root folder:

      \Front\task-list-manager

    2. Install Dependencies:
      ~~~
      npm install
      ~~~
      o
      ~~~
      yarn install
      ~~~

    3. After all depdencies are installed execute :

      ~~~
      npm run serve
      ~~~
     o
      ~~~
      yarn serve
      ~~~

Be sure to have the API app running.
