# WebAPI

The main project is HelloAPI which is a .Net Core WebAPI.  The API can be called as follows: http://localhost:6713/api/values  There is a Console App that can be run that displays a static message.  The TestHelloValue in UnitTestHello can be used to run a unit test of the provider.

In the HelloAPI Startup, you can switch out the serviceTypeName => HelloAPI.Services.ContextService so that the HelloAPI use EF.  You'll need to update the HelloConnection string in the appsettings to point to your SQL Server database.  In addition, you need to create a table called Messages.  I've included a file that can be used to create the table.  Unit test TestHelloContext can be used to test EF.

