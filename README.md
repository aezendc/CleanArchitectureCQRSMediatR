# 🧱 .NET API Clean Architecture CQRS and MediatR (v12.5.0)

A sample **.NET 8 Web API** project implementing **Clean Architecture**, **CQRS**, and **MediatR** with **SQL Server** as the database.

---

## 🏗️ Architecture Overview

The solution follows **Clean Architecture** principles with the following layers:


**Layer dependencies:**

| Layer | References |
|--------|-------------|
| Domain | — |
| Application | Domain |
| Infrastructure | Application, Domain |
| API | Application, Infrastructure |

---

## 🧩 Technologies

| Component | Version |
|------------|----------|
| .NET | 8.0 |
| MediatR | 12.5.0 |
| Entity Framework Core | 9.x |
| SQL Server | Latest |
| Swashbuckle (Swagger) | 9.x |

---

## ⚙️ Database Setup

### 1️⃣ Create Database and Table

Run this SQL script in **SQL Server Management Studio (SSMS)** or your preferred SQL client:

```sql
CREATE DATABASE StudentDB;
GO

USE StudentDB;
GO

CREATE TABLE dbo.Students
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    StudentName NVARCHAR(100) NOT NULL,
    StudentEmail NVARCHAR(100) NOT NULL,
    StudentAddress NVARCHAR(200) NOT NULL,
    StudentAge INT NOT NULL
);
GO

-- ========================================
-- Insert Sample Data
-- ========================================
INSERT INTO dbo.Students (StudentName, StudentEmail, StudentAddress, StudentAge)
VALUES 
('Alice Tan', 'alice.tan@example.com', 'Manila', 20),
('John Cruz', 'john.cruz@example.com', 'Cebu', 21),
('Maria Santos', 'maria.santos@example.com', 'Davao', 22),
('Luis Reyes', 'luis.reyes@example.com', 'Quezon City', 23),
('Emma Lopez', 'emma.lopez@example.com', 'Makati', 19);
GO
