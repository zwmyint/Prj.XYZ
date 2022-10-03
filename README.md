Prj.XYZ 

## Introduction

Autogen broker solution serves the following 3 main business logic
Note that the 3 main flow may not be triggered in single user transaction. 
It depends on user interaction with the kiosk machine.

## 1. CreateEOrderSolutionSetCommand - Domain Flow
To return appointment slot details for patient orders (CreateEOrderSolutionSet)
* Each schedulable order contain visits of visit types
* Each visit can have multiple visits solution.
* One/Many visit solutions form an option set. [option 1 (AM), option 2 (PM), option 3(AM)]
* These option sets form a solution set
* Each bundle after scheduling will have a solution set.
* One/Many solution set for bundle(s) will create a responseSet

1.0 ESB to forward requests from QMS

1.1 Filtering
* Retrieve patient orders from EPIC
* Filter by department Id and today's date, ingnorable procedures and blacklisted visitTypesIds

1.2 Bundling 
*Create bundles of orders by EPD

1.3 Combination
* Combined visit types within and across all Orders
* Return VisitsToSearch in request

1.4 Scheduling
* Get visit solutions(appointment slots) for VisitsToSearch from EPIC
* Create AM/PM/AM solution sets

1.5 Appointment
* Auto book the visit solutions in first optionset via EPIC

1.6 Return solution set as eOrderSolutions in response back to ESB

## 2. PrintFutureAppointment - Domain Flow
2. To return all scheduled appointments for the patient in the cluster (PrintFutureAppointment)
* Each cluster has a set of departments (polyclinics)
* The broker will consolidate all the appointments from all the departments And return as single response 

2.0 ESB to forward requests from QMS
2.1 Get future appts for each department from EPIC
2.2 Concatenate list of future appts
2.3 Return appts in response back to ESB

## 3. PrintFutureAppointment - Domain Flow
3. To manual book appointments triggered by request (BookEOrderAppointments)
* Any errors will require cancellation of already booked appointments

3.0 ESB to forward requests from QMS
3.1 When received, the list of appointments are grouped by their bundleId
3.2 Booking is done bundle by bundle
3.3 Return booking status back to ESB


## Technologies
* .NET Core 3.1 (upgraded to .net 6 - 20220928)
* ASP .NET Core 3.1
* Entity Framework Core 3.1
* MediatR
* FluentValidation
* NUnit, FluentAssertions, Moq
* Swashbuckle 
* Polly
* AutoMapper

### WebAPI
This layer contains the controllers and http middlewares for the REST api endpoints.

### Domain
This will contain all entities, enums, exceptions, interfaces, types and logic specific to the domain layer.

### Application
This layer contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project. 
This layer defines interfaces that are implemented by outside layers. 
For example, if the application need to access a notification service, a new interface would be added to application and an implementation would be created within infrastructure.

### Infrastructure
This layer contains classes for accessing external resources such as file systems, web services, smtp, and so on. 
These classes should be based on interfaces defined within the application layer.


### Database Configuration
Use the dotnet ef database update command to create database locally if not already created.
Once created, insert the master data using DML scripts from the db folder.

### Database Migrations
To use `dotnet-ef` for your migrations. Run following command to install dotnet ef cli
dotnet tool install --global dotnet-ef

Assuming you are executing from repository root directory
--project src/Infrastructure` (optional if in Infrastructure folder)
--startup-project OR -s
--output-dir OR -o

Alternatively, 'cd' to Infrastructure folder
To add a new migration:
dotnet ef migrations add <SomeMigrationName> -s ../WebAPI/WebAPI.csproj

(Recommended approach to update STG/PRD environments)
To generate SQL script :
dotnet ef migrations script -s ../WebAPI/WebAPI.csproj -o allscripts.sql

To generate migration SQL scripts after certain migration:
dotnet ef migrations script 20200714094731_AddedPerfLog -s ../WebAPI/WebAPI.csproj -o migration_update.sql
 
(Requires connectivity to DB. Recommended for localdb)
To update directly:
dotnet ef database update -s ../WebAPI/WebAPI.csproj

### SQL to check Test Environment - Mock Service
select *
from [AutogenDB_Test].[dbo].[ATGN_TestCaseSources] as tcs 
join [AutogenDB_Test].[dbo].[ATGN_TestSources] as ts
on tcs.TestSourceId = ts.TestSourceId
where TestCaseId = <TestCaseId>
order by TestUriId
  

### Other Routing Paths
* Healthcheck for basic DB health probe
/Health 

* Log files (Non-PROD environment only)
/LogsFiles

### Important Settings
* ATT ClientId (Base64) old: "ZTViMmFkNTUtMGUxNS00NTdiLTkyOGYtYzI4NTBhYjQ3NTcy"
* ATT ClientId (Base64) new: "NzZjNDQ4ZTctMjRmYi00NjMyLWJmZjktMGQxYTFkN2I2N2Rm"
* BB ClientId (Base64): "YWQzMWUzMDMtY2QxYi00NWEwLWFiOWUtMmUwMWI5NGIxMDg0"

### Service Accounts
Staging: 
Production: 
