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
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=EmployeeDb;Trusted_Connection=True;TrustServerCertificate=True"
}
Example connection string for PostgreSQL:
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=EmployeeDb;Username=postgres;Password=yourpassword"
}
 
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
[
  {
    "id": 1,
    "firstName": "John",
    "lastName": "Doe",
    "dateOfBirth": "1990-01-15T00:00:00",
    "educationLevel": "Bachelor",
    "age": 35
  }
]
 
POST /api/employees
Request:
{
  "firstName": "Anna",
  "lastName": "Smith",
  "dateOfBirth": "1995-06-23",
  "educationLevel": "Master"
}
Response:
{
  "id": 3,
  "firstName": "Anna",
  "lastName": "Smith",
  "dateOfBirth": "1995-06-23T00:00:00",
  "educationLevel": "Master",
  "age": 29
}

