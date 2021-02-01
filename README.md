# LawyerSuits
.NET Core 3.1 Project in C#

IF Database is null run the following command at "LawyerSuits\LawyerSuits\LawyerSuit.Web" :
dotnet ef migrations add Lawsuits --startup-project ./ --project ../LawyerSuits.DAL/

Then run in the same folder: 
dotnet ef database update --startup-project ./ --project ../LawyerSuits.DAL/