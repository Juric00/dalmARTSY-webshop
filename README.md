# Seminarski_Testna_Verzija_dalmARTSY
dalmARTSY

ABOUT dalmARTSY
========================================================================================================================================
dalmARTSY is a webshop that sells original art - primarily paintings by artists from Dalmatian islands. It has a variety of options, something 
for everyone based on our categories and styles.

INSTALLATION AND SETUP
========================================================================================================================================

To run the dalmARTSY application you will need the following:

Prerequisites:
- .NET 6.0 SDK
- Visual Studio or Visual Studio Code with C# extension
- platform for your local database setup (dBeaver, Docker, MySQL..)

Steps:
- extract the compressed file to a folder on your local machine
- open the solution file 'dalmARTSY_Test.sln' in VIisual Studio or Visual Studio Code
- in the 'appsettings.Development.json' file, update the 'ConnectionStrings' section to match your local database connection settings
- open 'Package Manager Console' and apply the initial migration and update database: 
      'add-migration InitialMigration' - (command in EF that is used to scaffold a new migration)
      'update-database' - (command in EF that applies migrations to the database)
      

USAGE
========================================================================================================================================
Once the installation is completed, launch the web application after it is builded successfully and start exploring dalmARTSY webshop.

The dalmARTSY webshop has a user-friendly interface that allows customers to browse, search, and purchase original art pieces. The home page 
displays featured paintings, while the shop page allows customers to filter paintings by category. Customers can view
the details of each painting. 
