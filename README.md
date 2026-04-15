A C# Windows Forms application designed to manage different academic roles (Admins, Teachers, and Students) within a unified system. This project demonstrates the practical application of Object-Oriented Programming (OOP) principles, specifically inheritance and polymorphism, combined with SQL Server for persistent data storage.

Key Features
Role-Based Management: Specialized input handling for Admins (salary/hours), Teachers (subjects/salary), and Students (enrolled subjects).

Dynamic UI: Adaptive interface that toggles input panels based on the selected user role.

Full CRUD Operations: Support for Creating, Reading, Updating, and Deleting records directly through a DataGridView interface.

Polymorphic Architecture: Uses an abstract Person base class to streamline database operations and ensure code maintainability.

Database Integration: Connects to a SQL Server backend using ADO.NET for reliable data management and parameterized queries to prevent SQL injection.

Technical Stack
Language: C#

Framework: .NET Framework (Windows Forms)

Database: SQL Server

Key Concepts: Inheritance, Polymorphism, Abstraction, ADO.NET, SQL CRUD.

How it Works
The project utilizes a Single Table Inheritance pattern in the database. When a user is saved, the application creates a specific object (Admin, Teacher, or Student) and uses Method Overriding to map unique parameters to the SQL command. The results are fetched into an in-memory DataTable and displayed to the user for real-time interaction.
