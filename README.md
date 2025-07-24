
# 📝 TaskManager – ASP.NET MVC Clean Architecture App

TaskManager is a simple yet well-structured task tracking application built with **ASP.NET Core MVC**, **Entity Framework Core**, and **Clean Architecture principles**. It allows users to create, edit, list, and delete tasks with priorities and completion status.

---

## 📚 Technologies Used

- ✅ ASP.NET Core MVC (.NET 8)
- ✅ Entity Framework Core
- ✅ SQL Server
- ✅ Clean Architecture (Domain → Application → Infrastructure → UI)
- ✅ Dependency Injection (Built-in .NET Core DI)
- ✅ Bootstrap 5 for UI styling

---

## 🏗️ Project Structure

TaskManagerSolution


├── TaskManager.Web/ → Presentation Layer (MVC)

├── TaskManager.Application/ → Use Cases & Interfaces

├── TaskManager.Domain/ → Business Entities & Enums

├── TaskManager.Infrastructure/ → EF Core, Services, DbContext

└── TaskManager.sln → Visual Studio Solution


## 💡 Features

- ✅ Task creation with title, description, due date, and priority
- ✅ View list of all tasks
- ✅ Edit and delete tasks
- ✅ Mark tasks as completed
- ✅ Bootstrap UI with task highlighting
- ✅ Optional filtering by completion
- ✅ Server-side validation using Data Annotations
- ✅ Separated concerns using Clean Architecture principles

---

## ⚙️ Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/yourusername/TaskManager.git
cd TaskManager
2. Configure Connection String
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=TaskManagerDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
3. Apply EF Core Migrations
Add-Migration InitialCreate
Update-Database

options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection"),
    b => b.MigrationsAssembly("TaskManager.Infrastructure")
);
4. Run the Application
dotnet run --project TaskManager.Web

🌱 Sample Seed Data
On first run, the app seeds sample tasks:

"Finish Project Report"

"Team Meeting"

"Buy Groceries"

Located in: AppDbContextSeed.cs

🧪 Future Improvements
 User Authentication (ASP.NET Identity)

 Task filtering & sorting enhancements

 Export tasks to Excel/CSV

 Role-based access (Admin/User)

 REST API version

👨‍💻 Author
Md Shuhag – Full-Stack Developer (ASP.NET + Angular/React)

📝 License
This project is open source and available under the MIT License.

