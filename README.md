# 📘 Book Management System - ASP.NET Web Forms (CRUD)

## ✅ Summary

This project demonstrates a basic **CRUD** (Create, Read, Update, Delete) application using **ASP.NET Web Forms** and **ADO.NET**, with a clean **3-layer architecture** to separate responsibilities and improve maintainability.

---

## 🔧 Technologies Used

- ASP.NET Web Forms  
- ADO.NET  
- SQL Server  
- C#
- OOP
- SOLID

---

## 🧱 Project Architecture

The solution is divided into **3 layers**:

### 1️⃣ UI Layer (Presentation)
- Includes pages like `CRUD.aspx`, `Login.aspx`.
- Manages user input and display using controls like `TextBox`, `GridView`, `Button`.
- Handles events and triggers service or data access operations.

### 2️⃣ Data Access Layer (DAL)
- Handles direct communication with the SQL Server database using ADO.NET.
- Contains methods for:
  - `AddBook()`
  - `GetAllBooks()`
  - `UpdateBook()`
  - `DeleteBook()`

### 3️⃣ Service Layer (Optional / For Business Logic)
- Acts as a middle layer (currently simple).
- Can be extended for validation, API communication, or processing logic.

---

## 🔐 Authentication

- A basic login system is implemented in `Login.aspx`.
- After login, the username is stored in `Session["username"]`.
- Pages like `CRUD.aspx` are protected — users are redirected to login if not authenticated.

---

## 📦 Features

- ✅ Add a new book  
- ✅ View all books in a styled `GridView`  
- ✅ Update selected book  
- ✅ Delete selected book  
- ✅ Session-based login authentication  
- ✅ Clean UI styling  

---

## 🗃️ Database Schema (SQL Server)

Table: `BookApp`

```sql
CREATE TABLE BookApp (
    BookID INT PRIMARY KEY IDENTITY(1,1),
    BookTitle NVARCHAR(100),
    Price DECIMAL(10,2),
    BookDescription NVARCHAR(250)
);
📁 Project Structure
/MyApplication
│
├── UI/
│   ├── CRUD.aspx
│   └── Login.aspx
│
├── Models/
│   └── Book.cs
│
├── DataAccess/
│   └── BookDAL.cs
│
├── Services/
│   └── BookService.cs
│
├── Web.config
└── README.md
🚀 How to Run

Clone or download the project.

Create the BookApp table in your SQL Server database.

Update the database connection string in Web.config.

Open the solution in Visual Studio and run it.

Login via Login.aspx  User Name= admin & Password=12345  , then manage books via CRUD.aspx.
👨‍💻 Author

Created by Mohamed Elzoghby
Demo project to implement full CRUD using ASP.NET Web Forms and ADO.NET in a layered architecture.
