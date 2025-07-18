
## Helpful Tips
	-Add ToDoApp.Data.Sqlite project into this solution

	-If you do want to do a clean run, you can run the following for example

	dotnet tool update --global dotnet-ef 

	dotnet ef migrations add InitialCreate \
	  --project <Your Project repo path>\ToDoApp.Data.Sqlite \
	  --startup-project <Your Project repo path>\ToDoApp.SoapApi.CoreWcf or <API Style project name>>

	dotnet ef database update \
	  --project <Your Project repo path>\ToDoApp.Data.Sqlite \
	  --startup-project <Your Project repo path>\ToDoApp.SoapApi.CoreWcf or <API Style project name>>