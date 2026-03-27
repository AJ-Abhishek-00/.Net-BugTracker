# 🐞 Bug Tracking & Defect Management System (.NET)

## 🚀 Overview

A production-ready **Bug Tracking System** built using **.NET Web API, Entity Framework Core, and SQL Server**, following **Clean Architecture principles**.

This system allows teams to efficiently **log, track, manage, and analyze defects** with full lifecycle support and audit logging.

---

## 🏗️ Architecture (Clean Architecture)

The project is structured into four layers:

* **BugTracker.API** → Handles HTTP requests (Controllers, Swagger)
* **BugTracker.Application** → Business logic and services
* **BugTracker.Domain** → Core entities and enums
* **BugTracker.Infrastructure** → Database, repositories, EF Core

---

## ⚙️ Tech Stack

* .NET 10 Web API
* Entity Framework Core
* SQL Server / LocalDB
* Swagger (API Testing)
* Clean Architecture Pattern

---

## ✨ Features

* 🐞 Defect lifecycle management

  * Open → In Progress → Resolved → Closed

* ⚠️ Severity classification

  * Low / Medium / High

* 📝 Audit logging

  * Tracks all defect actions

* 🔄 CRUD Operations

  * Create, update, delete, fetch defects

* 📊 Reporting

  * Defects grouped by severity

* 🧱 Layered architecture (scalable & maintainable)

---

## 📂 Project Structure

```
BugTracker
│
├── BugTracker.API
├── BugTracker.Application
├── BugTracker.Domain
└── BugTracker.Infrastructure
```

---

## 🛠️ Setup Instructions

### 1️⃣ Clone Repository

```bash
git clone https://github.com/<your-username>/BugTracker.git
cd BugTracker
```

---

### 2️⃣ Install Dependencies

```bash
dotnet restore
```

---

### 3️⃣ Configure Database

Update `appsettings.json`:

```json
"ConnectionStrings": {
  "Default": "Server=(localdb)\\MSSQLLocalDB;Database=BugTrackerDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

---

### 4️⃣ Run Migrations

```bash
cd BugTracker.API

dotnet ef migrations add init --project ../BugTracker.Infrastructure --startup-project .
dotnet ef database update --project ../BugTracker.Infrastructure --startup-project .
```

---

### 5️⃣ Run Application

```bash
dotnet run
```

---

## 🧪 API Testing (Swagger)

After running, open:

```
https://localhost:xxxx/swagger
```

---

## 📊 Database Tables

* **Defects**
* **AuditLogs**

---

## 🔥 Example API Endpoints

* `GET /api/defects` → Get all defects
* `POST /api/defects` → Create defect
* `PUT /api/defects/{id}/status` → Update status
* `GET /api/defects/report` → Get severity report

---

## 🚀 Future Improvements

* 🔐 JWT Authentication
* 👥 Role-based access (Tester / Manager)
* 📄 Pagination & filtering
* 🌐 React frontend dashboard
* 🧪 Unit & integration testing
* 🐳 Docker deployment

---

## 👨‍💻 Author

**Abhishek**

---

## ⭐ If you like this project

Give it a ⭐ on GitHub and share!
