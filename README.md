# Employee Management – .NET Web API
This is a simple CRUD Web API built with ASP.NET Core and Entity Framework Core for managing employee records.
The API exposes endpoints for creating, reading, updating, and deleting employees and calculates employee age dynamically.
 
## 1. How to Run the Project
## Prerequisites
Before running the project, ensure you have:
•	.NET 8 or .NET 9 SDK installed
•	A database engine:
o	SQL Server or
o	PostgreSQL
You must update the connection string inside EmployeeManagement.Api/appsettings.json.
Example connection string for SQL Server:
<img width="1241" height="136" alt="image" src="https://github.com/user-attachments/assets/88c89c77-133f-462b-a538-8c98d83d35cd" />

 
## Running the API
Open a terminal inside the project folder and run:
cd EmployeeManagement.Api
dotnet run
The API will start at:
•	https://localhost:5001
•	http://localhost:5000
You can test the API with:
curl https://localhost:5001/api/employees
 
## 2. API Endpoint Documentation
Base URL
/api/employees
Available Endpoints
GET /api/employees
Returns all employees. The response includes a dynamically calculated age value.
GET /api/employees/{id}
Returns a single employee by ID (if implemented in your controller).
POST /api/employees
Creates a new employee record.
PUT /api/employees/{id}
Updates an existing employee.
DELETE /api/employees/{id}
Deletes an employee from the database.
 
Request & Response Examples
GET /api/employees
Example response:
<img width="1800" height="646" alt="image" src="https://github.com/user-attachments/assets/c1bc21a0-7a35-47d9-9674-c724c0eb3b01" />

 
POST /api/employees
<img width="1818" height="666" alt="image" src="https://github.com/user-attachments/assets/7c899175-c8bf-4268-b283-a1504aaa7ef5" />
<img width="1805" height="541" alt="image" src="https://github.com/user-attachments/assets/bda1d1df-c135-4e5b-af4c-845c3b1a1752" />



