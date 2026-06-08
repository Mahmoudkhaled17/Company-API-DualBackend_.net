# Company Management System (ASP.NET Core MVC / Web API)

A robust, enterprise-grade enterprise system architecture designed using Microsoft’s flagship stack to illustrate standard MVC design patterns, strict database schema enforcement, and strongly-typed data manipulation pipelines.

---

## 🏗️ Relational Database Design

The physical backend layer maps corporate entities through an optimized schema utilizing proper schema mapping and referential structures.

### Database Schema (ER Diagram)
<img width="1312" height="777" alt="Screenshot 2026-06-08 232114" src="https://github.com/user-attachments/assets/ba8a025b-c48d-41af-b570-cd50ad7c430c" />

### Structural Engineering Highlights:
- **Strong Referential Coupling**: Multi-layered foreign keys bind `Instructors`, `Trainees`, and `Courses` back to the central `Departments` table.
- **Relational Bridges**: Employs an index-optimized `CrsResults` model to resolve many-to-many performance scaling when querying student grades.

---

## 🛠️ Tech Stack & System Highlights

- **Framework:** ASP.NET Core (MVC / Web API Framework Architecture)
- **Object-Relational Mapper (ORM):** Entity Framework Core (EF Core)
- **Database Engine:** Microsoft SQL Server (MSSQL / LocalDB)
- **Programming Language:** C# 12 (.NET 8.0/9.0)

### 🌟 Advanced Feature: Clean MVC Controller Abstraction
Leverages a robust `CompanyDbContext` interface within standard API actions. Uses explicit async/sync LINQ queries (`FirstOrDefault()`, `ToList()`) combined with proper `HttpNotFound()` action result validations to guarantee fail-safe request handling.

---

## 🖥️ Application UI & Live Preview

### Feature: Instructor Show All & Show Details View

### Show All View Execution Screenshot
<img width="1907" height="682" alt="image" src="https://github.com/user-attachments/assets/a5bdc229-1de6-4eac-8416-1378f736add3" />


### Individual Detail View Card Screenshot
<img width="1915" height="780" alt="image" src="https://github.com/user-attachments/assets/82a47993-c843-4fcc-b7f1-b459f3014fca" />


---


